using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VDS.RDF;
using VDS.RDF.Parsing;
using VDS.RDF.Query;

namespace LinkedData_Web_Application_HelloWorld.Pages
{
    public class AboutModel : PageModel
    {
        private string myversion = "20200624-1730";

        public string Message { get; set; }
        public string msg { get; set; }
        public int tqpostvalue = 0;

        [HttpPost]
        public ActionResult SubmitAction(FormCollection collection)
        {
            tqpostvalue = int.Parse(collection["testquery"]);

            Message = "<p>Via the ActionResult SubmitAction.</p>";
            msg = getResults(tqpostvalue,Request.Form["field"],Request.Form["terms"]);
            return null;
        }

        public void OnPost()
        {
            Message += "<p>Was a post</p>";

            try
            {
                tqpostvalue = int.Parse(Request.Form["testquery"]);
            }
            catch (Exception e)
            {
                tqpostvalue = 0;
            }

            Message = "Via the ActionResult SubmitAction.";

            msg = getResults(tqpostvalue,Request.Form["field"],Request.Form["terms"]);
        }

        public void OnGet()
        {
            int tqvalue = 0;

            Message = "This is the message to the Linked Data Team.";

            IQueryCollection qs = Request.Query;
            
            if (qs !=null && qs["testquery"].ToString().Length>0)
            {
                Message += " testquery qs attr=[" + qs["testquery"].ToString() + "].";
                tqvalue = int.Parse(qs["testquery"]);
            }
            else
            {
                Message += " No testquery qs attr.";
            }

            msg = getResults(tqvalue,null,null);
        }

        private Dictionary<string,string> getSubjectHeadings(string linkURI, string myuri,ref RemoteQueryProcessor rqp)
        {
            SparqlQueryParser parser = new SparqlQueryParser();
            SparqlResultSet results;

            Dictionary<string, string> sh = new Dictionary<string, string>();

            string query = @"
            PREFIX edm: <http://www.europeana.eu/schemas/edm/>
            PREFIX usfldc: <http://digital.lib.usf.edu/>
            PREFIX dcterms: <http://purl.org/dc/terms/>
            PREFIX skos: <http://www.w3.org/2004/02/skos/core#>

            SELECT *
            WHERE
            {
                {
                    ?subject edm:isShownAt.isShownAt <";
                    query += linkURI + @"> .
  	                ?subject dcterms:subject.sourceResource.subject ?subjectheading .
  
  	                ?subjectheading skos:prefLabel ?shlabel . 
                }
                union
                {
                    ?subject edm:isShownAt.isShownAt <";
                    query += linkURI + @"> .
  	                ?subject dcterms:subject.sourceResource.subject ?subjectheading .
                }
            }
            ";
                
            SparqlQuery q = parser.ParseFromString(query);
            string subjectURI=null, slabel=null,msg=null;

            try
            {
                results = (SparqlResultSet)rqp.ProcessQuery(q);
            }
            catch (Exception e)
            {
                return null;
            }

            foreach (SparqlResult result in results)
            {
                if (result.Count > 0)
                {
                    subjectURI = result[1].ToString();

                    if (result[2] != null)
                    {
                        slabel = result[2].ToString();
                        slabel = slabel.Substring(0, slabel.IndexOf("@")).Trim();
                    }
                    else
                    {
                        slabel = null;
                    }

                    if (subjectURI.Contains("http") && (slabel!=null && slabel.Length>0))
                    {
                        // is a subject heading with a uri and value
                    }
                    else if (subjectURI.Contains("http") && slabel==null)
                    {
                        // is a subject heading with a uri but the label is blank, i.e. a dup, or not in the authorities
                        subjectURI = null;
                        slabel = null;
                    }
                    else
                    {
                        // literal
                        slabel = subjectURI;
                        subjectURI = null;
                    }

                    if ((subjectURI != null && slabel != null) || (subjectURI==null && slabel!=null))
                    {
                        if (subjectURI == null) subjectURI = "none";

                        if (sh.ContainsKey(subjectURI))
                        {
                            //msg="Already added [" + subjectURI + "],[" + slabel + "].";
                            //sh.Add(Guid.NewGuid().ToString(), msg);
                        }
                        else
                        {
                            if (!sh.ContainsValue(slabel))
                            {
                                sh.Add(subjectURI, slabel);
                            }
                        }
                    }
                }
            }

            return sh;
        }
   
        private string getResults(int testquery, string field, string terms)
        {
            List<String> msgs = new List<string>();
            String msg,myout=String.Empty,query=null,myuri;
            SparqlResultSet results;

            String testquerymsg;

            if (field!=null && terms!=null)
            {
                testquerymsg = field + "={" + terms + "}";
            }
            else if (testquery==0)
            {
                testquerymsg = "default";
                return "";
            }
            else
            {
                testquerymsg = testquery.ToString();
            }

            SparqlQueryParser parser = new SparqlQueryParser();

            if (!(field != null && terms != null))
            {
                msgs.Add("<p>Processing query [" + testquerymsg + "].</p>");

                switch (testquery)
                {
                    case 1:
                        {
                            myuri = "http://disdev.lib.usf.edu:3030/sparql-fund3-data-research_libraries_uk/query";
                            query = "SELECT * WHERE {?subject ?predicate ?object} limit 25";
                            break;
                        }

                    case 2:
                        {
                            myuri = "http://disdev.lib.usf.edu:3030/sparql-fund1-code-data-001-thru-006/query";
                            query = "PREFIX books: <http://example.org/ns/book#> PREFIX schema: <http://schema.org/> SELECT * WHERE { ?subject ?predicate ?object. FILTER(regex(?object, 'Linked Data', 'i'))}";
                            break;
                        }

                    case 3:
                        {
                            myuri = "http://disdev.lib.usf.edu:3030/sparql-fund1-code-data-001-thru-006/query";
                            query = "PREFIX books: <http://example.org/ns/book#> PREFIX schema: <http://schema.org/> SELECT * WHERE { ?subject schema:name 'Linked data evolving the web into a global data space'. ?subject schema:datePublished '2011'. ?subject ?predicate ?object.}";
                            break;
                        }

                    case 4:
                        {
                            myuri = "http://disdev.lib.usf.edu:3030/sparql-fund3-data-research_libraries_uk/query";
                            query = "SELECT * WHERE {?subject ?predicate ?object} limit 25";
                            break;
                        }

                    case 5:
                        {
                            myuri = "http://disdev.lib.usf.edu:3030/lc-subject_headings/query";
                            query = "select * where {?subject ?predicate ?object} limit 25";
                            break;
                        }

                    case 6:
                        {
                            myuri = "http://disdev.lib.usf.edu:3030/lc-data-service-skos-genreforms/query";
                            query = "select * where {?subject ?predicate ?object} limit 25";
                            break;
                        }

                    default:
                        {
                            myuri = "http://disdev.lib.usf.edu:3030/ohp-ybor-test3/query";
                            query = "select * WHERE {?subject ?perdicate ?object} limit 25";
                            break;
                        }
                }
            }
            else
            {
                myuri = "http://disdev.lib.usf.edu:3030/ohp-ybor-test6-with-bonita-skos-authorities/query";

                if (terms.Trim().Length == 0) terms = "*";

                switch (field)
                {
                    case "Full-text":
                        {
                            query = "SELECT * WHERE { ?subject ?predicate ?object. FILTER(regex(?object, '" + terms + "', 'i'))}";
                            break;
                        }

                    case "Title":
                        {
                            query = "prefix dcterms: <http://purl.org/dc/terms/> select * where { ?subject dcterms:title.sourceResource.title ?object. FILTER (regex(?object, '" + terms + "', 'i'))} limit 25";
                            break;
                        }

                    case "Subject":
                        {
                            // took out ?subjectheading ?shlabel ?genre
                    query= @"PREFIX dc: <http://purl.org/dc/elements/1.1>
                            PREFIX dcterms: <http://purl.org/dc/terms/>
                            PREFIX dpla: <http://dp.la/about/map/>
                            PREFIX edm: <http://www.europeana.eu/schemas/edm/> 
                            PREFIX gn: <http://www.geonames.org/ontology#>
                            PREFIX lc: <http://id.loc.gov/authorities/subject/>
                            PREFIX usfldc: <http://digital.lib.usf.edu/>
                            PREFIX dpla: <http://dp.la/about/map/>
                            PREFIX schema: <http://schema.org/>
                            PREFIX owl: <http://www.w3.org/2002/07/owl#>
                            PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
                            PREFIX skos: <http://www.w3.org/2004/02/skos/core#>

                            SELECT distinct ?title ?author ?date ?format ?link
                            WHERE 
                            {
	                            {
		                            ?subject
			                            dcterms:subject.sourceResource.subject ?object ;
  		
			                            dcterms:title.sourceResource.title ?title ;
			                            dc:format ?format ;
			                            dc:date.sourceResource.date ?date ;
			                            edm:isShownAt.isShownAt ?link ;
			                            dcterms:creator.sourceResource.creator ?author ;
  			                            dcterms:type.sourceResource.type ?qenre ;
			                            dcterms:subject.sourceResource.subject ?subjectheading .
  
  		                            ?subjectheading skos:prefLabel ?shlabel .	
   		                           
  		                            FILTER(regex(?object, '";
                                    query += terms + @"','i')).
                                }
                                UNION
                                {
		                            ?subject
                                        dcterms:subject.sourceResource.subject ?object ;

                                        dcterms:title.sourceResource.title ?title;
                                        dc:format ?format;
                                        dc:date.sourceResource.date ?date;
                                        edm:isShownAt.isShownAt ?link;
                                        dcterms:creator.sourceResource.creator ?author;
                                        dcterms:type.sourceResource.type ?qenre;
                                        dcterms:subject.sourceResource.subject ?subjectheading .
  		
  		                            ?subjectheading skos:prefLabel  ?shlabel .	
                                    
                                    FILTER(regex(?shlabel, '";
                                    query += terms + @"', 'i')).
                                }
                            }

                            group by ?title ?format ?date ?link ?author
                            ";

                            //query = "prefix dcterms: <http://purl.org/dc/terms/> select * where { ?subject dcterms:subject.sourceResource.subject ?object. FILTER (regex(?object, '" + terms + "', 'i'))} limit 25";

                            break;
                        }

                    case "Creator":
                        {
                            query = @"PREFIX dc: <http://purl.org/dc/elements/1.1>
                            PREFIX dcterms: <http://purl.org/dc/terms/>
                            PREFIX dpla: <http://dp.la/about/map/>
                            PREFIX edm: <http://www.europeana.eu/schemas/edm/> 
                            PREFIX gn: <http://www.geonames.org/ontology#>
                            PREFIX lc: <http://id.loc.gov/authorities/subject/>
                            PREFIX usfldc: <http://digital.lib.usf.edu/>
                            PREFIX dpla: <http://dp.la/about/map/>
                            PREFIX schema: <http://schema.org/>
                            PREFIX owl: <http://www.w3.org/2002/07/owl#>
                            PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
                            PREFIX skos: <http://www.w3.org/2004/02/skos/core#>

                            SELECT distinct ?title ?author ?date ?format ?link
                            WHERE 
                                {
		                            ?subject
			                            dcterms:creator.sourceResource.creator ?object ;
  		
			                            dcterms:title.sourceResource.title ?title ;
			                            dc:format ?format ;
			                            dc:date.sourceResource.date ?date ;
			                            edm:isShownAt.isShownAt ?link ;
			                            dcterms:type.sourceResource.type ?qenre ;
                                        dcterms:creator.sourceResource.creator ?author ;
			                       
  		                            FILTER(regex(?object, '";
                                    query += terms + @"','i')).
                                }
                      
                                group by ?title ?format ?date ?link ?author
                            ";

                            break;
                        }

                    case "Keyword":
                        {
                            query = "select * where { ?subject ?predicate ?object} limit 25";
                            break;
                        }

                    case "Browse":
                        {
                            query = @"PREFIX dc: <http://purl.org/dc/elements/1.1>
                            PREFIX dcterms: <http://purl.org/dc/terms/>
                            PREFIX dpla: <http://dp.la/about/map/>
                            PREFIX edm: <http://www.europeana.eu/schemas/edm/> 
                            PREFIX gn: <http://www.geonames.org/ontology#>
                            PREFIX lc: <http://id.loc.gov/authorities/subject/>
                            PREFIX usfldc: <http://digital.lib.usf.edu/>
                            PREFIX dpla: <http://dp.la/about/map/>
                            PREFIX schema: <http://schema.org/>
                            PREFIX owl: <http://www.w3.org/2002/07/owl#>
                            PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>
                            PREFIX skos: <http://www.w3.org/2004/02/skos/core#>

                            SELECT distinct ?title ?author ?date ?format ?link
                            WHERE 
                            {
	                            {
		                            ?subject
			                            dcterms:subject.sourceResource.subject ?object ;
  		
			                            dcterms:title.sourceResource.title ?title ;
			                            dc:format ?format ;
			                            dc:date.sourceResource.date ?date ;
			                            edm:isShownAt.isShownAt ?link ;
			                            dcterms:creator.sourceResource.creator ?author ;
  			                    }
                                UNION
                                {
		                            ?subject
                                        dcterms:subject.sourceResource.subject ?object ;

                                        dcterms:title.sourceResource.title ?title;
                                        dc:format ?format;
                                        dc:date.sourceResource.date ?date;
                                        edm:isShownAt.isShownAt ?link;
                                        dcterms:creator.sourceResource.creator ?author;
                                }
                            }

                            group by ?title ?format ?date ?link ?author
                            ";

                            break;
                        }
                }
            }

            SparqlQuery q = parser.ParseFromString(query);

            SparqlRemoteEndpoint endpoint = new SparqlRemoteEndpoint(new Uri(myuri), "");
            endpoint.Credentials = new System.Net.NetworkCredential();

            //endpoint.Credentials.UserName = "";
            //endpoint.Credentials.Password = "";

            endpoint.HttpMode = "POST";
            RemoteQueryProcessor rqp = new RemoteQueryProcessor(endpoint);

            //msgs.Add("<p>Quering [" + endpoint.Uri + "].</p>");
            //msgs.Add("<p>query=[" + query + "].</p>");
            //msgs.Add("<p>The current ResultsAcceptHeader=[" + endpoint.ResultsAcceptHeader + "].</p>");

            //List<string> defaultGraphs = endpoint.DefaultGraphs;

            /*
            if (defaultGraphs.Count>0)
            {
                foreach (string graph in defaultGraphs)
                {
                    msgs.Add("<p>default graph [" + graph + "].</p>");
                }
            }
            */

            String temp;

            try
            {
                results = (SparqlResultSet)rqp.ProcessQuery(q);
            }
            catch (Exception e)
            {
                results = null;
                msgs.Add("<p>There was an error while trying to process your query, please try again later.</p>");
                return string.Join("\r\n",msgs);
            }

            if (results==null || results.Count==0)
            {
               msgs.Add("<p>There were no results for your <span class=\"fieldtype\">" + field + "</span> search for \"" + terms + "\".</p><br/>");
                return string.Join("\r\n", msgs);
            }
            else
            {
                //msgs.Add("<p>For the query [" + query + "].</p>");
                temp="<p>There ";

                if (results.Count == 1)
                {
                    temp += "is 1 result";
                }
                else
                {
                    temp += "are [" + results.Count + "] result(s)";
                }

                if (field == "Browse")
                {
                    temp += " for your browse.</p><hr/>";
                }
                else
                {
                    temp += " for your <span class=\"fieldtype\">" + field + "</span> search for \"" + terms + "\".</p><br/><hr/>";
                }

                msgs.Add(temp);
            }

            int idx = 0;
            string linkURI=null,linkHTML=null,lastLabel=null;

            myout += "<hr/>";

            foreach (SparqlResult result in results)
            {
                idx++;

                if (result.Count > 0)
                {
                    msgs.Add("<div>");
                   
                    myout = String.Empty;
                    lastLabel = "none";

                    foreach (KeyValuePair<String, VDS.RDF.INode> data in result)
                    {
                        if (data.Key != "link")
                        {
                            myout += "<span class=\"dlabel\">" + data.Key + "</span> : ";
                            lastLabel = data.Key;
                        }

                        if (data.Key == "link")
                        {
                            linkHTML = "<span class=\"dlabel\">link</span> : <a target=\"_blank\" href=\"" + data.Value + "\">Digital resource</a> (" + data.Value.ToString().Substring(data.Value.ToString().IndexOf("?")+1) + ")";
                            linkURI = data.Value.ToString();
                        }
                        else
                        {
                            myout += data.Value;
                            myout += "<br/>";
                        }
                    }

                    Dictionary<string, string> shs = new Dictionary<string, string>();
                    shs = getSubjectHeadings(linkURI, myuri, ref rqp);
                    idx = 0;

                    if (shs.Count>0)
                    {
                        foreach (KeyValuePair<string, string> sh in shs)
                        {
                            if (idx == 0)
                            {
                                myout += "<span class=\"dlabel\">subject</span> : ";
                            }
                            else
                            {
                                myout += "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;";
                            }

                            idx++;
                            myout += sh.Value + "<br/>";
                        }
                    }

                    myout += linkHTML;

                    /*
                    if (testquery==0)
                    {
                        myout += "<br/><li><a target=\"_blank\" href=\"" + result["subject"].ToString() + "\">" + result["subject"].ToString() + "</a></li>";
                    }
                    */

                    msgs.Add(myout + "<hr/></div>");
                }
                else
                {
                    msgs.Add("No results.<br/>");
                }
            
                Console.WriteLine(result.ToString());
            }

            msgs.Add("<br/>");

            msg = string.Join("\r\n", msgs);

            return msg;
        }
    }
}
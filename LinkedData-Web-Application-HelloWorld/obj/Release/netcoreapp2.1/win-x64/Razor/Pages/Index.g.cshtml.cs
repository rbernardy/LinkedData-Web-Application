#pragma checksum "C:\Users\Administrator\Box Sync\LinkedData-Web-Application-HelloWorld\LinkedData-Web-Application-HelloWorld\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4312f8d5a77fdaceecb7a9526c18625491dee6e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LinkedData_Web_Application_HelloWorld.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(LinkedData_Web_Application_HelloWorld.Pages.Pages_Index), null)]
namespace LinkedData_Web_Application_HelloWorld.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Administrator\Box Sync\LinkedData-Web-Application-HelloWorld\LinkedData-Web-Application-HelloWorld\Pages\_ViewImports.cshtml"
using LinkedData_Web_Application_HelloWorld;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4312f8d5a77fdaceecb7a9526c18625491dee6e9", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"753b2607710621976bc2dbc4f99d55070c25fdee", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("usfliblogo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/libraries-darkbg-1c-white-h.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("USF Libraries darkbg 1c-white-h logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Administrator\Box Sync\LinkedData-Web-Application-HelloWorld\LinkedData-Web-Application-HelloWorld\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 100, true);
            WriteLiteral("\r\n<nav class=\"navbar navbar-expand-lg navbar-light usfgreen\">\r\n    <div class=\"container\">\r\n        ");
            EndContext();
            BeginContext(171, 113, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f317e24e4ea849dab5c77409d1aee28c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(284, 3085, true);
            WriteLiteral(@"
        <a class=""navbar-brand text-white"" href=""#"">USF Libraries - Digital Scholarship Services - Linked Data Web Application</a>
        <!--
    <form class=""form-inline my-2 my-lg-0"">
        <button class=""btn btn-outline-success my-2 my-sm-0 mx-2 btn-homepage"" type=""submit"">Learn More</button>
        <button class=""btn btn-outline-success my-2 my-sm-0 btn-homepage"" type=""submit"">Accept</button>

    </form>
        -->
    </div>
</nav>
<section class=""home-hero"">
    <div class=""container body-content"">
        <div class=""tab-content active"">
            <h2 style=""color:white"">Ybor Oral History Linked Data Project</h2>
            <div class=""row"">
                <div class=""col-md-10"">
                    <div id=""custom-search-input"">
                        <div class=""input-group"">
                            <input id=""searchterms"" type=""text"" class=""form-control input-lg"" placeholder=""Search"" />
                            <div id=""searchtype"" class=""dropdown mx-2"">
    ");
            WriteLiteral(@"                            <button class=""btn btn-outline-success btn-homepage dropdown-toggle"" type=""button"" id=""searchDropdownMenuButton"" data-toggle=""dropdown"">
                                    Choose
                                    <span class=""caret""></span>
                                </button>
                                <ul id=""menu"" class=""dropdown-menu"">
                                    <li><a id=""au"" class=""dropdown-item"" href=""#"">Creator</a></li>
                                    <li><a id=""to"" class=""dropdown-item"" href=""#"">Subject</a></li>
                                    <!-- <a id=""tx"" class=""dropdown-item"" href=""#"">Full-text</a> -->
                                </ul>
                            </div>
                            <button id=""submitsearch"" class=""btn btn-outline-success btn-homepage"" type=""submit"">Search</button>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button id=""browse"" class=""btn btn-outline-success btn-homepage"" type=""");
            WriteLiteral(@"button"">Browse</button>
                        </div>
                    </div>
                </div>
                <div class=""col-md-2"">
                </div>
            </div>
        </div>

        <div id=""notifications"" class=""float-right"">
            
        </div>

        <div class=""intro"">
            <br />
            <p class=""designheader"">USF Libraries’ design for transforming digital collections to linked data</p>
            <p>
                This is a pilot project the USF Libraries Linked Data Team has created to experiment transforming digital collections into linked data.
                The Team chose a small oral history collection to work on and was able to reconcile the data, transform the data into triples, and
                design SPARQL queries to support basic search. Throughout the process, the Team was inspired to streamline the workflow and further enhance
                the final product.
            </p>
        </div>

        <div cla");
            WriteLiteral("ss=\"results\">");
            EndContext();
            BeginContext(3370, 19, false);
#line 65 "C:\Users\Administrator\Box Sync\LinkedData-Web-Application-HelloWorld\LinkedData-Web-Application-HelloWorld\Pages\Index.cshtml"
                        Write(Html.Raw(Model.msg));

#line default
#line hidden
            EndContext();
            BeginContext(3389, 172, true);
            WriteLiteral("</div>\r\n\r\n        <footer>\r\n            <p style=\"color:white\">&copy; 2019-2020 - USF Libraries - Digital Scholarship Services - Linked Data Demo Web Application - Version ");
            EndContext();
            BeginContext(3562, 25, false);
#line 68 "C:\Users\Administrator\Box Sync\LinkedData-Web-Application-HelloWorld\LinkedData-Web-Application-HelloWorld\Pages\Index.cshtml"
                                                                                                                                           Write(Html.Raw(Model.myversion));

#line default
#line hidden
            EndContext();
            BeginContext(3587, 66, true);
            WriteLiteral("</p>\r\n        </footer>\r\n\r\n        <div class=\"log\">\r\n            ");
            EndContext();
            BeginContext(3654, 19, false);
#line 72 "C:\Users\Administrator\Box Sync\LinkedData-Web-Application-HelloWorld\LinkedData-Web-Application-HelloWorld\Pages\Index.cshtml"
       Write(Html.Raw(Model.log));

#line default
#line hidden
            EndContext();
            BeginContext(3673, 45, true);
            WriteLiteral(";\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            EndContext();
#line 77 "C:\Users\Administrator\Box Sync\LinkedData-Web-Application-HelloWorld\LinkedData-Web-Application-HelloWorld\Pages\Index.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(3748, 285, true);
            WriteLiteral(@"    <fieldset>
        <input type=""hidden"" id=""terms"" name=""terms"" />
        <input type=""hidden"" id=""field"" name=""field"" />
        <button style=""visibility:hidden"" id=""hiddensearchbutton"" name=""hiddensearchbutton"" value=""search"" type=""submit"">Search</button>
    </fieldset>
");
            EndContext();
#line 84 "C:\Users\Administrator\Box Sync\LinkedData-Web-Application-HelloWorld\LinkedData-Web-Application-HelloWorld\Pages\Index.cshtml"
}

#line default
#line hidden
            BeginContext(4036, 2381, true);
            WriteLiteral(@"
<!--
<div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"" data-interval=""6000"">
    <ol class=""carousel-indicators"">
        <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
        <li data-target=""#myCarousel"" data-slide-to=""1""></li>
        <li data-target=""#myCarousel"" data-slide-to=""2""></li>
    </ol>
    <div class=""carousel-inner"" role=""listbox"">
        <div class=""item active"">

            <img src=""~/images/turtle-logo-vector-19144604.jpg"" alt=""ASP.NET"" class=""img-responsive"" />
            <div class=""carousel-caption"" role=""option"">
                <p>
                    Linked data & Digi development.
                    <a class=""btn btn-default"" href=""https://digital.lib.usf.edu/"">
                        Learn More
                    </a>
                </p>
            </div>
        </div>
        <div class=""item"">

            <img src=""~/images/AmazonWebservices_Logo-1989-823.jpg"" alt=""Amazon Web Services"" class=""img-responsive"" ");
            WriteLiteral(@"/>
            <div class=""carousel-caption"" role=""option"">
                <p>
                    I love Amazon Web Services more!
                    <a class=""btn btn-default"" href=""https://aws.amazon.com"">
                        Learn More
                    </a>
                </p>
            </div>
        </div>
        <div class=""item"">
            <img src=""~/images/all-collectionimage-mirror.jpg"" alt=""USF Libraries"" class=""img-responsive"" />
            <div class=""carousel-caption"" role=""option"">
                <p>
                    Learn how the USF Libraries innovates!
                    <a class=""btn btn-default"" href=""https://lib.usf.edu/"">
                        Learn More
                    </a>
                </p>
            </div>
        </div>
    </div>
    <a class=""left carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""prev"">
        <span class=""glyphicon glyphicon-chevron-left"" aria-hidden=""true""></span>
        <span class=""sr-only""");
            WriteLiteral(@">Previous</span>
    </a>
    <a class=""right carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""next"">
        <span class=""glyphicon glyphicon-chevron-right"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
    </a>
</div>

<div class=""row"">
    <div class=""col-md-3"">
        <h2>Version ");
            EndContext();
            BeginContext(6418, 19, false);
#line 142 "C:\Users\Administrator\Box Sync\LinkedData-Web-Application-HelloWorld\LinkedData-Web-Application-HelloWorld\Pages\Index.cshtml"
               Write(ViewData["version"]);

#line default
#line hidden
            EndContext();
            BeginContext(6437, 2307, true);
            WriteLiteral(@"</h2>
        <h2>Application uses</h2>
        <ul>
            <li>Sample pages using ASP.NET Core Razor Pages</li>
            <li>Theming using <a href=""https://go.microsoft.com/fwlink/?LinkID=398939"">Bootstrap</a></li>
        </ul>
    </div>
    <div class=""col-md-3"">
        <h2>How to</h2>
        <ul>
            <li><a href=""https://go.microsoft.com/fwlink/?linkid=852130"">Working with Razor Pages.</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=699315"">Manage User Secrets using Secret Manager.</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=699316"">Use logging to log a message.</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=699317"">Add packages using NuGet.</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=699319"">Target development, staging or production environment.</a></li>
        </ul>
    </div>
    <div class=""col-md-3"">
        <h2>Overview</h2>
        <ul>
           ");
            WriteLiteral(@" <li><a href=""https://go.microsoft.com/fwlink/?LinkId=518008"">Conceptual overview of what is ASP.NET Core</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=699320"">Fundamentals of ASP.NET Core such as Startup and middleware.</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=398602"">Working with Data</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkId=398603"">Security</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=699321"">Client side development</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=699322"">Develop on different platforms</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=699323"">Read more on the documentation site</a></li>
        </ul>
    </div>
    <div class=""col-md-3"">
        <h2>Run &amp; Deploy</h2>
        <ul>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=517851"">Run your app</a></li>
            <li><a href=""https:");
            WriteLiteral(@"//go.microsoft.com/fwlink/?LinkID=517853"">Run tools such as EF migrations and more</a></li>
            <li><a href=""https://go.microsoft.com/fwlink/?LinkID=398609"">Publish to Microsoft Azure App Service</a></li>
        </ul>
    </div>
</div>
    -->
");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AboutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AboutModel>)PageContext?.ViewData;
        public AboutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

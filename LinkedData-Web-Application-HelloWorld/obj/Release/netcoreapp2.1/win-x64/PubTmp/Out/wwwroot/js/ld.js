$(document).ready(function()
{
    console.log("document ready...");

});

$("#searchtype").on("show.bs.dropbown",function()
{
    console.log("show.bs.dropdown");

}).on("shown.bs.dropdown",function()
{
    console.log("shown.bs.dropdown");

}).on("hide.bs.dropdown",function()
{
    console.log("hide.bs.dropdown");

}).on("hidden.bs.dropdown",function()
{
    console.log("hidden.bs.dropdown");
      
    });

$("#browse").on("click", function (e) {
    $("#terms").val("");
    $("#field").val("Browse");
    $("#hiddensearchbutton").click();
});

$(".dropdown-item").on("click", function (e)
{
    console.log("click of dropdown-item [" + $(this).text() + "].");
    $("#searchDropdownMenuButton").html($(this).text() + "<span class=\"caret\"></span>");
    //$(".dropdown-toggle").dropdown("toggle");
    //$(".in,.open").removeClass("in open");
});

$("#submitsearch").on("click", function (e)
{
    var field = $("#searchDropdownMenuButton").text();
    var terms = $("#searchterms").val();
    var html = "";

    console.log("submitsearch button clicked.");
    //alert("field=[" + field + "].");
    
    if (terms==null || terms.trim().length == 0) {
        console.log("No search terms have been entered.");
        alert("No serch terms were entered.");
        return;
    }

    if (field == "Choose" || field.indexOf("Choose")!=-1)
    {
        console.log("clicked search but no dropdown choice was made.");
        alert("No search type was chosen.");
        //$(".dropdown-toggle").dropdown("toggle");

        /*
        html = "<div id=\"nofieldselected\" aria-live=\"polite\" aria-atomic=\"true\" class=\"d-flex justify-content-center align-items-center\" style=\"min-height: 200px;\"> \
            <div class=\"toast\" role=\"alert\" aria-live=\"assertive\" aria-atomic=\"true\"> \
                <div class=\"toast-header\"> \
                    <img src=\"...\" class=\"rounded mr-2\" alt=\"...\"> \
                        <strong class=\"mr-auto\">Bootstrap</strong> \
                        <small>a few seconds ago</small> \
                        <button type=\"button\" class=\"ml-2 mb-1 close\" data-delay=\"3000\" data-autohide=\"true\" data-dismiss=\"toast\" aria-label=\"Close\"> \
                            <span aria-hidden=\"true\">&times;</span> \
                        </button> \
                </div> \
                    <div class=\"toast-body\"> \
                        You must choose a search field. \
                    </div> \
                </div> \
            </div>";
            */

        //$("#notifications").empty();
        //$("#notifications").append(html);
        //$(".toast").toast();
        //$("#nofieldselected").toast("show");
        return;
    }

    console.log("searchfield=[" + $("#searchDropdownMenuButton").text() + "].");
    console.log("search terms=[" + $("#searchterms").val() + "].");

    $("#terms").val($("#searchterms").val());
    $("#field").val($("#searchDropdownMenuButton").text());
    $("#hiddensearchbutton").click();

});
#pragma checksum "C:\Users\Dor\Desktop\Money2Go\Money2Go\Views\Projects\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e438e05d337cc493ba9db6fc28448da0430f35f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_Details), @"mvc.1.0.view", @"/Views/Projects/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Projects/Details.cshtml", typeof(AspNetCore.Views_Projects_Details))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Dor\Desktop\Money2Go\Money2Go\Views\_ViewImports.cshtml"
using Money2Go;

#line default
#line hidden
#line 2 "C:\Users\Dor\Desktop\Money2Go\Money2Go\Views\_ViewImports.cshtml"
using Money2Go.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e438e05d337cc493ba9db6fc28448da0430f35f", @"/Views/Projects/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75ef2477bd4dadeb3959c724977659104385592e", @"/Views/_ViewImports.cshtml")]
    public class Views_Projects_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Money2Go.Models.Project>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/DescriptionJS.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/DescriptionStyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/rotating-card.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/rotating_card_thumb3.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/video/GoPro.mp4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("video/mp4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return false"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PostCommentLayout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CommentLayout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hm-gradient"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 325, true);
            WriteLiteral(@"
<link href=""//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
<script src=""//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js""></script>
<script src=""//code.jquery.com/jquery-1.11.1.min.js""></script>
<!------ Include the above in your HEAD tag ---------->
");
            EndContext();
            BeginContext(357, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a23dcc6d521345fb924b021bd706ec2b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(403, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(405, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "659789aef6c440e58656775accfe7664", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
            BeginContext(464, 56, true);
            WriteLiteral("\r\n\r\n<link href=\"css/bootstrap.css\" rel=\"stylesheet\" />\r\n");
            EndContext();
            BeginContext(520, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2012d45c297947169a366906ec7dc789", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(576, 288, true);
            WriteLiteral(@"
<link href=""https://netdna.bootstrapcdn.com/font-awesome/4.5.0/css/font-awesome.min.css"" rel=""stylesheet"" />
<script>
    $(document).ready(function () {
        $('#backingBttn').click(function () {
            var vAmount = $('#backingAmount').val();
            var projectId = ");
            EndContext();
            BeginContext(865, 41, false);
#line 17 "C:\Users\Dor\Desktop\Money2Go\Money2Go\Views\Projects\Details.cshtml"
                       Write(Html.DisplayFor(model => model.ProjectId));

#line default
#line hidden
            EndContext();
            BeginContext(906, 262, true);
            WriteLiteral(@";
            if (vAmount.trim() == '') {
                document.getElementById(""backingStatus"").innerHTML = ""Please enter the backing amount."";
                return;
            }
            else {
                $.ajax({
                    url: """);
            EndContext();
            BeginContext(1169, 41, false);
#line 24 "C:\Users\Dor\Desktop\Money2Go\Money2Go\Views\Projects\Details.cshtml"
                     Write(Url.Action("BackProject", "Tranzactions"));

#line default
#line hidden
            EndContext();
            BeginContext(1210, 879, true);
            WriteLiteral(@""",
                    type: 'POST',

                    //dataType: 'json',
                    data: { amount: vAmount, projectId: projectId },
                    cache: false,
                    success: function (result) {
                        document.getElementById(""backingStatus"").innerHTML = result;
                        $(""#backersCount"").load(location.href + "" #backersCount > *"");
                        $(""#currentMoney"").load(location.href + "" #currentMoney > *"");
                    },
                    error: function (xhr, ajaxOptions, thrownError) {
                        //alert(xhr.status);
                        //alert(thrownError);
                        document.getElementById(""backingStatus"").innerHTML = ""Please log in."";
                    }
                });
            }
        });


    });
</script>
");
            EndContext();
            BeginContext(2089, 9146, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b48efe44a6b4ca29c70b784e7d03bb6", async() => {
                BeginContext(2115, 16, true);
                WriteLiteral("\r\n\r\n    <main>\r\n");
                EndContext();
                BeginContext(2143, 388, true);
                WriteLiteral(@"            <!--MDB Video-->
            <div class=""container mt-4"">
                <!-- Grid row -->

                <div class=""col-md-12"">
                    <!--CARD rotate tranzaction !-->
                    <div class=""card-container-static"">
                        <div class=""card"">

                            <div class=""cover"">
                                ");
                EndContext();
                BeginContext(2531, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "813536716d574096a19c9b5ac6affd68", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2578, 609, true);
                WriteLiteral(@"
                            </div>
                            <div class=""user"">
                                <img class=""img-circle"" src=""https://scontent.fsdv1-2.fna.fbcdn.net/v/t31.0-8/23215507_10214820127760895_5227542030539600835_o.jpg?_nc_cat=107&_nc_oc=AQlY4SQzEtb2heParqoqmEwrK4rR-u1JNcTkVc4ocCwZw1PpSp0MdwZdUL0V2ENRpUc&_nc_ht=scontent.fsdv1-2.fna&oh=eded92d04c4e6bf055e3ad8c9536406d&oe=5E2030F0"" />
                            </div>
                            <div class=""content"">
                                <div class=""main"">
                                    <h3 class=""name"">");
                EndContext();
                BeginContext(3188, 20, false);
#line 68 "C:\Users\Dor\Desktop\Money2Go\Money2Go\Views\Projects\Details.cshtml"
                                                Write(Model.user.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(3208, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(3210, 19, false);
#line 68 "C:\Users\Dor\Desktop\Money2Go\Money2Go\Views\Projects\Details.cshtml"
                                                                      Write(Model.user.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(3229, 801, true);
                WriteLiteral(@"</h3>
                                    <p class=""profession"">Project Manager</p>
                                </div>
                            </div>


                        </div> <!-- end card -->
                    </div> <!-- end card-container -->
                    <!-- Grid column -->
                </div>
                <div class=""row"">

                    <!-- Grid column -->
                    <div class=""col-md-8 mb-4"">

                        <div class=""card"">
                            <div class=""card-block p-3"">
                                <!--Title-->


                                <div class=""embed-responsive embed-responsive-16by9"">
                                    <video controls>
                                        ");
                EndContext();
                BeginContext(4030, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("source", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "45cce68eb6504e0ab99d159c6a2f5e73", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4079, 845, true);
                WriteLiteral(@"
                                        Your browser does not support the video tag.
                                    </video>
                                </div>
                            </div>


                        </div>

                    </div>

                    <div class=""col-md-4 mb-4 card-container-static"">
                        <div class=""card-container-static"">
                            <div class=""card"">

                                <div class=""front"">

                                    <div class=""content"">
                                        <div class=""main"">
                                            <h4 class=""text-center"">Back this project</h4>
                                            <hr />
                                            <p class=""text-center"">");
                EndContext();
                BeginContext(4925, 17, false);
#line 111 "C:\Users\Dor\Desktop\Money2Go\Money2Go\Views\Projects\Details.cshtml"
                                                              Write(Model.Description);

#line default
#line hidden
                EndContext();
                BeginContext(4942, 226, true);
                WriteLiteral("</p>\r\n\r\n                                            <div class=\"stats-container\">\r\n                                                <div id=\"currentMoney\" class=\"stats\">\r\n                                                    <h4>");
                EndContext();
                BeginContext(5169, 20, false);
#line 115 "C:\Users\Dor\Desktop\Money2Go\Money2Go\Views\Projects\Details.cshtml"
                                                   Write(TempData["SumMoney"]);

#line default
#line hidden
                EndContext();
                BeginContext(5189, 124, true);
                WriteLiteral("$</h4>\r\n                                                    <p>\r\n                                                        of ");
                EndContext();
                BeginContext(5314, 10, false);
#line 117 "C:\Users\Dor\Desktop\Money2Go\Money2Go\Views\Projects\Details.cshtml"
                                                      Write(Model.goal);

#line default
#line hidden
                EndContext();
                BeginContext(5324, 260, true);
                WriteLiteral(@"$
                                                    </p>
                                                </div>
                                                <div id=""backersCount"" class=""stats"">
                                                    <h4>");
                EndContext();
                BeginContext(5585, 23, false);
#line 121 "C:\Users\Dor\Desktop\Money2Go\Money2Go\Views\Projects\Details.cshtml"
                                                   Write(Model.tranzaction.Count);

#line default
#line hidden
                EndContext();
                BeginContext(5608, 368, true);
                WriteLiteral(@"</h4>
                                                    <p>
                                                        backers
                                                    </p>
                                                </div>
                                                <div class=""stats"">
                                                    <h4>");
                EndContext();
#line 127 "C:\Users\Dor\Desktop\Money2Go\Money2Go\Views\Projects\Details.cshtml"
                                                          
                                                        DateTime? d1 = Model.DateProject;
                                                        DateTime? d2 = DateTime.Now;
                                                        int? d3 = (int?)(d1 - d2)?.TotalDays;
                                                        

#line default
#line hidden
                BeginContext(6311, 52, true);
                WriteLiteral("                                                    ");
                EndContext();
                BeginContext(6364, 2, false);
#line 132 "C:\Users\Dor\Desktop\Money2Go\Money2Go\Views\Projects\Details.cshtml"
                                               Write(d3);

#line default
#line hidden
                EndContext();
                BeginContext(6366, 673, true);
                WriteLiteral(@"</h4>
                                                    <p>
                                                        days to go
                                                    </p>
                                                </div>
                                            </div>


                                        </div>
                                        <div>

                                        </div>
                                    </div>
                                    <div class=""container"">
                                        <div class="" align-content-center"">
                                            ");
                EndContext();
                BeginContext(7039, 751, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d33d4c04b46b4ee893e4530dd691d187", async() => {
                    BeginContext(7069, 714, true);
                    WriteLiteral(@"
                                                <div class=""row justify-content-center"" style=""padding-top:20px;"">

                                                    <input id=""backingAmount"" name=""Amount"" type=""text"" placeholder=""Amount"" />
                                                    <button id=""backingBttn"" value=""Create"" class=""btn btn-success green center"">
                                                        Back Now
                                                    </button>
                                                </div>
                                                <div id=""backingStatus"" style=""margin-left:18px""></div>
                                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7790, 1195, true);
                WriteLiteral(@"
                                        </div>
                                    </div>
                                </div> <!-- end back panel -->

                            </div> <!-- end card -->
                        </div> <!-- end card-container -->
                    </div>

                </div>
                <!-- Grid row -->
                <!-- Grid row -->

            </div>
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <div class=""row"">
                            <div class=""col-md-12"">
                                <div class=""ibox float-e-margins"">
                                    <div class=""ibox-title"">
                                        <h3 class=""text-center font-up font-bold indigo-text py-2 mb-3"">
                                            <strong>
                                                Description
                                        ");
                WriteLiteral("    </strong>\r\n                                        </h3>\r\n                                        <hr />\r\n                                        <p class=\"newspaper\">");
                EndContext();
                BeginContext(8986, 17, false);
#line 183 "C:\Users\Dor\Desktop\Money2Go\Money2Go\Views\Projects\Details.cshtml"
                                                        Write(Model.Description);

#line default
#line hidden
                EndContext();
                BeginContext(9003, 265, true);
                WriteLiteral(@"</p>
                                    </div>
                                    <div class=""ibox-content profile-content"">


                                        <p>
                                            <i class=""fa fa-clock-o""></i> Uploaded on ");
                EndContext();
                BeginContext(9269, 35, false);
#line 189 "C:\Users\Dor\Desktop\Money2Go\Money2Go\Views\Projects\Details.cshtml"
                                                                                 Write(Html.DisplayFor(x => x.DateProject));

#line default
#line hidden
                EndContext();
                BeginContext(9304, 12, true);
                WriteLiteral(" By <strong>");
                EndContext();
                BeginContext(9317, 19, false);
#line 189 "C:\Users\Dor\Desktop\Money2Go\Money2Go\Views\Projects\Details.cshtml"
                                                                                                                                 Write(Model.user.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(9336, 157, true);
                WriteLiteral("</strong>\r\n                                        </p>\r\n                                        <h3 class=\"font-up font-bold indigo-text py-2 mb-3\"><strong>");
                EndContext();
                BeginContext(9494, 17, false);
#line 191 "C:\Users\Dor\Desktop\Money2Go\Money2Go\Views\Projects\Details.cshtml"
                                                                                               Write(Model.ProjectName);

#line default
#line hidden
                EndContext();
                BeginContext(9511, 436, true);
                WriteLiteral(@"</strong></h3>

                                        <div class=""row m-t-md"">
                                            <div class=""col-md-3"">
                                                <h5><strong>169</strong> Likes</h5>
                                            </div>
                                            <div class=""col-md-9"">
                                                <h5 id=""commentsCount""><strong>");
                EndContext();
                BeginContext(9948, 20, false);
#line 198 "C:\Users\Dor\Desktop\Money2Go\Money2Go\Views\Projects\Details.cshtml"
                                                                          Write(Model.comments.Count);

#line default
#line hidden
                EndContext();
                BeginContext(9968, 381, true);
                WriteLiteral(@"</strong> Comments</h5>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
            </div>
            <!--MDB Video-->
");
                EndContext();
                BeginContext(10360, 181, true);
                WriteLiteral("    </main>\r\n    <link href=\"https://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css\" rel=\"stylesheet\">\r\n    <h3>Related Projects</h3>\r\n\r\n    <div class=\"row\">\r\n");
                EndContext();
#line 216 "C:\Users\Dor\Desktop\Money2Go\Money2Go\Views\Projects\Details.cshtml"
          
            foreach (var project in ((List<Project>)TempData["Suggestion"]))
            {


#line default
#line hidden
                BeginContext(10648, 54, true);
                WriteLiteral("            <div class=\"col-sm-4\">\r\n                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 10702, "\"", 10775, 1);
#line 221 "C:\Users\Dor\Desktop\Money2Go\Money2Go\Views\Projects\Details.cshtml"
WriteAttributeValue("", 10709, Url.Action("Details", "Projects", new { id = project.ProjectId }), 10709, 66, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(10776, 45, true);
                WriteLiteral(">\r\n                    <img class=\"img-fluid\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 10821, "\"", 10844, 1);
#line 222 "C:\Users\Dor\Desktop\Money2Go\Money2Go\Views\Projects\Details.cshtml"
WriteAttributeValue("", 10827, project.pic_path, 10827, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(10845, 91, true);
                WriteLiteral(" onerror=\"this.src=\'https://teamdo.co.il/wp-content/uploads/2018/01/people-management.png\'\"");
                EndContext();
                BeginWriteAttribute("alt", " alt=\"", 10936, "\"", 10962, 1);
#line 222 "C:\Users\Dor\Desktop\Money2Go\Money2Go\Views\Projects\Details.cshtml"
WriteAttributeValue("", 10942, project.ProjectName, 10942, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(10963, 78, true);
                WriteLiteral(" style=\"width:350px;height:250px;\">\r\n                </a>\r\n                <a>");
                EndContext();
                BeginContext(11042, 19, false);
#line 224 "C:\Users\Dor\Desktop\Money2Go\Money2Go\Views\Projects\Details.cshtml"
              Write(project.ProjectName);

#line default
#line hidden
                EndContext();
                BeginContext(11061, 26, true);
                WriteLiteral("</a>\r\n            </div>\r\n");
                EndContext();
#line 226 "C:\Users\Dor\Desktop\Money2Go\Money2Go\Views\Projects\Details.cshtml"
                }

            

#line default
#line hidden
                BeginContext(11123, 27, true);
                WriteLiteral("    </div>\r\n    </br>\r\n    ");
                EndContext();
                BeginContext(11150, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3bff990f3c4643a2b0df34d16eda265a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(11187, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(11193, 33, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3585633de8a84af6b60c48d917515e81", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(11226, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Money2Go.Models.Project> Html { get; private set; }
    }
}
#pragma warning restore 1591

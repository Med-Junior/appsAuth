#pragma checksum "L:\Applications\InitApps\InitApps\Views\Authentification\RegisterConfirm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1364b6d06a9e2295659ec33aeeabda2a6b4a6d28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Authentification_RegisterConfirm), @"mvc.1.0.view", @"/Views/Authentification/RegisterConfirm.cshtml")]
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
#nullable restore
#line 1 "L:\Applications\InitApps\InitApps\Views\_ViewImports.cshtml"
using InitApps;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "L:\Applications\InitApps\InitApps\Views\_ViewImports.cshtml"
using InitApps.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1364b6d06a9e2295659ec33aeeabda2a6b4a6d28", @"/Views/Authentification/RegisterConfirm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e3769a02b4b4846ca28bbf3013ab0948acfb8a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Authentification_RegisterConfirm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("well form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex justify-content-end"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Authentification", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "L:\Applications\InitApps\InitApps\Views\Authentification\RegisterConfirm.cshtml"
  
    Layout = "_LayoutNotLogged";
    ViewData["Title"] = "Confirm Register";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container"">
    <!-- Begin Page Content -->



    <div class=""container-fluid p-0 px-lg-0 px-md-0"">

        <div class=""container"">

            <!-- Begin Page Content -->
            <div class=""container-fluid px-lg-4"">
                <div class=""row"">
                    <div class=""col-md-12 mt-lg-4 mt-4"">
                        <!-- column -->
                        <div class=""col-md-12 mt-2"">
                            <div class=""card"">
                                <div class=""card-body"">
                                    <!-- title -->
                                    <div class=""d-md-flex align-items-center"">
                                        <div>
                                            <h4 class=""card-title""></h4>
                                            <h4 class=""card-subtitle"">Registration</h4>
                                        </div>
                                    </div>
                                    <!-- titl");
            WriteLiteral(@"e -->
                                </div>
                                <div class=""table-responsive"">

                                    <table class=""table table-striped"">
                                        <tbody>
                                            <tr>
                                                <td colspan=""1"">
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1364b6d06a9e2295659ec33aeeabda2a6b4a6d286462", async() => {
                WriteLiteral(@"
                                                        <fieldset>
                                                            <div class=""form-group"">
                                                                <div class=""input-group"">
                                                                    <label class=""col-3 control-label col-form-label"">Name</label>
                                                                    <input readonly
                                                                           id=""nameOrg"" name=""nameOrg""
                                                                           placeholder=""Name""
                                                                           class=""form-control"" required=""true""");
                BeginWriteAttribute("value", "\r\n                                                                           value=\"", 2322, "\"", 2406, 0);
                EndWriteAttribute();
                WriteLiteral(@" type=""text"">
                                                                </div>
                                                            </div>

                                                            <div class=""form-group"">
                                                                <div class=""input-group"">
                                                                    <label class=""col-3 control-label col-form-label"">Affiliation</label>
                                                                    <input readonly
                                                                           id=""AffiliationOrg""
                                                                           name=""AffiliationOrg""
                                                                           placeholder=""Affiliation""
                                                                           class=""form-control"" required=""true""");
                BeginWriteAttribute("value", "\r\n                                                                           value=\"", 3372, "\"", 3456, 0);
                EndWriteAttribute();
                WriteLiteral(@" type=""text"">
                                                                </div>
                                                            </div>

                                                            <div class=""form-group"">
                                                                <div class=""input-group"">
                                                                    <label class=""col-3 control-label col-form-label"">
                                                                        Field Of
                                                                        Activity
                                                                    </label>
                                                                    <input readonly
                                                                           id=""FieldOfActivityOrg""
                                                                           name=""FieldOfActivityOrg""
                                         ");
                WriteLiteral("                                  placeholder=\"Field Of Activity\"\r\n                                                                           class=\"form-control\" required=\"true\"");
                BeginWriteAttribute("value", "\r\n                                                                           value=\"", 4659, "\"", 4743, 0);
                EndWriteAttribute();
                WriteLiteral(@" type=""text"">
                                                                </div>
                                                            </div>

                                                            <div class=""form-group"">
                                                                <div class=""input-group"">
                                                                    <label class=""col-3 control-label col-form-label"">Address</label>
                                                                    <input readonly
                                                                           id=""addressOrg"" name=""addressOrg""
                                                                           placeholder=""Address""
                                                                           class=""form-control"" required=""true""");
                BeginWriteAttribute("value", "\r\n                                                                           value=\"", 5617, "\"", 5701, 0);
                EndWriteAttribute();
                WriteLiteral(@" type=""text"">
                                                                </div>
                                                            </div>

                                                            <div class=""form-group"">
                                                                <div class=""input-group"">
                                                                    <label class=""col-3 control-label col-form-label"">City</label>
                                                                    <input readonly
                                                                           id=""city"" name=""city""
                                                                           placeholder=""City""
                                                                           class=""form-control"" required=""true""");
                BeginWriteAttribute("value", "\r\n                                                                           value=\"", 6557, "\"", 6641, 0);
                EndWriteAttribute();
                WriteLiteral(@" type=""text"">
                                                                </div>
                                                            </div>

                                                            <div class=""form-group"">
                                                                <div class=""input-group"">
                                                                    <label class=""col-3 control-label col-form-label"">
                                                                        Postal
                                                                        Code/ZIP
                                                                    </label>
                                                                    <input readonly
                                                                           id=""postcode"" name=""postcode""
                                                                           placeholder=""Postal Code/ZIP""
                                 ");
                WriteLiteral("                                          class=\"form-control\" required=\"true\"");
                BeginWriteAttribute("value", "\r\n                                                                           value=\"", 7744, "\"", 7828, 0);
                EndWriteAttribute();
                WriteLiteral(@" type=""text"">
                                                                </div>
                                                            </div>

                                                            <div class=""form-group"">
                                                                <div class=""input-group"">
                                                                    <label class=""col-3 control-label col-form-label"">Country</label>
                                                                    <input readonly
                                                                           id=""Country"" name=""Country""
                                                                           placeholder=""Tunisia""
                                                                           class=""form-control"" required=""true""");
                BeginWriteAttribute("value", "\r\n                                                                           value=\"", 8696, "\"", 8780, 0);
                EndWriteAttribute();
                WriteLiteral(@" type=""text"">
                                                                </div>
                                                            </div>

                                                            <div class=""form-group"">
                                                                <div class=""input-group"">
                                                                    <label class=""col-3 control-label col-form-label"">Email</label>
                                                                    <input readonly
                                                                           id=""email"" name=""email""
                                                                           placeholder=""Email""
                                                                           class=""form-control"" required=""true""");
                BeginWriteAttribute("value", "\r\n                                                                           value=\"", 9640, "\"", 9724, 0);
                EndWriteAttribute();
                WriteLiteral(@" type=""text"">
                                                                </div>
                                                            </div>

                                                            <div class=""form-group"">
                                                                <div class=""input-group"">
                                                                    <label class=""col-3 control-label col-form-label"">
                                                                        Phone
                                                                        Number
                                                                    </label>
                                                                    <input readonly
                                                                           id=""phoneNumber"" name=""phoneNumber""
                                                                           placeholder=""Phone Number""
                                 ");
                WriteLiteral("                                          class=\"form-control\" required=\"true\"");
                BeginWriteAttribute("value", "\r\n                                                                           value=\"", 10827, "\"", 10911, 0);
                EndWriteAttribute();
                WriteLiteral(@" type=""text"">
                                                                </div>
                                                            </div>


                                                            <div class=""form-group"">
                                                                <div class=""input-group"">
                                                                    <label class=""col-3 control-label col-form-label"">
                                                                        Person To
                                                                        Contact
                                                                    </label>
                                                                    <input readonly
                                                                           id=""PersonToContact""
                                                                           name=""PersonToContact""
                                             ");
                WriteLiteral("                              placeholder=\"Person To Contact\"\r\n                                                                           class=\"form-control\" required=\"true\"");
                BeginWriteAttribute("value", "\r\n                                                                           value=\"", 12110, "\"", 12194, 0);
                EndWriteAttribute();
                WriteLiteral(@" type=""text"">
                                                                </div>
                                                            </div>

                                                            <div class=""form-group"">
                                                                <div class=""input-group"">
                                                                    <label class=""col-3 control-label col-form-label"">
                                                                        Contact
                                                                        Mail
                                                                    </label>
                                                                    <input readonly
                                                                           id=""ContactMail"" name=""ContactMail""
                                                                           placeholder=""Contact Mail""
                                 ");
                WriteLiteral("                                          class=\"form-control\" required=\"true\"");
                BeginWriteAttribute("value", "\r\n                                                                           value=\"", 13297, "\"", 13381, 0);
                EndWriteAttribute();
                WriteLiteral(@" type=""text"">
                                                                </div>
                                                            </div>

                                                            <div class=""form-group"">
                                                                <div class=""input-group"">
                                                                    <label class=""col-3 control-label col-form-label"">
                                                                        Contact
                                                                        Phone
                                                                    </label>
                                                                    <input readonly
                                                                           id=""ContactPhone""
                                                                           name=""ContactPhone""
                                                         ");
                WriteLiteral("                  placeholder=\"Contact Phone\"\r\n                                                                           class=\"form-control\" required=\"true\"");
                BeginWriteAttribute("value", "\r\n                                                                           value=\"", 14564, "\"", 14648, 0);
                EndWriteAttribute();
                WriteLiteral(@" type=""text"">
                                                                </div>
                                                            </div>

                                                            <div class=""form-group"">
                                                                <div class=""input-group"">
                                                                    <label class=""col-3 control-label col-form-label"">
                                                                        Contact
                                                                        Position
                                                                    </label>
                                                                    <input readonly
                                                                           id=""ContactPosition""
                                                                           name=""ContactPosition""
                                                ");
                WriteLiteral("                           placeholder=\"Contact Position\"\r\n                                                                           class=\"form-control\" required=\"true\"");
                BeginWriteAttribute("value", "\r\n                                                                           value=\"", 15843, "\"", 15927, 0);
                EndWriteAttribute();
                WriteLiteral(@" type=""text"">
                                                                </div>
                                                            </div>


                                                            <div class=""form-group"">
                                                                <div class=""input-group"">
                                                                    <label class=""col-3 control-label col-form-label"">
                                                                        Register Demand
                                                                        Date
                                                                    </label>
                                                                    <input readonly
                                                                           id=""RegDemandDate""
                                                                           name=""RegDemandDate""
                                              ");
                WriteLiteral("                             placeholder=\"Register Demand Date\"\r\n                                                                           class=\"form-control\" required=\"true\"");
                BeginWriteAttribute("value", "\r\n                                                                           value=\"", 17128, "\"", 17212, 0);
                EndWriteAttribute();
                WriteLiteral(@" type=""text"">
                                                                </div>
                                                            </div>

                                                            <div class=""form-group"">
                                                                <div class=""input-group"">
                                                                    <label class=""col-3 control-label col-form-label"">
                                                                        Register Demand
                                                                        Decision
                                                                    </label>
                                                                    <input readonly
                                                                           id=""RegDemandDate""
                                                                           name=""RegDemandDecision""
                                        ");
                WriteLiteral("                                   placeholder=\"Register Demand Decision\"\r\n                                                                           class=\"form-control\" required=\"true\"");
                BeginWriteAttribute("value", "\r\n                                                                           value=\"", 18423, "\"", 18507, 0);
                EndWriteAttribute();
                WriteLiteral(@" type=""text"">
                                                                </div>
                                                            </div>

                                                            <div class=""form-group"">
                                                                <div class=""input-group"">
                                                                    <label class=""col-3 control-label col-form-label"">
                                                                        Register Demand
                                                                        Decision Date
                                                                    </label>
                                                                    <input readonly
                                                                           id=""RegDemandDate""
                                                                           name=""RegDemandDecisionDate""
                               ");
                WriteLiteral("                                            placeholder=\"Register Demand Decision Date\"\r\n                                                                           class=\"form-control\" required=\"true\"");
                BeginWriteAttribute("value", "\r\n                                                                           value=\"", 19732, "\"", 19816, 0);
                EndWriteAttribute();
                WriteLiteral(@" type=""text"">
                                                                </div>
                                                            </div>
                                                        </fieldset>

                                                        <div class=""ml-auto d-flex justify-content-end"">
                                                            <div class=""dl"">

                                                                <button class=""btn btn-success mx-2"">Submit</button>
                                                                <button class=""btn btn-warning mx-2"">Update</button>
                                                            </div>
                                                        </div>
                                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1364b6d06a9e2295659ec33aeeabda2a6b4a6d2829970", async() => {
                WriteLiteral("<button class=\"btn btn-warning mx-2\">Update</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>


                    </div>

                </div>
                <!-- /.container-fluid -->

            </div>
        </div>

    </div>





    <!-- /.container-fluid -->

</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

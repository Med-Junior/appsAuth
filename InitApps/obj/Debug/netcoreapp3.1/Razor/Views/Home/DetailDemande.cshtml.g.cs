#pragma checksum "L:\Applications\InitApps\InitApps\Views\Home\DetailDemande.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52e2d7c982925fe8df4453fc5834c4ae65120cd6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DetailDemande), @"mvc.1.0.view", @"/Views/Home/DetailDemande.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52e2d7c982925fe8df4453fc5834c4ae65120cd6", @"/Views/Home/DetailDemande.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e3769a02b4b4846ca28bbf3013ab0948acfb8a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DetailDemande : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("well form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "L:\Applications\InitApps\InitApps\Views\Home\DetailDemande.cshtml"
  
    ViewData["Title"] = "Detail Demande";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container"">
    <!-- Begin Page Content -->
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
                                    <h5 class=""card-subtitle"">Detail Organisation Nom Here</h5>
                                </div>
                                <div class=""ml-auto"">
                                    <div class=""dl"">

                                        <button type=""submit"" class=""btn btn-success"">Accepter</button>
                                        <button type=""submit"" class");
            WriteLiteral(@"=""btn btn-warning"">Refuser</button>
                                        <button type=""submit"" class=""btn btn-danger"">Supprimer</button>
                                    </div>
                                </div>
                            </div>
                            <!-- title -->
                        </div>
                        <div class=""table-responsive"">

                            <table class=""table table-striped"">
                                <tbody>
                                    <tr>
                                        <td colspan=""1"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52e2d7c982925fe8df4453fc5834c4ae65120cd65481", async() => {
                WriteLiteral(@"
                                                <fieldset>
                                                    <div class=""form-group"">
                                                        <div class=""input-group"">
                                                            <label class=""col-3 control-label col-form-label"">Name</label>
                                                            <input readonly
                                                                   id=""nameOrg"" name=""nameOrg""
                                                                   placeholder=""Name""
                                                                   class=""form-control"" required=""true""");
                BeginWriteAttribute("value", "\r\n                                                                   value=\"", 2465, "\"", 2541, 0);
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
                BeginWriteAttribute("value", "\r\n                                                                   value=\"", 3427, "\"", 3503, 0);
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
                                                                   placeholder=""Field Of Activity""
                             ");
                WriteLiteral("                                      class=\"form-control\" required=\"true\"");
                BeginWriteAttribute("value", "\r\n                                                                   value=\"", 4602, "\"", 4678, 0);
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
                BeginWriteAttribute("value", "\r\n                                                                   value=\"", 5480, "\"", 5556, 0);
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
                BeginWriteAttribute("value", "\r\n                                                                   value=\"", 6340, "\"", 6416, 0);
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
                                                                   class=""form-control"" required=""true""");
                BeginWriteAttribute("value", "\r\n                                                                   value=\"", 7423, "\"", 7499, 0);
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
                BeginWriteAttribute("value", "\r\n                                                                   value=\"", 8295, "\"", 8371, 0);
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
                BeginWriteAttribute("value", "\r\n                                                                   value=\"", 9159, "\"", 9235, 0);
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
                                                                   class=""form-control"" required=""true""");
                BeginWriteAttribute("value", "\r\n                                                                   value=\"", 10242, "\"", 10318, 0);
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
                                                                   placeholder=""Person To Contact""
                                 ");
                WriteLiteral("                                  class=\"form-control\" required=\"true\"");
                BeginWriteAttribute("value", "\r\n                                                                   value=\"", 11413, "\"", 11489, 0);
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
                                                                   class=""form-control"" required=""true""");
                BeginWriteAttribute("value", "\r\n                                                                   value=\"", 12496, "\"", 12572, 0);
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
                                                                   placeholder=""Contact Phone""
                                                 ");
                WriteLiteral("                  class=\"form-control\" required=\"true\"");
                BeginWriteAttribute("value", "\r\n                                                                   value=\"", 13651, "\"", 13727, 0);
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
                                                                   placeholder=""Contact Position""
                                     ");
                WriteLiteral("                              class=\"form-control\" required=\"true\"");
                BeginWriteAttribute("value", "\r\n                                                                   value=\"", 14818, "\"", 14894, 0);
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
                                                                   placeholder=""Register Demand Date""
                               ");
                WriteLiteral("                                    class=\"form-control\" required=\"true\"");
                BeginWriteAttribute("value", "\r\n                                                                   value=\"", 15991, "\"", 16067, 0);
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
                                                                   placeholder=""Register Demand Decision""
                     ");
                WriteLiteral("                                              class=\"form-control\" required=\"true\"");
                BeginWriteAttribute("value", "\r\n                                                                   value=\"", 17174, "\"", 17250, 0);
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
                                                                   placeholder=""Register Demand Decision Date""
       ");
                WriteLiteral("                                                            class=\"form-control\" required");
                BeginWriteAttribute("value", "\r\n                                                                   value=\"", 18364, "\"", 18440, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"text\">\r\n                                                        </div>\r\n                                                    </div>\r\n                                                </fieldset>\r\n                                            ");
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

    <!-- /.container-fluid -->

</div>
");
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
#pragma checksum "E:\New folder2\Employee Management\Employee Management\Employee Management\Views\Position\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5605eb7b31aa7dd40ab7852a7476e10fa4eff8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Position_Index), @"mvc.1.0.view", @"/Views/Position/Index.cshtml")]
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
#line 1 "E:\New folder2\Employee Management\Employee Management\Employee Management\Views\_ViewImports.cshtml"
using Employee_Management.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\New folder2\Employee Management\Employee Management\Employee Management\Views\_ViewImports.cshtml"
using Employee_Management.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\New folder2\Employee Management\Employee Management\Employee Management\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5605eb7b31aa7dd40ab7852a7476e10fa4eff8a", @"/Views/Position/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c190d19520ea44a4df6e823ec2ec466f984b4978", @"/Views/_ViewImports.cshtml")]
    public class Views_Position_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Position>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Position", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/customScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\New folder2\Employee Management\Employee Management\Employee Management\Views\Position\Index.cshtml"
  
    ViewBag.Title = "Position List";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1 class=\"text-center\">Position List</h1>\r\n<hr />\r\n\r\n<div id=\"PlaceHolderHere\"></div>\r\n\r\n");
            WriteLiteral("<button type=\"button\" class=\"btn btn-primary m-1\" style=\"width:auto\" data-toggle=\"ajax-modal\" data-target=\"#addModal\"\r\n        data-url=\"");
#nullable restore
#line 13 "E:\New folder2\Employee Management\Employee Management\Employee Management\Views\Position\Index.cshtml"
             Write(Url.Action("Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n    Create New\r\n</button>\r\n\r\n<table class=\"table mt-2\">\r\n    <thead class=\"thead-light\">\r\n        <tr>\r\n            <th>Position Name</th>\r\n            <th>Action</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 25 "E:\New folder2\Employee Management\Employee Management\Employee Management\Views\Position\Index.cshtml"
         foreach (var position in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 28 "E:\New folder2\Employee Management\Employee Management\Employee Management\Views\Position\Index.cshtml"
               Write(position.PositionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5605eb7b31aa7dd40ab7852a7476e10fa4eff8a6639", async() => {
                WriteLiteral("\r\n\r\n                        <button type=\"button\" class=\"btn btn-primary m-1\" style=\"width:auto\" data-toggle=\"ajax-modal\" data-target=\"#addModal\"\r\n                                data-url=\"");
#nullable restore
#line 33 "E:\New folder2\Employee Management\Employee Management\Employee Management\Views\Position\Index.cshtml"
                                     Write(Url.Action($"Edit/{position.PositionID}"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\">\r\n                            Edit\r\n                        </button>\r\n                        <button type=\"submit\" class=\"btn btn-danger\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1273, "\"", 1366, 12);
                WriteAttributeValue("", 1283, "return", 1283, 6, true);
                WriteAttributeValue(" ", 1289, "confirm(\'Are", 1290, 13, true);
                WriteAttributeValue(" ", 1302, "you", 1303, 4, true);
                WriteAttributeValue(" ", 1306, "sure", 1307, 5, true);
                WriteAttributeValue(" ", 1311, "you", 1312, 4, true);
                WriteAttributeValue(" ", 1315, "want", 1316, 5, true);
                WriteAttributeValue(" ", 1320, "to", 1321, 3, true);
                WriteAttributeValue(" ", 1323, "Delete", 1324, 7, true);
                WriteAttributeValue(" ", 1330, "Position", 1331, 9, true);
                WriteAttributeValue(" ", 1339, ":", 1340, 2, true);
#nullable restore
#line 36 "E:\New folder2\Employee Management\Employee Management\Employee Management\Views\Position\Index.cshtml"
WriteAttributeValue(" ", 1341, position.PositionName, 1342, 22, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1364, "\')", 1364, 2, true);
                EndWriteAttribute();
                WriteLiteral(">Delete</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "E:\New folder2\Employee Management\Employee Management\Employee Management\Views\Position\Index.cshtml"
                                                                          WriteLiteral(position.PositionID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 40 "E:\New folder2\Employee Management\Employee Management\Employee Management\Views\Position\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5605eb7b31aa7dd40ab7852a7476e10fa4eff8a11849", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Position>> Html { get; private set; }
    }
}
#pragma warning restore 1591

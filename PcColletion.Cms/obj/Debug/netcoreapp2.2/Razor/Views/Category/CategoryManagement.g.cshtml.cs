#pragma checksum "C:\Users\lenovo\source\repos\PcColletion\PcColletion.Cms\Views\Category\CategoryManagement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e635115640011acd3873945400775a5a493481b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_CategoryManagement), @"mvc.1.0.view", @"/Views/Category/CategoryManagement.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Category/CategoryManagement.cshtml", typeof(AspNetCore.Views_Category_CategoryManagement))]
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
#line 1 "C:\Users\lenovo\source\repos\PcColletion\PcColletion.Cms\Views\_ViewImports.cshtml"
using PcColletion.Cms;

#line default
#line hidden
#line 2 "C:\Users\lenovo\source\repos\PcColletion\PcColletion.Cms\Views\_ViewImports.cshtml"
using PcColletion.Cms.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e635115640011acd3873945400775a5a493481b6", @"/Views/Category/CategoryManagement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"220de110fc46100f2894ae9ded1b673e93e5395a", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_CategoryManagement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PcColletion.InfraStructure.Model.Categorie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-send btn-primary btn-xs pull-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-send btn-primary btn-xs"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\lenovo\source\repos\PcColletion\PcColletion.Cms\Views\Category\CategoryManagement.cshtml"
  
    ViewData["Title"] = "CategoryManagement";
        Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
            BeginContext(173, 246, true);
            WriteLiteral("\r\n \r\n \r\n<style>\r\n    .table-responsive {\r\n        overflow-x: auto;\r\n    }\r\n\r\n    td, th {\r\n        white-space: nowrap;\r\n        padding: 5px 10px !important;\r\n    }\r\n</style>\r\n<div class=\"row\">\r\n    <h2>\r\n        Category Management\r\n\r\n        ");
            EndContext();
            BeginContext(419, 113, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e635115640011acd3873945400775a5a493481b65334", async() => {
                BeginContext(493, 35, true);
                WriteLiteral("<i class=\"fa fa-pencil\"></i> Create");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(532, 81, true);
            WriteLiteral("\r\n\r\n    </h2>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-md-12 col-xs-12\">\r\n");
            EndContext();
#line 31 "C:\Users\lenovo\source\repos\PcColletion\PcColletion.Cms\Views\Category\CategoryManagement.cshtml"
         if (Model != null)
        {

#line default
#line hidden
            BeginContext(653, 1004, true);
            WriteLiteral(@"            <div class=""adv-table"">
                <div id=""example_wrapper"" class=""table-responsive"">
                    <table class=""table table-bordered table-striped"" id=""example"">
                        <thead>
                            <tr role=""row"">
                                <th></th>
                                <th class=""sorting"" role=""columnheader"" tabindex=""0"" aria-controls=""example"" rowspan=""1"" colspan=""1"">Id</th>
                                <th class=""sorting"" role=""columnheader"" tabindex=""0"" aria-controls=""example"" rowspan=""1"" colspan=""1"">Name</th>
                                <th class=""sorting"" role=""columnheader"" tabindex=""0"" aria-controls=""example"" rowspan=""1"" colspan=""1"">Parent</th>

                                <th class=""sorting"" role=""columnheader"" tabindex=""0"" aria-controls=""example"" rowspan=""1"" colspan=""1"">CreateDate</th>

                            </tr>
                        </thead>


                        <tbody>
");
            EndContext();
#line 50 "C:\Users\lenovo\source\repos\PcColletion\PcColletion.Cms\Views\Category\CategoryManagement.cshtml"
                             foreach (var item in Model.ToList())
                            {

#line default
#line hidden
            BeginContext(1755, 139, true);
            WriteLiteral("                                <tr class=\"gradeX odd\">\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(1894, 179, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e635115640011acd3873945400775a5a493481b68748", async() => {
                BeginContext(2040, 29, true);
                WriteLiteral("<i class=\"fa fa-eye\"></i> Seç");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 54 "C:\Users\lenovo\source\repos\PcColletion\PcColletion.Cms\Views\Category\CategoryManagement.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues = new Dictionary<string, string> { { "Id",@item.Id.ToString() } };

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-all-route-data", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2073, 87, true);
            WriteLiteral("\r\n                                    </td>\r\n\r\n                                    <td>");
            EndContext();
            BeginContext(2161, 7, false);
#line 57 "C:\Users\lenovo\source\repos\PcColletion\PcColletion.Cms\Views\Category\CategoryManagement.cshtml"
                                   Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2168, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2216, 9, false);
#line 58 "C:\Users\lenovo\source\repos\PcColletion\PcColletion.Cms\Views\Category\CategoryManagement.cshtml"
                                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2225, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2273, 11, false);
#line 59 "C:\Users\lenovo\source\repos\PcColletion\PcColletion.Cms\Views\Category\CategoryManagement.cshtml"
                                   Write(item.Parent);

#line default
#line hidden
            EndContext();
            BeginContext(2284, 49, true);
            WriteLiteral("</td>\r\n\r\n                                    <td>");
            EndContext();
            BeginContext(2334, 35, false);
#line 61 "C:\Users\lenovo\source\repos\PcColletion\PcColletion.Cms\Views\Category\CategoryManagement.cshtml"
                                   Write(item.CreateDate.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(2369, 46, true);
            WriteLiteral("</td>\r\n                                </tr>\r\n");
            EndContext();
#line 63 "C:\Users\lenovo\source\repos\PcColletion\PcColletion.Cms\Views\Category\CategoryManagement.cshtml"
                            }

#line default
#line hidden
            BeginContext(2446, 114, true);
            WriteLiteral("\r\n\r\n\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 71 "C:\Users\lenovo\source\repos\PcColletion\PcColletion.Cms\Views\Category\CategoryManagement.cshtml"
        }

#line default
#line hidden
            BeginContext(2571, 141, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n<style>\r\n    .dataTable tr td:last-child, .dataTable tr th:last-child {\r\n        display: block;\r\n    }\r\n</style>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PcColletion.InfraStructure.Model.Categorie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
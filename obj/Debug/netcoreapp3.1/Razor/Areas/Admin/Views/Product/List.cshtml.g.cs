#pragma checksum "C:\Project\Areas\Admin\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8df7403a687cdbaaeb1d06ff9da109ad8f337948"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_List), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/List.cshtml")]
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
#line 1 "C:\Project\Areas\Admin\Views\_ViewImports.cshtml"
using Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Project\Areas\Admin\Views\_ViewImports.cshtml"
using Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8df7403a687cdbaaeb1d06ff9da109ad8f337948", @"/Areas/Admin/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89e31fbbec8fb4222cf117a26f28137c5b00e63f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Project\Areas\Admin\Views\Product\List.cshtml"
  
    ViewBag.Title = "Product List";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br>
<h1 id=""Catext"" style=""text-align: center;"">WELCOME ADMIN</h1>

<br><br>

<h1> Add ,Remove & Update <a id=""Highlight"">Items</a> on Store</h1>
<br><br><br>
<h3> To <a id=""Highlight"" >Add</a> an<a id=""Highlight""> Item</a> on Store hit the following bottom</h3>
<br>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8df7403a687cdbaaeb1d06ff9da109ad8f3379484101", async() => {
                WriteLiteral("\r\n  <button mdbRipple rippleColor=\"dark\" type=\"button\"class=\"btn btn-outline-success btn-rounded\" style=\"size: 4ch;\">\r\n    Add Item</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<br>
       
<br><br><br>
<h3 style=""border-top: 2px solid green;""><a id=""Highlight"">Available</a> Products</h3>
<br>
<h1><a id=""Highlight"">ALL</a> Products </h1>
    <div class=""col-sm-10"">
        <table class=""table table-bordered "" id=""TableItems"">
            <thead>
                <tr style=""color: white;"">
                    <th>Name</th>
                    <th>Price</th>
                   <th>Remove / Update</th>
            </thead>
            <tbody>
");
#nullable restore
#line 33 "C:\Project\Areas\Admin\Views\Product\List.cshtml"
                 foreach (var product in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr style=\"color: white;\">\r\n                        <td>");
#nullable restore
#line 36 "C:\Project\Areas\Admin\Views\Product\List.cshtml"
                       Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 37 "C:\Project\Areas\Admin\Views\Product\List.cshtml"
                       Write(product.Price.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                       <td>\r\n                            \r\n                        <a style=\"text-decoration: none;color: green\" onclick=\"return confirm(\'Are you sure you want to delete this item?\');\"");
            BeginWriteAttribute("href", " href=\"", 1453, "\"", 1524, 1);
#nullable restore
#line 40 "C:\Project\Areas\Admin\Views\Product\List.cshtml"
WriteAttributeValue("", 1460, Url.Action("Delete", "Product", new { id = product.ProductID }), 1460, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                        <a style=\"text-decoration: none;color: green\"");
            BeginWriteAttribute("href", " href=\"", 1607, "\"", 1678, 1);
#nullable restore
#line 41 "C:\Project\Areas\Admin\Views\Product\List.cshtml"
WriteAttributeValue("", 1614, Url.Action("Update", "Product", new { id = product.ProductID }), 1614, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Update</a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 44 "C:\Project\Areas\Admin\Views\Product\List.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Project\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "874cdd30b65167baaa5110e2e3288451535ee1b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
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
#line 1 "C:\Project\Views\_ViewImports.cshtml"
using Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Project\Views\_ViewImports.cshtml"
using Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"874cdd30b65167baaa5110e2e3288451535ee1b0", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89e31fbbec8fb4222cf117a26f28137c5b00e63f", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Project\Views\Product\Details.cshtml"
  
    ViewBag.Title = "Product Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Product <a id=\"Highlight\">Details</a></h1>\r\n<br><br>\r\n <img id=\"Category\"");
            BeginWriteAttribute("src", " src=\"", 142, "\"", 176, 1);
#nullable restore
#line 8 "C:\Project\Views\Product\Details.cshtml"
WriteAttributeValue("", 148, Url.Content(ViewBag.imgurl), 148, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", "  alt=\"", 177, "\"", 201, 2);
#nullable restore
#line 8 "C:\Project\Views\Product\Details.cshtml"
WriteAttributeValue("", 184, Model.Name, 184, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 195, "Image", 196, 6, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-responsive center-block\"/>\r\n                 \r\n<br><br>\r\n    <div class=\"col-sm-6\">\r\n        \r\n        <h2 id=\"Highlight\">");
#nullable restore
#line 13 "C:\Project\Views\Product\Details.cshtml"
                      Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <table class=\"table table-bordered table-striped\" style=\"border: 1px solid green;\">\r\n            <tr style=\"color: white;\">\r\n                <td>Initial Price:</td>\r\n                <td>");
#nullable restore
#line 17 "C:\Project\Views\Product\Details.cshtml"
               Write(Model.Price.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr style=\"color: white;\">\r\n                <td>Discount:</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Project\Views\Product\Details.cshtml"
               Write(Model.DiscountPercent.ToString("P0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr style=\"color: white;\">\r\n                <td>Final Price:</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Project\Views\Product\Details.cshtml"
               Write(Model.DiscountPrice.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            </tr>\r\n        </table>\r\n        <a style=\"text-decoration: none;color: green\"");
            BeginWriteAttribute("href", " \r\n        href=\"", 990, "\"", 1068, 1);
#nullable restore
#line 29 "C:\Project\Views\Product\Details.cshtml"
WriteAttributeValue("", 1007, Url.Action("AddItem", "Cart", new { id = @Model.ProductID }), 1007, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <button mdbRipple rippleColor=\"dark\" type=\"button\" \r\n        class=\"btn btn-outline-success btn-rounded\" style=\"size: 4ch;\" >\r\n        Add to Cart</button></a>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
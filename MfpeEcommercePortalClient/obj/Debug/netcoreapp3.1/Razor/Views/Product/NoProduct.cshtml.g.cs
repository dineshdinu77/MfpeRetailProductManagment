#pragma checksum "C:\Users\deepa\Desktop\mfpe\MFPE-master\EcommercePortalClient\Views\Product\NoProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62ea11eca9fc736449d878bc2e01b32fd8883c9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_NoProduct), @"mvc.1.0.view", @"/Views/Product/NoProduct.cshtml")]
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
#line 1 "C:\Users\deepa\Desktop\mfpe\MFPE-master\EcommercePortalClient\Views\_ViewImports.cshtml"
using EcommercePortalClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\deepa\Desktop\mfpe\MFPE-master\EcommercePortalClient\Views\_ViewImports.cshtml"
using EcommercePortalClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62ea11eca9fc736449d878bc2e01b32fd8883c9a", @"/Views/Product/NoProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54efc102f830d4495d20e975969a23ce1481d099", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_NoProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\deepa\Desktop\mfpe\MFPE-master\EcommercePortalClient\Views\Product\NoProduct.cshtml"
  
    ViewData["Title"] = "NoProduct";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>There is No such Product,Would you like to search for other product</h1>\r\n<a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 153, "\"", 190, 1);
#nullable restore
#line 7 "C:\Users\deepa\Desktop\mfpe\MFPE-master\EcommercePortalClient\Views\Product\NoProduct.cshtml"
WriteAttributeValue("", 160, Url.Action("Home", "Product"), 160, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Yes</a>\r\n<a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 227, "\"", 262, 1);
#nullable restore
#line 8 "C:\Users\deepa\Desktop\mfpe\MFPE-master\EcommercePortalClient\Views\Product\NoProduct.cshtml"
WriteAttributeValue("", 234, Url.Action("Logout","Auth"), 234, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">No</a>\r\n\r\n\r\n");
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

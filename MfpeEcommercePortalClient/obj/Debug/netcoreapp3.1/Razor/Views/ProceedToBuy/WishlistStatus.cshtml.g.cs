#pragma checksum "C:\Users\deepa\Desktop\mfpe\MFPE-master\EcommercePortalClient\Views\ProceedToBuy\WishlistStatus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "160a8802375a2dc13c8d6e59437ca0a1c6123b0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProceedToBuy_WishlistStatus), @"mvc.1.0.view", @"/Views/ProceedToBuy/WishlistStatus.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"160a8802375a2dc13c8d6e59437ca0a1c6123b0a", @"/Views/ProceedToBuy/WishlistStatus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54efc102f830d4495d20e975969a23ce1481d099", @"/Views/_ViewImports.cshtml")]
    public class Views_ProceedToBuy_WishlistStatus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EcommercePortalClient.Models.ViewModels.WishlistStatusViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\deepa\Desktop\mfpe\MFPE-master\EcommercePortalClient\Views\ProceedToBuy\WishlistStatus.cshtml"
  
    ViewData["Title"] = "WishlistStatus";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>WishlistStatus</h1>\n\n<div>\n\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 13 "C:\Users\deepa\Desktop\mfpe\MFPE-master\EcommercePortalClient\Views\ProceedToBuy\WishlistStatus.cshtml"
       Write(Html.DisplayNameFor(model => model.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 16 "C:\Users\deepa\Desktop\mfpe\MFPE-master\EcommercePortalClient\Views\ProceedToBuy\WishlistStatus.cshtml"
       Write(Html.DisplayFor(model => model.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EcommercePortalClient.Models.ViewModels.WishlistStatusViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\ener-\source\repos\Nutritionist\Nutritionist.UI\Views\Basket\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "438a68c358bdc6f59cbeb3928334eb8fcdc92fb4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Basket_Index), @"mvc.1.0.view", @"/Views/Basket/Index.cshtml")]
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
#line 1 "C:\Users\ener-\source\repos\Nutritionist\Nutritionist.UI\Views\_ViewImports.cshtml"
using Nutritionist.UI;

#line default
#line hidden
#line 2 "C:\Users\ener-\source\repos\Nutritionist\Nutritionist.UI\Views\_ViewImports.cshtml"
using Nutritionist.UI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"438a68c358bdc6f59cbeb3928334eb8fcdc92fb4", @"/Views/Basket/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"497e7b6bc5606f328cd84c4a97644ee147d9644d", @"/Views/_ViewImports.cshtml")]
    public class Views_Basket_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BasketModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\ener-\source\repos\Nutritionist\Nutritionist.UI\Views\Basket\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            WriteLiteral("\r\n<h1>SEPETİM</h1>\r\n");
#line 8 "C:\Users\ener-\source\repos\Nutritionist\Nutritionist.UI\Views\Basket\Index.cshtml"
 foreach (var item in Model)
{


#line default
#line hidden
            WriteLiteral("    <h5> Diyet Adı : ");
#line 11 "C:\Users\ener-\source\repos\Nutritionist\Nutritionist.UI\Views\Basket\Index.cshtml"
                Write(item.Name);

#line default
#line hidden
            WriteLiteral("     ->>>    </h5>\r\n");
#line 12 "C:\Users\ener-\source\repos\Nutritionist\Nutritionist.UI\Views\Basket\Index.cshtml"

}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BasketModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
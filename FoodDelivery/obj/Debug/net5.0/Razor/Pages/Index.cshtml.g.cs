#pragma checksum "D:\asp\assignment-2\FoodDelivery\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0af435606dd445cb9e03c5e0dc5108c0fb654d90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FoodDelivery.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace FoodDelivery.Pages
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
#line 1 "D:\asp\assignment-2\FoodDelivery\Pages\_ViewImports.cshtml"
using FoodDelivery;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0af435606dd445cb9e03c5e0dc5108c0fb654d90", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"544aec42d10ad7cb7c596921fbfda09391486f99", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\asp\assignment-2\FoodDelivery\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n");
#nullable restore
#line 11 "D:\asp\assignment-2\FoodDelivery\Pages\Index.cshtml"
  
    var food = new[]{
        new{
            foodItem="Burger",
            Price="3.65$",
            totalItems="1",
        },
        new{
            foodItem="Spring Rolls",
            Price="4.55$",
            totalItems="4",
        },
        new{
            foodItem="Veg Combo",
            Price="12.85$",
            totalItems="6",
        },
        new{
           foodItem="Chicken Nuggets",
            Price="8.00$",
            totalItems="8",
        },
        new{
            foodItem="Pizza",
            Price="12.45$",
            totalItems="1",
        }
    };

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "D:\asp\assignment-2\FoodDelivery\Pages\Index.cshtml"
 for (var i = 0; i <food.Length; i++)
{
    var foodY =food[i];
    

#line default
#line hidden
#nullable disable
            WriteLiteral("foodItem:<strong>");
#nullable restore
#line 43 "D:\asp\assignment-2\FoodDelivery\Pages\Index.cshtml"
                      Write(foodY.foodItem);

#line default
#line hidden
#nullable disable
            WriteLiteral("  <br/> </strong> ");
            WriteLiteral("\r\n");
            WriteLiteral("Price:");
#nullable restore
#line 44 "D:\asp\assignment-2\FoodDelivery\Pages\Index.cshtml"
           Write(foodY.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>");
            WriteLiteral("\r\n");
            WriteLiteral("Total Items:");
#nullable restore
#line 45 "D:\asp\assignment-2\FoodDelivery\Pages\Index.cshtml"
                 Write(foodY.totalItems);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>");
#nullable restore
#line 45 "D:\asp\assignment-2\FoodDelivery\Pages\Index.cshtml"
                                                   
} 

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

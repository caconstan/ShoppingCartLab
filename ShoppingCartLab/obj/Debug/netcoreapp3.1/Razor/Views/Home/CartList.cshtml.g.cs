#pragma checksum "C:\Users\Chris\Documents\GC bootcamp\ShoppingCartLab\ShoppingCartLab\Views\Home\CartList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fd14ecc64e2045dbec8442e5b991abc7872e8de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CartList), @"mvc.1.0.view", @"/Views/Home/CartList.cshtml")]
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
#line 1 "C:\Users\Chris\Documents\GC bootcamp\ShoppingCartLab\ShoppingCartLab\Views\_ViewImports.cshtml"
using ShoppingCartLab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Chris\Documents\GC bootcamp\ShoppingCartLab\ShoppingCartLab\Views\_ViewImports.cshtml"
using ShoppingCartLab.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fd14ecc64e2045dbec8442e5b991abc7872e8de", @"/Views/Home/CartList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36ef302df58b3d015dd11fa5931d98ae3a7cda92", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CartList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CartModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("CartForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Receipt"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Chris\Documents\GC bootcamp\ShoppingCartLab\ShoppingCartLab\Views\Home\CartList.cshtml"
  
    ViewData["Title"] = "Cart List Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\nYour total comes to ");
#nullable restore
#line 6 "C:\Users\Chris\Documents\GC bootcamp\ShoppingCartLab\ShoppingCartLab\Views\Home\CartList.cshtml"
               Write(Model.GetTotal());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\nHere are the items in your cart:\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fd14ecc64e2045dbec8442e5b991abc7872e8de4521", async() => {
                WriteLiteral("\r\n        <table border=\"1\">\r\n            <tr><th>ID</th><th>Movie</th><th>Genre</th><th>Price</th></tr>\r\n\r\n");
#nullable restore
#line 14 "C:\Users\Chris\Documents\GC bootcamp\ShoppingCartLab\ShoppingCartLab\Views\Home\CartList.cshtml"
             foreach (MovieModel mm in Model.moviesList)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 17 "C:\Users\Chris\Documents\GC bootcamp\ShoppingCartLab\ShoppingCartLab\Views\Home\CartList.cshtml"
                   Write(mm.ID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 18 "C:\Users\Chris\Documents\GC bootcamp\ShoppingCartLab\ShoppingCartLab\Views\Home\CartList.cshtml"
                   Write(mm.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 19 "C:\Users\Chris\Documents\GC bootcamp\ShoppingCartLab\ShoppingCartLab\Views\Home\CartList.cshtml"
                   Write(mm.Genre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>$");
#nullable restore
#line 20 "C:\Users\Chris\Documents\GC bootcamp\ShoppingCartLab\ShoppingCartLab\Views\Home\CartList.cshtml"
                    Write(mm.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 22 "C:\Users\Chris\Documents\GC bootcamp\ShoppingCartLab\ShoppingCartLab\Views\Home\CartList.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n\r\n        <input type=\"submit\" onclick=\"document.location = \'MovieList\'; return false;\" value=\"Add Another Movie\" />\r\n        <input type=\"submit\" value=\"Check Out\" />\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CartModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

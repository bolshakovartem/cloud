#pragma checksum "D:\cloud\lab1\WebApplication1\WebApplication1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c69709ffca6571117ffe0f5eb3a11cd6e5259f60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\cloud\lab1\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\cloud\lab1\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c69709ffca6571117ffe0f5eb3a11cd6e5259f60", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\cloud\lab1\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Book Shop";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <div>
        <h3>Sale</h3>
        <table>
            <tr>
                <td><p>Name of a book</p></td>
                <td><p>Author</p></td>
                <td><p>Price</p></td>
                <td></td>
            </tr>
");
#nullable restore
#line 15 "D:\cloud\lab1\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
              
                foreach (var b in ViewBag.Books)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td><p>");
#nullable restore
#line 19 "D:\cloud\lab1\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                          Write(b.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                        <td><p>");
#nullable restore
#line 20 "D:\cloud\lab1\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                          Write(b.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                        <td><p>");
#nullable restore
#line 21 "D:\cloud\lab1\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                          Write(b.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n                       <td><p><a");
            BeginWriteAttribute("href", " href=\"", 609, "\"", 631, 2);
            WriteAttributeValue("", 616, "/Home/Buy/", 616, 10, true);
#nullable restore
#line 22 "D:\cloud\lab1\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
WriteAttributeValue("", 626, b.Id, 626, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Buy</a></p></td>\r\n                       \r\n                    </tr>\r\n");
#nullable restore
#line 25 "D:\cloud\lab1\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    </div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

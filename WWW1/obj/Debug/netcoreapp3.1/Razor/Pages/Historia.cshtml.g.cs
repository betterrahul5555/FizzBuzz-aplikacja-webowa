#pragma checksum "C:\Users\Janek\source\repos\FizzBuzz-aplikacja-webowa\WWW1\Pages\Historia.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64ea3a11834674da014cbe42cf2ab3c922c00e1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WWW1.Pages.Pages_Historia), @"mvc.1.0.razor-page", @"/Pages/Historia.cshtml")]
namespace WWW1.Pages
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
#line 1 "C:\Users\Janek\source\repos\FizzBuzz-aplikacja-webowa\WWW1\Pages\_ViewImports.cshtml"
using WWW1;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64ea3a11834674da014cbe42cf2ab3c922c00e1c", @"/Pages/Historia.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cba076aa7f30ea06f97638cb776126f70aa1c2b4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Historia : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Janek\source\repos\FizzBuzz-aplikacja-webowa\WWW1\Pages\Historia.cshtml"
  
    ViewData["Title"] = "Historia";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Historia</h1>\r\n");
#nullable restore
#line 8 "C:\Users\Janek\source\repos\FizzBuzz-aplikacja-webowa\WWW1\Pages\Historia.cshtml"
 foreach (var item in Model.historia)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n    ");
#nullable restore
#line 11 "C:\Users\Janek\source\repos\FizzBuzz-aplikacja-webowa\WWW1\Pages\Historia.cshtml"
Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(",&nbsp; ");
#nullable restore
#line 11 "C:\Users\Janek\source\repos\FizzBuzz-aplikacja-webowa\WWW1\Pages\Historia.cshtml"
               Write(item.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp;");
#nullable restore
#line 11 "C:\Users\Janek\source\repos\FizzBuzz-aplikacja-webowa\WWW1\Pages\Historia.cshtml"
                                  Write(item.Dataa);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp;");
#nullable restore
#line 11 "C:\Users\Janek\source\repos\FizzBuzz-aplikacja-webowa\WWW1\Pages\Historia.cshtml"
                                                    Write(item.St);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n</p>\r\n");
#nullable restore
#line 15 "C:\Users\Janek\source\repos\FizzBuzz-aplikacja-webowa\WWW1\Pages\Historia.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WWW1.Pages.HistoriaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WWW1.Pages.HistoriaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WWW1.Pages.HistoriaModel>)PageContext?.ViewData;
        public WWW1.Pages.HistoriaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
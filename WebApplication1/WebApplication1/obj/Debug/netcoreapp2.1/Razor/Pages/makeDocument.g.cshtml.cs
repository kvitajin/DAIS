#pragma checksum "/home/kvitajin/RiderProjects/vsb/DAIS/WebApplication1/WebApplication1/Pages/makeDocument.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "340fe81703dd21361dc54fbe2dc02be9de245d76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApplication1.Pages.Pages_makeDocument), @"mvc.1.0.razor-page", @"/Pages/makeDocument.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/makeDocument.cshtml", typeof(WebApplication1.Pages.Pages_makeDocument), null)]
namespace WebApplication1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/home/kvitajin/RiderProjects/vsb/DAIS/WebApplication1/WebApplication1/Pages/_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "/home/kvitajin/RiderProjects/vsb/DAIS/WebApplication1/WebApplication1/Pages/makeDocument.cshtml"
using WebApplication1.App_Data;

#line default
#line hidden
#line 3 "/home/kvitajin/RiderProjects/vsb/DAIS/WebApplication1/WebApplication1/Pages/makeDocument.cshtml"
using WebApplication1.App_Data.proxy_shet;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"340fe81703dd21361dc54fbe2dc02be9de245d76", @"/Pages/makeDocument.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"668cc64a084232eafef8610da2704d38f65e7f86", @"/Pages/_ViewImports.cshtml")]
    public class Pages_makeDocument : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(123, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 6 "/home/kvitajin/RiderProjects/vsb/DAIS/WebApplication1/WebApplication1/Pages/makeDocument.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(148, 25, true);
            WriteLiteral("\n<!DOCTYPE html>\n\n<html>\n");
            EndContext();
            BeginContext(173, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0050078e345437fb760849972ab0702", async() => {
                BeginContext(179, 64, true);
                WriteLiteral("\n    <title>Pokud toto vidíš, máš krutě pomalý internet</title>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(250, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(251, 419, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c74197f6af0847369db449cba092c539", async() => {
                BeginContext(257, 7, true);
                WriteLiteral("\n<div>\n");
                EndContext();
#line 18 "/home/kvitajin/RiderProjects/vsb/DAIS/WebApplication1/WebApplication1/Pages/makeDocument.cshtml"
      
        Dokument tmp= new Dokument();
        tmp.Nadpis = Request.Form["nadpis"];
        tmp.RubrikaId = Convert.ToInt32(Request.Form["rubrikaId"]);
        var obsah = Request.Form["text"];
        var obecId = Request.Form["obecId"];
        tmp.Obrazek = "";
        tmp.Obsah = obsah;
        DokumentTableProxy.Insert(tmp);
        Response.Redirect("/Index");

        
    

#line default
#line hidden
                BeginContext(655, 8, true);
                WriteLiteral("\n</div>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(670, 8, true);
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Pages.makeDocument> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication1.Pages.makeDocument> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication1.Pages.makeDocument>)PageContext?.ViewData;
        public WebApplication1.Pages.makeDocument Model => ViewData.Model;
    }
}
#pragma warning restore 1591

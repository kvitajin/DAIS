#pragma checksum "/home/kvitajin/RiderProjects/WebApplication1/WebApplication1/Pages/makeRegister.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f29902659157bb8aa3a8fa9b022e55253f82752"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApplication1.Pages.Pages_makeRegister), @"mvc.1.0.razor-page", @"/Pages/makeRegister.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/makeRegister.cshtml", typeof(WebApplication1.Pages.Pages_makeRegister), null)]
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
#line 1 "/home/kvitajin/RiderProjects/WebApplication1/WebApplication1/Pages/_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "/home/kvitajin/RiderProjects/WebApplication1/WebApplication1/Pages/makeRegister.cshtml"
using WebApplication1.App_Data;

#line default
#line hidden
#line 3 "/home/kvitajin/RiderProjects/WebApplication1/WebApplication1/Pages/makeRegister.cshtml"
using WebApplication1.App_Data.proxy_shet;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f29902659157bb8aa3a8fa9b022e55253f82752", @"/Pages/makeRegister.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"668cc64a084232eafef8610da2704d38f65e7f86", @"/Pages/_ViewImports.cshtml")]
    public class Pages_makeRegister : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 6 "/home/kvitajin/RiderProjects/WebApplication1/WebApplication1/Pages/makeRegister.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(148, 25, true);
            WriteLiteral("\n<!DOCTYPE html>\n\n<html>\n");
            EndContext();
            BeginContext(173, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a5fd3ed274d428799f571d7169dc8c9", async() => {
                BeginContext(179, 21, true);
                WriteLiteral("\n    <title></title>\n");
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
            BeginContext(207, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(208, 752, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97f5b3a9100c49b1958b3a95b587ae7f", async() => {
                BeginContext(214, 7, true);
                WriteLiteral("\n<div>\n");
                EndContext();
#line 18 "/home/kvitajin/RiderProjects/WebApplication1/WebApplication1/Pages/makeRegister.cshtml"
      
        Uzivatel tmp = new Uzivatel();
        var jmeno = Request.Form["jmeno"];
        var heslo = Request.Form["heslo"];
        var hesloZnova = Request.Form["hesloZnova"];
        var email = Request.Form["email"];
        var datumNarozeni = Convert.ToDateTime(Request.Form["datumNarozeni"]);
        var obecId = Convert.ToInt32(Request.Form["obecId"]);
        tmp.Nick = jmeno;
        tmp.Heslo = heslo;
        tmp.Email = email;
        tmp.DatumNarozeni = datumNarozeni;
        tmp.ObecId = obecId;
//        Console.WriteLine("shit"+tmp.Nick+ " " +tmp.Email+" " +tmp.Heslo+" " +tmp.ObecId+" " +tmp.DatumNarozeni);
        UzivatelTableProxy.Insert(tmp);
        Response.Redirect("/Index");
    

#line default
#line hidden
                BeginContext(941, 12, true);
                WriteLiteral("    \n</div>\n");
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
            BeginContext(960, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Pages.makeRegister> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication1.Pages.makeRegister> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication1.Pages.makeRegister>)PageContext?.ViewData;
        public WebApplication1.Pages.makeRegister Model => ViewData.Model;
    }
}
#pragma warning restore 1591

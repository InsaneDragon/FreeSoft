#pragma checksum "C:\Users\C#Developer\source\repos\FreeSoft\FreeSoft\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09a6c29730b07e73726a0f7fe0de53de6bbdb79a"
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
#line 1 "C:\Users\C#Developer\source\repos\FreeSoft\FreeSoft\Views\_ViewImports.cshtml"
using FreeSoft;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\C#Developer\source\repos\FreeSoft\FreeSoft\Views\_ViewImports.cshtml"
using FreeSoft.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09a6c29730b07e73726a0f7fe0de53de6bbdb79a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b84830e3275fdc53c31136fde8cfa7286970c96d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Soft>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\C#Developer\source\repos\FreeSoft\FreeSoft\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "FreeSoft";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09a6c29730b07e73726a0f7fe0de53de6bbdb79a3364", async() => {
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09a6c29730b07e73726a0f7fe0de53de6bbdb79a4330", async() => {
                WriteLiteral("\r\n    <div id=\"SoftList\"");
                BeginWriteAttribute("style", "style=\"", 110, "\"", 117, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 9 "C:\Users\C#Developer\source\repos\FreeSoft\FreeSoft\Views\Home\Index.cshtml"
         for (int i=0;i<Model.Count;i++)
        {
            string CatPic = "\\Icons\\"+ViewBag.Cats[i].PictureUrl;
            string SoftPic = "\\Images\\" + Model[i].PictureLink;

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"Soft shadow\"");
                BeginWriteAttribute("style", " style=\"", 342, "\"", 350, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 351, "\"", 368, 1);
#nullable restore
#line 13 "C:\Users\C#Developer\source\repos\FreeSoft\FreeSoft\Views\Home\Index.cshtml"
WriteAttributeValue("", 356, Model[i].ID, 356, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <img class=\"SoftImg\"");
                BeginWriteAttribute("src", " src=\"", 404, "\"", 418, 1);
#nullable restore
#line 14 "C:\Users\C#Developer\source\repos\FreeSoft\FreeSoft\Views\Home\Index.cshtml"
WriteAttributeValue("", 410, SoftPic, 410, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            <div style=\"float:right;width:48%\">\r\n                <div style=\"display:inline-block\"><a");
                BeginWriteAttribute("href", " href=\"", 525, "\"", 578, 2);
                WriteAttributeValue("", 532, "/MoreAboutSoft/Index?id=", 532, 24, true);
#nullable restore
#line 16 "C:\Users\C#Developer\source\repos\FreeSoft\FreeSoft\Views\Home\Index.cshtml"
WriteAttributeValue("", 556, Model[i].SoftIdentity, 556, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("class=\"SoftName\">");
#nullable restore
#line 16 "C:\Users\C#Developer\source\repos\FreeSoft\FreeSoft\Views\Home\Index.cshtml"
                                                                                                                      Write(Model[i].Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></div>\r\n                <div style=\"margin-top:10px\">\r\n                    <img style=\"width:50px\"");
                BeginWriteAttribute("src", " src=\"", 712, "\"", 725, 1);
#nullable restore
#line 18 "C:\Users\C#Developer\source\repos\FreeSoft\FreeSoft\Views\Home\Index.cshtml"
WriteAttributeValue("", 718, CatPic, 718, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/><label class=\"CatName instagram-gradient\">");
#nullable restore
#line 18 "C:\Users\C#Developer\source\repos\FreeSoft\FreeSoft\Views\Home\Index.cshtml"
                                                                                                Write(ViewBag.Cats[i].Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    <label style=\"font-size:16px\" class=\"CatName\">");
#nullable restore
#line 19 "C:\Users\C#Developer\source\repos\FreeSoft\FreeSoft\Views\Home\Index.cshtml"
                                                             Write(Model[i].Date);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                </div>\r\n                <label style=\"margin-top: 30px;font-size:17px;font-weight:bold\">");
#nullable restore
#line 21 "C:\Users\C#Developer\source\repos\FreeSoft\FreeSoft\Views\Home\Index.cshtml"
                                                                           Write(Model[i].Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 24 "C:\Users\C#Developer\source\repos\FreeSoft\FreeSoft\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Soft>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\C#Developer\source\repos\FreeSoft\FreeSoft\Views\MoreAboutSoft\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfe909285b0119c23957c506f2639d2e1eb092e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MoreAboutSoft_Index), @"mvc.1.0.view", @"/Views/MoreAboutSoft/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfe909285b0119c23957c506f2639d2e1eb092e4", @"/Views/MoreAboutSoft/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b84830e3275fdc53c31136fde8cfa7286970c96d", @"/Views/_ViewImports.cshtml")]
    public class Views_MoreAboutSoft_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Soft>
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
#line 2 "C:\Users\C#Developer\source\repos\FreeSoft\FreeSoft\Views\MoreAboutSoft\Index.cshtml"
  
    ViewData["Title"] = "MoreAboutSoft";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfe909285b0119c23957c506f2639d2e1eb092e43417", async() => {
                WriteLiteral("\r\n\r\n");
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
#nullable restore
#line 8 "C:\Users\C#Developer\source\repos\FreeSoft\FreeSoft\Views\MoreAboutSoft\Index.cshtml"
  string SoftPic = "\\Images\\" + Model.PictureLink;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfe909285b0119c23957c506f2639d2e1eb092e44606", async() => {
                WriteLiteral(@"
    <script>
        function DeleteAlert() {
            $('#snackbar').css({ 'visibility': 'hidden' })
        }
        function Comment()
        {
            let text = $('#CommentText').val();
            debugger;
            if (text) {
            $.post(""/MoreAboutSoft/Comment"", { Text: text, id:""");
#nullable restore
#line 20 "C:\Users\C#Developer\source\repos\FreeSoft\FreeSoft\Views\MoreAboutSoft\Index.cshtml"
                                                          Write(Model.SoftIdentity);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"})\r\n                .done(function () {\r\n                    let date = ");
#nullable restore
#line 22 "C:\Users\C#Developer\source\repos\FreeSoft\FreeSoft\Views\MoreAboutSoft\Index.cshtml"
                          Write(DateTime.Now.Day.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral(" + \"/\" + ");
#nullable restore
#line 22 "C:\Users\C#Developer\source\repos\FreeSoft\FreeSoft\Views\MoreAboutSoft\Index.cshtml"
                                                               Write(DateTime.Now.Month.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral(" + \"/\" + ");
#nullable restore
#line 22 "C:\Users\C#Developer\source\repos\FreeSoft\FreeSoft\Views\MoreAboutSoft\Index.cshtml"
                                                                                                      Write(DateTime.Now.Year.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
                    $('#CommentList').append(`<div style=""margin-top: 20px; margin-left: 20px;"">
                    <img style=""float:left;border:1px solid gray;border-radius:50%;margin-right:15px"" src=""/Icons/security.png"" />
                    <label style=""font-weight:500;font-size:13px"">${text}</label>  
                    <label style=""width:100%;margin-left:35px;font-size:14px"">${date}</label>
                </div><hr/>`);
                    $('#CommentText').val('');
                })
            }
            else {
                $('#snackbar').html(""Комментарий не может быть пустым"");
                $('#snackbar').css({ 'visibility': 'visible', 'background-color': 'red' });
                setTimeout(DeleteAlert, 4000);
            }
        }
    </script>
    <div style=""width:77%"">
        <img style=""width:100%""");
                BeginWriteAttribute("src", " src=\"", 1525, "\"", 1539, 1);
#nullable restore
#line 39 "C:\Users\C#Developer\source\repos\FreeSoft\FreeSoft\Views\MoreAboutSoft\Index.cshtml"
WriteAttributeValue("", 1531, SoftPic, 1531, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <div class=\"UnderPicture\">\r\n            <a class=\"btn btn-light\" href=\"#desc\">Описание</a>\r\n            <a class=\"btn btn-light\" href=\"#Comments\">Комментарии</a>\r\n");
#nullable restore
#line 43 "C:\Users\C#Developer\source\repos\FreeSoft\FreeSoft\Views\MoreAboutSoft\Index.cshtml"
             if (Model.YoutubeLink != null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <a class=\"btn\"style=\"background-color:#ff0000;color:white\"");
                BeginWriteAttribute("href", " href=\"", 1850, "\"", 1875, 1);
#nullable restore
#line 45 "C:\Users\C#Developer\source\repos\FreeSoft\FreeSoft\Views\MoreAboutSoft\Index.cshtml"
WriteAttributeValue("", 1857, Model.YoutubeLink, 1857, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">YouTube</a>\r\n");
#nullable restore
#line 46 "C:\Users\C#Developer\source\repos\FreeSoft\FreeSoft\Views\MoreAboutSoft\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <a class=\"btn btn-success\"");
                BeginWriteAttribute("href", " href=\"", 1943, "\"", 2002, 2);
                WriteAttributeValue("", 1950, "/MoreAboutSoft/DownloadFile?FileName=", 1950, 37, true);
#nullable restore
#line 47 "C:\Users\C#Developer\source\repos\FreeSoft\FreeSoft\Views\MoreAboutSoft\Index.cshtml"
WriteAttributeValue("", 1987, Model.FileName, 1987, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Скачать</a>\r\n        </div>\r\n        <h4 id=\"desc\" style=\"text-align:center;margin-bottom:10px;\">Описание</h4>\r\n        <label style=\"font-size:17px;font-weight:bold\">");
#nullable restore
#line 50 "C:\Users\C#Developer\source\repos\FreeSoft\FreeSoft\Views\MoreAboutSoft\Index.cshtml"
                                                  Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
        <div id=""Comments"" class=""Comments"">
            <div style=""height:35px;"" class=""bg-primary""></div>
            <input  id=""CommentText"" placeholder=""Ваш Комментарий..."" />
            <button style=""float:right"" onclick=""Comment()"" class=""btn btn-primary"">Отправить</button>
            <div id=""CommentList"">
");
#nullable restore
#line 56 "C:\Users\C#Developer\source\repos\FreeSoft\FreeSoft\Views\MoreAboutSoft\Index.cshtml"
                 foreach (var item in ViewBag.Comments as List<Comment>)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <div style=""margin-top:20px;margin-left:20px;"">
                        <img style=""float:left;border:1px solid gray;border-radius:50%;margin-right:15px"" src=""/Icons/security.png"" />
                        <label style=""font-weight:500;font-size:13px"">");
#nullable restore
#line 60 "C:\Users\C#Developer\source\repos\FreeSoft\FreeSoft\Views\MoreAboutSoft\Index.cshtml"
                                                                 Write(item.Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                        <label style=\"width:100%;margin-left:35px;font-size:14px;\">");
#nullable restore
#line 61 "C:\Users\C#Developer\source\repos\FreeSoft\FreeSoft\Views\MoreAboutSoft\Index.cshtml"
                                                                              Write(item.Date);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    </div><hr style=\"margin:0\" />\r\n");
#nullable restore
#line 63 "C:\Users\C#Developer\source\repos\FreeSoft\FreeSoft\Views\MoreAboutSoft\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n    <div id=\"snackbar\">\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Soft> Html { get; private set; }
    }
}
#pragma warning restore 1591
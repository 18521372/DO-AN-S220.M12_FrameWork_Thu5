#pragma checksum "C:\Users\Administrator\Source\Repos\DO-AN-S220.M12_FrameWork_Thu5\qltx\qltx\Views\Home\quanlythuexe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "339beecd85ebb783709335d53511fad6b98d1e7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_quanlythuexe), @"mvc.1.0.view", @"/Views/Home/quanlythuexe.cshtml")]
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
#line 1 "C:\Users\Administrator\Source\Repos\DO-AN-S220.M12_FrameWork_Thu5\qltx\qltx\Views\_ViewImports.cshtml"
using qltx;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Source\Repos\DO-AN-S220.M12_FrameWork_Thu5\qltx\qltx\Views\_ViewImports.cshtml"
using qltx.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"339beecd85ebb783709335d53511fad6b98d1e7e", @"/Views/Home/quanlythuexe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"386ad46c9643ec5eee85a6f7a8289bb92e7d037e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_quanlythuexe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Timthuexe"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Administrator\Source\Repos\DO-AN-S220.M12_FrameWork_Thu5\qltx\qltx\Views\Home\quanlythuexe.cshtml"
  

    Layout = "~/Views/Shared/_Layout2.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n        <script>\r\n            $(function () {\r\n                $(\'#AlertBox\').removeClass(\'hide\');\r\n                $(\'#AlertBox\').delay(2000).slideUp(500);\r\n            });\r\n\r\n        </script>\r\n    ");
            }
            );
#nullable restore
#line 14 "C:\Users\Administrator\Source\Repos\DO-AN-S220.M12_FrameWork_Thu5\qltx\qltx\Views\Home\quanlythuexe.cshtml"
     
    
    if (TempData["AlertMessage"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div id=\"AlertBox\"");
            BeginWriteAttribute("class", " class=\"", 369, "\"", 410, 3);
            WriteAttributeValue("", 377, "alert", 377, 5, true);
#nullable restore
#line 18 "C:\Users\Administrator\Source\Repos\DO-AN-S220.M12_FrameWork_Thu5\qltx\qltx\Views\Home\quanlythuexe.cshtml"
WriteAttributeValue(" ", 382, TempData["AlertType"], 383, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 405, "hide", 406, 5, true);
            EndWriteAttribute();
            WriteLiteral(" role=\"alert\" style=\"text-align:center;\">\r\n            ");
#nullable restore
#line 19 "C:\Users\Administrator\Source\Repos\DO-AN-S220.M12_FrameWork_Thu5\qltx\qltx\Views\Home\quanlythuexe.cshtml"
       Write(TempData["AlertMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 21 "C:\Users\Administrator\Source\Repos\DO-AN-S220.M12_FrameWork_Thu5\qltx\qltx\Views\Home\quanlythuexe.cshtml"
    }
    var i = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <html lang=\"en\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "339beecd85ebb783709335d53511fad6b98d1e7e6228", async() => {
                WriteLiteral(@"
        <title>Bootstrap Example</title>
        <meta charset=""utf-8"">
        <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
        <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.2/dist/css/bootstrap.min.css"" rel=""stylesheet"">
        <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.2/dist/js/bootstrap.bundle.min.js""></script>
    ");
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "339beecd85ebb783709335d53511fad6b98d1e7e7587", async() => {
                WriteLiteral("\r\n        <div class=\"container mt-3\" style=\"color:white;\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "339beecd85ebb783709335d53511fad6b98d1e7e7922", async() => {
                    WriteLiteral(@"
                <div class=""row"">
                    <div class=""col"">
                        <input type=""text"" class=""form-control"" name=""id_tim"" placeholder=""Nhập id"">
                    </div>
                    <div class=""col"">
                        <input type=""Submit"" name=""Submit"" class=""btn btn-primary"" value=""Tìm"">
                    </div>
                </div>
            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "339beecd85ebb783709335d53511fad6b98d1e7e9949", async() => {
                    WriteLiteral(@"
                <div class=""row"">                   
                    <div class=""row"">
                        <div class=""col table-wrapper-scroll-y my-custom-scrollbar"" style=""height: 50px ;overflow-y: scroll;overflow-x:hidden; min-height: 450px; "">
                            <table class=""table "">
                                <thead>
                                    <tr>
                                        <th>No</th>
                                        <th>id </th>
                                        <th>Mã xe</th>
                                        <th>Mã người thuê</th>
                                        <th>Số điện thoại</th>
                                        <th>Email</th>
                                        <th>Ngày bắt đầu</th>
                                        <th>Ngày kết thúc</th>
                                        <th>Trạng thái</th>
                                        <th>Tổng tiền</th>
                                 ");
                    WriteLiteral("       <th>Thanh toán</th>\r\n                                        <th></th>\r\n                                    </tr>\r\n                                </thead>\r\n                                <tbody>\r\n");
#nullable restore
#line 65 "C:\Users\Administrator\Source\Repos\DO-AN-S220.M12_FrameWork_Thu5\qltx\qltx\Views\Home\quanlythuexe.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 68 "C:\Users\Administrator\Source\Repos\DO-AN-S220.M12_FrameWork_Thu5\qltx\qltx\Views\Home\quanlythuexe.cshtml"
                                       Write(i);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 69 "C:\Users\Administrator\Source\Repos\DO-AN-S220.M12_FrameWork_Thu5\qltx\qltx\Views\Home\quanlythuexe.cshtml"
                                       Write(item.id);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 70 "C:\Users\Administrator\Source\Repos\DO-AN-S220.M12_FrameWork_Thu5\qltx\qltx\Views\Home\quanlythuexe.cshtml"
                                       Write(item.xe_id);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 71 "C:\Users\Administrator\Source\Repos\DO-AN-S220.M12_FrameWork_Thu5\qltx\qltx\Views\Home\quanlythuexe.cshtml"
                                       Write(item.nsd_id);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 72 "C:\Users\Administrator\Source\Repos\DO-AN-S220.M12_FrameWork_Thu5\qltx\qltx\Views\Home\quanlythuexe.cshtml"
                                       Write(item.sodienthoai);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 73 "C:\Users\Administrator\Source\Repos\DO-AN-S220.M12_FrameWork_Thu5\qltx\qltx\Views\Home\quanlythuexe.cshtml"
                                       Write(item.email);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 74 "C:\Users\Administrator\Source\Repos\DO-AN-S220.M12_FrameWork_Thu5\qltx\qltx\Views\Home\quanlythuexe.cshtml"
                                       Write(item.batdau);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 75 "C:\Users\Administrator\Source\Repos\DO-AN-S220.M12_FrameWork_Thu5\qltx\qltx\Views\Home\quanlythuexe.cshtml"
                                       Write(item.ketthuc);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 76 "C:\Users\Administrator\Source\Repos\DO-AN-S220.M12_FrameWork_Thu5\qltx\qltx\Views\Home\quanlythuexe.cshtml"
                                       Write(item.trangthai);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 77 "C:\Users\Administrator\Source\Repos\DO-AN-S220.M12_FrameWork_Thu5\qltx\qltx\Views\Home\quanlythuexe.cshtml"
                                       Write(item.tongtien);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 78 "C:\Users\Administrator\Source\Repos\DO-AN-S220.M12_FrameWork_Thu5\qltx\qltx\Views\Home\quanlythuexe.cshtml"
                                       Write(item.thanhtoan);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                        <td><a");
                    BeginWriteAttribute("href", " href=\"", 3621, "\"", 3652, 2);
                    WriteAttributeValue("", 3628, "Suanguoidung?Id=", 3628, 16, true);
#nullable restore
#line 79 "C:\Users\Administrator\Source\Repos\DO-AN-S220.M12_FrameWork_Thu5\qltx\qltx\Views\Home\quanlythuexe.cshtml"
WriteAttributeValue("", 3644, item.id, 3644, 8, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" class=\"btn btn-primary\">Sửa</a></td>\r\n                                    </tr>\r\n");
#nullable restore
#line 81 "C:\Users\Administrator\Source\Repos\DO-AN-S220.M12_FrameWork_Thu5\qltx\qltx\Views\Home\quanlythuexe.cshtml"
                                        i++;
                                    }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                    </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n    ");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

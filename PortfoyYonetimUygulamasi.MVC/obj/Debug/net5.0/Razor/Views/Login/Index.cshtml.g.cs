#pragma checksum "C:\Users\hakan\source\repos\PortfoyYonetimUygulamasi\PortfoyYonetimUygulamasi.MVC\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4b593a6a9422ed45b47cdd230052db6e504a970"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4b593a6a9422ed45b47cdd230052db6e504a970", @"/Views/Login/Index.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/bootstrap/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/userlogin.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a4b593a6a9422ed45b47cdd230052db6e504a9703648", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a4b593a6a9422ed45b47cdd230052db6e504a9704763", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">

<div class=""container"">
    <div class=""row justify-content-center"">
        <div class=""col-lg-5"">
            <div class=""card shadow-lg border-0 rounded-lg mt-5"">
                <div class=""card-header""><h3 class=""text-center font-weight-light my-4""><span class=""fas fa-house-user""></span> Giriş Yap</h3></div>
                <div class=""card-body"">
                    <form asp-controller=""Login"" asp-action=""Login"" method=""post"">
                        <div asp-validation-summary=""All"" class=""text-danger""></div>
                        <div class=""form-group"">
                            <label class=""small mb-1"" asp-for=""Email"">E-Posta Adresi</label>
                            <input class=""form-control py-4"" asp-for=""Email"" type=""email"" placeholder=""Lütfen e-posta adresinizi giriniz."" />
                            <span asp-validation-for=""Email"" class=""text-danger""></span");
            WriteLiteral(@">
                        </div>
                        <div class=""form-group"">
                            <label class=""small mb-1"" asp-for=""Password"">Şifre</label>
                            <input class=""form-control py-4"" asp-for=""Password"" type=""password"" placeholder=""Lütfen şifrenizi giriniz."" />
                            <span asp-validation-for=""Password"" class=""text-danger""></span>
                        </div>
                        <div class=""form-group"">
                            <div class=""custom-control custom-checkbox"">
                                <input class=""custom-control-input"" asp-for=""RememberMe"" type=""checkbox"" />
                                <label class=""custom-control-label"" asp-for=""RememberMe"">Beni Hatırla</label>
                            </div>
                        </div>
                        <div class=""form-group d-flex align-items-center justify-content-between mt-4 mb-0"">
                            <a class=""btn btn-secondary text-whi");
            WriteLiteral("te\"><span class=\"fas fa-user-lock\"></span> Şifremi Unuttum</a>\r\n                            <button class=\"btn btn-primary\" type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2315, "\"", 2373, 3);
            WriteAttributeValue("", 2325, "location.href=\'", 2325, 15, true);
#nullable restore
#line 31 "C:\Users\hakan\source\repos\PortfoyYonetimUygulamasi\PortfoyYonetimUygulamasi.MVC\Views\Login\Index.cshtml"
WriteAttributeValue("", 2340, Url.Action("Index", "UserPage"), 2340, 32, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2372, "\'", 2372, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" /><span class=""fas fa-sign-in-alt""></span> Giriş Yap</button>
                        </div>
                    </form>
                </div>
                <div class=""card-footer text-center"">
                    <button class=""btn btn-primary"" type=""button""");
            BeginWriteAttribute("onclick", " onclick=\"", 2643, "\"", 2701, 3);
            WriteAttributeValue("", 2653, "location.href=\'", 2653, 15, true);
#nullable restore
#line 36 "C:\Users\hakan\source\repos\PortfoyYonetimUygulamasi\PortfoyYonetimUygulamasi.MVC\Views\Login\Index.cshtml"
WriteAttributeValue("", 2668, Url.Action("Register", "Login"), 2668, 32, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2700, "\'", 2700, 1, true);
            EndWriteAttribute();
            WriteLiteral(" /><span class=\"fas fa-sign-in-alt\"></span> Kayıt Ol</button>\r\n");
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
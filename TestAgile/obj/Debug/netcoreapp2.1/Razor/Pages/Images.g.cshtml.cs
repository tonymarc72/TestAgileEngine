#pragma checksum "C:\Proyectos\AgileEngine\Test\TestAgileEngine\TestAgile\Pages\Images.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d53ad1fd78dc6054d7bfda9eee73cf3a96c25391"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TestAgile.Pages.Pages_Images), @"mvc.1.0.razor-page", @"/Pages/Images.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Images.cshtml", typeof(TestAgile.Pages.Pages_Images), null)]
namespace TestAgile.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Proyectos\AgileEngine\Test\TestAgileEngine\TestAgile\Pages\_ViewImports.cshtml"
using TestAgile;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d53ad1fd78dc6054d7bfda9eee73cf3a96c25391", @"/Pages/Images.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2f1c3d74ccdab8987bc375811cc5cb09455f70f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Images : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Proyectos\AgileEngine\Test\TestAgileEngine\TestAgile\Pages\Images.cshtml"
  
    ViewData["Title"] = "Image Gallery";


#line default
#line hidden
            BeginContext(78, 299, true);
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-md-6"">
            <h2>Images</h2>
        </div>
        <div class=""col-md-6"" style=""float:right"">

            <div class=""row"" style=""margin-top: 25px;"">
                <div class=""col-md-12"">
                    ");
            EndContext();
            BeginContext(377, 481, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d524a6566754386a2425873f458648f", async() => {
                BeginContext(423, 428, true);
                WriteLiteral(@"
                        <div class=""col-md-9"" style=""text-align:right;padding-right: 0px;"">
                            <input type=""text"" name=""searchtext"" class=""form-control"" />
                        </div>
                        <div class=""col-md-3"" style=""padding-left: 2px;"">
                            <button class=""btn btn-success btn-sm"">Search</button>
                        </div>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(858, 197, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<hr />\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12 col-md-12 col-sm-12\">\r\n");
            EndContext();
#line 37 "C:\Proyectos\AgileEngine\Test\TestAgileEngine\TestAgile\Pages\Images.cshtml"
             if (Model.ImgList != null)
            {
                foreach (var imgModel in Model.ImgList)
                {

#line default
#line hidden
            BeginContext(1187, 153, true);
            WriteLiteral("                    <div class=\"col-lg-2  col-md-3 col-sm-4\" style=\"margin-bottom:10px\">\r\n                        <img style=\"width:150px; height:150px;\"");
            EndContext();
            BeginWriteAttribute("src", " src=", 1340, "", 1370, 1);
#line 42 "C:\Proyectos\AgileEngine\Test\TestAgileEngine\TestAgile\Pages\Images.cshtml"
WriteAttributeValue("", 1345, imgModel.Cropped_picture, 1345, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1370, 66, true);
            WriteLiteral(" />\r\n\r\n                        <div>\r\n                            ");
            EndContext();
            BeginContext(1437, 15, false);
#line 45 "C:\Proyectos\AgileEngine\Test\TestAgileEngine\TestAgile\Pages\Images.cshtml"
                       Write(imgModel.Author);

#line default
#line hidden
            EndContext();
            BeginContext(1452, 62, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 48 "C:\Proyectos\AgileEngine\Test\TestAgileEngine\TestAgile\Pages\Images.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(1548, 58, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n<hr />\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ImagesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ImagesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ImagesModel>)PageContext?.ViewData;
        public ImagesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

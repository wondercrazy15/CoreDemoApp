#pragma checksum "F:\Project\DemoApp\Bhavesh\DemoApp\CoreDemoApp\DemoApp.Web\Views\UserAlbum\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e44974baa7c0423c6520eb2653c95bb28b36a668"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserAlbum_Index), @"mvc.1.0.view", @"/Views/UserAlbum/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserAlbum/Index.cshtml", typeof(AspNetCore.Views_UserAlbum_Index))]
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
#line 1 "F:\Project\DemoApp\Bhavesh\DemoApp\CoreDemoApp\DemoApp.Web\Views\_ViewImports.cshtml"
using DemoApp.Web;

#line default
#line hidden
#line 2 "F:\Project\DemoApp\Bhavesh\DemoApp\CoreDemoApp\DemoApp.Web\Views\_ViewImports.cshtml"
using DemoApp.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e44974baa7c0423c6520eb2653c95bb28b36a668", @"/Views/UserAlbum/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3207b0b531e43e00e9f835bfdb957a8769f20f7", @"/Views/_ViewImports.cshtml")]
    public class Views_UserAlbum_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DemoApp.Model.UserInfoModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\Project\DemoApp\Bhavesh\DemoApp\CoreDemoApp\DemoApp.Web\Views\UserAlbum\Index.cshtml"
  
    ViewData["Title"] = "GetUserInfo";

#line default
#line hidden
            BeginContext(89, 385, true);
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">User Information</h1>

</div>

<div class=""container"">
    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th>Name</th>
                <th>Email</th>
                <th>Total Album</th>
                <th>Total Photo</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 22 "F:\Project\DemoApp\Bhavesh\DemoApp\CoreDemoApp\DemoApp.Web\Views\UserAlbum\Index.cshtml"
             if (Model != null)
            {
                foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(586, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(641, 9, false);
#line 27 "F:\Project\DemoApp\Bhavesh\DemoApp\CoreDemoApp\DemoApp.Web\Views\UserAlbum\Index.cshtml"
                       Write(item.name);

#line default
#line hidden
            EndContext();
            BeginContext(650, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(686, 10, false);
#line 28 "F:\Project\DemoApp\Bhavesh\DemoApp\CoreDemoApp\DemoApp.Web\Views\UserAlbum\Index.cshtml"
                       Write(item.email);

#line default
#line hidden
            EndContext();
            BeginContext(696, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(732, 28, false);
#line 29 "F:\Project\DemoApp\Bhavesh\DemoApp\CoreDemoApp\DemoApp.Web\Views\UserAlbum\Index.cshtml"
                       Write(item.userAlbumModels.Count());

#line default
#line hidden
            EndContext();
            BeginContext(760, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(796, 33, false);
#line 30 "F:\Project\DemoApp\Bhavesh\DemoApp\CoreDemoApp\DemoApp.Web\Views\UserAlbum\Index.cshtml"
                       Write(item.userAlbumPhotoModels.Count());

#line default
#line hidden
            EndContext();
            BeginContext(829, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 32 "F:\Project\DemoApp\Bhavesh\DemoApp\CoreDemoApp\DemoApp.Web\Views\UserAlbum\Index.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(897, 42, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DemoApp.Model.UserInfoModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

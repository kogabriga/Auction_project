#pragma checksum "C:\Users\Nikola\Desktop\IepProjekat\Views\Administrator\UnbanUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9758548fa819a0a2256423c28667814c9572518"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrator_UnbanUser), @"mvc.1.0.view", @"/Views/Administrator/UnbanUser.cshtml")]
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
#line 1 "C:\Users\Nikola\Desktop\IepProjekat\Views\_ViewImports.cshtml"
using IepProjekat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nikola\Desktop\IepProjekat\Views\_ViewImports.cshtml"
using IepProjekat.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9758548fa819a0a2256423c28667814c9572518", @"/Views/Administrator/UnbanUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f853ca594baa1dcb4d1122ade114ed67f4edfaf", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrator_UnbanUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IepProjekat.Models.Database.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class = \"car text-white bg-danger mb-3\">\r\n    <div class = \"card-header\">\r\n        User Id : ");
#nullable restore
#line 5 "C:\Users\Nikola\Desktop\IepProjekat\Views\Administrator\UnbanUser.cshtml"
             Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class = \"card-body\">\r\n        <h5 class = \"card-title\">");
#nullable restore
#line 8 "C:\Users\Nikola\Desktop\IepProjekat\Views\Administrator\UnbanUser.cshtml"
                            Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 8 "C:\Users\Nikola\Desktop\IepProjekat\Views\Administrator\UnbanUser.cshtml"
                                             Write(Model.firstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 8 "C:\Users\Nikola\Desktop\IepProjekat\Views\Administrator\UnbanUser.cshtml"
                                                               Write(Model.lastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 8 "C:\Users\Nikola\Desktop\IepProjekat\Views\Administrator\UnbanUser.cshtml"
                                                                                Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h5>\r\n    </div>\r\n    <div class = \"card-footer\">\r\n        <button type=\"button\" class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 398, "\"", 436, 3);
            WriteAttributeValue("", 408, "unbanUser(\'", 408, 11, true);
#nullable restore
#line 11 "C:\Users\Nikola\Desktop\IepProjekat\Views\Administrator\UnbanUser.cshtml"
WriteAttributeValue("", 419, Model.UserName, 419, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 434, "\')", 434, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Unban</button>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IepProjekat.Models.Database.User> Html { get; private set; }
    }
}
#pragma warning restore 1591

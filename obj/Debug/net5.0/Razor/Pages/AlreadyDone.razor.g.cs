#pragma checksum "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\Pages\AlreadyDone.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a79ad6fc65f50fe663a8ec5a99185ea9891ac9b"
// <auto-generated/>
#pragma warning disable 1591
namespace CodeSubmissionClient.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\_Imports.razor"
using CodeSubmissionClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\_Imports.razor"
using CodeSubmissionClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\_Imports.razor"
using CodeSubmissionClient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\_Imports.razor"
using CodeSubmissionClient.ClientTestEnv.Utils;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/alreadyDone")]
    public partial class AlreadyDone : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .done-content {\r\n        margin-top: 10%;\r\n        text-align: center;\r\n    }\r\n\r\n    svg {\r\n        width: 100px;\r\n        display: block;\r\n        margin: 40px auto 0;\r\n    }\r\n\r\n\r\n\r\n    .path {\r\n        stroke-dasharray: 1000;\r\n        stroke-dashoffset: 0;\r\n    }\r\n\r\n\r\n\r\n\r\n        .path.circle {\r\n            -webkit-animation: dash .9s ease-in-out;\r\n            animation: dash .9s ease-in-out;\r\n        }\r\n\r\n\r\n\r\n        .path.line {\r\n            stroke-dashoffset: 1000;\r\n            -webkit-animation: dash .9s .35s ease-in-out forwards;\r\n            animation: dash .9s .35s ease-in-out forwards;\r\n        }\r\n\r\n\r\n\r\n        .path.check {\r\n            stroke-dashoffset: -100;\r\n            -webkit-animation: dash-check .9s .35s ease-in-out forwards;\r\n            animation: dash-check .9s .35s ease-in-out forwards;\r\n        }\r\n\r\n\r\n\r\n    p {\r\n        text-align: center;\r\n        margin: 20px 0 60px;\r\n        font-size: 1.25em;\r\n    }\r\n\r\n\r\n\r\n\r\n    .error {\r\n        color: #D06079;\r\n    }\r\n\r\n\r\n\r\n    @-webkit-keyframes dash {\r\n        0% {\r\n            stroke-dashoffset: 1000;\r\n        }\r\n\r\n        100% {\r\n            stroke-dashoffset: 0;\r\n        }\r\n    }\r\n\r\n\r\n\r\n    @keyframes dash {\r\n        0% {\r\n            stroke-dashoffset: 1000;\r\n        }\r\n\r\n        100% {\r\n            stroke-dashoffset: 0;\r\n        }\r\n    }\r\n\r\n\r\n\r\n    @-webkit-keyframes dash-check {\r\n        0% {\r\n            stroke-dashoffset: -100;\r\n        }\r\n\r\n        100% {\r\n            stroke-dashoffset: 900;\r\n        }\r\n    }\r\n\r\n\r\n\r\n    @keyframes dash-check {\r\n        0% {\r\n            stroke-dashoffset: -100;\r\n        }\r\n\r\n        100% {\r\n            stroke-dashoffset: 900;\r\n        }\r\n    }\r\n</style>\r\n");
            __builder.AddMarkupContent(1, "<div class=\"done-content\"><h3>It seems you have already done this test!</h3>\r\n    <p>If that is not the case, contact your recruiter ASAP for help.</p></div>\r\n\r\n");
            __builder.AddMarkupContent(2, @"<svg version=""1.1"" xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 130.2 130.2""><circle class=""path circle"" fill=""none"" stroke=""#D06079"" stroke-width=""6"" stroke-miterlimit=""10"" cx=""65.1"" cy=""65.1"" r=""62.1""></circle>
    <line class=""path line"" fill=""none"" stroke=""#D06079"" stroke-width=""6"" stroke-linecap=""round"" stroke-miterlimit=""10"" x1=""34.4"" y1=""37.9"" x2=""95.8"" y2=""92.3""></line>
    <line class=""path line"" fill=""none"" stroke=""#D06079"" stroke-width=""6"" stroke-linecap=""round"" stroke-miterlimit=""10"" x1=""95.8"" y1=""38"" x2=""34.4"" y2=""92.2""></line></svg>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

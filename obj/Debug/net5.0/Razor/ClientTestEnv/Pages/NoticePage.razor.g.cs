#pragma checksum "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Pages\NoticePage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a7d6491795de37a04a64b4cc3475c8591f11fef"
// <auto-generated/>
#pragma warning disable 1591
namespace CodeSubmissionClient.ClientTestEnv.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/notice")]
    public partial class NoticePage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>@import url(\'https://fonts.googleapis.com/css2?family=Montserrat:wght@100;200;300;400;500;600;700;800;900&display=swap\');\r\n\r\n    * {\r\n        font-family: \'Montserrat\', sans-serif;\r\n        line-height: 22px;\r\n    }\r\n\r\n    .wrapper {\r\n        width: 100%;\r\n        height: 100vh;\r\n    }\r\n\r\n    /*NAV*/\r\n    .nav-container {\r\n        width: 100%;\r\n        height: 8vh;\r\n        display: flex;\r\n        align-items: center;\r\n        justify-content: space-between;\r\n        padding: 0px 2rem;\r\n        box-shadow: rgba(0, 0, 0, 0.2) 0px 12px 28px 0px, rgba(0, 0, 0, 0.1) 0px 2px 4px 0px, rgba(255, 255, 255, 0.05) 0px 0px 0px 1px inset;\r\n    }\r\n\r\n    .icon span {\r\n        font-weight: bold;\r\n    }\r\n\r\n\r\n    /*MAIN SECTION*/\r\n    .center-container {\r\n        width: 100%;\r\n        height: 86vh;\r\n        display: flex;\r\n        justify-content: center;\r\n        align-items: center;\r\n    }\r\n\r\n    .center-inner {\r\n        width: 80%;\r\n        height: 80%;\r\n        margin: auto;\r\n        max-width: 1000px;\r\n        max-height: 600px;\r\n        display: flex;\r\n        justify-content: center;\r\n        align-items: center;\r\n        background-color: #edf2fb;\r\n        border-radius: 5px;\r\n        box-shadow: rgba(0, 0, 0, 0.4) 0px 2px 4px, rgba(0, 0, 0, 0.3) 0px 7px 13px -3px, rgba(0, 0, 0, 0.2) 0px -3px 0px inset;\r\n        padding: 20px;\r\n    }\r\n\r\n    .content-wrapper {\r\n        display: flex;\r\n        justify-content: center;\r\n        align-items: center;\r\n        width: 90%;\r\n        max-width: 400px;\r\n        height: 90%;\r\n        max-height: 350px;\r\n        font-size: 13px;\r\n        padding: 20px;\r\n        background-color: #fff;\r\n        border-radius: 5px;\r\n        border: 1px solid #a8dadc;\r\n    }\r\n\r\n\r\n    /*FOOTER*/\r\n    .footer-container {\r\n        width: 100%;\r\n        height: 6vh;\r\n        display: flex;\r\n        align-items: center;\r\n        justify-content: flex-end;\r\n    }\r\n\r\n        .footer-container span {\r\n            font-size: 13px;\r\n            font-weight: bold;\r\n            margin-right: 2rem;\r\n        }\r\n\r\n    @media screen and (max-width: 500px) {\r\n        .content-wrapper {\r\n            overflow-y: scroll;\r\n        }\r\n    }\r\n\r\n    @media screen and (max-height: 550px) {\r\n        .content-wrapper {\r\n            overflow-y: scroll;\r\n        }\r\n    }\r\n\r\n    @media screen and (max-width: 240px) {\r\n        .wrapper {\r\n            display: none;\r\n        }\r\n    }\r\n\r\n    @media screen and (max-height: 300px) {\r\n        .wrapper {\r\n            display: none;\r\n        }\r\n    }\r\n</style>");
#nullable restore
#line 116 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Pages\NoticePage.razor"
 if (string.IsNullOrEmpty(username))
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "RegLogComponent");
            __builder.CloseElement();
#nullable restore
#line 119 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Pages\NoticePage.razor"
}
else
{
    if (State.Submissions.Count > 0 && !role.ToLower().Equals("candidate"))
    {
        NavigationManager.NavigateTo("/alreadyDone");
    }
    else
    {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "wrapper");
            __builder.AddMarkupContent(4, "<div class=\"nav-container\"><div class=\"icon\"><img src=\"images/launch.png\" alt=\"astro\"> &nbsp;\r\n                    <span>The Crossroads</span></div></div>\r\n\r\n            ");
            __builder.OpenElement(5, "UserAuthActionComponent");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "center-container");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "center-inner");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "content-wrapper");
            __builder.OpenElement(13, "div");
            __builder.AddMarkupContent(14, "<p>You are about to begin the test. Ensure you\'re in a quiet environment with no distractions.</p>\r\n                            ");
            __builder.AddMarkupContent(15, "<p>There\'s a total of six questions and no time limit. For the best experience, we suggest you use a laptop or a desktop computer.</p>\r\n                            ");
            __builder.AddMarkupContent(16, "<p>Read the questions carefully and save your answers in the space provided.</p>\r\n                            ");
            __builder.AddMarkupContent(17, "<p>You may begin when you\'re ready. Goodluck!</p>\r\n\r\n                            ");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "type", "button");
            __builder.AddAttribute(20, "class", "btn btn-outline-success btn-sm");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 160 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Pages\NoticePage.razor"
                                                                                                   Start

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(22, "Start");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n\r\n\r\n            ");
            __builder.AddMarkupContent(24, "<div class=\"footer-container\"><span>Nebula 2021 &reg;</span></div>");
            __builder.CloseElement();
#nullable restore
#line 181 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Pages\NoticePage.razor"

    }
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 186 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Pages\NoticePage.razor"
 
    /*AUTHORIZING USER*/
    string username = string.Empty;
    string role = string.Empty;

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        var userdata = await jsr.InvokeAsync<string>("localStorage.getItem", "user").ConfigureAwait(false);
        if (!string.IsNullOrWhiteSpace(userdata))
        {
            string[] userdetails = userdata.Split(';', 3);
            username = userdetails[0];
            role = userdetails[1].ToLower();
            State.Submissions = await client.GetFromJsonAsync<List<SubmissionSample>>($"https://codesubmissionapi.azurewebsites.net/api/submissionsample/email={username}");
        }
    }
    private async Task Start()
    {
        bool confirm = await jsr.InvokeAsync<bool>("confirm", "Are you sure?");
        if (confirm)
            NavigationManager.NavigateTo("/testenv");

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private State State { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Components\ViewSubmissionsComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94d8ceba155b012c255ae277e7ddda3ef01a13f2"
// <auto-generated/>
#pragma warning disable 1591
namespace CodeSubmissionClient.ClientTestEnv.Components
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
#nullable restore
#line 1 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Components\ViewSubmissionsComponent.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    public partial class ViewSubmissionsComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n  .center-inner {\r\n    width: 80%;\r\n    height: 80%;\r\n    margin: auto;\r\n    max-width: 1000px;\r\n    max-height: 600px;\r\n    display: flex;\r\n    justify-content: center;\r\n    align-items: center;\r\n    flex-direction: column;\r\n    background-color: #edf2fb;\r\n    border-radius: 5px;\r\n    box-shadow: rgba(0, 0, 0, 0.4) 0px 2px 4px, rgba(0, 0, 0, 0.3) 0px 7px 13px -3px, rgba(0, 0, 0, 0.2) 0px -3px 0px inset;\r\n    padding: 20px;\r\n    overflow-y: scroll;\r\n  }\r\n\r\n    .center-inner::-webkit-scrollbar {\r\n            width: 12px;\r\n        }\r\n\r\n        .center-inner::-webkit-scrollbar-track {\r\n            background-color: #EAF2F8;\r\n        }\r\n\r\n        .center-inner::-webkit-scrollbar-thumb {\r\n            background-color: #95A5A6;\r\n            border-radius: 20px;\r\n            border: 3px solid #EAF2F8;\r\n        }\r\n\r\n  .btn-admin-wrapper {\r\n    width: 100%;\r\n    display: flex;\r\n    justify-content: flex-end;\r\n    align-items: center;\r\n  }\r\n\r\n  .answer-modal {\r\n    position: absolute;\r\n    top: 0;\r\n    width: 100%;\r\n    height: 94vh;\r\n    z-index: 1;\r\n    transition: all 0.5s ease-in-out;\r\n    background-color: #2d2d2d;\r\n    color: #fff;\r\n    display: none;\r\n\r\n  }\r\n\r\n  .answer-modal-user {\r\n    height: 10%;\r\n    width: 100%;\r\n    display: flex;\r\n    justify-content: space-between;\r\n    align-items: center;\r\n    padding: 0 0.6rem;\r\n  }\r\n\r\n  .answer-modal-title {\r\n    height: 30%;\r\n    width: 100%;\r\n    display: flex;\r\n    justify-content: center;\r\n    align-items: center;\r\n  }\r\n\r\n  .answer-modal-container {\r\n    height: 60%;\r\n    width: 100%;\r\n    display: flex;\r\n    justify-content: center;\r\n    align-items: center;\r\n\r\n  }\r\n\r\n  .answer-modal-container-inner {\r\n\r\n    width: 90%;\r\n    height: 90%;\r\n    margin: auto;\r\n    color: #000;\r\n    max-width: 700px;\r\n    max-height: 500px;\r\n    padding: 0.6rem;\r\n    background-color: #fff;\r\n    border-radius: 5px;\r\n    overflow-y: scroll;\r\n    box-shadow: rgba(0, 0, 0, 0.4) 0px 2px 4px, rgba(0, 0, 0, 0.3) 0px 7px 13px -3px, rgba(0, 0, 0, 0.2) 0px -3px 0px inset;\r\n\r\n  }\r\n</style>\r\n\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "answer-modal");
            __builder.AddAttribute(3, "id", "answer-modal");
#nullable restore
#line 103 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Components\ViewSubmissionsComponent.razor"
   if (SingleSubmission != null)
  {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "answer-modal-user");
            __builder.OpenElement(6, "p");
            __builder.AddContent(7, 
#nullable restore
#line 106 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Components\ViewSubmissionsComponent.razor"
            SingleSubmission.UserEmail

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 107 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Components\ViewSubmissionsComponent.razor"
                                                        () => ToggleAnswerModal(SingleSubmission)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(12, "Close");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n      ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "answer-modal-title");
            __builder.OpenElement(16, "h2");
            __builder.AddContent(17, 
#nullable restore
#line 110 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Components\ViewSubmissionsComponent.razor"
             SingleSubmission.QuestionTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n      ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "answer-modal-container");
            __builder.OpenElement(21, "textarea");
            __builder.AddAttribute(22, "class", "answer-modal-container-inner");
            __builder.AddAttribute(23, "spellcheck", "false");
            __builder.AddContent(24, 
#nullable restore
#line 115 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Components\ViewSubmissionsComponent.razor"
         SingleSubmission.Answer

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 119 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Components\ViewSubmissionsComponent.razor"
  }
  else
  {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(25, "<h3>No data...</h3>");
#nullable restore
#line 123 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Components\ViewSubmissionsComponent.razor"
  }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(27);
            __builder.AddAttribute(28, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 127 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Components\ViewSubmissionsComponent.razor"
                 Submission

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "class", "center-inner");
            __builder.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
#nullable restore
#line 129 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Components\ViewSubmissionsComponent.razor"
   if (filterIsClicked)
  {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 131 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Components\ViewSubmissionsComponent.razor"
     if (TotalSubmissions != null)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "btn-admin-wrapper mb-3");
#nullable restore
#line 135 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Components\ViewSubmissionsComponent.razor"
         if (SingleSubmission != null)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(33, "button");
                __builder2.AddAttribute(34, "type", "button");
                __builder2.AddAttribute(35, "class", "btn btn-outline-danger btn-sm mr-2");
                __builder2.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 137 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Components\ViewSubmissionsComponent.razor"
                                                                                            () => DeleteSubmission(SingleSubmission.UserEmail)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(37, "Delete Submission");
                __builder2.CloseElement();
#nullable restore
#line 138 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Components\ViewSubmissionsComponent.razor"
        }        

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(38, "button");
                __builder2.AddAttribute(39, "type", "button");
                __builder2.AddAttribute(40, "class", "btn btn-outline-success btn-sm");
                __builder2.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 139 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Components\ViewSubmissionsComponent.razor"
                                                                                   Reset

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(42, "Reset");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.OpenElement(43, "table");
                __builder2.AddAttribute(44, "class", "table table-bordered table-dark");
                __builder2.AddMarkupContent(45, "<thead><tr><th scope=\"col\">#</th>\r\n                <th scope=\"col\">Email</th>\r\n                <th scope=\"col\">Title</th>\r\n                <th scope=\"col\">Action</th></tr></thead>\r\n            ");
                __builder2.OpenElement(46, "tbody");
#nullable restore
#line 154 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Components\ViewSubmissionsComponent.razor"
           foreach (var submission in TotalSubmissions)
          {


#line default
#line hidden
#nullable disable
                __builder2.OpenElement(47, "tr");
                __builder2.OpenElement(48, "th");
                __builder2.AddAttribute(49, "scope", "row");
                __builder2.AddContent(50, 
#nullable restore
#line 158 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Components\ViewSubmissionsComponent.razor"
                                     submission.QuestionNumber

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n                    ");
                __builder2.OpenElement(52, "td");
                __builder2.AddContent(53, 
#nullable restore
#line 159 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Components\ViewSubmissionsComponent.razor"
                         submission.UserEmail

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n                    ");
                __builder2.OpenElement(55, "td");
                __builder2.AddContent(56, 
#nullable restore
#line 160 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Components\ViewSubmissionsComponent.razor"
                         submission.QuestionTitle

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n                    ");
                __builder2.OpenElement(58, "td");
                __builder2.OpenElement(59, "button");
                __builder2.AddAttribute(60, "class", "btn btn-primary btn-sm");
                __builder2.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 161 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Components\ViewSubmissionsComponent.razor"
                                                                         () => ToggleAnswerModal(submission)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(62, "View\r\n                        Submission");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 164 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Components\ViewSubmissionsComponent.razor"

          }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 169 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Components\ViewSubmissionsComponent.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(63, "<h1>Loading data...</h1>");
#nullable restore
#line 173 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Components\ViewSubmissionsComponent.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 173 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Components\ViewSubmissionsComponent.razor"
     

  }
  else
  {

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 179 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Components\ViewSubmissionsComponent.razor"
     if (Emails != null)
    {


#line default
#line hidden
#nullable disable
                __builder2.OpenElement(64, "table");
                __builder2.AddAttribute(65, "class", "table table-bordered table-dark");
                __builder2.AddMarkupContent(66, "<thead><tr><th scope=\"col\">#</th>\r\n                <th scope=\"col\">Email</th>\r\n                <th scope=\"col\">Action</th></tr></thead>\r\n            ");
                __builder2.OpenElement(67, "tbody");
#nullable restore
#line 192 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Components\ViewSubmissionsComponent.razor"
           foreach (var email in Emails)
          {


#line default
#line hidden
#nullable disable
                __builder2.OpenElement(68, "tr");
                __builder2.AddMarkupContent(69, "<th scope=\"row\">1</th> \r\n                    ");
                __builder2.OpenElement(70, "td");
                __builder2.AddContent(71, 
#nullable restore
#line 197 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Components\ViewSubmissionsComponent.razor"
                         email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "           \r\n                    ");
                __builder2.OpenElement(73, "td");
                __builder2.OpenElement(74, "button");
                __builder2.AddAttribute(75, "class", "btn btn-primary btn-sm");
                __builder2.AddAttribute(76, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 198 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Components\ViewSubmissionsComponent.razor"
                                                                         () => Filter(email)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(77, "View\r\n                        Submissions");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 201 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Components\ViewSubmissionsComponent.razor"

          }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 206 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Components\ViewSubmissionsComponent.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(78, "<h1>Loading data...</h1>");
#nullable restore
#line 210 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Components\ViewSubmissionsComponent.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 210 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Components\ViewSubmissionsComponent.razor"
     


  } 

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 219 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Components\ViewSubmissionsComponent.razor"
 
  public SubmissionSample Submission { get; set; } = new SubmissionSample();
  List<SubmissionSample> TotalSubmissions;
  SubmissionSample SingleSubmission;

  List<string> Cache;
  bool firstStart = false;

  /*new updates*/
  bool filterIsClicked = false;
  List<string> Emails;

  protected override async Task OnInitializedAsync()
  {

    firstStart = true;
    Emails = await HttpClient.GetFromJsonAsync<List<string>>("https://codesubmissionapi.azurewebsites.net/api/SubmissionSample/user");
    Cache = Emails;

  }

  protected override async Task OnAfterRenderAsync(bool firstRender)
  {
    if (firstRender)
    {
      await jsr.InvokeVoidAsync("initializeAnswerModalIds");
    }
  }

  private void Reset()
  {
    filterIsClicked = false;
    Emails = Cache;
  }

  private async Task Filter(string email)
  {
    filterIsClicked = true;
    TotalSubmissions = await
    HttpClient.GetFromJsonAsync<List<SubmissionSample>>($"https://codesubmissionapi.azurewebsites.net/api/submissionsample/email={email}");
    SingleSubmission = TotalSubmissions[0];

  }

  private async Task ToggleAnswerModal(SubmissionSample submission)
  {
    SingleSubmission = submission;
    await jsr.InvokeVoidAsync("toggle");
  }

  private async Task DeleteSubmission(string email)
  {
    bool confirmed = await jsr.InvokeAsync<bool>("confirm", "Are you sure? All submissions for this candidate will be deleted");

    if (confirmed)
    {
      await HttpClient.DeleteAsync($"https://codesubmissionapi.azurewebsites.net/api/submissionsample/email={email}");
      Emails = await HttpClient.GetFromJsonAsync<List<string>>("https://codesubmissionapi.azurewebsites.net/api/SubmissionSample/user");
      Cache = Emails;
      filterIsClicked = false;

    }

  }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591

// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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

// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CodeSubmissionClient.ClientTestEnv.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Components;
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
#line 6 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Pages\TestingSpace.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Pages\TestingSpace.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Pages\TestingSpace.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Pages\TestingSpace.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/testenv")]
    public partial class TestingSpace : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 121 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Pages\TestingSpace.razor"
 

    public SubmissionSample Submission { get; set; }
    private int Counter = 1;
    private int InitialCount = 0;
    private bool loaded = false;
      private async Task PageUp()
    {
        if (State.Count <= State.Submissions.Count && State.isSaved)
        {
            Counter++;
            State.Count++;
            State.isSaved = false;
            if (Counter > 6)
                Counter = 6;
        }
        else
        {
            await jsr.InvokeVoidAsync("alert", "Don't forget to save your work!");
        }      

    }

    private void PageDown()
    {
        Counter--;
        State.Count--;
        if (Counter < 1)
            Counter = 1; 

    }

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
            InitialCount = State.Submissions.Count;
            loaded = true;
        } 
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 171 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Pages\TestingSpace.razor"
                                                                      

    private async Task SubmitResponse()
    {
        if (State.Count == State.Submissions.Count)
        {
            foreach (var item in State.Submissions)
            {
                item.UserEmail = username;
            }
            var SubmissionJson = JsonConvert.SerializeObject(State.Submissions);
            var httpContent = new StringContent(SubmissionJson, Encoding.UTF8, "application/json");
            await client.PostAsync("api/SubmissionSample", httpContent);

            await client.PostAsJsonAsync("https://prod-168.westeurope.logic.azure.com:443/workflows/9acd2517f22a4b9aad3cf300df015596/triggers/manual/paths/invoke?api-version=2016-06-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=U_cZvxtuKiZSIPoAWoXd2AM_uEn291I3gNJVjlrH-DI", State.Submissions[0]);

            NavigationManager.NavigateTo("/done"); 
        }
        else
        {
            await jsr.InvokeVoidAsync("alert", "Don't forget to save your work!");
        } 

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private State State { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsr { get; set; }
    }
}
#pragma warning restore 1591

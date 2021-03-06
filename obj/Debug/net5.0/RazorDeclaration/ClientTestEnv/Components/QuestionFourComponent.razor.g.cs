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
    public partial class QuestionFourComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 186 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Components\QuestionFourComponent.razor"
 

    public SubmissionSample Submission { get; set; } = new SubmissionSample();
    private bool Saved = false;
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await jsr.InvokeVoidAsync("initialize");
            await jsr.InvokeVoidAsync("getIds");
        }

        string[] elementInfo = await jsr.InvokeAsync<string[]>("getValues");
        Submission.QuestionNumber = State.Count;
        Submission.QuestionTitle = elementInfo[0];
        Submission.QuestionDescription = elementInfo[1];

    }

    protected override void OnInitialized()
    {
        if (State.Submissions.Count >= State.Count)
        {
            Submission = State.Submissions[State.Count - 1];
        }
        else
        {
            Submission.Answer = State.Q4template;
        }
    }

    private async Task ShowModal()
    {
        await jsr.InvokeVoidAsync("showModal");
    }

    private void Save()
    {
        //TODO: Check state of Submission
        //check if response box is filled
        //add prompt for next button - create own drop down confirm box
        //keep state once page is refreshed - look into localstorage - cache

        if (State.Submissions.Count < State.Count)
        {
            State.Submissions.Add(Submission);
        }
        else
        {
            State.Submissions[State.Count - 1] = Submission;
        }
        Saved = true;
        State.isSaved = true;
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private State State { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsr { get; set; }
    }
}
#pragma warning restore 1591

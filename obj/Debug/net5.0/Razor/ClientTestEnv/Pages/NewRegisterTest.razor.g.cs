#pragma checksum "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Pages\NewRegisterTest.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff9f02f3e4b3fbc767adb5223587ed98837ece28"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class NewRegisterTest : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>

    *{
    font-family: 'Montserrat', sans-serif;
    }

    .wrapper-reg {
        width: 100%;
        height: 100vh;
        display: flex;
        justify-content: center;
        align-items: center;
        flex-direction: column;
    }

    .wrapper-reg h3
    {
        font-size: 3rem;
    }

    .reg-container {
        width: 90%;
        max-width: 400px;
        display: flex;
        flex-direction: column;
        justify-content: space-evenly;
        padding: 25px;
        box-shadow: rgba(0, 0, 0, 0.4) 0px 2px 4px, rgba(0, 0, 0, 0.3) 0px 7px 13px -3px, rgba(0, 0, 0, 0.2) 0px -3px 0px inset;
        border-radius: 5px;
    }

    .btn-container {
        display: flex;
        justify-content: space-between;
        align-items: center;
    }

    .btn-container a{
        font-size: 14px;
        margin-right: 5px;
    }

     /*MEDIA QUERIES*/
  @media screen and (max-width: 400px)
  {
      .btn-container
      {
          flex-direction: column;
          align-items: flex-start;
          justify-content: space-evenly;
      }
  }

  @media screen and (max-width: 215px)
  {
      .wrapper-reg 
      {
          display: none;
      }
  }


</style>


");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "wrapper-reg");
            __builder.AddMarkupContent(3, "<h3>Register</h3>\r\n    \r\n    ");
            __builder.OpenElement(4, "p");
            __builder.AddContent(5, 
#nullable restore
#line 74 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Pages\NewRegisterTest.razor"
        message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "p");
            __builder.OpenElement(8, "a");
            __builder.AddAttribute(9, "href", "/login_");
            __builder.AddContent(10, 
#nullable restore
#line 75 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Pages\NewRegisterTest.razor"
                          login

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(12);
            __builder.AddAttribute(13, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 77 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Pages\NewRegisterTest.razor"
                     reg

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 77 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Pages\NewRegisterTest.razor"
                                         OnValid

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(15, "class", "reg-container");
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(17);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(19);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "mb-2");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "class", "form-control");
                __builder2.AddAttribute(25, "placeholder", "Enter Email");
                __builder2.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 81 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Pages\NewRegisterTest.razor"
                                                         reg.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => reg.Email = __value, reg.Email))));
                __builder2.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => reg.Email));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n\r\n        ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "mb-2");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(32);
                __builder2.AddAttribute(33, "type", "password");
                __builder2.AddAttribute(34, "class", "form-control");
                __builder2.AddAttribute(35, "placeholder", "Enter Password");
                __builder2.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 85 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Pages\NewRegisterTest.razor"
                                                                         reg.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => reg.Password = __value, reg.Password))));
                __builder2.AddAttribute(38, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => reg.Password));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n        ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "mb-2");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(42);
                __builder2.AddAttribute(43, "type", "password");
                __builder2.AddAttribute(44, "class", "form-control");
                __builder2.AddAttribute(45, "placeholder", "Confirm Password");
                __builder2.AddAttribute(46, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 88 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Pages\NewRegisterTest.razor"
                                                                         reg.ConfirmPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => reg.ConfirmPassword = __value, reg.ConfirmPassword))));
                __builder2.AddAttribute(48, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => reg.ConfirmPassword));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n\r\n        ");
                __builder2.OpenElement(50, "select");
                __builder2.AddAttribute(51, "class", "custom-select mb-2");
                __builder2.AddAttribute(52, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 91 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Pages\NewRegisterTest.razor"
                                                      OnValueChanged

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "title", "Role is required ");
                __builder2.OpenElement(54, "option");
                __builder2.AddAttribute(55, "value", "Select");
                __builder2.AddAttribute(56, "selected");
                __builder2.AddAttribute(57, "disabled", "disabled");
                __builder2.AddAttribute(58, "style", "text-align:center; font-family:inherit;");
                __builder2.AddContent(59, "-- Select Role --");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n            ");
                __builder2.OpenElement(61, "option");
                __builder2.AddAttribute(62, "value", "Developer");
                __builder2.AddContent(63, "Developer");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n            ");
                __builder2.OpenElement(65, "option");
                __builder2.AddAttribute(66, "value", "Admin");
                __builder2.AddContent(67, "Admin");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n            ");
                __builder2.OpenElement(69, "option");
                __builder2.AddAttribute(70, "value", "Candidate");
                __builder2.AddContent(71, "Candidate");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 98 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Pages\NewRegisterTest.razor"
         if (!string.IsNullOrEmpty(reg.Role))
        {
            if (reg.Role.Equals("Developer") || reg.Role.Equals("Admin"))
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "mb-2");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(74);
                __builder2.AddAttribute(75, "type", "password");
                __builder2.AddAttribute(76, "class", "form-control mb-2");
                __builder2.AddAttribute(77, "placeholder", "Enter Security Key");
                __builder2.AddAttribute(78, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 103 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Pages\NewRegisterTest.razor"
                                                                                      securityKey

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(79, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => securityKey = __value, securityKey))));
                __builder2.AddAttribute(80, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => securityKey));
                __builder2.CloseComponent();
                __builder2.CloseElement();
#nullable restore
#line 105 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Pages\NewRegisterTest.razor"
            }
        }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "mb-2 mt-2 text-left btn-container");
                __builder2.OpenElement(83, "button");
                __builder2.AddAttribute(84, "class", "btn btn-primary btn-sm");
                __builder2.AddAttribute(85, "disabled", 
#nullable restore
#line 110 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Pages\NewRegisterTest.razor"
                                                              isDisabled

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(86, "Register");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n            &nbsp; &nbsp; ");
                __builder2.AddMarkupContent(88, "<a href=\"/login_\">Already with us? Login</a>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 120 "C:\Users\Ashton\OneDrive - Nebula\course-work\recruitment-portal-project\CodeSubmissionClient\ClientTestEnv\Pages\NewRegisterTest.razor"
       

    RegisterModel reg = new RegisterModel();
    string message = string.Empty;
    string login = string.Empty;
    bool isDisabled = false;
    private string securityKey = string.Empty;

    [Parameter]
    public EventCallback<string> ValueChanged
    {
        get;
        set;
    }
    private Task OnValueChanged(ChangeEventArgs e)
    {
        reg.Role = e.Value.ToString();
        return ValueChanged.InvokeAsync(reg.Role);
    }



    private async Task OnValid()
    {
        bool validSecurityKey = true;

        //check security key

        if (reg.Role != null && !reg.Role.Equals("Candidate"))
        {
            if (string.IsNullOrEmpty(securityKey) || !securityKey.Equals("1234"))
                validSecurityKey = false;

        }

        if (validSecurityKey)
        {
            isDisabled = true;
            using (var msg = await Http.PostAsJsonAsync<RegisterModel>("https://codesubmissionapi.azurewebsites.net/api/auth/register", reg, System.Threading.CancellationToken.None))
            {
                if (msg.IsSuccessStatusCode)
                {
                    LoginResult result = await msg.Content.ReadFromJsonAsync<LoginResult>();
                    message = result.Message;
                    if (result.Success)
                    {
                        message += " Please LOGIN to continue.";
                        login = "Click here to LOGIN.";
                    }
                    else
                        isDisabled = false;
                }
            }
        } 


    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
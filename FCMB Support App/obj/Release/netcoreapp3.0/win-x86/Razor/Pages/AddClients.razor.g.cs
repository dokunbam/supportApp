#pragma checksum "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\Pages\AddClients.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54c2a7a527e2bf268ae567ffbc3dbe86cf86576d"
// <auto-generated/>
#pragma warning disable 1591
namespace FCMB_Support_App.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\_Imports.razor"
using FCMB_Support_App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\_Imports.razor"
using FCMB_Support_App.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\_Imports.razor"
using FCMB_Support_App.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\_Imports.razor"
using FCMB_Support_App.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\Pages\AddClients.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addclients")]
    public partial class AddClients : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Clients</h3>\r\n\r\n\r\n\r\n\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n        ");
                __builder2.OpenComponent<FCMB_Support_App.Pages.ClientsForm>(4);
                __builder2.AddAttribute(5, "ButtonText", "Add Client");
                __builder2.AddAttribute(6, "Clients", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<FCMB_Support_App.Models.Client>(
#nullable restore
#line 29 "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\Pages\AddClients.razor"
                                                      clientObj

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 29 "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\Pages\AddClients.razor"
                                                                                 PostClient

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n    ");
            }
            ));
            __builder.AddAttribute(9, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n        Please login to view this page\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\Pages\AddClients.razor"
       

    Client clientObj = new Client();

    List<FCMB_Support_App.Models.Client> clients { get; set; }



    //method to post client
    protected async Task PostClient()
    {
        await clientsController.PostClients(clientObj);

        navigationManager.NavigateTo("/clients");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClientsController clientsController { get; set; }
    }
}
#pragma warning restore 1591

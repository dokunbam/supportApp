#pragma checksum "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\Pages\Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcee58a39064122f1c14c3946d2d0c0dac90790f"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 6 "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\Pages\Edit.razor"
using FCMB_Support_App.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\Pages\Edit.razor"
using FCMB_Support_App.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/client/edit/{ClientId:int}")]
    public partial class Edit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\Pages\Edit.razor"
       
    [Parameter] public int clientId { get; set; }
    Client Clients = new Client();

    //protected async Task UpdateClient()
    //{
    //    var oneclient = await clientsController.OneClient(clientId);

    //}

    async Task EditClient()
    {
        await clientsController.PutClient(clientId, Clients);
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClientsController clientsController { get; set; }
    }
}
#pragma warning restore 1591

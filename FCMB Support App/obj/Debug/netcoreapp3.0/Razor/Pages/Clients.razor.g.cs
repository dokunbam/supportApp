#pragma checksum "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\Pages\Clients.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2fc15ab94f3dfc82dddbefc7c12aa9e87a7e797"
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
#line 4 "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\Pages\Clients.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\Pages\Clients.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\Pages\Clients.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/clients")]
    public partial class Clients : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        ");
                __builder2.AddMarkupContent(3, "<h3>Clients</h3>\r\n\r\n        ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row");
                __builder2.AddMarkupContent(6, "\r\n            ");
                __builder2.AddMarkupContent(7, "<div class=\"col-md-6\">\r\n                <a type=\"button\" class=\"btn btn-primary\" href=\"addclients\">\r\n                    Add Client\r\n                </a>\r\n            </div>\r\n            ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "col-md-6 offset-3");
                __builder2.AddMarkupContent(10, "\r\n                ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "form-inline");
                __builder2.AddMarkupContent(13, "\r\n                    ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "form-group");
                __builder2.AddMarkupContent(16, "\r\n                        ");
                __builder2.AddMarkupContent(17, "<label for=\"issues\" class=\"sr-only\">Issues</label>\r\n                        ");
                __builder2.OpenElement(18, "input");
                __builder2.AddAttribute(19, "type", "text");
                __builder2.AddAttribute(20, "class", "form-control");
                __builder2.AddAttribute(21, "name", "issues");
                __builder2.AddAttribute(22, "placeholder", "Filter Names");
                __builder2.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 110 "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\Pages\Clients.razor"
                                                                       nameFilter

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nameFilter = __value, nameFilter));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n                    ");
                __builder2.OpenElement(27, "button");
                __builder2.AddAttribute(28, "type", "submit");
                __builder2.AddAttribute(29, "class", "btn btn-primary mb-2");
                __builder2.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 112 "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\Pages\Clients.razor"
                                                                                 Filter

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(31, "Filter");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n                    ");
                __builder2.OpenElement(33, "button");
                __builder2.AddAttribute(34, "type", "submit");
                __builder2.AddAttribute(35, "class", "btn btn-success ml-2 mb-2");
                __builder2.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 113 "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\Pages\Clients.razor"
                                                                                      Clear

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(37, "Clear");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n\r\n\r\n\r\n");
#nullable restore
#line 123 "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\Pages\Clients.razor"
         if (clients == null)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(42, "            ");
                __builder2.AddMarkupContent(43, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 126 "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\Pages\Clients.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(44, "            ");
                __builder2.OpenElement(45, "table");
                __builder2.AddAttribute(46, "class", "table table table-striped");
                __builder2.AddMarkupContent(47, "\r\n                ");
                __builder2.AddMarkupContent(48, @"<thead class=""thead-dark"">
                    <tr>
                        <th>Name</th>
                        <th>Email</th>
                        <th>Address</th>
                        <th>Phone</th>
                        <th>Edit Actions</th>
                        <th>Delete Actions</th>
                    </tr>
                </thead>
                ");
                __builder2.OpenElement(49, "tbody");
                __builder2.AddMarkupContent(50, "\r\n");
#nullable restore
#line 141 "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\Pages\Clients.razor"
                     foreach (var client in clients)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(51, "                        ");
                __builder2.OpenElement(52, "tr");
                __builder2.AddMarkupContent(53, "\r\n                            ");
                __builder2.OpenElement(54, "td");
                __builder2.AddContent(55, 
#nullable restore
#line 144 "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\Pages\Clients.razor"
                                 client.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n                            ");
                __builder2.OpenElement(57, "td");
                __builder2.AddContent(58, 
#nullable restore
#line 145 "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\Pages\Clients.razor"
                                 client.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                            ");
                __builder2.OpenElement(60, "td");
                __builder2.AddContent(61, 
#nullable restore
#line 146 "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\Pages\Clients.razor"
                                 client.Address

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n                            ");
                __builder2.OpenElement(63, "td");
                __builder2.AddContent(64, 
#nullable restore
#line 147 "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\Pages\Clients.razor"
                                 client.Phone

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n                            ");
                __builder2.OpenElement(66, "td");
                __builder2.OpenElement(67, "a");
                __builder2.AddAttribute(68, "class", "btn btn-warning");
                __builder2.AddAttribute(69, "href", "/client/edit/" + (
#nullable restore
#line 148 "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\Pages\Clients.razor"
                                                                               client.ClientId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(70, "Edit");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n                            ");
                __builder2.OpenElement(72, "td");
                __builder2.OpenElement(73, "a");
                __builder2.AddAttribute(74, "class", "btn btn-danger");
                __builder2.AddAttribute(75, "href", "/client/delete/" + (
#nullable restore
#line 149 "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\Pages\Clients.razor"
                                                                                client.ClientId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(76, "Delete");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n");
#nullable restore
#line 151 "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\Pages\Clients.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(79, "                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n");
#nullable restore
#line 154 "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\Pages\Clients.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(82, "\r\n        ");
                __builder2.OpenComponent<FCMB_Support_App.Pages.Pagination>(83);
                __builder2.AddAttribute(84, "TotalPagesQuantity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 156 "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\Pages\Clients.razor"
                                        totalPageQuantity

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(85, "CurrentPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 156 "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\Pages\Clients.razor"
                                                                        currentPage

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(86, "Radius", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 156 "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\Pages\Clients.razor"
                                                                                             2

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(87, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 156 "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\Pages\Clients.razor"
                                                                                                              SelectedPage

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(88, "\r\n\r\n    ");
            }
            ));
            __builder.AddAttribute(89, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(90, "\r\n       Please login to view this page\r\n\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\Pages\Clients.razor"
       

    Client clientObj = new Client();
    PaginationDTO pagination = new PaginationDTO();

    List<FCMB_Support_App.Models.Client> clients { get; set; }
    private int totalPageQuantity;
    private int currentPage = 1;
    private string nameFilter = string.Empty;


    protected async Task GetClients(int page = 1, int quantityPerpage = 10)
    //http://localhost:54888/fcmb/clients
    {
        //clients = await http.GetJsonAsync<List<Client>>($"http://localhost:54888/fcmb/clients?page={page}&quantityPerPage={quantityPerpage}");

        var httpResponse = await http.GetAsync($"http://localhost:54888/fcmb/clients?page={page}&quantityPerPage={quantityPerpage}&name={nameFilter}");
        if (httpResponse.IsSuccessStatusCode)
        {
            totalPageQuantity = int.Parse(httpResponse.Headers.GetValues("pagesQuantity").FirstOrDefault());
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            clients = JsonSerializer.Deserialize<List<Client>>(responseString,
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });


        }
        else { }

        //clients = await clientsController.GetAllClients(pagination);
    }

    protected async Task SearchListItem()
    {
        var result = await clientsController.Search(clientObj);


    }

    //method to post client
    protected async Task PostClient()
    {
        await clientsController.PostClients(clientObj);

        navigationManager.NavigateTo("/clients");
    }

    //This will run when the page loads
    protected override async Task OnInitializedAsync()
    {
        await GetClients();
    }

    private async Task SelectedPage(int page)
    {
        currentPage = page;
        await GetClients(page);
    }

    private async Task Filter()
    {
        currentPage = 1;
        await GetClients();
    }

    private async Task Clear()
    {
        nameFilter = string.Empty;
        currentPage = 1;
        await GetClients();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClientsController clientsController { get; set; }
    }
}
#pragma warning restore 1591

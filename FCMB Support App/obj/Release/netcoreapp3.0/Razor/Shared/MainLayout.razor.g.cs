#pragma checksum "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b76ac10ee61ab26bb40d37892da9f0e2437104a2"
// <auto-generated/>
#pragma warning disable 1591
namespace FCMB_Support_App.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n            ");
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "sidebar");
                __builder2.AddMarkupContent(5, "\r\n                ");
                __builder2.OpenComponent<FCMB_Support_App.Shared.NavMenu>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(8, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n\r\n       ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "main");
            __builder.AddMarkupContent(12, "\r\n         ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "top-row px-4");
            __builder.AddAttribute(15, "style", "background-color: #04163d");
            __builder.AddMarkupContent(16, "\r\n             ");
            __builder.OpenComponent<FCMB_Support_App.Shared.LoginDisplay>(17);
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\r\n               ");
            __builder.AddMarkupContent(19, "<a class=\"text-white\" href=\"#\" target=\"_blank\">About</a>\r\n         ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n          ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "content px-4");
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.AddContent(24, 
#nullable restore
#line 17 "C:\Users\DELL\Desktop\FCMB Support App folder\New folder\FCMB Support App\Shared\MainLayout.razor"
                     Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(25, "\r\n          ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n         ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

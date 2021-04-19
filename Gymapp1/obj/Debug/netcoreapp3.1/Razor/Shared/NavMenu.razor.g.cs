#pragma checksum "/Users/erikolah/Projects/Gymapp1/Gymapp1/Shared/NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb5aa02072163e04b8922f03166e39d080d3f58e"
// <auto-generated/>
#pragma warning disable 1591
namespace Gymapp1.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/erikolah/Projects/Gymapp1/Gymapp1/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/erikolah/Projects/Gymapp1/Gymapp1/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/erikolah/Projects/Gymapp1/Gymapp1/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/erikolah/Projects/Gymapp1/Gymapp1/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/erikolah/Projects/Gymapp1/Gymapp1/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/erikolah/Projects/Gymapp1/Gymapp1/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/erikolah/Projects/Gymapp1/Gymapp1/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/erikolah/Projects/Gymapp1/Gymapp1/_Imports.razor"
using Gymapp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/erikolah/Projects/Gymapp1/Gymapp1/_Imports.razor"
using Gymapp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/erikolah/Projects/Gymapp1/Gymapp1/_Imports.razor"
using Gymapp1.Models;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "nav navbarr navbar-expand-lg navbar-light");
            __builder.AddMarkupContent(2, "\n        ");
            __builder.OpenElement(3, "a");
            __builder.AddAttribute(4, "class", "navbar-brand");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 2 "/Users/erikolah/Projects/Gymapp1/Gymapp1/Shared/NavMenu.razor"
                                          ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "href", "/");
            __builder.AddContent(7, "GymApp");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n        ");
            __builder.AddMarkupContent(9, "<button class=\"navbar-toggler\" type=\"button\" data-toggle=\"collapse\" data-target=\"#navbarText\">\n            <span class=\"navbar-toggler-icon\"></span>\n        </button>\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "collapse navbar-collapse");
            __builder.AddAttribute(12, "id", "navbarText");
            __builder.AddMarkupContent(13, "\n            ");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "navbar-nav mr-auto ");
            __builder.AddMarkupContent(16, "\n                ");
            __builder.AddMarkupContent(17, "<li class=\"nav-item active\">\n                    <a class=\"nav-link\" href=\"/\">Home <span class=\"sr-only\">(current)</span></a>\n                </li>\n                ");
            __builder.AddMarkupContent(18, "<li class=\"nav-item\">\n                    <a class=\"nav-link\" href=\"foglalas\">Foglalás</a>\n                </li>\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(19);
            __builder.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(21, "\n                    ");
                __builder2.AddMarkupContent(22, "<li class=\"nav-item\">\n                        <a class=\"nav-link\" href=\"foglalt\">Foglalt</a>\n                    </li>\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(23, "\n                ");
            __builder.AddMarkupContent(24, "<li class=\"nav-item\">\n                    <a class=\"nav-link\" href=\"elerhetoseg\">Elerhetőség</a>\n                </li>\n                ");
            __builder.OpenElement(25, "li");
            __builder.AddAttribute(26, "class", "nav-item");
            __builder.AddMarkupContent(27, "\n                    ");
            __builder.OpenComponent<Gymapp1.Shared.LoginDisplay>(28);
            __builder.CloseComponent();
            __builder.AddMarkupContent(29, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "/Users/erikolah/Projects/Gymapp1/Gymapp1/Shared/NavMenu.razor"
       


    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

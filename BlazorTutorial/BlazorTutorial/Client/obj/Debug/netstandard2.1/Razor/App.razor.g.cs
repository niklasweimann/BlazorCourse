#pragma checksum "/Users/crystark/Documents/BlazorCourse/BlazorTutorial/BlazorTutorial/Client/App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6afc4ec48fb12609615569a764b91fd26f44bbc0"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorTutorial.Client
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/crystark/Documents/BlazorCourse/BlazorTutorial/BlazorTutorial/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/crystark/Documents/BlazorCourse/BlazorTutorial/BlazorTutorial/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/crystark/Documents/BlazorCourse/BlazorTutorial/BlazorTutorial/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/crystark/Documents/BlazorCourse/BlazorTutorial/BlazorTutorial/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/crystark/Documents/BlazorCourse/BlazorTutorial/BlazorTutorial/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/crystark/Documents/BlazorCourse/BlazorTutorial/BlazorTutorial/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/crystark/Documents/BlazorCourse/BlazorTutorial/BlazorTutorial/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/crystark/Documents/BlazorCourse/BlazorTutorial/BlazorTutorial/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/crystark/Documents/BlazorCourse/BlazorTutorial/BlazorTutorial/Client/_Imports.razor"
using BlazorTutorial.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/crystark/Documents/BlazorCourse/BlazorTutorial/BlazorTutorial/Client/_Imports.razor"
using BlazorTutorial.Client.Shared;

#line default
#line hidden
#nullable disable
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(3);
                __builder2.AddAttribute(4, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 2 "/Users/crystark/Documents/BlazorCourse/BlazorTutorial/BlazorTutorial/Client/App.razor"
                          typeof(Program).Assembly

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder3) => {
                    __builder3.AddMarkupContent(6, "\n            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeRouteView>(7);
                    __builder3.AddAttribute(8, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 4 "/Users/crystark/Documents/BlazorCourse/BlazorTutorial/BlazorTutorial/Client/App.razor"
                                            routeData

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(9, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 4 "/Users/crystark/Documents/BlazorCourse/BlazorTutorial/BlazorTutorial/Client/App.razor"
                                                                       typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(10, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder4) => {
                        __builder4.AddMarkupContent(11, "\n");
#nullable restore
#line 6 "/Users/crystark/Documents/BlazorCourse/BlazorTutorial/BlazorTutorial/Client/App.razor"
                     if (!context.User.Identity.IsAuthenticated)
                    {

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(12, "                        ");
                        __builder4.OpenComponent<BlazorTutorial.Client.Shared.RedirectToLogin>(13);
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(14, "\n");
#nullable restore
#line 9 "/Users/crystark/Documents/BlazorCourse/BlazorTutorial/BlazorTutorial/Client/App.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(15, "                        ");
                        __builder4.AddMarkupContent(16, "<p>You are not authorized to access this resource.</p>\n");
#nullable restore
#line 13 "/Users/crystark/Documents/BlazorCourse/BlazorTutorial/BlazorTutorial/Client/App.razor"
                    }

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(17, "                ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(18, "\n        ");
                }
                ));
                __builder2.AddAttribute(19, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(20, "\n            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(21);
                    __builder3.AddAttribute(22, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 18 "/Users/crystark/Documents/BlazorCourse/BlazorTutorial/BlazorTutorial/Client/App.razor"
                                 typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(24, "\n                ");
                        __builder4.AddMarkupContent(25, "<p>Sorry, there\'s nothing at this address.</p>\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(26, "\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

#pragma checksum "/Users/crystark/Documents/BlazorCourse/BlazorTutorial/BlazorTutorial/Client/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23bbd216460fc177100a57b04016a27e8dcc5fc4"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorTutorial.Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "p");
            __builder.AddContent(1, "Hello, ");
            __builder.AddContent(2, 
#nullable restore
#line 3 "/Users/crystark/Documents/BlazorCourse/BlazorTutorial/BlazorTutorial/Client/Pages/Index.razor"
           getName("viet")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\n\n");
            __builder.OpenElement(4, "p");
            __builder.AddContent(5, " Number of clicks ");
            __builder.AddContent(6, 
#nullable restore
#line 5 "/Users/crystark/Documents/BlazorCourse/BlazorTutorial/BlazorTutorial/Client/Pages/Index.razor"
                      _num_of_click

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n\n");
            __builder.OpenElement(8, "p");
            __builder.AddContent(9, 
#nullable restore
#line 7 "/Users/crystark/Documents/BlazorCourse/BlazorTutorial/BlazorTutorial/Client/Pages/Index.razor"
    _text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n\n");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "class", "btn btn-primary");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "/Users/crystark/Documents/BlazorCourse/BlazorTutorial/BlazorTutorial/Client/Pages/Index.razor"
                                            ()=>ChangeText()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, "Click Me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "/Users/crystark/Documents/BlazorCourse/BlazorTutorial/BlazorTutorial/Client/Pages/Index.razor"
      
    private string _name;
    private int _result;
    private string _text;
    private int _num;
    private int _num_of_click;

    public string getName(string name)
    {
        return _name = name.ToUpper();
    }

    public int getResult(int number)
    {
        int result = 0;
        for(int i = 0; i < number; i++)
        {
            result = i;
        }
        return _result = result;
    }

    public void ChangeText()
    {
        _num++;
        _num_of_click++;

        if (_num == 1)
        {
            _text = "Stark";
        }
        else if (_num == 2)
        {
            _text = "Iron Man";
        }
        else if (_num == 3)
        {
            _text = "Thor";
        }
        else
        {
            _text = "Default";
            _num = 0;
        }
        

    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

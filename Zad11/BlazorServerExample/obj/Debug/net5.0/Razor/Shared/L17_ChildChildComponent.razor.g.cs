#pragma checksum "C:\Users\Piotr\Downloads\BlazorServerExample\BlazorServerExample\Shared\L17_ChildChildComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c456d465f71d41e4f7dd11e47edcc19495420d57"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServerExample.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Piotr\Downloads\BlazorServerExample\BlazorServerExample\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Piotr\Downloads\BlazorServerExample\BlazorServerExample\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Piotr\Downloads\BlazorServerExample\BlazorServerExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Piotr\Downloads\BlazorServerExample\BlazorServerExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Piotr\Downloads\BlazorServerExample\BlazorServerExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Piotr\Downloads\BlazorServerExample\BlazorServerExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Piotr\Downloads\BlazorServerExample\BlazorServerExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Piotr\Downloads\BlazorServerExample\BlazorServerExample\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Piotr\Downloads\BlazorServerExample\BlazorServerExample\_Imports.razor"
using BlazorServerExample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Piotr\Downloads\BlazorServerExample\BlazorServerExample\_Imports.razor"
using BlazorServerExample.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Piotr\Downloads\BlazorServerExample\BlazorServerExample\_Imports.razor"
using BlazorServerExample.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Piotr\Downloads\BlazorServerExample\BlazorServerExample\_Imports.razor"
using BlazorServerExample.Services;

#line default
#line hidden
#nullable disable
    public partial class L17_ChildChildComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Child child component</h3>\r\n");
            __builder.AddMarkupContent(1, "<p>\r\n    This is text from much more nested component\r\n</p>\r\n");
            __builder.OpenElement(2, "table");
#nullable restore
#line 6 "C:\Users\Piotr\Downloads\BlazorServerExample\BlazorServerExample\Shared\L17_ChildChildComponent.razor"
     if (Students.Count == 0)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<tr><td>\r\n                There are no students\r\n            </td></tr>");
#nullable restore
#line 13 "C:\Users\Piotr\Downloads\BlazorServerExample\BlazorServerExample\Shared\L17_ChildChildComponent.razor"
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Piotr\Downloads\BlazorServerExample\BlazorServerExample\Shared\L17_ChildChildComponent.razor"
         foreach (var s in Students)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "tr");
            __builder.OpenElement(5, "td");
            __builder.AddContent(6, 
#nullable restore
#line 20 "C:\Users\Piotr\Downloads\BlazorServerExample\BlazorServerExample\Shared\L17_ChildChildComponent.razor"
                     s.IdStudent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n                ");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 23 "C:\Users\Piotr\Downloads\BlazorServerExample\BlazorServerExample\Shared\L17_ChildChildComponent.razor"
                     s.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 26 "C:\Users\Piotr\Downloads\BlazorServerExample\BlazorServerExample\Shared\L17_ChildChildComponent.razor"
                     s.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Users\Piotr\Downloads\BlazorServerExample\BlazorServerExample\Shared\L17_ChildChildComponent.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Piotr\Downloads\BlazorServerExample\BlazorServerExample\Shared\L17_ChildChildComponent.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\Piotr\Downloads\BlazorServerExample\BlazorServerExample\Shared\L17_ChildChildComponent.razor"
       

    [CascadingParameter]
    public List<Student> Students { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
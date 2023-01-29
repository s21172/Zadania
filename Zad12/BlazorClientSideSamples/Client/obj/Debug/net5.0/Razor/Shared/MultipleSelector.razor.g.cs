#pragma checksum "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\Shared\MultipleSelector.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32cacb2c63d9e04c241388ad55de6a90822e926c"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorClientSideSamples.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\_Imports.razor"
using BlazorClientSideSamples.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\_Imports.razor"
using BlazorClientSideSamples.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\_Imports.razor"
using BlazorClientSideSamples.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\_Imports.razor"
using BlazorClientSideSamples.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\_Imports.razor"
using BlazorMovies.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\_Imports.razor"
using BlazorMovies.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\_Imports.razor"
using BlazorMovies.Shared.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\_Imports.razor"
using BlazorMovies.Client.Repository;

#line default
#line hidden
#nullable disable
    public partial class MultipleSelector : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "multiple-selector");
            __builder.OpenElement(2, "ul");
            __builder.AddAttribute(3, "class", "selectable-ul");
#nullable restore
#line 3 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\Shared\MultipleSelector.razor"
         foreach (var item in NoSelected)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "li");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\Shared\MultipleSelector.razor"
                            () => Select(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(6, 
#nullable restore
#line 5 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\Shared\MultipleSelector.razor"
                                                  item.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 6 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\Shared\MultipleSelector.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "multiple-selector-buttons");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "type", "button");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\Shared\MultipleSelector.razor"
                                        SelectAll

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, ">>");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "type", "button");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\Shared\MultipleSelector.razor"
                                        DeselectAll

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, 
#nullable restore
#line 10 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\Shared\MultipleSelector.razor"
                                                      removeAllText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.OpenElement(20, "ul");
            __builder.AddAttribute(21, "class", "selectable-ul");
#nullable restore
#line 13 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\Shared\MultipleSelector.razor"
         foreach (var item in Selected)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "li");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\Shared\MultipleSelector.razor"
                            () => Deselect(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(24, 
#nullable restore
#line 15 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\Shared\MultipleSelector.razor"
                                                    item.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 16 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\Shared\MultipleSelector.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\Shared\MultipleSelector.razor"
       
    private string removeAllText = "<<";
    [Parameter]
    public List<MultipleSelectorModel> NoSelected { get; set; } = new List<MultipleSelectorModel>();
    [Parameter]
    public List<MultipleSelectorModel> Selected { get; set; } = new List<MultipleSelectorModel>();

    private void Select(MultipleSelectorModel item)
    {
        NoSelected.Remove(item);
        Selected.Add(item);
    }

    private void Deselect(MultipleSelectorModel item)
    {
        Selected.Remove(item);
        NoSelected.Add(item);
    }

    private void SelectAll()
    {
        Selected.AddRange(NoSelected);
        NoSelected.Clear();
    }

    private void DeselectAll()
    {
        NoSelected.AddRange(Selected);
        Selected.Clear();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
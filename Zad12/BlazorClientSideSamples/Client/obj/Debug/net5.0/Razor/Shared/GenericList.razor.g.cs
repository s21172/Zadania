#pragma checksum "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\Shared\GenericList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2ee36144f57bdb0d72ebbfdd071a75b3311c1fc"
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
    public partial class GenericList<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\Shared\GenericList.razor"
 if (List == null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\Shared\GenericList.razor"
     if (NullTemplate != null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, 
#nullable restore
#line 7 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\Shared\GenericList.razor"
         NullTemplate

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 7 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\Shared\GenericList.razor"
                     
    }
    else
    {
        // Default Content

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<img src=\"https://media.giphy.com/media/3oEjI6SIIHBdRxXI40/giphy.gif\">");
#nullable restore
#line 13 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\Shared\GenericList.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\Shared\GenericList.razor"
     
}
else if (List.Count == 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\Shared\GenericList.razor"
     if (EmptyTemplate != null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, 
#nullable restore
#line 19 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\Shared\GenericList.razor"
         EmptyTemplate

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 19 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\Shared\GenericList.razor"
                      
    }
    else
    {
        // Default Content
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "There are no records to show");
#nullable restore
#line 24 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\Shared\GenericList.razor"
                                                 
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\Shared\GenericList.razor"
     
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\Shared\GenericList.razor"
     if (ElementTemplate != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\Shared\GenericList.razor"
         foreach (var element in List)
        {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, 
#nullable restore
#line 33 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\Shared\GenericList.razor"
             ElementTemplate(element)

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 33 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\Shared\GenericList.razor"
                                     
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\Shared\GenericList.razor"
         
    }
    else
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, 
#nullable restore
#line 38 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\Shared\GenericList.razor"
         WholeListTemplate

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 38 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\Shared\GenericList.razor"
                          
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\Shared\GenericList.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\Piotr\Downloads\project-templates\BlazorClientSideSamples\BlazorClientSideSamples\Client\Shared\GenericList.razor"
       
    [Parameter] public RenderFragment NullTemplate { get; set; }
    [Parameter] public RenderFragment EmptyTemplate { get; set; }
    [Parameter] public RenderFragment<TItem> ElementTemplate { get; set; }
    [Parameter] public RenderFragment WholeListTemplate { get; set; }

    [Parameter] public List<TItem> List { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
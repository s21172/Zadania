#pragma checksum "C:\Users\Piotr\Downloads\BlazorServerExample\BlazorServerExample\Pages\ComponentsExamples\L4_SamplePage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56e71da1030755dfd71b7eac152f333f16db20ac"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServerExample.Pages.ComponentsExamples
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/l4-samplepage")]
    public partial class L4_SamplePage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>This is parent page</h3>\r\n\r\n");
            __builder.OpenComponent<BlazorServerExample.Shared.L4_StudentList>(1);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

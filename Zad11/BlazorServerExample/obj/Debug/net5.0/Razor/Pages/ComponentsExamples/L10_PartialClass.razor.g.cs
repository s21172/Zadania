#pragma checksum "C:\Users\Piotr\Downloads\BlazorServerExample\BlazorServerExample\Pages\ComponentsExamples\L10_PartialClass.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e29a6f57c0397f2eece7929b22be353c25f390ea"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/l10-samplepage")]
    public partial class L10_PartialClass : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Partial class example</h3>\r\n\r\n");
            __builder.OpenElement(1, "table");
#nullable restore
#line 6 "C:\Users\Piotr\Downloads\BlazorServerExample\BlazorServerExample\Pages\ComponentsExamples\L10_PartialClass.razor"
     if (students.Count == 0)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<tr><td>\r\n                There are no students\r\n            </td></tr>");
#nullable restore
#line 13 "C:\Users\Piotr\Downloads\BlazorServerExample\BlazorServerExample\Pages\ComponentsExamples\L10_PartialClass.razor"
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Piotr\Downloads\BlazorServerExample\BlazorServerExample\Pages\ComponentsExamples\L10_PartialClass.razor"
         foreach (var s in students)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorServerExample.Shared.L8_ChildComponent>(3);
            __builder.AddAttribute(4, "Student", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorServerExample.Models.Student>(
#nullable restore
#line 18 "C:\Users\Piotr\Downloads\BlazorServerExample\BlazorServerExample\Pages\ComponentsExamples\L10_PartialClass.razor"
                                        s

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnDeleteClicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorServerExample.Models.Student>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorServerExample.Models.Student>(this, 
#nullable restore
#line 18 "C:\Users\Piotr\Downloads\BlazorServerExample\BlazorServerExample\Pages\ComponentsExamples\L10_PartialClass.razor"
                                                            DeleteStudent

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 19 "C:\Users\Piotr\Downloads\BlazorServerExample\BlazorServerExample\Pages\ComponentsExamples\L10_PartialClass.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Piotr\Downloads\BlazorServerExample\BlazorServerExample\Pages\ComponentsExamples\L10_PartialClass.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

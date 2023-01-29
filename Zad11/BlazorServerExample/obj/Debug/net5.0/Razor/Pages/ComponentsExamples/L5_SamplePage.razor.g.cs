#pragma checksum "C:\Users\Piotr\Downloads\BlazorServerExample\BlazorServerExample\Pages\ComponentsExamples\L5_SamplePage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ff80b7fc210c5cbe5369420aeab46d3ea95cfff"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/l5-samplepage")]
    public partial class L5_SamplePage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Parameter example with nested component</h3>\r\n\r\n");
            __builder.OpenComponent<BlazorServerExample.Shared.L5_StudentList>(1);
            __builder.AddAttribute(2, "Students", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorServerExample.Models.Student>>(
#nullable restore
#line 5 "C:\Users\Piotr\Downloads\BlazorServerExample\BlazorServerExample\Pages\ComponentsExamples\L5_SamplePage.razor"
                          students

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\Piotr\Downloads\BlazorServerExample\BlazorServerExample\Pages\ComponentsExamples\L5_SamplePage.razor"
       
    private List<Student> students = new List<Student>();

    protected override async Task OnInitializedAsync()
    {
        await Task.Delay(4000);
        students.Add(new Student
        {
            FirstName = "John",
            LastName = "Smith",
            IdStudent = 1
        });
        students.Add(new Student
        {
            FirstName = "Anne",
            LastName = "Smith",
            IdStudent = 2
        });
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\Alex\source\repos\MyNestedComponent\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d50820d8751f93fa39305b7737335b7469e5aeff"
// <auto-generated/>
#pragma warning disable 1591
namespace MyNestedComponent.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Alex\source\repos\MyNestedComponent\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alex\source\repos\MyNestedComponent\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alex\source\repos\MyNestedComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Alex\source\repos\MyNestedComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Alex\source\repos\MyNestedComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Alex\source\repos\MyNestedComponent\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Alex\source\repos\MyNestedComponent\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Alex\source\repos\MyNestedComponent\_Imports.razor"
using MyNestedComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Alex\source\repos\MyNestedComponent\_Imports.razor"
using MyNestedComponent.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n");
            __builder.OpenComponent<MyNestedComponent.Pages.Dialog>(1);
            __builder.AddAttribute(2, "Title", "Blazor");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    Do you want to ");
                __builder2.AddMarkupContent(5, "<i> learn more </i> about Blazor?\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

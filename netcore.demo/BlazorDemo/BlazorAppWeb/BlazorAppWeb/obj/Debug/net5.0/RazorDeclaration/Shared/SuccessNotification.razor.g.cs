// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorAppWeb.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\lzx\source\repos\BlazorDemo\BlazorAppWeb\BlazorAppWeb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lzx\source\repos\BlazorDemo\BlazorAppWeb\BlazorAppWeb\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lzx\source\repos\BlazorDemo\BlazorAppWeb\BlazorAppWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lzx\source\repos\BlazorDemo\BlazorAppWeb\BlazorAppWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lzx\source\repos\BlazorDemo\BlazorAppWeb\BlazorAppWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lzx\source\repos\BlazorDemo\BlazorAppWeb\BlazorAppWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lzx\source\repos\BlazorDemo\BlazorAppWeb\BlazorAppWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\lzx\source\repos\BlazorDemo\BlazorAppWeb\BlazorAppWeb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\lzx\source\repos\BlazorDemo\BlazorAppWeb\BlazorAppWeb\_Imports.razor"
using BlazorAppWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\lzx\source\repos\BlazorDemo\BlazorAppWeb\BlazorAppWeb\_Imports.razor"
using BlazorAppWeb.Shared;

#line default
#line hidden
#nullable disable
    public partial class SuccessNotification : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\lzx\source\repos\BlazorDemo\BlazorAppWeb\BlazorAppWeb\Shared\SuccessNotification.razor"
      

    private string _modalDisplay;
    private string _modalClass;
    private bool _showBackdrop;

    [Inject]
    public NavigationManager Navigation { get; set; }

    [Parameter]
    public string Url { get; set; }
    public void Show()
    {
        _modalDisplay = "block;";
        _modalClass = "show";
        _showBackdrop = true;
        StateHasChanged();
    }

    private void Hide()
    {
        _modalDisplay = "none;";
        _modalClass = "";
        _showBackdrop = false;
        StateHasChanged();
        Navigation.NavigateTo("/" + Url);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

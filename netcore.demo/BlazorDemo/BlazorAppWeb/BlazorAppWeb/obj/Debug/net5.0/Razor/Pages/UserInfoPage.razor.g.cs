#pragma checksum "C:\Users\lzx\source\repos\BlazorDemo\BlazorAppWeb\BlazorAppWeb\Pages\UserInfoPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8be9ebd8eabce6825604952f2e2eac166b9b81e4"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAppWeb.Pages
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
#nullable restore
#line 2 "C:\Users\lzx\source\repos\BlazorDemo\BlazorAppWeb\BlazorAppWeb\Pages\UserInfoPage.razor"
using BlazorAppWeb.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/userspage")]
    public partial class UserInfoPage : UserInfoPageBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-md-8");
            __builder.OpenComponent<BlazorAppWeb.Components.Search>(4);
            __builder.AddAttribute(5, "OnSearchChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 6 "C:\Users\lzx\source\repos\BlazorDemo\BlazorAppWeb\BlazorAppWeb\Pages\UserInfoPage.razor"
                                 SearchChanged

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(7, "<div class=\"col-md-2\"><a class=\"btn btn-primary\" href=\"/createuser\">新增用户</a></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "div");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "btn btn-primary");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\lzx\source\repos\BlazorDemo\BlazorAppWeb\BlazorAppWeb\Pages\UserInfoPage.razor"
                                               SayHello

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "Say Hello");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "h2");
            __builder.AddContent(16, 
#nullable restore
#line 15 "C:\Users\lzx\source\repos\BlazorDemo\BlazorAppWeb\BlazorAppWeb\Pages\UserInfoPage.razor"
         Result

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "row");
            __builder.OpenComponent<BlazorAppWeb.Components.UserTable>(20);
            __builder.AddAttribute(21, "UserInfos", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorApp.Shared.UserInfo>>(
#nullable restore
#line 21 "C:\Users\lzx\source\repos\BlazorDemo\BlazorAppWeb\BlazorAppWeb\Pages\UserInfoPage.razor"
                          UserInfos

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "Count", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 21 "C:\Users\lzx\source\repos\BlazorDemo\BlazorAppWeb\BlazorAppWeb\Pages\UserInfoPage.razor"
                                            UserInfos.Count

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "OnDeleted", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 21 "C:\Users\lzx\source\repos\BlazorDemo\BlazorAppWeb\BlazorAppWeb\Pages\UserInfoPage.razor"
                                                                        DeleteUser

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "row");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "col");
            __builder.OpenComponent<BlazorAppWeb.Components.Pagination>(29);
            __builder.AddAttribute(30, "MetaData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorApp.Shared.MetaData>(
#nullable restore
#line 27 "C:\Users\lzx\source\repos\BlazorDemo\BlazorAppWeb\BlazorAppWeb\Pages\UserInfoPage.razor"
                              MetaData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "Spread", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 27 "C:\Users\lzx\source\repos\BlazorDemo\BlazorAppWeb\BlazorAppWeb\Pages\UserInfoPage.razor"
                                                2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 27 "C:\Users\lzx\source\repos\BlazorDemo\BlazorAppWeb\BlazorAppWeb\Pages\UserInfoPage.razor"
                                                                 SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\lzx\source\repos\BlazorDemo\BlazorAppWeb\BlazorAppWeb\Components\UserTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30c8f442219edb848106ae7acc45b3f8861b38da"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAppWeb.Components
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
#line 1 "C:\Users\lzx\source\repos\BlazorDemo\BlazorAppWeb\BlazorAppWeb\Components\UserTable.razor"
using BlazorAppWeb.Components;

#line default
#line hidden
#nullable disable
    public partial class UserTable : UserTableBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, 
#nullable restore
#line 3 "C:\Users\lzx\source\repos\BlazorDemo\BlazorAppWeb\BlazorAppWeb\Components\UserTable.razor"
     Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 5 "C:\Users\lzx\source\repos\BlazorDemo\BlazorAppWeb\BlazorAppWeb\Components\UserTable.razor"
 if (UserInfos.Count > 0)
{


#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table table-hover table-striped");
            __builder.AddMarkupContent(4, "<thead class=\"thead-dark\"><tr><th>ID</th>\r\n                <th>部门</th>\r\n                <th>姓名</th>\r\n                <th>出生日期</th>\r\n                <th>性别</th>\r\n                <th>操作</th></tr></thead>\r\n        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 20 "C:\Users\lzx\source\repos\BlazorDemo\BlazorAppWeb\BlazorAppWeb\Components\UserTable.razor"
             foreach (var em in UserInfos)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 23 "C:\Users\lzx\source\repos\BlazorDemo\BlazorAppWeb\BlazorAppWeb\Components\UserTable.razor"
                         em.UserID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                    ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 24 "C:\Users\lzx\source\repos\BlazorDemo\BlazorAppWeb\BlazorAppWeb\Components\UserTable.razor"
                         em.DeptId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 25 "C:\Users\lzx\source\repos\BlazorDemo\BlazorAppWeb\BlazorAppWeb\Components\UserTable.razor"
                         em.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 26 "C:\Users\lzx\source\repos\BlazorDemo\BlazorAppWeb\BlazorAppWeb\Components\UserTable.razor"
                         em.BirthDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 27 "C:\Users\lzx\source\repos\BlazorDemo\BlazorAppWeb\BlazorAppWeb\Components\UserTable.razor"
                         em.Gender

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.OpenElement(23, "a");
            __builder.AddAttribute(24, "href", 
#nullable restore
#line 29 "C:\Users\lzx\source\repos\BlazorDemo\BlazorAppWeb\BlazorAppWeb\Components\UserTable.razor"
                                   $"userdetail/{em.UserID}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(25, "class", "btn btn-primary btn-sm");
            __builder.AddMarkupContent(26, "\r\n                            详情\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                        |\r\n                        ");
            __builder.OpenElement(28, "a");
            __builder.AddAttribute(29, "href", 
#nullable restore
#line 33 "C:\Users\lzx\source\repos\BlazorDemo\BlazorAppWeb\BlazorAppWeb\Components\UserTable.razor"
                                   $"createuser/{em.UserID}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(30, "class", "btn btn-primary btn-sm");
            __builder.AddMarkupContent(31, "\r\n                            编辑\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\r\n                        ");
            __builder.OpenElement(33, "a");
            __builder.AddAttribute(34, "href", "javascript:void(0)");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\lzx\source\repos\BlazorDemo\BlazorAppWeb\BlazorAppWeb\Components\UserTable.razor"
                                                               () => Delete(em.UserID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "class", "btn btn-primary btn-sm");
            __builder.AddMarkupContent(37, "\r\n                            删除\r\n                        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 49 "C:\Users\lzx\source\repos\BlazorDemo\BlazorAppWeb\BlazorAppWeb\Components\UserTable.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 52 "C:\Users\lzx\source\repos\BlazorDemo\BlazorAppWeb\BlazorAppWeb\Components\UserTable.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(38, "<span>\r\n        Loading...\r\n    </span>");
#nullable restore
#line 58 "C:\Users\lzx\source\repos\BlazorDemo\BlazorAppWeb\BlazorAppWeb\Components\UserTable.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

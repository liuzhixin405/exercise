#pragma checksum "C:\Users\lzx\source\repos\BlazorAppWeb\BlazorAppWeb\Pages\CreateUser.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f66f5887da0a3e48cf18e0872cab344de61d097f"
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
#line 1 "C:\Users\lzx\source\repos\BlazorAppWeb\BlazorAppWeb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lzx\source\repos\BlazorAppWeb\BlazorAppWeb\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lzx\source\repos\BlazorAppWeb\BlazorAppWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lzx\source\repos\BlazorAppWeb\BlazorAppWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lzx\source\repos\BlazorAppWeb\BlazorAppWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lzx\source\repos\BlazorAppWeb\BlazorAppWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lzx\source\repos\BlazorAppWeb\BlazorAppWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\lzx\source\repos\BlazorAppWeb\BlazorAppWeb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\lzx\source\repos\BlazorAppWeb\BlazorAppWeb\_Imports.razor"
using BlazorAppWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\lzx\source\repos\BlazorAppWeb\BlazorAppWeb\_Imports.razor"
using BlazorAppWeb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lzx\source\repos\BlazorAppWeb\BlazorAppWeb\Pages\CreateUser.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/createuser")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/createuser/{UserId:int}")]
    public partial class CreateUser : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Employee Edit</h3>");
#nullable restore
#line 6 "C:\Users\lzx\source\repos\BlazorAppWeb\BlazorAppWeb\Pages\CreateUser.razor"
 if (!Saved)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\Users\lzx\source\repos\BlazorAppWeb\BlazorAppWeb\Pages\CreateUser.razor"
                      UserInfo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "C:\Users\lzx\source\repos\BlazorAppWeb\BlazorAppWeb\Pages\CreateUser.razor"
                              HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\lzx\source\repos\BlazorAppWeb\BlazorAppWeb\Pages\CreateUser.razor"
                                HandleInvalidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n\r\n        \r\n        \r\n        ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group row");
                __builder2.AddMarkupContent(12, "<label for=\"userName\" class=\"col-sm-2 col-form-label\">姓名</label>\r\n            ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "col-sm-3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(15);
                __builder2.AddAttribute(16, "class", "form-control");
                __builder2.AddAttribute(17, "id", "userName");
                __builder2.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\lzx\source\repos\BlazorAppWeb\BlazorAppWeb\Pages\CreateUser.razor"
                                                                            UserInfo.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UserInfo.UserName = __value, UserInfo.UserName))));
                __builder2.AddAttribute(20, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => UserInfo.UserName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n                ");
                __Blazor.BlazorAppWeb.Pages.CreateUser.TypeInference.CreateValidationMessage_0(__builder2, 22, 23, 
#nullable restore
#line 25 "C:\Users\lzx\source\repos\BlazorAppWeb\BlazorAppWeb\Pages\CreateUser.razor"
                                          () => UserInfo.UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n        ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group row");
                __builder2.AddMarkupContent(27, "<label for=\"birthDate\" class=\"col-sm-2 col-form-label\">出生日期</label>\r\n            ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "col-sm-3");
                __Blazor.BlazorAppWeb.Pages.CreateUser.TypeInference.CreateInputDate_1(__builder2, 30, 31, "form-control", 32, "birthDate", 33, 
#nullable restore
#line 31 "C:\Users\lzx\source\repos\BlazorAppWeb\BlazorAppWeb\Pages\CreateUser.razor"
                                                                             UserInfo.BirthDate

#line default
#line hidden
#nullable disable
                , 34, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UserInfo.BirthDate = __value, UserInfo.BirthDate)), 35, () => UserInfo.BirthDate);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n        ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "form-group row");
                __builder2.AddMarkupContent(39, "<label for=\"gender\" class=\"col-sm-2 col-form-label\">性别</label>\r\n            ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "col-sm-3");
                __Blazor.BlazorAppWeb.Pages.CreateUser.TypeInference.CreateInputSelect_2(__builder2, 42, 43, "form-control", 44, "gender", 45, 
#nullable restore
#line 37 "C:\Users\lzx\source\repos\BlazorAppWeb\BlazorAppWeb\Pages\CreateUser.razor"
                                                                            UserInfo.Gender

#line default
#line hidden
#nullable disable
                , 46, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UserInfo.Gender = __value, UserInfo.Gender)), 47, () => UserInfo.Gender, 48, (__builder3) => {
#nullable restore
#line 38 "C:\Users\lzx\source\repos\BlazorAppWeb\BlazorAppWeb\Pages\CreateUser.razor"
                     foreach (var value in Enum.GetValues(typeof(Gender)))
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(49, "option");
                    __builder3.AddAttribute(50, "value", 
#nullable restore
#line 40 "C:\Users\lzx\source\repos\BlazorAppWeb\BlazorAppWeb\Pages\CreateUser.razor"
                                        value

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(51, 
#nullable restore
#line 40 "C:\Users\lzx\source\repos\BlazorAppWeb\BlazorAppWeb\Pages\CreateUser.razor"
                                                value

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 41 "C:\Users\lzx\source\repos\BlazorAppWeb\BlazorAppWeb\Pages\CreateUser.razor"
                        }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n\r\n        ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "form-group row");
                __builder2.AddMarkupContent(55, "<label for=\"departmentId\" class=\"col-sm-2 col-form-label\">部门</label>\r\n            ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "col-sm-3");
                __Blazor.BlazorAppWeb.Pages.CreateUser.TypeInference.CreateInputSelect_3(__builder2, 58, 59, "form-control", 60, "departmentId", 61, 
#nullable restore
#line 49 "C:\Users\lzx\source\repos\BlazorAppWeb\BlazorAppWeb\Pages\CreateUser.razor"
                                                                                  DeptId

#line default
#line hidden
#nullable disable
                , 62, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => DeptId = __value, DeptId)), 63, () => DeptId, 64, (__builder3) => {
#nullable restore
#line 50 "C:\Users\lzx\source\repos\BlazorAppWeb\BlazorAppWeb\Pages\CreateUser.razor"
                     foreach (var department in DeptInfos)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(65, "option");
                    __builder3.AddAttribute(66, "value", 
#nullable restore
#line 52 "C:\Users\lzx\source\repos\BlazorAppWeb\BlazorAppWeb\Pages\CreateUser.razor"
                                        department.DeptId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(67, 
#nullable restore
#line 52 "C:\Users\lzx\source\repos\BlazorAppWeb\BlazorAppWeb\Pages\CreateUser.razor"
                                                            department.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 53 "C:\Users\lzx\source\repos\BlazorAppWeb\BlazorAppWeb\Pages\CreateUser.razor"
                        }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n\r\n        ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "form-group row offset-sm-2");
#nullable restore
#line 59 "C:\Users\lzx\source\repos\BlazorAppWeb\BlazorAppWeb\Pages\CreateUser.razor"
             if (UserId > 0)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(71, "input");
                __builder2.AddAttribute(72, "type", "button");
                __builder2.AddAttribute(73, "value", "Delete");
                __builder2.AddAttribute(74, "class", "btn btn-danger mr-2");
                __builder2.AddAttribute(75, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "C:\Users\lzx\source\repos\BlazorAppWeb\BlazorAppWeb\Pages\CreateUser.razor"
                                                                                           DeleteEmployee

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
#nullable restore
#line 62 "C:\Users\lzx\source\repos\BlazorAppWeb\BlazorAppWeb\Pages\CreateUser.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(76, "<button type=\"submit\" class=\"btn btn-primary mr-2\">Submit</button>\r\n\r\n            ");
                __builder2.OpenElement(77, "button");
                __builder2.AddAttribute(78, "class", "btn btn-secondary");
                __builder2.AddAttribute(79, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "C:\Users\lzx\source\repos\BlazorAppWeb\BlazorAppWeb\Pages\CreateUser.razor"
                                                         GoBack

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(80, "Go Back");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 69 "C:\Users\lzx\source\repos\BlazorAppWeb\BlazorAppWeb\Pages\CreateUser.razor"

}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", 
#nullable restore
#line 73 "C:\Users\lzx\source\repos\BlazorAppWeb\BlazorAppWeb\Pages\CreateUser.razor"
                 CssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(83, "role", "alert");
            __builder.AddContent(84, 
#nullable restore
#line 74 "C:\Users\lzx\source\repos\BlazorAppWeb\BlazorAppWeb\Pages\CreateUser.razor"
         Message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 76 "C:\Users\lzx\source\repos\BlazorAppWeb\BlazorAppWeb\Pages\CreateUser.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorAppWeb.Shared.SuccessNotification>(85);
            __builder.AddAttribute(86, "Url", "userspage");
            __builder.AddComponentReferenceCapture(87, (__value) => {
#nullable restore
#line 78 "C:\Users\lzx\source\repos\BlazorAppWeb\BlazorAppWeb\Pages\CreateUser.razor"
                           _notification = (BlazorAppWeb.Shared.SuccessNotification)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.BlazorAppWeb.Pages.CreateUser
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

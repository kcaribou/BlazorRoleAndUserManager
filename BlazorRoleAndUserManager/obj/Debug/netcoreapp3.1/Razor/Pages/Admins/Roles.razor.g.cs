#pragma checksum "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\Pages\Admins\Roles.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51389e553a781cbfaf3b54c107be90dced634329"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorRoleAndUserManager.Pages.Admins
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\_Imports.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\_Imports.razor"
using BlazorRoleAndUserManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\_Imports.razor"
using BlazorRoleAndUserManager.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\_Imports.razor"
using BlazorRoleAndUserManager.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\_Imports.razor"
using BlazorRoleAndUserManager.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\_Imports.razor"
using BlazorRoleAndUserManager.Pages.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\_Imports.razor"
using BlazorRoleAndUserManager.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\Pages\Admins\Roles.razor"
           [Authorize(Roles = "Admins")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/roles")]
    public partial class Roles : OwningComponentBase<RoleManager<AppRole>>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Roles</h3>\r\n\r\n");
#nullable restore
#line 7 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\Pages\Admins\Roles.razor"
 if (_items == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p>Loading ...</p>\r\n");
#nullable restore
#line 10 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\Pages\Admins\Roles.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "table-responsive tableFixHead");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table table-sm table-bordered table-hover table-striped");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddMarkupContent(10, "<caption>List of Roles</caption>\r\n            ");
            __builder.OpenElement(11, "thead");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "tr");
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "th");
            __builder.AddAttribute(16, "scope", "col");
            __builder.AddMarkupContent(17, "\r\n                        ");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "class", "btn btn-outline-success");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\Pages\Admins\Roles.razor"
                                                                          add

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "title", "Add");
            __builder.AddMarkupContent(22, "<span class=\"oi oi-plus\" aria-hidden=\"true\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.AddMarkupContent(25, "<th scope=\"col\">Id</th>\r\n                    ");
            __builder.AddMarkupContent(26, "<th scope=\"col\">Name</th>\r\n                    ");
            __builder.AddMarkupContent(27, "<th scope=\"col\">Farsi Name</th>\r\n                    <th scope=\"col\"></th>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenElement(30, "tbody");
            __builder.AddMarkupContent(31, "\r\n");
#nullable restore
#line 28 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\Pages\Admins\Roles.razor"
                  
                    int rowNbr = 1;
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\Pages\Admins\Roles.razor"
                 foreach (var item in _items)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(32, "                    ");
            __builder.OpenElement(33, "tr");
            __builder.AddMarkupContent(34, "\r\n                        ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 34 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\Pages\Admins\Roles.razor"
                              rowNbr++

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                        ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 35 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\Pages\Admins\Roles.razor"
                             item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                        ");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, 
#nullable restore
#line 36 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\Pages\Admins\Roles.razor"
                             item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                        ");
            __builder.OpenElement(44, "td");
            __builder.AddContent(45, 
#nullable restore
#line 37 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\Pages\Admins\Roles.razor"
                             item.FaName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                        ");
            __builder.OpenElement(47, "td");
            __builder.AddMarkupContent(48, "\r\n");
#nullable restore
#line 39 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\Pages\Admins\Roles.razor"
                             if (item.CreatedBy != "seed")
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "                                ");
            __builder.OpenElement(50, "button");
            __builder.AddAttribute(51, "class", "btn btn-outline-primary");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\Pages\Admins\Roles.razor"
                                                                                  (()=>edit(item))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "title", "Edit");
            __builder.AddMarkupContent(54, "<span class=\"oi oi-pencil\" aria-hidden=\"true\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                                ");
            __builder.OpenElement(56, "button");
            __builder.AddAttribute(57, "class", "btn btn-outline-danger");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\Pages\Admins\Roles.razor"
                                                                                 (async ()=>await delete(item))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "title", "Delete");
            __builder.AddMarkupContent(60, "<span class=\"oi oi-trash\" aria-hidden=\"true\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                                ");
            __builder.OpenElement(62, "button");
            __builder.AddAttribute(63, "class", "btn btn-outline-warning");
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\Pages\Admins\Roles.razor"
                                                                                  (()=>accessRights(item))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "title", "access rights");
            __builder.AddContent(66, "access rights");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n");
#nullable restore
#line 44 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\Pages\Admins\Roles.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(68, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n");
#nullable restore
#line 48 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\Pages\Admins\Roles.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(71, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n");
#nullable restore
#line 53 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\Pages\Admins\Roles.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(75, "\r\n");
#nullable restore
#line 55 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\Pages\Admins\Roles.razor"
 if (_show)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(76, "    ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "modal");
            __builder.AddAttribute(79, "tabindex", "-1");
            __builder.AddAttribute(80, "style", "display:block;");
            __builder.AddMarkupContent(81, "\r\n\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(82);
            __builder.AddAttribute(83, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 59 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\Pages\Admins\Roles.razor"
                         _model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(84, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 59 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\Pages\Admins\Roles.razor"
                                                  async () => await validsubmit()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(85, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(86, "\r\n\r\n            ");
                __builder2.OpenElement(87, "div");
                __builder2.AddAttribute(88, "class", "modal-dialog modal-dialog-scrollable modal-lg");
                __builder2.AddMarkupContent(89, "\r\n                ");
                __builder2.OpenElement(90, "div");
                __builder2.AddAttribute(91, "class", "modal-content");
                __builder2.AddMarkupContent(92, "\r\n                    ");
                __builder2.OpenElement(93, "div");
                __builder2.AddAttribute(94, "class", "modal-header");
                __builder2.AddMarkupContent(95, "\r\n                        ");
                __builder2.OpenElement(96, "h5");
                __builder2.AddAttribute(97, "class", "modal-title text-info");
                __builder2.AddContent(98, 
#nullable restore
#line 64 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\Pages\Admins\Roles.razor"
                                                            _model.Id == null ? "Add" : "Edit"

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(99, " Category");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\r\n                        ");
                __builder2.OpenElement(101, "button");
                __builder2.AddAttribute(102, "type", "button");
                __builder2.AddAttribute(103, "class", "close");
                __builder2.AddAttribute(104, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\Pages\Admins\Roles.razor"
                                                                      close

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(105, "\r\n                            ");
                __builder2.AddMarkupContent(106, "<span aria-hidden=\"true\">&times;</span>\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(108, "\r\n                    ");
                __builder2.OpenElement(109, "div");
                __builder2.AddAttribute(110, "class", "modal-body");
                __builder2.AddMarkupContent(111, "\r\n                        ");
                __builder2.OpenElement(112, "div");
                __builder2.AddAttribute(113, "class", "row");
                __builder2.AddMarkupContent(114, "\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(115);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(116, "\r\n\r\n                            ");
                __builder2.OpenElement(117, "div");
                __builder2.AddAttribute(118, "class", "text-danger");
                __builder2.AddMarkupContent(119, "\r\n                                ");
                __builder2.OpenElement(120, "ul");
                __builder2.AddMarkupContent(121, "\r\n");
#nullable restore
#line 75 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\Pages\Admins\Roles.razor"
                                     foreach (var error in _serverSideErrors)
                                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(122, "                                        ");
                __builder2.OpenElement(123, "li");
                __builder2.AddContent(124, 
#nullable restore
#line 77 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\Pages\Admins\Roles.razor"
                                             error

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(125, "\r\n");
#nullable restore
#line 78 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\Pages\Admins\Roles.razor"
                                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(126, "                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(127, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(128, "\r\n\r\n                            ");
                __builder2.OpenElement(129, "div");
                __builder2.AddAttribute(130, "class", "col-12");
                __builder2.AddMarkupContent(131, "\r\n                                ");
                __builder2.OpenElement(132, "div");
                __builder2.AddAttribute(133, "class", "row");
                __builder2.AddMarkupContent(134, "\r\n                                    ");
                __builder2.AddMarkupContent(135, "<div class=\"col-4\">\r\n                                        Role Name\r\n                                    </div>\r\n                                    ");
                __builder2.OpenElement(136, "div");
                __builder2.AddAttribute(137, "class", "col-8");
                __builder2.AddMarkupContent(138, "\r\n                                        ");
                __builder2.OpenElement(139, "div");
                __builder2.AddAttribute(140, "class", "form-group");
                __builder2.AddMarkupContent(141, "\r\n                                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(142);
                __builder2.AddAttribute(143, "class", "form-control");
                __builder2.AddAttribute(144, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 90 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\Pages\Admins\Roles.razor"
                                                                                          _model.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(145, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _model.Name = __value, _model.Name))));
                __builder2.AddAttribute(146, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _model.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(147, "\r\n                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(148, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(149, "\r\n\r\n                                    <div class=\"col-4\"></div>\r\n                                    ");
                __builder2.OpenElement(150, "div");
                __builder2.AddAttribute(151, "class", "col-8");
                __Blazor.BlazorRoleAndUserManager.Pages.Admins.Roles.TypeInference.CreateValidationMessage_0(__builder2, 152, 153, 
#nullable restore
#line 95 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\Pages\Admins\Roles.razor"
                                                                                 ()=> _model.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(154, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(155, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(156, "\r\n\r\n                            ");
                __builder2.OpenElement(157, "div");
                __builder2.AddAttribute(158, "class", "col-12");
                __builder2.AddMarkupContent(159, "\r\n                                ");
                __builder2.OpenElement(160, "div");
                __builder2.AddAttribute(161, "class", "row");
                __builder2.AddMarkupContent(162, "\r\n                                    ");
                __builder2.AddMarkupContent(163, "<div class=\"col-4\">\r\n                                        Role Farsi Name\r\n                                    </div>\r\n                                    ");
                __builder2.OpenElement(164, "div");
                __builder2.AddAttribute(165, "class", "col-8");
                __builder2.AddMarkupContent(166, "\r\n                                        ");
                __builder2.OpenElement(167, "div");
                __builder2.AddAttribute(168, "class", "form-group");
                __builder2.AddMarkupContent(169, "\r\n                                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(170);
                __builder2.AddAttribute(171, "class", "form-control");
                __builder2.AddAttribute(172, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 106 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\Pages\Admins\Roles.razor"
                                                                                          _model.FaName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(173, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _model.FaName = __value, _model.FaName))));
                __builder2.AddAttribute(174, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _model.FaName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(175, "\r\n                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(176, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(177, "\r\n\r\n                                    <div class=\"col-4\"></div>\r\n                                    ");
                __builder2.OpenElement(178, "div");
                __builder2.AddAttribute(179, "class", "col-8");
                __Blazor.BlazorRoleAndUserManager.Pages.Admins.Roles.TypeInference.CreateValidationMessage_1(__builder2, 180, 181, 
#nullable restore
#line 111 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\Pages\Admins\Roles.razor"
                                                                                 ()=> _model.FaName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(182, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(183, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(184, "\r\n\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(185, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(186, "\r\n                    ");
                __builder2.OpenElement(187, "div");
                __builder2.AddAttribute(188, "class", "modal-footer");
                __builder2.AddMarkupContent(189, "\r\n                        ");
                __builder2.AddMarkupContent(190, "<button type=\"submit\" class=\"btn btn-success\" data-dismiss=\"modal\">\r\n                            <span aria-hidden=\"true\">save</span>\r\n                        </button>\r\n                        ");
                __builder2.OpenElement(191, "button");
                __builder2.AddAttribute(192, "type", "button");
                __builder2.AddAttribute(193, "class", "btn btn-light");
                __builder2.AddAttribute(194, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 121 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\Pages\Admins\Roles.razor"
                                                                              close

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(195, "\r\n                            ");
                __builder2.AddMarkupContent(196, "<span aria-hidden=\"true\">close</span>\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(197, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(198, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(199, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(200, "\r\n\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(201, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(202, "\r\n");
#nullable restore
#line 130 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\Pages\Admins\Roles.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 132 "C:\Users\k.salahshoor\Desktop\XXX\BlazorRoleAndUserManager\Pages\Admins\Roles.razor"
       
    private RoleManager<AppRole> _roleManager => Service;

    [Inject] private IJSRuntime _js { get; set; }
    [Inject] private NavigationManager _navigationManager { get; set; }

    List<AppRole> _items;
    RoleViewModel _model;
    private bool _show;
    private List<string> _serverSideErrors = new List<string>();

    protected override async Task OnInitializedAsync()
    {
        _items = await _roleManager.Roles.ToListAsync();
    }

    private async Task validsubmit()
    {
        _serverSideErrors.Clear();

        if (!string.IsNullOrEmpty(_model.Name) && !string.IsNullOrEmpty(_model.FaName))
        {
            _show = false;

            IdentityResult result;

            if (_model.Id == null)
            {
                result = await _roleManager.CreateAsync(new AppRole(_model.Name, _model.FaName));
            }
            else
            {
                var itemToUpdate = await _roleManager.Roles.SingleAsync(x => x.Id == _model.Id);
                itemToUpdate.Name = _model.Name;
                itemToUpdate.FaName = _model.FaName;
                result = await _roleManager.UpdateAsync(itemToUpdate);
            }

            if (result.Succeeded)
            {
                //saved
                await _js.InvokeVoidAsync("alert", "Data saved");

                _items = await _roleManager.Roles.ToListAsync();
            }
            else
            {
                foreach (IdentityError err in result.Errors)
                {
                    _serverSideErrors.Add(err.Description);
                }

                //error
                await _js.InvokeVoidAsync("alert", "Error saving data");
            }
        }
        else
        {
            _serverSideErrors.Add("Please fill in all fields");

            //error
            await _js.InvokeVoidAsync("alert", "Please fill in all fields");
        }
    }

    private void add()
    {
        _serverSideErrors.Clear();

        _model = new RoleViewModel();

        _show = true;
    }

    private void edit(AppRole model)
    {
        _serverSideErrors.Clear();

        _model = new RoleViewModel { Id = model.Id, Name = model.Name, FaName = model.FaName };

        _show = true;
    }

    private async Task delete(AppRole model)
    {
        _serverSideErrors.Clear();

        if (await _js.InvokeAsync<bool>("confirm", "Are absolutely you sure you want to delete this item?"))
        {
            _model = null;
            var result = await _roleManager.DeleteAsync(model);
            if (result.Succeeded)
            {
                //saved
                await _js.InvokeVoidAsync("alert", "Data saved");

                _items = await _roleManager.Roles.ToListAsync();
            }
            else
            {
                foreach (IdentityError err in result.Errors)
                {
                    _serverSideErrors.Add(err.Description);
                }

                //error
                await _js.InvokeVoidAsync("alert", "Error deleting data");
            }
        }

    }

    private void accessRights(AppRole model)
    {
        _navigationManager.NavigateTo($"/accessrights/role/{model.Id}");
    }

    private void close()
    {
        _show = false;
    }

    private class RoleViewModel
    {
        public string Id { get; set; }
        [Display(Name = "نام لاتین")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمائید")]
        public string Name { get; set; }
        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمائید")]
        public string FaName { get; set; }
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorRoleAndUserManager.Pages.Admins.Roles
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
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\0\source\repos\Сайт\Сайт\Goods\Godox_ad1200(1).razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d214cd34fc3074a9abce93df341d72ec003a08e"
// <auto-generated/>
#pragma warning disable 1591
namespace Сайт.Goods
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\0\source\repos\Сайт\Сайт\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\0\source\repos\Сайт\Сайт\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\0\source\repos\Сайт\Сайт\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\0\source\repos\Сайт\Сайт\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\0\source\repos\Сайт\Сайт\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\0\source\repos\Сайт\Сайт\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\0\source\repos\Сайт\Сайт\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\0\source\repos\Сайт\Сайт\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\0\source\repos\Сайт\Сайт\_Imports.razor"
using Сайт;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\0\source\repos\Сайт\Сайт\_Imports.razor"
using Сайт.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\0\source\repos\Сайт\Сайт\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\0\source\repos\Сайт\Сайт\_Imports.razor"
using Сайт.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\0\source\repos\Сайт\Сайт\Goods\Godox_ad1200(1).razor"
using Сайт.Goodsbuttom;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Good")]
    public partial class Godox_ad1200_1_ : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "html");
            __builder.OpenElement(1, "body");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "page-wrapper fhg-content");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container page-inner ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "breadcrumb-wrapper");
#nullable restore
#line 13 "C:\Users\0\source\repos\Сайт\Сайт\Goods\Godox_ad1200(1).razor"
                 if (good2.Subcategory == "импульсный свет" || good2.Subcategory == "постоянный свет")
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "ul");
            __builder.AddAttribute(9, "class", "breadcrumb1");
            __builder.AddMarkupContent(10, "<li class=\"breadcrumb-item home\"><a class=\"breadcrumb-link\" title=\"Главная\" href=\"/\"><i class=\"fa fa-home\"></i></a></li>\r\n                        ");
            __builder.AddMarkupContent(11, "<li class=\"breadcrumb-item\"><a class=\"breadcrumb-link\" title=\"Каталог\" href=\"/Catalog\">Каталог</a></li>\r\n                        ");
            __builder.AddMarkupContent(12, "<li class=\"breadcrumb-item\"><a class=\"breadcrumb-link\" title=\"Световые приборы\" href=\"/Light\">Световые приборы</a></li>\r\n                        ");
            __builder.OpenElement(13, "li");
            __builder.AddAttribute(14, "class", "breadcrumb-item");
            __builder.OpenElement(15, "span");
            __builder.AddAttribute(16, "class", "breadcrumb-link current-page");
            __builder.AddContent(17, 
#nullable restore
#line 26 "C:\Users\0\source\repos\Сайт\Сайт\Goods\Godox_ad1200(1).razor"
                                                                        good2.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Users\0\source\repos\Сайт\Сайт\Goods\Godox_ad1200(1).razor"
                }
                else if (good2.Subcategory == "беззеркалки")
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "ul");
            __builder.AddAttribute(19, "class", "breadcrumb1");
            __builder.AddMarkupContent(20, "<li class=\"breadcrumb-item home\"><a class=\"breadcrumb-link\" title=\"Главная\" href=\"/\"><i class=\"fa fa-home\"></i></a></li>\r\n                        ");
            __builder.AddMarkupContent(21, "<li class=\"breadcrumb-item\"><a class=\"breadcrumb-link\" title=\"Каталог\" href=\"/Catalog\">Каталог</a></li>\r\n                        ");
            __builder.AddMarkupContent(22, "<li class=\"breadcrumb-item\"><a class=\"breadcrumb-link\" title=\"Фотоаппараты\" href=\"/Ph\">Фотоаппараты</a></li>\r\n                        ");
            __builder.AddMarkupContent(23, "<li class=\"breadcrumb-item\"><a class=\"breadcrumb-link\" title=\"Бз\" href=\"/Phwithoutmirror\">Беззеркальные</a></li>\r\n                        ");
            __builder.OpenElement(24, "li");
            __builder.AddAttribute(25, "class", "breadcrumb-item");
            __builder.OpenElement(26, "span");
            __builder.AddAttribute(27, "class", "breadcrumb-link current-page");
            __builder.AddContent(28, 
#nullable restore
#line 46 "C:\Users\0\source\repos\Сайт\Сайт\Goods\Godox_ad1200(1).razor"
                                                                        good2.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 49 "C:\Users\0\source\repos\Сайт\Сайт\Goods\Godox_ad1200(1).razor"
                }
                else if (good2.Subcategory == "зеркалки")
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(29, "ul");
            __builder.AddAttribute(30, "class", "breadcrumb1");
            __builder.AddMarkupContent(31, "<li class=\"breadcrumb-item home\"><a class=\"breadcrumb-link\" title=\"Главная\" href=\"/\"><i class=\"fa fa-home\"></i></a></li>\r\n                        ");
            __builder.AddMarkupContent(32, "<li class=\"breadcrumb-item\"><a class=\"breadcrumb-link\" title=\"Каталог\" href=\"/Catalog\">Каталог</a></li>\r\n                        ");
            __builder.AddMarkupContent(33, "<li class=\"breadcrumb-item\"><a class=\"breadcrumb-link\" title=\"Фотоаппараты\" href=\"/Ph\">Фотоаппараты</a></li>\r\n                        ");
            __builder.AddMarkupContent(34, "<li class=\"breadcrumb-item\"><a class=\"breadcrumb-link\" title=\"Бз\" href=\"/Phwithmirror\">Зеркальные</a></li>\r\n                        ");
            __builder.OpenElement(35, "li");
            __builder.AddAttribute(36, "class", "breadcrumb-item");
            __builder.OpenElement(37, "span");
            __builder.AddAttribute(38, "class", "breadcrumb-link current-page");
            __builder.AddContent(39, 
#nullable restore
#line 66 "C:\Users\0\source\repos\Сайт\Сайт\Goods\Godox_ad1200(1).razor"
                                                                        good2.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 69 "C:\Users\0\source\repos\Сайт\Сайт\Goods\Godox_ad1200(1).razor"
                }
                else if (good2.Subcategory == "fullframe" || good2.Subcategory == "apsc")
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(40, "ul");
            __builder.AddAttribute(41, "class", "breadcrumb1");
            __builder.AddMarkupContent(42, "<li class=\"breadcrumb-item home\"><a class=\"breadcrumb-link\" title=\"Главная\" href=\"/\"><i class=\"fa fa-home\"></i></a></li>\r\n                        ");
            __builder.AddMarkupContent(43, "<li class=\"breadcrumb-item\"><a class=\"breadcrumb-link\" title=\"Каталог\" href=\"/Catalog\">Каталог</a></li>\r\n                        ");
            __builder.AddMarkupContent(44, "<li class=\"breadcrumb-item\"><a class=\"breadcrumb-link\" title=\"Световые приборы\" href=\"/Lens\">Объективы</a></li>\r\n                        ");
            __builder.OpenElement(45, "li");
            __builder.AddAttribute(46, "class", "breadcrumb-item");
            __builder.OpenElement(47, "span");
            __builder.AddAttribute(48, "class", "breadcrumb-link current-page");
            __builder.AddContent(49, 
#nullable restore
#line 83 "C:\Users\0\source\repos\Сайт\Сайт\Goods\Godox_ad1200(1).razor"
                                                                        good2.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 86 "C:\Users\0\source\repos\Сайт\Сайт\Goods\Godox_ad1200(1).razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(50, "ul");
            __builder.AddAttribute(51, "class", "breadcrumb1");
            __builder.AddMarkupContent(52, "<li class=\"breadcrumb-item home\"><a class=\"breadcrumb-link\" title=\"Главная\" href=\"/\"><i class=\"fa fa-home\"></i></a></li>\r\n                        ");
            __builder.AddMarkupContent(53, "<li class=\"breadcrumb-item\"><a class=\"breadcrumb-link\" title=\"Каталог\" href=\"/Catalog\">Каталог</a></li>\r\n                        ");
            __builder.OpenElement(54, "li");
            __builder.AddAttribute(55, "class", "breadcrumb-item");
            __builder.OpenElement(56, "span");
            __builder.AddAttribute(57, "class", "breadcrumb-link current-page");
            __builder.AddContent(58, 
#nullable restore
#line 97 "C:\Users\0\source\repos\Сайт\Сайт\Goods\Godox_ad1200(1).razor"
                                                                        good2.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 100 "C:\Users\0\source\repos\Сайт\Сайт\Goods\Godox_ad1200(1).razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(59, " \r\n\r\n            ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "decorated-title-wrapper");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "decorated-title");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "page-header-wrapper");
            __builder.OpenElement(66, "h1");
            __builder.AddAttribute(67, "class", "page-header");
            __builder.AddContent(68, 
#nullable restore
#line 108 "C:\Users\0\source\repos\Сайт\Сайт\Goods\Godox_ad1200(1).razor"
                             good2.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(69, " \r\n            ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "row");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "product-gallery-wrapper cell-5 cell-12-sm");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "id", "carouselExampleIndicators");
            __builder.AddAttribute(76, "class", "carousel slide");
            __builder.AddAttribute(77, "data-bs-ride", "carousel");
            __builder.AddAttribute(78, "style", "background-color:black;");
            __builder.AddMarkupContent(79, @"<div class=""carousel-indicators""><button type=""button"" data-bs-target=""#carouselExampleIndicators"" data-bs-slide-to=""0"" class=""active"" aria-current=""true"" aria-label=""Slide 1""></button>
                            <button type=""button"" data-bs-target=""#carouselExampleIndicators"" data-bs-slide-to=""1"" aria-label=""Slide 2""></button>
                            <button type=""button"" data-bs-target=""#carouselExampleIndicators"" data-bs-slide-to=""2"" aria-label=""Slide 3""></button></div>
                        ");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "carousel-inner");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "carousel-item");
            __builder.OpenElement(84, "img");
            __builder.AddAttribute(85, "src", 
#nullable restore
#line 123 "C:\Users\0\source\repos\Сайт\Сайт\Goods\Godox_ad1200(1).razor"
                                           good2.Picture

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(86, "class", "d-block w-100");
            __builder.AddAttribute(87, "alt", "...");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                            ");
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "class", "carousel-item active");
            __builder.OpenElement(91, "img");
            __builder.AddAttribute(92, "src", 
#nullable restore
#line 126 "C:\Users\0\source\repos\Сайт\Сайт\Goods\Godox_ad1200(1).razor"
                                           good2.Picture2

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(93, "class", "d-block w-100");
            __builder.AddAttribute(94, "alt", "...");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n                            ");
            __builder.OpenElement(96, "div");
            __builder.AddAttribute(97, "class", "carousel-item");
            __builder.OpenElement(98, "img");
            __builder.AddAttribute(99, "src", 
#nullable restore
#line 129 "C:\Users\0\source\repos\Сайт\Сайт\Goods\Godox_ad1200(1).razor"
                                           good2.Picture3

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(100, "class", "d-block w-100");
            __builder.AddAttribute(101, "alt", "...");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                        ");
            __builder.AddMarkupContent(103, "<button class=\"carousel-control-prev\" type=\"button\" data-bs-target=\"#carouselExampleIndicators\" data-bs-slide=\"prev\"><span class=\"carousel-control-prev-icon\" aria-hidden=\"true\"></span></button>\r\n                        ");
            __builder.AddMarkupContent(104, "<button class=\"carousel-control-next\" type=\"button\" data-bs-target=\"#carouselExampleIndicators\" data-bs-slide=\"next\"><span class=\"carousel-control-next-icon\" aria-hidden=\"true\"></span></button>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n                \r\n\r\n                ");
            __builder.OpenElement(106, "div");
            __builder.AddAttribute(107, "class", "product-content-wrapper cell-7 cell-12-sm");
            __builder.OpenElement(108, "div");
            __builder.AddAttribute(109, "class", "product-introtext on-page editor");
            __builder.AddContent(110, 
#nullable restore
#line 144 "C:\Users\0\source\repos\Сайт\Сайт\Goods\Godox_ad1200(1).razor"
                         good2.P1

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n\r\n                    ");
            __builder.OpenElement(112, "form");
            __builder.AddAttribute(113, "class", "product-form");
            __builder.OpenElement(114, "div");
            __builder.AddAttribute(115, "class", "product-sku-wrapper ");
            __builder.AddMarkupContent(116, "<span>Артикул:</span>\r\n                            ");
            __builder.OpenElement(117, "span");
            __builder.AddContent(118, 
#nullable restore
#line 151 "C:\Users\0\source\repos\Сайт\Сайт\Goods\Godox_ad1200(1).razor"
                                   good2.Idgood

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n\r\n                        ");
            __builder.OpenElement(120, "div");
            __builder.AddAttribute(121, "class", "product-prices on-page");
            __builder.OpenElement(122, "div");
            __builder.AddAttribute(123, "class", "price js-product-price on-page");
            __builder.AddContent(124, 
#nullable restore
#line 155 "C:\Users\0\source\repos\Сайт\Сайт\Goods\Godox_ad1200(1).razor"
                                                                         good2.Price

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(125, "&nbsp;руб");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n                            <div class=\"old-price  on-page\"></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n\r\n                        ");
            __builder.OpenElement(128, "div");
            __builder.AddAttribute(129, "class", "product-control on-page");
            __builder.OpenElement(130, "div");
            __builder.AddAttribute(131, "class", "counter");
            __builder.AddAttribute(132, "data-quantity");
            __builder.AddAttribute(133, "data-quantity-change-init", "true");
            __builder.AddAttribute(134, "style");
            __builder.OpenElement(135, "button");
            __builder.AddAttribute(136, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 163 "C:\Users\0\source\repos\Сайт\Сайт\Goods\Godox_ad1200(1).razor"
                                                  down

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(137, "type", "button");
            __builder.AddAttribute(138, "class", "counter-button button count-down");
            __builder.AddMarkupContent(139, "<i class=\"icon fa fa-minus\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n\r\n                                ");
            __builder.OpenElement(141, "input");
            __builder.AddAttribute(142, "type", "text");
            __builder.AddAttribute(143, "value", 
#nullable restore
#line 167 "C:\Users\0\source\repos\Сайт\Сайт\Goods\Godox_ad1200(1).razor"
                                                           quantity

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(144, "min", "1");
            __builder.AddAttribute(145, "max", "1000");
            __builder.AddAttribute(146, "name", "quantity");
            __builder.AddAttribute(147, "class", "counter-input input-number input-field");
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\r\n\r\n                                ");
            __builder.OpenElement(149, "button");
            __builder.AddAttribute(150, "type", "button");
            __builder.AddAttribute(151, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 169 "C:\Users\0\source\repos\Сайт\Сайт\Goods\Godox_ad1200(1).razor"
                                                                up

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(152, "data-quantity-change", "1");
            __builder.AddAttribute(153, "class", "counter-button button count-up");
            __builder.AddMarkupContent(154, "<i class=\"icon fa fa-plus\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(155, " \r\n\r\n                            ");
            __builder.OpenElement(156, "div");
            __builder.AddAttribute(157, "class", "buy");
            __builder.OpenElement(158, "div");
            __builder.AddAttribute(159, "class", "product-order-variant variant-shown");
            __builder.OpenElement(160, "button");
            __builder.AddAttribute(161, "class", "product-button button is-primary");
            __builder.AddAttribute(162, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 176 "C:\Users\0\source\repos\Сайт\Сайт\Goods\Godox_ad1200(1).razor"
                                                                                               tocart

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(163, "type", "button");
            __builder.AddMarkupContent(164, "<i class=\"icon buy-icon fa fa-shopping-cart\"></i>\r\n                                        ");
            __builder.AddMarkupContent(165, "<span class=\"button-text\">В корзину</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 183 "C:\Users\0\source\repos\Сайт\Сайт\Goods\Godox_ad1200(1).razor"
                             if (warning == 2)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(166, "<span class=\"button-text\" style=\"color:red\">Данный товар уже есть в корзине!</span>");
#nullable restore
#line 186 "C:\Users\0\source\repos\Сайт\Сайт\Goods\Godox_ad1200(1).razor"
                            } 

#line default
#line hidden
#nullable disable
#nullable restore
#line 187 "C:\Users\0\source\repos\Сайт\Сайт\Goods\Godox_ad1200(1).razor"
                             if(warning == 1)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(167, "<span class=\"button-text\" style=\"color:green\">Товар добавлен в корзину</span>");
#nullable restore
#line 190 "C:\Users\0\source\repos\Сайт\Сайт\Goods\Godox_ad1200(1).razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(168, "\r\n\r\n                ");
            __builder.OpenElement(169, "div");
            __builder.AddAttribute(170, "class", "cell-12");
            __builder.OpenElement(171, "div");
            __builder.AddAttribute(172, "class", "product-content");
            __builder.AddMarkupContent(173, @"<div class=""tabs-menu-wrapper""><ul class=""tabs-menu product-tabs-list""><button class=""tabs-menu-item tabs-menu-link is-active tablinks"" onclick=""openMenu(event, 'About')"" id=""defaultOpen"">Описание</button>
                                <button class=""tabs-menu-item tabs-menu-link tablinks"" onclick=""openMenu(event, 'Har')"" id=""defaultOpen"">Характеристики</button></ul></div>


                        ");
            __builder.OpenElement(174, "div");
            __builder.AddAttribute(175, "class", "tabs-list product-tabs-list");
            __builder.OpenElement(176, "div");
            __builder.AddAttribute(177, "class", "tab-block tabcontent is-active");
            __builder.AddAttribute(178, "id", "About");
            __builder.OpenElement(179, "div");
            __builder.AddAttribute(180, "class", "editor");
            __builder.OpenElement(181, "p");
            __builder.OpenElement(182, "span");
            __builder.AddContent(183, 
#nullable restore
#line 213 "C:\Users\0\source\repos\Сайт\Сайт\Goods\Godox_ad1200(1).razor"
                                              good2.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(184, "\r\n                                    ");
            __builder.OpenElement(185, "p");
            __builder.OpenElement(186, "span");
            __builder.AddMarkupContent(187, "<br>");
            __builder.AddContent(188, 
#nullable restore
#line 214 "C:\Users\0\source\repos\Сайт\Сайт\Goods\Godox_ad1200(1).razor"
                                                  good2.P2

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(189, "\r\n                                    ");
            __builder.OpenElement(190, "p");
            __builder.AddContent(191, 
#nullable restore
#line 215 "C:\Users\0\source\repos\Сайт\Сайт\Goods\Godox_ad1200(1).razor"
                                        good2.P3

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(192, "\r\n\r\n                            ");
            __builder.OpenElement(193, "div");
            __builder.AddAttribute(194, "id", "Har");
            __builder.AddAttribute(195, "class", "tab-block tabcontent is-closed");
            __builder.OpenElement(196, "div");
            __builder.AddAttribute(197, "class", "editor");
            __builder.OpenElement(198, "table");
            __builder.AddAttribute(199, "class", " table-bordered table-striped table-hover");
            __builder.OpenElement(200, "tbody");
            __builder.OpenElement(201, "tr");
            __builder.AddMarkupContent(202, "<td>Длина</td>\r\n                                                ");
            __builder.OpenElement(203, "td");
            __builder.AddContent(204, 
#nullable restore
#line 226 "C:\Users\0\source\repos\Сайт\Сайт\Goods\Godox_ad1200(1).razor"
                                                     good2.Length

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(205, ", сантиметров\r\n                                                ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(206, "\r\n                                            ");
            __builder.OpenElement(207, "tr");
            __builder.AddMarkupContent(208, "<td>Ширина</td>\r\n                                                ");
            __builder.OpenElement(209, "td");
            __builder.AddContent(210, 
#nullable restore
#line 232 "C:\Users\0\source\repos\Сайт\Сайт\Goods\Godox_ad1200(1).razor"
                                                     good2.Width

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(211, ", сантиметров\r\n                                                ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(212, "\r\n                                            ");
            __builder.OpenElement(213, "tr");
            __builder.AddMarkupContent(214, "<td>Высота</td>\r\n                                                ");
            __builder.OpenElement(215, "td");
            __builder.AddContent(216, 
#nullable restore
#line 238 "C:\Users\0\source\repos\Сайт\Сайт\Goods\Godox_ad1200(1).razor"
                                                     good2.Height

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(217, ", сантиметров\r\n                                                ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(218, "\r\n                                            ");
            __builder.OpenElement(219, "tr");
            __builder.AddMarkupContent(220, "<td>Вес</td>\r\n                                                ");
            __builder.OpenElement(221, "td");
            __builder.AddContent(222, 
#nullable restore
#line 244 "C:\Users\0\source\repos\Сайт\Сайт\Goods\Godox_ad1200(1).razor"
                                                     good2.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(223, ", грамм\r\n                                                ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(224, "\r\n                                            ");
            __builder.OpenElement(225, "tr");
            __builder.AddMarkupContent(226, "<td>Гарантия</td>\r\n                                                ");
            __builder.OpenElement(227, "td");
            __builder.AddContent(228, 
#nullable restore
#line 250 "C:\Users\0\source\repos\Сайт\Сайт\Goods\Godox_ad1200(1).razor"
                                                     good2.Guarantee

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(229, ", месяцев\r\n                                                ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 272 "C:\Users\0\source\repos\Сайт\Сайт\Goods\Godox_ad1200(1).razor"
 
    int warning;
    public IList<Good> good;
    public static List<Good> addcart = new List<Good>();
    public static List<Good> addcartqu = new List<Good>();
    int quantity = 1;
    int qu = 1;
    Good good2;
    string pic, pic1, pic2, name, subcat, cat;
    int arc, guarantee;
    double price, weight, height, lenght, width;
    protected override async Task OnInitializedAsync()
    {
        good = Pages.Main.good;
        foreach (var i in good)
        {
            if (i.Idgood == Catalog.idTovar)
            {
                good2 = i;
                Catalog.idTovar = -1;
                break;
            }

            if (i.Idgood == Light.idTovar)
            {
                good2 = i;
                Light.idTovar = -1;
                break;
            }

            if (i.Idgood == Lens.idTovar)
            {
                good2 = i;
                Lens.idTovar = -1;
                break;
            }


            if (i.Idgood == Ph.idTovar)
            {
                good2 = i;
                Ph.idTovar = -1;
                break;
            }

            if (i.Idgood == Phwithmirror.idTovar)
            {
                good2 = i;
                Phwithmirror.idTovar = -1;
                break;
            }

            if (i.Idgood == Phwithoutmirror.idTovar)
            {
                good2 = i;
                Phwithoutmirror.idTovar = -1;
                break;
            }

            if (i.Idgood == Pages.Main.idTovar)
            {
                good2 = i;
                Pages.Main.idTovar = -1;
                break;
            }
        }
    }


    void down()
    {
        if (quantity == 1)
        {

        }
        else
        {
            quantity--;
            qu = quantity;
        }
    }

    void up()
    {
        //good =  Service.GetGoods();
        foreach (var i in good)
        {
            if (i.Name == good2.Name)
            {
                if (quantity < good2.Quantity)
                {
                    quantity++;
                    qu = quantity;
                }
                else
                {
                }
            }
        }
    }

    void tocart()
    {
        var match = Header.addcart.FirstOrDefault(p => p.Name == good2.Name);
        if (match == null)
        {
            warning = 1;
            Header.addcart.Add(good2);
            Header.addcartqu.Add(qu);
        }
        else
        {
            warning = 2;
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private GoodService Service { get; set; }
    }
}
#pragma warning restore 1591

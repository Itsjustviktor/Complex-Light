#pragma checksum "C:\Users\0\source\repos\Сайт\Сайт\Goodsbuttom\Phwithmirror.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe1aea5aeaa023204797962691e01dcdd4ddcdde"
// <auto-generated/>
#pragma warning disable 1591
namespace Сайт.Goodsbuttom
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Phwithmirror")]
    public partial class Phwithmirror : Microsoft.AspNetCore.Components.ComponentBase
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
            __builder.AddMarkupContent(6, @"<div class=""breadcrumb-wrapper""><ul class=""breadcrumb1""><li class=""breadcrumb-item home""><a class=""breadcrumb-link"" title=""Главная"" href=""/""><i class=""fa fa-home""></i></a></li>

                    <li class=""breadcrumb-item""><a class=""breadcrumb-link"" title=""Каталог"" href=""/Catalog"">Каталог</a></li>

                    <li class=""breadcrumb-item""><a class=""breadcrumb-link"" title=""Каталог"" href=""/Ph"">Фотоаппараты</a></li>

                    <li class=""breadcrumb-item""><span class=""breadcrumb-link current-page"">Зеркальные</span></li></ul></div> 
            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
            __builder.AddMarkupContent(9, @"<div class=""page-sidebar cell-3 cell-4-md hide-sm""><div class=""collection-menu-wrapper sidebar-block""><div class=""collection-menu-header sidebar-block-header"">
                            Каталог
                        </div>
                        <ul class=""collection-menu menu level-1""><li class=""collection-menu-item menu-item level-1 is-active""><a href=""/Ph"" class=""collection-menu-link menu-link level-1"">Фотоаппараты</a>
                                <ul class=""collection-menu menu level-2""><li class=""collection-menu-item menu-item level-2  is-current"">
                                        —<a href=""/Phwithmirror"" class=""collection-menu-link menu-link level-2"">Зеркальные</a></li>

                                    <li class=""collection-menu-item menu-item level-2 "">
                                        —<a href=""/Phwithoutmirror"" class=""collection-menu-link menu-link level-2"">Беззеркальные</a></li></ul></li>
                            <li class=""collection-menu-item menu-item level-1 ""><a href=""/Lens"" class=""collection-menu-link menu-link level-1"">Объективы</a></li>

                            <li class=""collection-menu-item menu-item level-1""><a href=""/Light"" class=""collection-menu-link menu-link level-1"">Световые приборы</a></li></ul></div></div>

                ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "page-content cell-9 cell-8-md cell-12-sm");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "decorated-title-wrapper");
            __builder.AddMarkupContent(14, "<div class=\"decorated-title\"><div class=\"page-header-wrapper\"><h1 class=\"page-header\">\r\n                                    Зеркальные фотоаппараты\r\n                                </h1></div></div>\r\n                        \r\n\r\n                        ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "collection-toolbar is-top");
            __builder.AddMarkupContent(17, "<button type=\"button\" class=\"button hide show-sm is-primary\" data-type=\"panel\">Фильтр</button>\r\n                            ");
            __builder.OpenElement(18, "form");
            __builder.AddAttribute(19, "class", "collection-order-wrapper ");
            __builder.AddAttribute(20, "action", "/collection/noutbuki");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "collection-order is-order  ");
            __builder.AddMarkupContent(23, "<label class=\"label-field hide\">Сортировка</label>\r\n\r\n                                    ");
            __builder.OpenElement(24, "select");
            __builder.AddAttribute(25, "class", "select-field");
            __builder.AddAttribute(26, "name", "order");
            __builder.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 94 "C:\Users\0\source\repos\Сайт\Сайт\Goodsbuttom\Phwithmirror.razor"
                                                                                         sort

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(28, "option");
            __builder.AddAttribute(29, "value");
            __builder.AddMarkupContent(30, "Сортировка");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                                        ");
            __builder.OpenElement(32, "option");
            __builder.AddAttribute(33, "value", "price");
            __builder.AddMarkupContent(34, "По возрастанию цены");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                                        ");
            __builder.OpenElement(36, "option");
            __builder.AddAttribute(37, "value", "descending_price");
            __builder.AddMarkupContent(38, "По убыванию цены");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n\r\n\r\n                    ");
            __builder.AddMarkupContent(40, @"<div class=""collection-description at-top content editor""><p><img src=""https://i.imgur.com/CFLOQGS.jpg"" alt></p>
                        <p><span style=""font-size: 12pt;"">Купить зеркальный фотоаппарат очень просто: достаточно оформить заказ онлайн. Консультанты нашего магазина всегда готовы прийти Вам на помощь – воспользовавшись их советами, Вы сможете выбрать для себя подходящий  зеркальный фотоаппарат.<br></span></p></div>
                    


                    ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "products-list row");
#nullable restore
#line 117 "C:\Users\0\source\repos\Сайт\Сайт\Goodsbuttom\Phwithmirror.razor"
                         foreach (var i in sortedgood)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "product-card-wrapper cell-4 cell-6-md cell-12-mc");
            __builder.OpenElement(45, "a");
            __builder.AddAttribute(46, "class", "product-card product-link");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 120 "C:\Users\0\source\repos\Сайт\Сайт\Goodsbuttom\Phwithmirror.razor"
                                                                           (()=>namesend(i.Idgood))

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "card-inner ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "product-photo");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "product-link image-container is-square ");
            __builder.OpenElement(54, "img");
            __builder.AddAttribute(55, "src", 
#nullable restore
#line 124 "C:\Users\0\source\repos\Сайт\Сайт\Goodsbuttom\Phwithmirror.razor"
                                                       i.Picture

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(56, "alt");
            __builder.AddAttribute(57, "title");
            __builder.AddAttribute(58, "class", "product-image");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                                        ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "product-prices in-card");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "price in-card");
            __builder.AddContent(64, 
#nullable restore
#line 128 "C:\Users\0\source\repos\Сайт\Сайт\Goodsbuttom\Phwithmirror.razor"
                                                 i.Price

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(65, "&nbsp;руб\r\n                                            ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                                    ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "product-caption product-link");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "product-title in-card");
            __builder.AddContent(71, 
#nullable restore
#line 134 "C:\Users\0\source\repos\Сайт\Сайт\Goodsbuttom\Phwithmirror.razor"
                                             i.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 140 "C:\Users\0\source\repos\Сайт\Сайт\Goodsbuttom\Phwithmirror.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n\r\n}");
        }
        #pragma warning restore 1998
#nullable restore
#line 152 "C:\Users\0\source\repos\Сайт\Сайт\Goodsbuttom\Phwithmirror.razor"
       
    string name;
    string pic;
    double price;
    public IList<Good> good;
    public List<Good> sortedgood = new List<Good>();
    public static int idTovar;
    private void namesend(int id)
    {
        idTovar = id;
        NavigationManager.NavigateTo("/Good");
    }
    protected override async Task OnInitializedAsync()
    {
        good = await Service.GetGoods();
        foreach (var i in good)
        {
            if (i.Subcategory == "зеркалки" && i.Quantity >= 1)
            {
                sortedgood.Add(i);
            }
        }
    }
    private void sort(ChangeEventArgs eventArgs)
    {
        Console.WriteLine(eventArgs.Value.ToString());
        if (eventArgs.Value.ToString() == "price")
        {
            sortedgood = sortedgood.OrderBy(C => C.Price).ToList();
            Console.WriteLine("зашел в прайс");
        }
        if (eventArgs.Value.ToString() == "descending_price")
        {
            sortedgood = sortedgood.OrderByDescending(C => C.Price).ToList();
            Console.WriteLine("зашел в дпрайс");
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

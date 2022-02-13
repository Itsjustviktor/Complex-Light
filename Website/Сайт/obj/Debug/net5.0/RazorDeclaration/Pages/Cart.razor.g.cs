// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Сайт.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Cart")]
    public partial class Cart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 206 "C:\Users\0\source\repos\Сайт\Сайт\Pages\Cart.razor"
       
        string adress = "г. Киров, ул. Чапаева, дом 10, офис 201";
        string email;
        string name, name2, name3, phone;
        int count = 0;
        int idbuyer;
        int change = 1;
        double summ = 0;
        double dost = 0;
        double all;
    public IList<Buyer> buyer;

    protected override async Task OnInitializedAsync()
    {
        email = await oLocalStore.GetItemAsync<string>("MySessionValue");
        buyer = await Service.GetBuyer();
        foreach (var i in buyer)
        {
            if (i.Emailbuyer == email)
            {
                name = i.First;
                name2 = i.Second;
                name3 = i.Third;
                phone = i.Telephonebuyer;
                idbuyer = i.Idbuyer;
            }
        }
        count = 0;
        foreach (var i in Header.addcart)
        {
            summ += Convert.ToDouble(i.Price) * Header.addcartqu[count];
            count++;
        }
        all = summ;
        count = 0;
        sendsum();
    } //загрузка информации

    void sendsum()
    {
        Header.changesumm(summ);
        Header.summ = summ;
    } //обновление суммы

    public async void ClearSession()
    {
        Header.addcart.Clear();
        Header.addcartqu.Clear();
        Header.changeemail(null);
        Header.Email = null;
        await oLocalStore.ClearAsync();
        NavigationManager.NavigateTo("/");
    }//очистка сессии

    public void click()
    {
        NavigationManager.NavigateTo("/Auth");
    }
    public void clicktocat()
    {
        NavigationManager.NavigateTo("/Catalog");
    }

    public void clear()
    {
        Header.addcart.Clear();
        Header.addcartqu.Clear();
        summ = 0;
        sendsum();
    } //очистить корзину

    public void office()
    {
        if (dost == 200)
        {
            all = all - dost;
            dost = 0;
            change = 1;
            adress = "г. Киров, ул. Чапаева, дом 10, офис 201";
            sendsum();
        }
        else
        {
            all = summ;
            change = 1;
            adress = "г. Киров, ул. Чапаева, дом 10, офис 201";
            sendsum();
        }
    } //выбор офиса

    public void dostavka()
    {
        dost = 200;
        all = summ + dost;
        change = 2;
        adress = "Россия, г.Киров 610000";
        sendsum();
    } //выбор доставки

    public Order order = new Order();

    public void add()
    {
        if (change == 1)
        {
            order.Status = "Ждет получателя в офисе";
            order.Priceoreder = summ;
            order.Paymentmethod = "Не оплачено";
            order.Takemethod = "Из офиса";
            order.Idbuyer = idbuyer;
            order.Tracknum = "-";
            order.Adress = adress;
            order.Date = DateTime.Now;
            Service1.InsertOrder(order);
        }
        if (change == 2)
        {
            order.Status = "Сбор заказа";
            order.Priceoreder = summ + dost;
            order.Paymentmethod = "Не оплачено";
            order.Takemethod = "Почта России";
            order.Idbuyer = idbuyer;
            order.Tracknum = "-";
            order.Adress = adress;
            order.Date = DateTime.Now;
            Service1.InsertOrder(order);
        } //добавление в таблицу заказ

        int k = 0;
        foreach (var i in Header.addcart)
        {
            Orderedgood orderedgood = new Orderedgood();
            Service2.UpdateGood(i, Header.addcartqu[k]);
            orderedgood.Idgood = i.Idgood;
            orderedgood.Quantityorderedgoods = Header.addcartqu[k];
            orderedgood.Price = i.Price;
            orderedgood.Idorder = order.Idorder;
            Service1.InsertOrderedGood(orderedgood);
            k++;
        } //добавление в таблицу заказанные товары

        clear();
        NavigationManager.NavigateTo("/");
    }

    //private void delete(string a)
    //{
    //    count = 0;
    //    var index = Header.addcart.FindIndex(i => i.Name == a);
    //    Header.addcart.RemoveAt(index);

    //    var index2 = Header.addcartqu.FindIndex(i => i == b);
    //    Header.addcartqu.RemoveAt(index2);

    //}


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private GoodService Service2 { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OrderService Service1 { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserService Service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService oLocalStore { get; set; }
    }
}
#pragma warning restore 1591

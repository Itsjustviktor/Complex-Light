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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Auth")]
    public partial class Auth : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Users\0\source\repos\Сайт\Сайт\Pages\Auth.razor"
       

    string pass;
    string email;
    public static string mailHead;
    string divsuccess = null;
    public List<Buyer> buyer;

    protected override async Task OnInitializedAsync()
    {
        buyer = await Service.GetBuyer();
        email = await oLocalStore.GetItemAsync<string>("MySessionValue");
    }

    private void emailsend(string e)
    {

        Header.Email = e;
        email = e;

    }

    public async void SaveSession()
    {
        await oLocalStore.SetItemAsync("MySessionValue", email);
    }

    public void success()
    {
        Buyer buyer1 = null;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "C:\Users\0\source\repos\Сайт\Сайт\Pages\Auth.razor"
         foreach (var i in buyer)
        {
            if (email == i.Emailbuyer)
            {
                buyer1 = i;
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "C:\Users\0\source\repos\Сайт\Сайт\Pages\Auth.razor"
         

            if (buyer1 == null)
            {
                divsuccess = "";
                divsuccess = "пользователя с таким email не существует";
                return;
            }
            if (buyer1.Password == pass)
            {
                divsuccess = null;
                SaveSession();
                NavigationManager.NavigateTo("/Lk");
                emailsend(buyer1.Emailbuyer);
                return;
            }//авторизация и сохранение сессии

            else
            {
                divsuccess = "";
                divsuccess = "неправильный пароль";
                return;
            }

        }

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService oLocalStore { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserService Service { get; set; }
    }
}
#pragma warning restore 1591

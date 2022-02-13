using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace Сайт.Services
{
    public class UserService
    {
        static IConfiguration conf = (new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build());
        public static string connection = conf["MyValues:ngrok"].ToString();

        protected inetmagazContext dB;
        public UserService()
        {
        }

        public async void InsertUser(Buyer buyer) {
            var contentText = JsonConvert.SerializeObject(buyer);
            var content = new StringContent(contentText, Encoding.UTF8, "application/json");

            HttpClient client = new HttpClient();
            String url = connection;
            HttpResponseMessage responseMessage = await client.PostAsync(url + "/api/user", content);
            string result = await responseMessage.Content.ReadAsStringAsync();
            Console.WriteLine(result);
        } //добавление

        public async Task<List<Buyer>> GetBuyer()
        {
            //var contentText = JsonConvert.SerializeObject();
            var content = new StringContent("", Encoding.UTF8, "application/json");
            HttpClient client = new HttpClient();
            String url = connection;
            HttpResponseMessage responseMessage = await client.PostAsync(url + "/api/getuser", content);
            string result = await responseMessage.Content.ReadAsStringAsync();
            Console.WriteLine(result);
            return JsonConvert.DeserializeObject<List<Buyer>>(result); 


            //using (dB = new inetmagazContext())
            //{
            //    return dB.Buyers.ToList();
            //}
            //
            //return dB.Buyers.ToList();
        }
        public async Task<List<Order>> GetOrder()
        {
            //var contentText = JsonConvert.SerializeObject();
            var content = new StringContent("", Encoding.UTF8, "application/json");
            HttpClient client = new HttpClient();
            String url = connection;
            HttpResponseMessage responseMessage = await client.PostAsync(url + "/api/order", content);
            string result = await responseMessage.Content.ReadAsStringAsync();
            Console.WriteLine(result);
            return JsonConvert.DeserializeObject<List<Order>>(result);


            //public List<Order> GetOrder()
            //{
            //    using (dB = new inetmagazContext())
            //    {
            //        return dB.Orders.ToList();
            //    }
            //}
        }


    }


}

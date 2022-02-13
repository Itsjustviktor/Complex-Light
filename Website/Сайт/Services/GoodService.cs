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
    public class GoodService
    {
        static IConfiguration conf = (new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build());
        public static string connection = conf["MyValues:ngrok"].ToString();

        protected inetmagazContext dB;
        public GoodService()
        {
        }
        //GetIzdelie_spr

        public async Task<List<Good>> GetGoods()
        {
            //var contentText = JsonConvert.SerializeObject();
            var content = new StringContent("", Encoding.UTF8, "application/json");
            HttpClient client = new HttpClient();
            String url = connection;
            HttpResponseMessage responseMessage = await client.PostAsync(url + "/api/good", content);
            string result = await responseMessage.Content.ReadAsStringAsync();
            Console.WriteLine(result);
            return JsonConvert.DeserializeObject<List<Good>>(result);
        }

       /* public List<Good> GetGoods()
        {
            using (dB = new inetmagazContext())
            {
                return dB.Goods.ToList();
            }
        } //возвращает лист гудс*/

        public async Task<string> UpdateGood(Good good, int count)
        {
            good.Quantity -= count;
            var content = new StringContent(JsonConvert.SerializeObject(good), Encoding.UTF8, "application/json");
            HttpClient client = new HttpClient();
            String url = connection;
            HttpResponseMessage responseMessage = await client.PostAsync(url + "/api/updategood", content);
            string result = await responseMessage.Content.ReadAsStringAsync();
            Console.WriteLine(result);
            return result;

           
            //using (dB = new inetmagazContext())
            //{
            //    var updategood = dB.Goods.FirstOrDefault(u => u.Idgood == good.Idgood);
            //    if(updategood.Quantity-count<0)
            //    {
            //        throw new Exception("На складе недостаточно товара");
            //    }
            //    else
            //    {
            //        updategood.Quantity = updategood.Quantity - count;
            //        dB.SaveChanges();
            //        return true;
            //    }
            //}
        } //возвращает лист гудс
    }
}

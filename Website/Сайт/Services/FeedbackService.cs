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
    public class FeedbackService
    {

        protected inetmagazContext dB;
        public FeedbackService()
        {
        }
        //GetIzdelie_spr

        public async Task InsertFeedback(Feedback feedback)
        {
            var contentText = JsonConvert.SerializeObject(feedback);
            var content = new StringContent(contentText, Encoding.UTF8, "application/json");

            HttpClient client = new HttpClient();
            String url = "http://127.0.0.1:9000";
            HttpResponseMessage responseMessage = await client.PostAsync(url + "/feedback", content);
            string result = await responseMessage.Content.ReadAsStringAsync();
            Console.WriteLine(result);
        } //добавление

       /* public bool InsertFeedback(Feedback feedback)
        {
            using (dB = new inetmagazContext())
            {
                dB.Feedbacks.Add(feedback);
                dB.SaveChanges();
                return true;
            }
        }*/
    }
}

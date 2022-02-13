using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Net;
using System.IO;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Xml.Linq;

namespace Сайт.Services
{
    public class OrderService
    {
        static IConfiguration conf = (new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build());
        public static string connection = conf["MyValues:ngrok"].ToString();

        protected inetmagazContext dB;
        public OrderService()
        {
        }

        public static HttpWebRequest CreateWebRequest()
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(connection+"/interation?wsdl");
            webRequest.Headers.Add(@"SOAP:Action");
            webRequest.ContentType = "text/xml;charset=\"utf-8\"";
            webRequest.Accept = "text/xml";
            webRequest.Method = "POST";
            return webRequest;
        }

        public static int idorder;
        public static string AddOrder(Order order)
        {
            HttpWebRequest request = CreateWebRequest();
            XmlDocument soapEnvelopeXml = new XmlDocument();
            soapEnvelopeXml.LoadXml("<soap12:Envelope xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:soap12=\"http://www.w3.org/2003/05/soap-envelope%22%3E\"> <soap12:Body> <createOrder xmlns = \"https://www.w3schools.com/xml/%22%3E\"> <value_json>"+JsonConvert.SerializeObject(order)+"</value_json> </createOrder></soap12:Body></soap12:Envelope>");

            using (Stream stream = request.GetRequestStream())
            {
                soapEnvelopeXml.Save(stream);
            }

            using (WebResponse response = request.GetResponse())
            {
                using (StreamReader rd = new StreamReader(response.GetResponseStream()))
                {
                    string soapResult = rd.ReadToEnd();
                    XmlDocument xml = new XmlDocument();
                    xml.LoadXml(soapResult);
                    XmlNamespaceManager nManager = new XmlNamespaceManager(xml.NameTable);
                    nManager.AddNamespace("soap", "http://schemas.xmlsoap.org/soap/envelope/");
                    nManager.AddNamespace("tns", "http://www.examples.com/wsdl/HelloService.wsdl");
                    string Id = xml.SelectSingleNode("//tns:bmi", nManager).InnerText;
                    idorder = Convert.ToInt32(Id);
                    return soapResult;
                }
            }
        }
        
        public static string AddOrderedGood(Orderedgood orderedgood)
        {
            HttpWebRequest request = CreateWebRequest();
            XmlDocument soapEnvelopeXml = new XmlDocument();
            orderedgood.Idorder = idorder;
            soapEnvelopeXml.LoadXml("<soap12:Envelope xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:soap12=\"http://www.w3.org/2003/05/soap-envelope%22%3E\"><soap12:Body><createOrderedGood xmlns = \"https://www.w3schools.com/xml/%22%3E\"><value_json>"+ JsonConvert.SerializeObject(orderedgood) + "</value_json></createOrderedGood></soap12:Body></soap12:Envelope>");

            using (Stream stream = request.GetRequestStream())
            {
                soapEnvelopeXml.Save(stream);
            }

            using (WebResponse response = request.GetResponse())
            {
                using (StreamReader rd = new StreamReader(response.GetResponseStream()))
                {
                    string soapResult = rd.ReadToEnd();
                    return soapResult;
                }
            }
        }

        public bool InsertOrder(Order order)
        {
            AddOrder(order);
            return true;
        }
        public bool InsertOrderedGood(Orderedgood orderedgood)
        {
            AddOrderedGood(orderedgood);
            return true;
        }

    }
}

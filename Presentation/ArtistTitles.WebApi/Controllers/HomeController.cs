using ArtistTitles.Domain;
using ArtistTitles.WebApi.Models;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Specialized;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Xml;

namespace ArtistTitles.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<CreateArtistTitleDto>> Index()   
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            string url = "https://yastatic.net/market-export/_/partner/help/YML.xml";
            var xmlDoc = new XmlDocument();
            string xmlStr;
            CreateArtistTitleDto tmpClass;

            using (var wc = new WebClient())
            {
                wc.Encoding = Encoding.GetEncoding(1251);
                xmlStr = wc.DownloadString(url);
            }
                xmlDoc.LoadXml(xmlStr);
                var offers = xmlDoc.DocumentElement.SelectNodes("/yml_catalog/shop/offers/offer");

                
                var tmpDict = new Dictionary<string, string> { };

                foreach (XmlNode item in offers)
                {
                    XmlNode attr = item.Attributes.GetNamedItem("id");

                    if (attr != null && attr.Value.ToString() == "12344")
                {
                    foreach (XmlNode item2 in item.ChildNodes)
                        tmpDict.Add(item2.Name, item2.InnerText);

                    tmpDict["offerId"] = attr.Value.ToString();
                }
                                            
                }

                tmpClass = JsonConvert.DeserializeObject<CreateArtistTitleDto>(JsonConvert.SerializeObject(tmpDict));

            var port = this.HttpContext.Connection.LocalPort;

            HttpClient httpClient = new HttpClient();
            using var response = await httpClient.PostAsJsonAsync($"https://localhost:{port}/api/ArtistTitle", tmpClass);
            Guid id_string = await response.Content.ReadFromJsonAsync<Guid>();
            return tmpClass;
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;

namespace FillHerUp
{
    public class CarListReader
    {
        static HttpClient client = new HttpClient();
        public List<Car> Cars { get; }

        public CarListReader()
        {
            Cars = new List<Car>();

            string url = "http://www.rantakallio.fi/fillherup/fillingapi.php?";
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            string path = client.BaseAddress + "action=get_cars";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(path);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string data = string.Empty;


            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;

                if (response.CharacterSet == null)
                {
                    readStream = new StreamReader(receiveStream);
                }
                else
                {
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                }

                data = readStream.ReadToEnd();
                Cars = JsonConvert.DeserializeObject<List<Car>>(data);
                response.Close();
                readStream.Close();
            }
        }
    }
}

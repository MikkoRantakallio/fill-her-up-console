using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace fill_her_up
{
    class FillingListReader
    {
        static HttpClient client = new HttpClient();
        public List<Filling> Fillings { get; }

        public FillingListReader(string carId)
        {
            Fillings = new List<Filling>();

            string url = "http://www.rantakallio.fi/fillherup/fillingapi.php?";
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            string path = client.BaseAddress + "action=get_fillings&id=" + carId.ToUpper();

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
                try
                {
                    Fillings = JsonConvert.DeserializeObject<List<Filling>>(data);
                }
                catch (JsonSerializationException)
                {

                }
                response.Close();
                readStream.Close();
            }
        }
    }
}

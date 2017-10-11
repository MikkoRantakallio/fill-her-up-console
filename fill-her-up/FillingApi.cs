using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FillHerUp
{
    class FillingApi
    {
        static HttpClient client = new HttpClient();
        public Filling fill { get; }

        private string url;

        public FillingApi()
        {
            url = "http://www.rantakallio.fi/fillherup/fillingapi.php?";
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public bool DeleteFilling(string id)
        {
            string path = client.BaseAddress + "action=delete_filling&id=" + id;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(path);
            request.Method = "DELETE";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string data = string.Empty;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                /*                Stream receiveStream = response.GetResponseStream();
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
                                response.Close();
                                readStream.Close();*/
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

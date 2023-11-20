using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace BuildCalculator.Classes
{
    public static class Net
    {
        private static string api = "https://6cf7-94-141-126-221.ngrok-free.app/";

        public static JObject GetRequest(string url, out HttpStatusCode status, JObject body = null)
        {
            using (HttpClient client = new HttpClient())
            {
                string queryString = (body != null) ? ToQueryString(body) : string.Empty;

                HttpResponseMessage response = client.GetAsync(api + url + queryString).Result;
                status = response.StatusCode;

                if (response.IsSuccessStatusCode)
                    return JObject.Parse(response.Content.ReadAsStringAsync().Result);
                else
                    return null;
            }
        }

        public static JObject PostRequest(string url, out HttpStatusCode status, JObject body = null)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpContent content = null;
                if (body != null)
                    content = new StringContent(body.ToString(), Encoding.UTF8, "application/json");

                HttpResponseMessage response = client.PostAsync(api + url, content).Result;
                status = response.StatusCode;

                if (response.IsSuccessStatusCode)
                    return JObject.Parse(response.Content.ReadAsStringAsync().Result);
                else
                    return null;
            }
        }

        private static string ToQueryString(JObject obj)
        {
            return "?" + string.Join("&", obj.Properties().Select(p => $"{p.Name}={Uri.EscapeDataString(p.Value.ToString())}"));
        }
    }
}

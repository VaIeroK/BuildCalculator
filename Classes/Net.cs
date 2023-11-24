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
        public static string api = "https://6cf7-94-141-126-221.ngrok-free.app/";

        public static JObject GetRequest(string url, out HttpStatusCode status, JObject url_body = null)
        {
            using (HttpClient client = new HttpClient())
            {
                string queryString = (url_body != null) ? ToQueryString(url_body) : string.Empty;

                HttpResponseMessage response = client.GetAsync(api + url + queryString).Result;
                status = response.StatusCode;

                if (response.IsSuccessStatusCode)
                    return JObject.Parse(response.Content.ReadAsStringAsync().Result);
                else
                    return null;
            }
        }

        public static string GetRequestString(string url, out HttpStatusCode status, JObject url_body = null)
        {
            using (HttpClient client = new HttpClient())
            {
                string queryString = (url_body != null) ? ToQueryString(url_body) : string.Empty;

                HttpResponseMessage response = client.GetAsync(api + url + queryString).Result;
                status = response.StatusCode;

                if (response.IsSuccessStatusCode)
                    return response.Content.ReadAsStringAsync().Result;
                else
                    return null;
            }
        }

        public static JObject PostRequest(string url, out HttpStatusCode status, JObject body = null, JObject url_body = null)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpContent content = null;
                if (body != null)
                    content = new StringContent(body.ToString(), Encoding.UTF8, "application/json");

                string queryString = (url_body != null) ? ToQueryString(url_body) : string.Empty;

                HttpResponseMessage response = client.PostAsync(api + url + queryString, content).Result;
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

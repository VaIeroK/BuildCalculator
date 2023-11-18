using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BuildCalculator.Classes
{
    public static class Net
    {
        public static string Request(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                    return response.Content.ReadAsStringAsync().Result;
                else
                    return null;
            }
        }
    }
}

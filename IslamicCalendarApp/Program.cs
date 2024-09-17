using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

class Program {
    static async Task Main(string[] args) {
        string url = "http://api.aladhan.com/v1/gToHCalendar/8/2024";
        bool useProxy = true;
        string proxyUrl = "http://your-proxy-url:port";

        HttpClientHandler handler;

        if (useProxy) {
            handler = new HttpClientHandler {
                Proxy = new WebProxy(proxyUrl),
                UseProxy = true
            };
        } else {
            handler = new HttpClientHandler {
                UseProxy = false
            };
        }
        using (HttpClient client = new HttpClient(handler)) {
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode) {
                string result = await response.Content.ReadAsStringAsync();
                ApiResponse apiResponse = JsonConvert.DeserializeObject<ApiResponse>(result);
            } else {
                Console.WriteLine("API Request is failed: " + response.StatusCode);
            }
        }
    }
}
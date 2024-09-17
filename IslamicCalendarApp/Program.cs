using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

class Program {
    static async Task Main(string[] args) {
        string url = "http://api.aladhan.com/v1/gToHCalendar/8/2024";

        using (HttpClient client = new HttpClient()) {
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
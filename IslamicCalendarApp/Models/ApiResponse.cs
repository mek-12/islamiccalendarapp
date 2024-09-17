using Newtonsoft.Json;

public class ApiResponse {
    [JsonProperty("code")]
    public int Code { get; set; }

    [JsonProperty("status")]
    public string Status { get; set; }

    [JsonProperty("data")]
    public List<DayData> Data { get; set; }
}

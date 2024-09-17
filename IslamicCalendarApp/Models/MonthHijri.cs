using Newtonsoft.Json;

public class MonthHijri {
    [JsonProperty("number")]
    public int Number { get; set; }

    [JsonProperty("en")]
    public string English { get; set; }

    [JsonProperty("ar")]
    public string Arabic { get; set; }
}
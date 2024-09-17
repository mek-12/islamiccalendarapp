using Newtonsoft.Json;

public class Month {
    [JsonProperty("number")]
    public int Number { get; set; }

    [JsonProperty("en")]
    public string English { get; set; }
}
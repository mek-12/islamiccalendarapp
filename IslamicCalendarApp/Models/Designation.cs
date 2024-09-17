using Newtonsoft.Json;

public class Designation {
    [JsonProperty("abbreviated")]
    public string Abbreviated { get; set; }

    [JsonProperty("expanded")]
    public string Expanded { get; set; }
}
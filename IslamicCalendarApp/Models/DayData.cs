using Newtonsoft.Json;

public class DayData {
    [JsonProperty("gregorian")]
    public Gregorian Gregorian { get; set; }

    [JsonProperty("hijri")]
    public Hijri Hijri { get; set; }
}
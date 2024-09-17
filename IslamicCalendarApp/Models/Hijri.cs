using Newtonsoft.Json;

public class Hijri {
    [JsonProperty("date")]
    public string Date { get; set; }

    [JsonProperty("format")]
    public string Format { get; set; }

    [JsonProperty("day")]
    public string Day { get; set; }

    [JsonProperty("weekday")]
    public WeekdayHijri Weekday { get; set; }

    [JsonProperty("month")]
    public MonthHijri Month { get; set; }

    [JsonProperty("year")]
    public string Year { get; set; }

    [JsonProperty("designation")]
    public Designation Designation { get; set; }

    [JsonProperty("holidays")]
    public List<object> Holidays { get; set; }
}
using Newtonsoft.Json;
using System.Collections.Generic;

public class Gregorian {
    [JsonProperty("date")]
    public string Date { get; set; }

    [JsonProperty("format")]
    public string Format { get; set; }

    [JsonProperty("day")]
    public string Day { get; set; }

    [JsonProperty("weekday")]
    public Weekday Weekday { get; set; }

    [JsonProperty("month")]
    public Month Month { get; set; }

    [JsonProperty("year")]
    public string Year { get; set; }

    [JsonProperty("designation")]
    public Designation Designation { get; set; }
}
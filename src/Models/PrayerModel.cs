using System.Text.Json.Serialization;

namespace TunisianMuslimApi.Models;

public class PrayerModel
{
    [JsonPropertyName("data")]
    public PrayerTimeData? Data { get; set; }

    [JsonPropertyName("method")]
    public string? Method { get; set; }
}

public class PrayerTimeData
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("gouvernorat")]
    public Location? City { get; set; }

    [JsonPropertyName("delegation")]
    public Location? Delegation { get; set; }

    [JsonPropertyName("date")]
    public string? Date { get; set; }

    [JsonPropertyName("sobh")]
    public string? Sobh { get; set; }

    [JsonPropertyName("dhohr")]
    public string? Dhohr { get; set; }

    [JsonPropertyName("aser")]
    public string? Aser { get; set; }

    [JsonPropertyName("magreb")]
    public string? Magreb { get; set; }

    [JsonPropertyName("isha")]
    public string? Isha { get; set; }

    [JsonPropertyName("lat")]
    public string? Latitude { get; set; }

    [JsonPropertyName("lng")]
    public string? Longtitude { get; set; }

    [JsonPropertyName("annee")]
    public int? Year { get; set; }

    [JsonPropertyName("active")]
    public bool? Active { get; set; }
}

public class Location
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("intituleFr")]
    public string? NameFr { get; set; }

    [JsonPropertyName("intituleAr")]
    public string? NameAr { get; set; }

    [JsonPropertyName("intituleAn")]
    public string? NameEn { get; set; }
}

namespace TunisianMuslimApi.Models;

/// <summary>
/// a clean models
/// </summary>
public class CleanPrayerModel
{
    /// <summary>
    /// time for sobh prayer
    /// </summary>
    /// <value></value>
    public string? Fajr { get; set; }

    /// <summary>
    /// time for Dhohr prayer
    /// </summary>
    /// <value></value>
    public string? Dhohr { get; set; }

    /// <summary>
    /// time for Aser prayer
    /// </summary>
    /// <value></value>
    public string? Aser { get; set; }

    /// <summary>
    /// time for Maghreb prayer
    /// </summary>
    /// <value></value>
    public string? Magreb { get; set; }

    /// <summary>
    /// time for Isha prayer
    /// </summary>
    /// <value></value>
    public string? Isha { get; set; }
}


using RestSharp;
using TunisianMuslimApi.Models;

namespace TunisianMuslimApi.Services;


/// <summary>
/// Nim = National Institute of Meteorology
/// https://www.meteo.tn/en/heures-prieres
/// </summary>
public class NimServices : INimServices
{
    /// <summary>
    /// Returns the time of prayer of today
    /// </summary>
    /// <param name="stateId">the id of the state</param>
    /// <param name="delegationId">the id of the delegate</param>
    /// <returns></returns>
    public async Task<PrayerModel?> GetTimeById(int stateId, int delegationId)
    {
        string url = "https://www.meteo.tn/horaire_gouvernorat";
        var options = new RestClientOptions(url);
        var client = new RestClient(options);
        var request = new RestRequest(DateTime.Now.ToString("yyyy-MM-dd") + $"/{stateId}/{delegationId}");
        var response = await client.GetAsync<PrayerModel>(request);
        return response;
    }
}

using Microsoft.AspNetCore.Mvc;
using TunisianMuslimApi.Models;
using TunisianMuslimApi.Services;

namespace TunisianMuslimApi.V1;

/// <summary>
/// Contains all endpoints related to prayer.
/// </summary>
public static class Prayer
{
    /// <summary>
    /// Maps all the endpoints for prayer related requests.
    /// </summary>
    /// <param name="app"></param>
    public static void MapPrayers(this WebApplication app)
    {
        // app.MapGet("/GetToday/{state}/{delegation}", (int state, int delegation, INimServices nimServices) => GetToday(state, delegation,nimServices));
        app.MapGet("/GetToday", GetToday);
        app.MapPost("/test", test);
    }

    private static async Task<CleanPrayerModel?> GetToday(int stateId, int delegationId, INimServices nimServices)
    {
        var response = await nimServices.GetTimeById(stateId, delegationId);

        return new CleanPrayerModel()
        {
            Fajr = response.Data.Sobh,
            Dhohr = response.Data.Dhohr,
            Aser = response.Data.Aser,
            Magreb = response.Data.Magreb,
            Isha = response.Data.Isha
        };

    }
    private static bool test([FromBody] CleanPrayerModel x)
    {
        return true;
    }
}

using TunisianMuslimApi.Models;

namespace TunisianMuslimApi.Services;
public interface INimServices
{
    Task<PrayerModel?> GetTimeById(int stateId, int delegationId);
}
namespace TunisianMuslimApi.V1;

public static class Main
{
    public static void MapV1(this WebApplication app)
    {
        app.MapPrayers();
    }
}

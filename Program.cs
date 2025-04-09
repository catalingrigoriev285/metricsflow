using metricsflow.database.contexts;
using metricsflow.database.seeders;
using metricsflow.resources.interfaces.auth;

namespace metricsflow;
internal static class Program
{
    [STAThread]
    static void Main()
    {
        DatabaseSeeder.Seed();

        ApplicationConfiguration.Initialize();
        Application.Run(new Auth());
    }
}
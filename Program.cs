using metricsflow.resources.interfaces.auth;

namespace metricsflow;
internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new Auth());
    }
}
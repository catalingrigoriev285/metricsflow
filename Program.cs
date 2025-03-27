using metricsflow.resources.interfaces.welcome;

namespace metricsflow;
internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new Welcome());
    }
}
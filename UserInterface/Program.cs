using Models;

namespace UserInterface
{
    public class globals {
        public static User _sessionUser;
        public static string _sessionToken;

        public static User sessionUser
        {
            get { return _sessionUser; }
            set { _sessionUser = value; }
        }
    };

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Auth());
        }
    }
}
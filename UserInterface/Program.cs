using Models;

namespace UserInterface
{
    public class globals {
        public static User _sessionUser;

        public static User sessionUser
        {
            get { return _sessionUser; }
            set { _sessionUser = value; }
        }

        public static User _sessionSelectedUser;

        public static User sessionSelectedUser
        {
            get { return _sessionSelectedUser; }
            set { _sessionSelectedUser = value; }
        }

        public static Role _sessionSelectedRole;

        public static Role sessionSelectedRole
        {
            get { return _sessionSelectedRole; }
            set { _sessionSelectedRole = value; }
        }

        public static Evaluation _sessionSelectedEvaluation;

        public static Evaluation sessionSelectedEvaluation
        {
            get { return _sessionSelectedEvaluation; }
            set { _sessionSelectedEvaluation = value; }
        }

        public static Question _sessionSelectedQuestion;
        public static Question sessionSelectedQuestion
        {
            get { return _sessionSelectedQuestion; }
            set { _sessionSelectedQuestion = value; }
        }

        public static Question.Answer _sessionSelectedAnswer;
        public static Question.Answer sessionSelectedAnswer
        {
            get { return _sessionSelectedAnswer; }
            set { _sessionSelectedAnswer = value; }
        }

        public static string _sessionToken;

        public static string sessionToken
        {
            get { return _sessionToken; }
            set { _sessionToken = value; }
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

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Auth());
        }
    }
}
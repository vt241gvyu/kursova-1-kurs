using FootballMatch;

namespace FootballMatch
{
    internal static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
                        DB db = new DB();
            db.CreateDB();
                Application.Run(new FormSignIn());
        }
    }
}
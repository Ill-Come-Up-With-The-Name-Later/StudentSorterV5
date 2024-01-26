using StudentSorter.Debug;

namespace StudentSorter
{
    static class Program
    {
        public const string Version = "0.6.2";

        public static DebugWindow Debugger = new();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new TitleWindow());
        }
    }
}
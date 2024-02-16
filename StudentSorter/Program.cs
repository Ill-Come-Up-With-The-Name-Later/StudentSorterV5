using StudentSorter.Debug;

namespace StudentSorter
{
    static class Program
    {
        public const string Version = "0.11.2";

        public static DebugWindow Debugger = null;

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
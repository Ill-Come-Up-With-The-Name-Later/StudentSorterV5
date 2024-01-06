namespace StudentSorter
{
    static class Program
    {
        public const string Version = "0.4.7.1";

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
namespace StudentSorter.Debug
{
    public class Debugger
    {
        /// <summary>
        /// Logs a message to the debug window with
        /// a timestamp
        /// </summary>
        /// <param name="message">
        /// The message to log
        /// </param>
        public static void Log(string message)
        {
            DateTime now = DateTime.Now;
            Program.Debugger.DebugLog.Text += $"\n[{now.Hour}:{(now.Minute < 10 ? $"0{now.Minute}" 
                : $"{now.Minute}")}.{(now.Second < 10 ? $"0{now.Second}" : $"{now.Second}")}]: {message}";
        }
    }
}

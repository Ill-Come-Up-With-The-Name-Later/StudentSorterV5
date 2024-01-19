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
            DateTime now = DateTime.Now; // Format soo that if a value is less than 10, put a leading 0, ex: 06:09.04
            Program.Debugger.DebugLog.Text += $"\n[{(now.Hour < 10 ? $"0{now.Hour}" : $"{now.Hour}")}:{(now.Minute < 10 ? $"0{now.Minute}" 
                : $"{now.Minute}")}.{(now.Second < 10 ? $"0{now.Second}" : $"{now.Second}")}]: {message}";
        }
    }
}

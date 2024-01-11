namespace StudentSorter.Debug
{
    public class Debugger
    {
        public static void Log(string message)
        {
            DateTime now = DateTime.Now;
            Program.Debugger.DebugLog.Text += $"\n[{now.Hour}:{now.Minute}]: {message}";
        }
    }
}

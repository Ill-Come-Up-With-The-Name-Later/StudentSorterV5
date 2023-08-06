namespace StudentSorter
{
    public static class Exporter
    {
        public static void Export(string fileName, List<string> lines)
        {
            try
            {
                File.WriteAllLines(fileName, lines);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}

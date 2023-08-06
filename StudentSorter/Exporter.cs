namespace StudentSorter
{
    public static class Exporter
    {
        public static void Export(string fileName, List<string> lines)
        {
            File.Create(fileName).DisposeAsync();
            File.WriteAllLinesAsync(fileName, lines.ToArray());
        }
    }
}

namespace StudentSorter
{
    public static class Exporter
    {
        /// <summary>
        /// Writes text to a file
        /// </summary>
        /// <param name="fileName">
        /// The path and name of the file to write to
        /// </param>
        /// <param name="lines">
        /// The text to write to the file
        /// </param>
        public static void Export(string fileName, List<string> lines)
        {
            try
            {
                File.WriteAllLines(fileName, lines);
            }
            catch (Exception ex)
            {
                Console.WriteLine("File Export error!");
                Console.WriteLine(ex);
            }
        }
    }
}

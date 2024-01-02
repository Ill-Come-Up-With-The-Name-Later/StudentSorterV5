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
        public static void WriteFile(string fileName, List<string> lines)
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

        /// <summary>
        /// Exports a single object to a JSON file
        /// </summary>
        /// <typeparam name="T">
        /// The type of the object to export
        /// </typeparam>
        /// <param name="obj">
        /// The object to export
        /// </param>
        public static void ExportObject<T>(T obj, string fileName) where T : Serializeable
        {
            List<string> lines = new()
            {
                obj.SerializeJSON()
            };

            WriteFile(fileName, lines);
        }

        /// <summary>
        /// Exports a list of objects to a JSON file
        /// </summary>
        /// <typeparam name="T">
        /// The type of the objects to export
        /// </typeparam>
        /// <param name="obj">
        /// A list of objects to export
        /// </param>
        public static void ExportObjects<T>(List<T> obj, string fileName) where T : Serializeable
        {
            List<string> lines = new();

            obj.ForEach(x => { lines.Add(x.SerializeJSON()); });

            WriteFile(fileName, lines);
        }
    }
}

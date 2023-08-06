using Newtonsoft.Json;

namespace StudentSorter
{
    public class Importer
    {
        public static void Import<T>(string filePath)
        {
            string file = filePath;
            string lines = File.ReadAllText(file);

            var jsonReader = new JsonTextReader(new StringReader(lines))
            {
                SupportMultipleContent = true
            };

            while(jsonReader.Read()) 
            {
                JsonSerializer serializer = new JsonSerializer();
                T obj = serializer.Deserialize<T>(jsonReader);
            }
        }
    }
}

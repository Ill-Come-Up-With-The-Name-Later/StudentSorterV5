using System.Text.Json;

namespace StudentSorter
{
    public abstract class Serializeable
    {   
        /// <summary>
        /// Serializes an object into JSON
        /// </summary>
        /// <returns>
        /// The JSON representation of the object
        /// </returns>
        public string SerializeJSON()
        {
            var config = new JsonSerializerOptions { WriteIndented = true };
            return JsonSerializer.Serialize(this, config);
        }
    }
}

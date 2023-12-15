using Newtonsoft.Json;

namespace StudentSorter
{
    public class Serializeable
    {
        /// <summary>
        /// Serializes the group into JSON
        /// </summary>
        /// <returns>
        /// JSON string of the group's information
        /// </returns>
        public string SerializeJSON() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}

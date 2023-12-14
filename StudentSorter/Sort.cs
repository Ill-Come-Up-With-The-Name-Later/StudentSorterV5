using Newtonsoft.Json;

namespace StudentSorter
{
    public class Sort
    {
        public string StudentFile { get; set; }
        public string GroupFile { get; set; }
        public string IllegalPairsFile { get; set; }

        [JsonConstructor]
        public Sort(string studentFile, string groupFile, string illegalPairFile) 
        {
            StudentFile = studentFile;
            GroupFile = groupFile;
            IllegalPairsFile = illegalPairFile;

            Sorter.GlobalInstance().SortConfigs.Clear();
            Sorter.GlobalInstance().SortConfigs.Add(this);
        }

        /// <summary>
        /// Serializes the group into JSON
        /// </summary>
        /// <returns>
        /// JSON string of the group's information
        /// </returns>
        public string SerializeJSON() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}

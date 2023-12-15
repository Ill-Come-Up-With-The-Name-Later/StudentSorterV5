using Newtonsoft.Json;

namespace StudentSorter
{
    public class Sort : Serializeable
    {
        public string StudentFile { get; set; }
        public string GroupFile { get; set; }
        public string IllegalPairsFile { get; set; }

        /// <summary>
        /// Creates a Sorter Configuration
        /// </summary>
        /// <param name="studentFile">
        /// The path of a file containing students' names
        /// </param>
        /// <param name="groupFile">
        /// The path of a file containing information
        /// about groups
        /// </param>
        /// <param name="illegalPairFile">
        /// The path of a file containing information about
        /// illegal pairs
        /// </param>
        [JsonConstructor]
        public Sort(string studentFile, string groupFile, string illegalPairFile) 
        {
            StudentFile = studentFile;
            GroupFile = groupFile;
            IllegalPairsFile = illegalPairFile;

            Sorter.GlobalInstance().SortConfigs.Clear();
            Sorter.GlobalInstance().SortConfigs.Add(this);
        }
    }
}

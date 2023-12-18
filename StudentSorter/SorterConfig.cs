using Newtonsoft.Json;

namespace StudentSorter
{
    public class SorterConfig : Serializeable
    {
        public string Name { get; set; }
        public string StudentFile { get; set; }
        public string GroupFile { get; set; }
        public string IllegalPairsFile { get; set; }
        public string ManualAssignmentsFile { get; set; }

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
        public SorterConfig(string name, string studentFile, string groupFile, string illegalPairFile, string manualAssignmentFile) 
        {
            Name = name;
            StudentFile = studentFile;
            GroupFile = groupFile;
            IllegalPairsFile = illegalPairFile;
            ManualAssignmentsFile = manualAssignmentFile;

            Sorter.GlobalInstance().SortConfigs.Clear();
            Sorter.GlobalInstance().SortConfigs.Add(this);
        }
    }
}

using Newtonsoft.Json;
using StudentSorter.FileHandling.Data;

namespace StudentSorter.SorterComponent
{
    public class SorterConfig : Serializeable
    {
        public string Name { get; set; }
        public string StudentFile { get; set; }
        public string GroupFile { get; set; }
        public string IllegalPairsFile { get; set; }
        public string ManualAssignmentsFile { get; set; }
        public SortAlgorithm Algorithm { get; set; }

        /// <summary>
        /// Constructs a sorter config
        /// </summary>
        /// <param name="name">
        /// The name of the config
        /// </param>
        /// <param name="studentFile">
        /// The path to the file containing students
        /// </param>
        /// <param name="groupFile">
        /// The path to the groups file
        /// </param>
        /// <param name="illegalPairsFile">
        /// The path to the illegal pairs file
        /// </param>
        /// <param name="manualAssignmentsFile">
        /// The path to the manual assignments file
        /// </param>
        /// <param name="algorithm">
        /// The shuffling algorithm to use
        /// </param>
        public SorterConfig(string name, string studentFile, string groupFile, string illegalPairsFile, string manualAssignmentsFile, SortAlgorithm algorithm)
        {
            Name = name;
            StudentFile = studentFile;
            GroupFile = groupFile;
            IllegalPairsFile = illegalPairsFile;
            ManualAssignmentsFile = manualAssignmentsFile;
            Algorithm = algorithm;
        }

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
        /// <param name="manualAssignmentFile">
        /// The file path of a file containing manual assignments
        /// </param>
        /// <param name="sortAlgorithm">
        /// The algorithm to use
        /// </param>
        [JsonConstructor]
        public SorterConfig(string name, string studentFile, string groupFile, string illegalPairFile, string manualAssignmentFile, int sortAlgorithm)
        {
            Name = name;
            StudentFile = studentFile;
            GroupFile = groupFile;
            IllegalPairsFile = illegalPairFile;
            ManualAssignmentsFile = manualAssignmentFile;

            switch (sortAlgorithm)
            {
                case 0:
                    Algorithm = SortAlgorithm.SelectiveShuffle;
                    break;
                case 1:
                    Algorithm = SortAlgorithm.HatDrawShuffle;
                    break;
                case 2:
                    Algorithm = SortAlgorithm.DodgeballTeamShuffle;
                    break;
            }

            Sorter.GlobalInstance().SortConfigs.Clear();
            Sorter.GlobalInstance().SortConfigs.Add(this);
        }

        public override string ToString()
        {
            return $"{Name}\nStudent File: {StudentFile}\nGroup File: {GroupFile}\nDisallowed Pair File: {IllegalPairsFile}\n" +
                $"Assignment File: {ManualAssignmentsFile}";
        }
    }
}

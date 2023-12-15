using Newtonsoft.Json;

namespace StudentSorter
{
    public class Sort : Serializeable
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
    }
}

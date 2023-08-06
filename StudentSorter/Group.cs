using System.Text.Json.Serialization;

namespace StudentSorter
{
    public class Group : Serializeable
    {
        [JsonInclude]
        public string Name { get; set; }

        [JsonInclude]
        public int MinDeterminant { get; set; }

        [JsonInclude]
        public int MaxDeterminant { get; set;}

        [JsonInclude]
        public int Capacity { get; set; }

        [JsonIgnore]
        public List<Student> students { get; private set; }

        [JsonConstructor]
        public Group(string name, int minDeterminant, int maxDeterminant, int capacity)
        {
            Name = name;
            MinDeterminant = minDeterminant;
            MaxDeterminant = maxDeterminant;
            Capacity = capacity;

            Sorter.GlobalInstance.AllGroups.Add(this);
        }
    }
}

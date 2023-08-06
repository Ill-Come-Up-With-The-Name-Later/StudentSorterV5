using Newtonsoft.Json;

namespace StudentSorter
{
    public class Group
    {
        public string Name { get; set; }

        public int MinDeterminant { get; set; }

        public int MaxDeterminant { get; set;}

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

            Sorter.GlobalInstance().AllGroups.Add(this);
        }

        public override bool Equals(object? obj)
        {
            if(obj == null) throw new ArgumentNullException(nameof(obj));
            if(obj.GetType() != typeof(Group)) return false;
            Group objGroup = (Group)obj;
            return objGroup.Name.Equals(Name) && objGroup.Capacity == Capacity && 
                objGroup.MinDeterminant == MinDeterminant && objGroup.MaxDeterminant == MaxDeterminant;   
        }

        public string SerializeJSON() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}

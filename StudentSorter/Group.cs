using Newtonsoft.Json;

namespace StudentSorter
{
    public class Group : Serializeable
    {
        public string Name { get; set; }
        public int MinDeterminant { get; set; }
        public int MaxDeterminant { get; set;}
        public int Capacity { get; set; }
        public int HashCode { get; set; }

        [JsonIgnore]
        public int Size { get { return Students.Count; } }

        [JsonIgnore]
        public List<Student> Students { get; private set; }

        /// <summary>
        /// Creates a group
        /// </summary>
        /// <param name="name">
        /// The group name
        /// </param>
        /// <param name="minDeterminant">
        /// The minimum accepted determinant for the group
        /// </param>
        /// <param name="maxDeterminant">
        /// The maximum accepted determinant for the group
        /// </param>
        /// <param name="capacity">
        /// The group's capacity
        /// </param>
        public Group(string name, int minDeterminant, int maxDeterminant, int capacity)
        {
            Name = name;
            MinDeterminant = minDeterminant;
            MaxDeterminant = maxDeterminant;
            Capacity = capacity;
            HashCode = new Random().Next();

            Students = new();

            Sorter.GlobalInstance().AllGroups.Add(this);
        }

        /// <summary>
        /// Creates a group, for JSON serialization only
        /// </summary>
        /// <param name="name">
        /// The group name
        /// </param>
        /// <param name="minDeterminant">
        /// The minimum accepted determinant for the group
        /// </param>
        /// <param name="maxDeterminant">
        /// The maximum accepted determinant for the group
        /// </param>
        /// <param name="capacity">
        /// The group's capacity
        /// </param>
        /// <param name="hashCode">
        /// The group's hash code
        /// </param>
        [JsonConstructor]
        public Group(string name, int minDeterminant, int maxDeterminant, int capacity, int hashCode)
        {
            Name = name;
            MinDeterminant = minDeterminant;
            MaxDeterminant = maxDeterminant;
            Capacity = capacity;
            HashCode = hashCode;

            Students = new();

            Sorter.GlobalInstance().AllGroups.Add(this);
        }
        
        /// <summary>
        /// Determines if the group is full
        /// </summary>
        /// <returns>
        /// Whether or not the group is full
        /// </returns>
        public bool IsFull()
        {
            return Size >= Capacity;
        }

        /// <summary>
        /// Determines if a student is already in the group
        /// </summary>
        /// <param name="student">
        /// The student to look for
        /// </param>
        /// <returns>
        /// If the student is in the group
        /// </returns>
        public bool Contains(Student student)
        {
            return Students.Contains(student);
        }

        /// <summary>
        /// Determines if a set of students are in the group
        /// </summary>
        /// <param name="students">
        /// The list of students to look for
        /// </param>
        /// <returns>
        /// If the students are in the group
        /// </returns>
        public bool Contains(List<Student> students)
        {
            if(students.Count > Capacity)
            {
                return false;
            }

            foreach(Student student in students)
            {
                if(!Contains(student))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Adds a student to the group if the group has space
        /// and they aren't in a group
        /// </summary>
        /// <param name="student">
        /// The student to add
        /// </param>
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        /// <summary>
        /// Removes a student from the group if they're in it
        /// </summary>
        /// <param name="student">
        /// The student to remove
        /// </param>
        public void RemoveStudent(Student student)
        {
            if(Contains(student)) Students.Remove(student);
        }

        /// <summary>
        /// Clears all students from the group
        /// </summary>
        public void Clear()
        {
            Students.Clear();
        }

        public override bool Equals(object? obj)
        {
            if(obj == null) throw new ArgumentNullException("object was null");
            if(obj.GetType() != typeof(Group)) return false;
            Group objGroup = (Group)obj;
            return objGroup.Name.Equals(Name) && objGroup.Capacity == Capacity && 
                objGroup.MinDeterminant == MinDeterminant && objGroup.MaxDeterminant == MaxDeterminant;
        }

        public static bool operator == (Group a, Group b)
        {
            return a.Equals(b);
        }

        public static bool operator != (Group a, Group b)
        {
            return !a.Equals(b);
        }

        public override int GetHashCode()
        {
            return HashCode;
        }
    }
}

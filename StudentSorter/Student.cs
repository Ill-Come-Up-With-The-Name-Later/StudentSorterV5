using Newtonsoft.Json;

namespace StudentSorter
{
    public class Student
    {
        public string Name { get; set; }

        [JsonIgnore]
        public int Determinant { get; set; }

        /// <summary>
        /// Constructs a student
        /// </summary>
        /// <param name="name">
        /// The student's name
        /// </param>
        [JsonConstructor]
        public Student(string name)
        {
            Name = name;

            Sorter.GlobalInstance().AllStudents.Add(this);
        }

        /// <summary>
        /// Constructs a student with a set determinant
        /// </summary>
        /// <param name="name">
        /// The student's name
        /// </param>
        /// <param name="determinant">
        /// The student's determinant
        /// </param>
        public Student(string name, int determinant)
        {
            Name = name;
            Determinant = determinant;

            Sorter.GlobalInstance().AllStudents.Add(this);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) throw new ArgumentNullException("object was null");
            if(obj .GetType() != typeof(Student)) return false;
            Student s = (Student)obj;
            return s.Name.Equals(Name) && s.Determinant == Determinant;
        }

        public static bool operator == (Student s1, Student s2)
        {
            return s1.Equals(s2);
        }

        public static bool operator != (Student s1, Student s2)
        {
            return !s1.Equals(s2);
        }

        public string SerializeJSON() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}

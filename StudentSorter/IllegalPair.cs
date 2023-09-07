using Newtonsoft.Json;

namespace StudentSorter
{
    public class IllegalPair
    {
        public Student Student1 { get; set; }
        public Student Student2 { get; set; }

        public int HashCode { get { return GetHashCode(); } set { } }

        /// <summary>
        /// Creates an illegal pair, the two students in the pair
        /// cannot be sorted together
        /// </summary>
        /// <param name="student1">
        /// The first student
        /// </param>
        /// <param name="student2">
        /// The second student
        /// </param>
        public IllegalPair(Student student1, Student student2)
        {
            Student1 = student1;
            Student2 = student2;
            HashCode = new Random().Next();

            Sorter.GlobalInstance().IllegalPairs.Add(this);
        }

        /// <summary>
        /// Creates an IllegalPair. For use with JSON deserialization
        /// </summary>
        /// <param name="student1"></param>
        /// <param name="student2"></param>
        /// <param name="hashCode"></param>
        [JsonConstructor]
        public IllegalPair(Student student1, Student student2, int hashCode)
        {
            Student1 = student1;
            Student2 = student2;
            HashCode = hashCode;

            Sorter.GlobalInstance().IllegalPairs.Add(this);
        }

        /// <summary>
        /// Determines if a student is in the pair
        /// </summary>
        /// <param name="student">
        /// The student to look for
        /// </param>
        /// <returns>
        /// If the student is in the pair
        /// </returns>
        public bool Contains(Student student)
        {
            return Student1 == student || Student2 == student;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) throw new ArgumentNullException();
            if(obj.GetType() != typeof(Student)) return false;
            IllegalPair pair = (IllegalPair)obj;

            return pair.Student1 == this.Student1 && pair.Student2 == this.Student2;
        }

        public static bool operator == (IllegalPair a, IllegalPair b)
        {
            return a.Equals(b);
        }

        public static bool operator != (IllegalPair a, IllegalPair b)
        {
            return !a.Equals(b);
        }

        /// <summary>
        /// Serializes the group into JSON
        /// </summary>
        /// <returns>
        /// JSON string of the group's information
        /// </returns>
        public string SerializeJSON() => JsonConvert.SerializeObject(this, Formatting.Indented);

        public override int GetHashCode()
        {
            return HashCode;
        }
    }
}

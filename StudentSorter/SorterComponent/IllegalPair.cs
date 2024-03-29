﻿using Newtonsoft.Json;
using StudentSorter.FileHandling.Data;
using Debugger = StudentSorter.Debug.Debugger;

namespace StudentSorter.SorterComponent
{
    public class IllegalPair : Serializeable
    {
        [JsonIgnore]
        public Student Student1 { get; set; }

        [JsonIgnore]
        public Student Student2 { get; set; }

        [JsonRequired]
        public int Student1Hash { get; set; }

        [JsonRequired]
        public int Student2Hash { get; set; }

        [JsonRequired]
        public int HashCode { get; set; }

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

            Student1Hash = Student1.GetHashCode();
            Student2Hash = Student2.GetHashCode();

            Sorter.GlobalInstance().AddIllegalPair(this);
        }

        /// <summary>
        /// Creates an illegal pair. For use with JSON deserialization only
        /// </summary>
        /// <param name="student1Hash">
        /// The hash code of student 1
        /// </param>
        /// <param name="student2Hash">
        /// The hash code of student 2
        /// </param>
        /// <param name="hashCode">
        /// The pair's hash code
        /// </param>
        [JsonConstructor]
        public IllegalPair(int student1Hash, int student2Hash, int hashCode)
        {
            Student1Hash = student1Hash;
            Student2Hash = student2Hash;
            HashCode = hashCode;

            try
            {
                Student1 = Sorter.GlobalInstance().GetStudentByHashCode(Student1Hash);
                Student2 = Sorter.GlobalInstance().GetStudentByHashCode(Student2Hash);
            }
            catch (NullReferenceException)
            {
                Debugger.Log("A student couldn't be found.");
            }

            Sorter.GlobalInstance().AddIllegalPair(this);
        }

        /// <summary>
        /// Converts the pair to a list
        /// </summary>
        /// <returns>
        /// A list containing the students in the pair
        /// </returns>
        public List<Student> AsList()
        {
            return new List<Student>
            {
                Student1,
                Student2
            };
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
            if (obj.GetType() != typeof(Student)) return false;
            IllegalPair pair = (IllegalPair)obj;

            return pair.Student1 == Student1 && pair.Student2 == Student2;
        }

        public static bool operator ==(IllegalPair a, IllegalPair b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(IllegalPair a, IllegalPair b)
        {
            return !a.Equals(b);
        }

        public override int GetHashCode()
        {
            return HashCode;
        }

        public override string ToString()
        {
            return $"{Student1.Name} and {Student2.Name}";
        }
    }
}

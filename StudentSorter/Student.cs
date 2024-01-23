using Newtonsoft.Json;
using StudentSorter.Debug;

namespace StudentSorter
{
    public class Student : Serializeable
    {
        public string Name { get; set; }
        public int Determinant { get; set; }
        public bool DeterminiantSet { get; set; }
        public int HashCode { get; set; }

        /// <summary>
        /// Constructs a student
        /// </summary>
        /// <param name="name">
        /// Student name
        /// </param>
        public Student(string name) 
        {
            Name = name;
            Determinant = int.MinValue; 
            DeterminiantSet = false;
            HashCode = new Random().Next();

            Sorter.GlobalInstance().AllStudents.Add(this);
        }

        /// <summary>
        /// Constructs a student. For JSON serialization only
        /// </summary>
        /// <param name="name">
        /// The student's name
        /// </param>
        /// <param name="determinant">
        /// Whether or not the student's determinant is set
        /// </param>
        /// <param name="determinantSet">
        /// Whether or not the student's determinant is set
        /// </param>
        /// <param name="hashCode">
        /// The student's hash code
        /// </param>
        [JsonConstructor]
        public Student(string name, int determinant, bool determinantSet, int hashCode)
        {
            Name = name;
            Determinant = determinant;
            DeterminiantSet = determinantSet;
            HashCode = hashCode;

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
            DeterminiantSet = true;
            HashCode = new Random().Next();

            Sorter.GlobalInstance().AllStudents.Add(this);
        }

        /// <summary>
        /// Determines if the student is in a group
        /// </summary>
        /// <returns>
        /// Whether the student is in a group
        /// </returns>
        public bool InGroup()
        {
            foreach(Group group in Sorter.GlobalInstance().AllGroups)
                if (group.Contains(this))
                    return true;

            return false;
        }

        /// <summary>
        /// Determines if the student's determinant matches a group
        /// </summary>
        /// <param name="group">
        /// The group to check
        /// </param>
        /// <returns>
        /// If the student's determinant matches the group's requirement
        /// </returns>
        public bool DeterminantMatches(Group group)
        {
            return group.MinDeterminant <= Determinant && Determinant <= group.MaxDeterminant;
        }

        /// <summary>
        /// Determines if the student can join a specific group
        /// </summary>
        /// <param name="group">
        /// The group to check
        /// </param>
        /// <returns>
        /// If the student can join the group
        /// </returns>
        public bool CanJoinGroup(Group group)
        {
            return DeterminantMatches(group) && !(group.IsFull() || InGroup() || group.Contains(this));
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) throw new ArgumentNullException("object was null");
            if(obj.GetType() != typeof(Student)) return false;

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

        /// <summary>
        /// Operator overload for '+' turns the two students into an
        /// illegal pair
        /// </summary>
        /// <param name="s1">
        /// The first student
        /// </param>
        /// <param name="s2">
        /// The second student
        /// </param>
        /// <returns>
        /// An illegal pair containing both students
        /// </returns>
        public static IllegalPair operator + (Student s1, Student s2)
        {
            return new IllegalPair(s1, s2);
        }

        /// <summary>
        /// Finds if this student has a
        /// manual group assignment
        /// </summary>
        /// <returns>
        /// If the student has a manual
        /// assignment
        /// </returns>
        public bool HasAssignment()
        {
            foreach (ManualAssignment assignment in Sorter.GlobalInstance().Assignments)
            {
                try
                {
                    if (Sorter.GlobalInstance().GetStudentByHashCode(assignment.StudentHashCode) == this)
                    {
                        return true;
                    }
                }
                catch (NullReferenceException)
                {
                    Debugger.Log("Couldnt find the student.");
                    return false;
                }
            }
            return false;
        }

        /// <summary>
        /// Gets the manual assignment the
        /// student is in
        /// </summary>
        /// <returns>
        /// The manual assignment the student has
        /// </returns>
        public ManualAssignment? GetAssignment()
        {
            if(HasAssignment())
            {
                foreach(ManualAssignment assignment in Sorter.GlobalInstance().Assignments)
                {
                    try
                    {
                        if (Sorter.GlobalInstance().GetStudentByHashCode(assignment.StudentHashCode) == this)
                            return assignment;
                    }
                    catch(NullReferenceException)
                    {
                        Debugger.Log("Couldn't find the student.");
                    }
                }
            }

            return null;
        }

        public override int GetHashCode()
        {
            return HashCode;
        }

        public override string ToString()
        {
            return $"{Name}\nHashCode: {HashCode}";
        }
    }
}

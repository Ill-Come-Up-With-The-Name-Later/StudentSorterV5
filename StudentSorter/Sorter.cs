namespace StudentSorter
{
    public class Sorter
    {
        public List<Student> AllStudents = new();
        public List<Group> AllGroups = new();

        public List<IllegalPair> IllegalPairs = new();

        private readonly static Sorter Instance = new();

        public static Sorter GlobalInstance() => Instance;

        public int DeterminantRange { get; set; }

        public Sorter()
        {
            DeterminantRange = int.MaxValue;
        }

        /// <summary>
        /// Shuffles the groups.
        /// 
        /// The shuffle is first by determinant, then by if 
        /// the group has space
        /// </summary>
        public void ShuffleGroups()
        {
            int sortedStudents = 0;

            foreach (Group AnalysisGroup in AllGroups)
            {
                foreach (Student AnalysisStudent in AllStudents)
                {
                    if (AnalysisStudent.CanJoinGroup(AnalysisGroup))
                    {
                        AnalysisGroup.AddStudent(AnalysisStudent);
                        sortedStudents++;
                    }
                }
            }

            foreach (Group AnalysisGroup in AllGroups)
            {
                if(AnalysisGroup.IsFull())
                {
                    continue;
                }

                foreach (Student AnalysisStudent in AllStudents)
                {
                    if (!AnalysisGroup.IsFull() && !AnalysisStudent.InGroup())
                    {
                        AnalysisGroup.AddStudent(AnalysisStudent);
                        sortedStudents++;
                    }
                }
            }
            Console.WriteLine($"\nSorted {sortedStudents}/{AllStudents.Count} students!");
            ReviseSort();
        }

        /// <summary>
        /// Revises the sort by fixing illegal pairs
        /// </summary>
        public void ReviseSort()
        {

        }

        /// <summary>
        /// Swaps the groups of two students
        /// </summary>
        /// <param name="student1">
        /// The first student
        /// </param>
        /// <param name="student2">
        /// The second student
        /// </param>
        public void SwapStudents(Student student1, Student student2)
        {
            Group? firstGroup = FindStudent(student1);
            Group? secondGroup = FindStudent(student2);

            if(firstGroup is null || secondGroup is null) 
            {
                return;
                throw new NullReferenceException("At least one of the students is not in a group");
            }

            if (firstGroup == secondGroup)
            {
                return;
                throw new AbandonedMutexException("Students were in the same group");
            }

            secondGroup.RemoveStudent(student2);
            secondGroup.AddStudent(student1);

            firstGroup.RemoveStudent(student1);
            firstGroup.AddStudent(student2);
        }

        /// <summary>
        /// Finds the group of a student if they're in one
        /// </summary>
        /// <param name="student">
        /// The student to find
        /// </param>
        /// <returns>
        /// The group the student is in or null
        /// </returns>
        public Group? FindStudent(Student student)
        {
            foreach(Group group in AllGroups)
            {
                if(group.Contains(student))
                {
                    return group;
                }
            }
            return null;
        }

        /// <summary>
        /// Resets the groups an students to be shuffled again
        /// </summary>
        public void Reset()
        {
            foreach (Group g in AllGroups) g.Clear();
            RandomizeDeterminants();
        }

        /// <summary>
        /// Randomizes each student's determinant
        /// </summary>
        public void RandomizeDeterminants()
        {
            foreach (var student in AllStudents)
                if(!student.DeterminiantSet)
                    student.Determinant = new Random().Next(1, MaxDeterminant(DeterminantRange));
        }

        /// <summary>
        /// Calculates the maximum determinant a student can have
        /// The maximum is the Determinant Range times number of groups
        /// </summary>
        /// <param name="DeterRange">
        /// The range of determinants accepted (i.e. 8, from 1 to 8 or 9 to 16)
        /// </param>
        /// <returns>
        /// The maximum determinant
        /// </returns>
        public int MaxDeterminant(int DeterRange)
        {
            return DeterRange * AllGroups.Count;
        }

        /// <summary>
        /// Adds an illegal pair to the list of illegal pairs
        /// </summary>
        /// <param name="pair">
        /// The pair to add
        /// </param>
        public void AddIllegalPair(IllegalPair pair)
        {
            IllegalPairs.Add(pair);
        }

        /// <summary>
        /// Gets a student by the HashCode
        /// </summary>
        /// <param name="code">
        /// The hash code to search for
        /// </param>
        /// <returns>
        /// The student or null if no one has the hash code
        /// </returns>
        public Student? GetStudentByHashCode(int code)
        {
            foreach(Student student in AllStudents)
            {
                if(student.HashCode == code)
                {
                    return student;
                }
            }

            return null;
        }
    }
}

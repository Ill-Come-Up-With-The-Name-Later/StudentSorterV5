namespace StudentSorter
{
    public class Sorter
    {
        public List<Student> AllStudents = new();
        public List<Group> AllGroups = new();

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
    }
}

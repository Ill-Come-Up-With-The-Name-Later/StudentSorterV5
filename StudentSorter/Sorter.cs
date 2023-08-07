namespace StudentSorter
{
    public class Sorter
    {
        public List<Student> AllStudents = new();
        public List<Group> AllGroups = new();

        private readonly static Sorter? Instance = new();

        public static Sorter GlobalInstance() => Instance;

        public int DeterminantRange { get; set; }

        public Sorter()
        {
            DeterminantRange = int.MaxValue;
        }

        public void RandomizeDeterminants()
        {
            foreach (var student in AllStudents)
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

namespace StudentSorter.Comparers
{
    public class StudentComparer : IComparer<Student>
    {
        /// <summary>
        /// Used to randomize the student list
        /// </summary>
        /// <param name="x">
        /// A student
        /// </param>
        /// <param name="y">
        /// A student
        /// </param>
        /// <returns>
        /// Random choice of -1, 0, or 1
        /// </returns>
        public int Compare(Student? x, Student? y)
        {
            if (x is null || y is null) return 0;
            if (x == y) return 0;

            return new Random().Next(-1, 2);
        }
    }
}

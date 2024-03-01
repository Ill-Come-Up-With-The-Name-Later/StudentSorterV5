namespace StudentSorter.Comparers
{
    public class GroupSizeComparer : IComparer<Group>
    {
        /// <summary>
        /// Compares two groups' sizes
        /// </summary>
        /// <param name="x">
        /// A group
        /// </param>
        /// <param name="y">
        /// A group
        /// </param>
        /// <returns>
        /// -1, 0, or 1
        /// </returns>
        public int Compare(Group? x, Group? y)
        {
            if (x == null || y == null) return 0;
            if (x == y) return 0;

            if(x.Size == y.Size) return 0;
            if(x.Size > y.Size) return -1;
            if(x.Size < y.Size) return 1;
            return 0;
        }
    }
}

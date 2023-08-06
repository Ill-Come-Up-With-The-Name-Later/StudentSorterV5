namespace StudentSorter
{
    public class Sorter
    {
        public List<Student> AllStudents = new();
        public List<Group> AllGroups = new();

        private readonly static Sorter? Instance = new();

        public static Sorter GlobalInstance() => Instance;

        public Sorter()
        {
        }
    }
}

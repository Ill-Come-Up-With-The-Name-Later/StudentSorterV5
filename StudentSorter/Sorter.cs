namespace StudentSorter
{
    public class Sorter
    {
        public List<Student> AllStudents = new();
        public List<Group> AllGroups = new();

        public static Sorter GlobalInstance = new Sorter();

        public Sorter() 
        {
            GlobalInstance = this;
        } 
    }
}

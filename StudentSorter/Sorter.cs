namespace StudentSorter
{
    public class Sorter
    {
        public List<Student> AllStudents;
        public List<Group> AllGroups;

        public static Sorter GlobalInstance = new Sorter();

        public Sorter() 
        {
            GlobalInstance = this;
        } 
    }
}

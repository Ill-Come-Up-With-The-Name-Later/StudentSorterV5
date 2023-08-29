namespace StudentSorter
{
    public partial class StudentInfoViewer : Form
    {
        private Student Student;
        private int StudentIndex;

        public StudentInfoViewer(int index)
        {
            StudentIndex = index;
            Student = Sorter.GlobalInstance().AllStudents[StudentIndex];
            InitializeComponent();
        }

        /// <summary>
        /// Loads student info on to the window
        /// </summary>
        private void StudentInfoViewer_Load(object sender, EventArgs e)
        {
            StudentNameTitle.Text = Student.Name;
        }
    }
}

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
            DeterminantSetCheck.Checked = Student.DeterminiantSet;

            DeterminantInput.Enabled = DeterminantSetCheck.Checked;
            DeterminantInput.ReadOnly = !DeterminantSetCheck.Checked;

            if (DeterminantSetCheck.Checked)
            {
                DeterminantInput.Value = Student.Determinant;
            }
        }

        /// <summary>
        /// Updates the student's determinant
        /// </summary>
        private void StudentInfoViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DeterminantSetCheck.Checked)
            {
                Student.Determinant = (int)DeterminantInput.Value;
                Student.DeterminiantSet = true;
            }
        }

        /// <summary>
        /// Enables/Disables the determinant input box
        /// </summary>
        private void DeterminantSetCheck_CheckedChanged(object sender, EventArgs e)
        {
            DeterminantInput.Enabled = DeterminantSetCheck.Checked;
            DeterminantInput.ReadOnly = !DeterminantSetCheck.Checked;
        }
    }
}

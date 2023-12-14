namespace StudentSorter
{
    public partial class StudentInfoViewer : Form
    {
        private Student Student;
        private readonly int StudentIndex;

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

            IDVal.Text = Student.GetHashCode().ToString();

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
            else
            {
                Student.Determinant = int.MinValue;
                Student.DeterminiantSet = false;
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

        /// <summary>
        /// Copies the student's ID to the clipboard
        /// </summary>
        private void CopyIDButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(IDVal.Text);
        }
    }
}

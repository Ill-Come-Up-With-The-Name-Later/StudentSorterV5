namespace StudentSorter
{
    public partial class StudentInfoViewer : Form
    {
        private readonly Student Student;
        private readonly int StudentIndex;
        private readonly Overviewer FormParent;

        public StudentInfoViewer(int index, Overviewer formParent)
        {
            StudentIndex = index;
            Student = Sorter.GlobalInstance().AllStudents[StudentIndex];

            InitializeComponent();

            FormParent = formParent;
        }

        /// <summary>
        /// Loads student info on to the window
        /// </summary>
        private void StudentInfoViewer_Load(object sender, EventArgs e)
        {
            StudentNameInput.Text = Student.Name;
            DeterminantSetCheck.Checked = Student.DeterminiantSet;

            DeterminantInput.Enabled = DeterminantSetCheck.Checked;
            DeterminantInput.ReadOnly = !DeterminantSetCheck.Checked;

            IDVal.Text = Student.GetHashCode().ToString();

            if (DeterminantSetCheck.Checked)
            {
                DeterminantInput.Value = Student.Determinant;
            }

            GroupList.Items.Add("");
            Sorter.GlobalInstance().AllGroups.ForEach(group => { GroupList.Items.Add(group.Name); });

            if (Student.HasAssignment())
            {
                ManualAssignment assignment = Student.GetAssignment();
                AssignGroupCheck.Checked = true;

                GroupList.SelectedIndex = GroupList.Items.IndexOf(Sorter.GlobalInstance().GetGroupByHashCode(assignment.GroupHashCode).Name);
            }
        }

        /// <summary>
        /// Updates the student's determinant
        /// </summary>
        private void StudentInfoViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            ErrorProvider.Clear();

            if(StudentNameInput.Text.Length == 0)
            {
                ErrorProvider.SetError(StudentNameInput, "A name is required");
            }

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

            if (AssignGroupCheck.Checked)
            {
                if (GroupList.SelectedIndex < 0)
                {
                    ErrorProvider.SetError(GroupList, "Select a group");
                }
                else
                {
                    if (!Student.HasAssignment())
                    {
                        ManualAssignment assignment = new(
                                Sorter.GlobalInstance().GetStudentByName(Student.Name).GetHashCode(), Sorter.GlobalInstance().GetGroupByName(
                                    GroupList.Items[GroupList.SelectedIndex].ToString()).GetHashCode());
                    }
                }
            }

            if (ErrorProvider.HasErrors)
            {
                return;
            }

            Student.Name = StudentNameInput.Text;

            FormParent.RefreshLists();
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

        /// <summary>
        /// Closes the window
        /// </summary>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Enables/disables group dropdown
        /// </summary>
        private void AssignGroupCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (Sorter.GlobalInstance().AllGroups.Count > 0)
                GroupList.Enabled = AssignGroupCheck.Checked;
            else
            {
                GroupList.Enabled = false;
                AssignGroupCheck.Checked = false;
                return;
            }
        }

        /// <summary>
        /// Deletes the student as well as all
        /// associated manual assignments and illegal
        /// pairs
        /// </summary>
        private void DeleteStudentButton_Click(object sender, EventArgs e)
        {
            Sorter.GlobalInstance().AllStudents.Remove(Student);

            if (Student.HasAssignment())
            {
                Sorter.GlobalInstance().Assignments.Remove(Student.GetAssignment());
            }

            foreach (IllegalPair pair in Sorter.GlobalInstance().IllegalPairs)
            {
                if (pair.Contains(Student))
                {
                    Sorter.GlobalInstance().IllegalPairs.Remove(pair);
                }
            }

            FormParent.RefreshLists();
            Close();
        }
    }
}

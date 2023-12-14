namespace StudentSorter
{
    public partial class IllegalPairCreator : Form
    {
        private readonly IllegalPairsOverviewer FormParent;

        private Student Student1 = Sorter.GlobalInstance().AllStudents[0];
        private Student Student2 = Sorter.GlobalInstance().AllStudents[1];

        public IllegalPairCreator(IllegalPairsOverviewer formParent)
        {
            InitializeComponent();
            FormParent = formParent;

            foreach (Student student in Sorter.GlobalInstance().AllStudents)
            {
                SelectStudent1.Items.Add(student.Name);
                SelectStudent2.Items.Add(student.Name);
            }
        }

        /// <summary>
        /// Selects the first student in the pair
        /// </summary>
        private void SelectStudent1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student1 = Sorter.GlobalInstance().AllStudents[SelectStudent1.SelectedIndex];
        }

        /// <summary>
        /// Selects the second student in the pair
        /// </summary>
        private void SelectStudent2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student2 = Sorter.GlobalInstance().AllStudents[SelectStudent2.SelectedIndex];
        }

        /// <summary>
        /// Adds the illegal pair
        /// </summary>
        private void AddPairButton_Click(object sender, EventArgs e)
        {
            if (SelectStudent1.SelectedIndex == -1)
            {
                ErrorProvider.SetError(SelectStudent1, "Two students are required");
            }

            if (SelectStudent2.SelectedIndex == -1)
            {
                ErrorProvider.SetError(SelectStudent2, "Two students are required");
            }

            if (SelectStudent1.SelectedIndex == SelectStudent2.SelectedIndex)
            {
                ErrorProvider.SetError(SelectStudent1, "Cannot select the same student twice");
                ErrorProvider.SetError(SelectStudent2, "Cannot select the same student twice");
            }

            IllegalPair pair = new(Student1, Student2);

            FormParent.RefreshPairList();
        }
    }
}

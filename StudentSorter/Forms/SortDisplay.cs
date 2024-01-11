using System.Data;
using StudentSorter.Debug;

namespace StudentSorter
{
    public partial class SortDisplay : Form
    {
        private readonly DataTable Groups = new();
        private readonly Overviewer FormParent;

        private readonly List<GroupStudentList> ChildForms = new();

        private SorterConfig Config { get; set; }

        public SortDisplay(Overviewer formParent, SorterConfig config)
        {
            InitializeComponent();

            GroupList.DataSource = Groups;
            Groups.Columns.Add("Name", typeof(string));
            FormParent = formParent;
            Config = config;
        }

        /// <summary>
        /// Loads the groups' names into the window
        /// </summary>
        private void SortDisplay_Load(object sender, EventArgs e)
        {
            foreach (Group group in Sorter.GlobalInstance().AllGroups)
                Groups.Rows.Add(group.Name);

            foreach (DataGridViewColumn column in GroupList.Columns)
            {
                column.Width = GroupList.Width;
            }

            StudentDropDown.Items.Add("");

            Sorter.GlobalInstance().AllStudents.ForEach(student => { StudentDropDown.Items.Add(student.Name); });

            ConfigUsedLabel.Text = $"Configuration used: {Config.Name}";

            Debugger.Log($"Used configuration: {Config.Name}");
        }

        /// <summary>
        /// Opens the list of students in the group
        /// </summary>
        private void GroupList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = GroupList.CurrentCell.RowIndex; if (index < 0) return;
            try
            {
                Group SelectedGroup = Sorter.GlobalInstance()
                    .GetGroupByName(GroupList.Rows[index].Cells[0].Value.ToString());

                GroupStudentList groupStudentList = new(SelectedGroup);
                groupStudentList.Show();

                ChildForms.Add(groupStudentList);
            }
            catch (Exception)
            {
                Console.WriteLine("Group couldn't be found.");
            }
        }

        /// <summary>
        /// Reshuffles the groups
        /// </summary>
        private void ReshuffleButton_Click(object sender, EventArgs e)
        {
            Sorter.GlobalInstance().Reset();
            Sorter.GlobalInstance().ShuffleGroups();

            if(StudentDropDown.SelectedIndex > 0)
            {
                Student student = Sorter.GlobalInstance().
                    GetStudentByName(StudentDropDown.Items[StudentDropDown.SelectedIndex].ToString());

                ShowStudentGroup(student);
            }

            ChildForms.ForEach(e => { e.Close(); });
        }

        /// <summary>
        /// Opens dialog to export the sorting result
        /// </summary>
        private void ExportSort_Click(object sender, EventArgs e)
        {
            SaveSort.ShowDialog();
        }

        /// <summary>
        /// Exports the sort result to a file
        /// </summary>
        private void SaveSort_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            List<string> lines = new();
            string file = SaveSort.FileName;

            foreach (Group group in Sorter.GlobalInstance().AllGroups)
            {
                lines.Add(group.Name);
                lines.Add("");

                foreach (Student student in group.Students)
                    lines.Add($" - {student.Name}");

                lines.Add("");
            }

            File.WriteAllLines(file, lines);
        }

        /// <summary>
        /// Resets the sorter, wipes all students, 
        /// groups, and illegal pairs
        /// </summary>
        private void ResetSorterButton_Click(object sender, EventArgs e)
        {
            Close();

            Sorter.GlobalInstance().AllStudents.Clear();
            Sorter.GlobalInstance().AllGroups.Clear();
            Sorter.GlobalInstance().IllegalPairs.Clear();
            Sorter.GlobalInstance().SortConfigs.Clear();

            FormParent.RefreshLists();
        }

        /// <summary>
        /// Searches groups for the selected
        /// student
        /// </summary>
        private void StudentDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StudentDropDown.SelectedIndex <= 0)
            {
                Groups.Rows.Clear();

                foreach (Group group in Sorter.GlobalInstance().AllGroups)
                    Groups.Rows.Add(group.Name);
                return;
            }

            try
            {
                Student student = Sorter.GlobalInstance().
                    GetStudentByName(StudentDropDown.Items[StudentDropDown.SelectedIndex].ToString());

                ShowStudentGroup(student);
            }
            catch (Exception)
            {
                Console.WriteLine("Couldn't find student");
            }
        }

        /// <summary>
        /// Sets the group list to display
        /// only the group that a student is in
        /// </summary>
        /// <param name="student">
        /// The student whose group to show
        /// </param>
        private void ShowStudentGroup(Student student)
        {
            Groups.Rows.Clear();

            Groups.Rows.Add(Sorter.GlobalInstance().FindStudent(student).Name);
        }
    }
}

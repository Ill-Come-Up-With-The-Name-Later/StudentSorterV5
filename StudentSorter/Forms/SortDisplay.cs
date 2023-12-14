using System.Data;
using System.Diagnostics;

namespace StudentSorter
{
    public partial class SortDisplay : Form
    {
        private readonly DataTable Groups = new();
        private readonly Overviewer FormParent;

        public SortDisplay(Overviewer formParent)
        {
            InitializeComponent();

            GroupList.DataSource = Groups;
            Groups.Columns.Add("Name", typeof(string));
            FormParent = formParent;
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
        }

        /// <summary>
        /// Opens the list of students in the group
        /// </summary>
        private void GroupList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = GroupList.CurrentCell.RowIndex; if (index < 0) return;
            Group SelectedGroup = Sorter.GlobalInstance().AllGroups[index];

            GroupStudentList groupStudentList = new(SelectedGroup);
            groupStudentList.Show();
        }

        /// <summary>
        /// Reshuffles the groups
        /// </summary>
        private void ReshuffleButton_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcesses();

            foreach (Process process in processes)
            {
                if (process.MainWindowTitle.Equals("Group Student List"))
                {
                    process.Kill();
                }
            }

            Sorter.GlobalInstance().Reset();
            Sorter.GlobalInstance().ShuffleGroups();
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
    }
}

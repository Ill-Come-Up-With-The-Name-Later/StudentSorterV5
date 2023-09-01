using System.Data;
using System.Diagnostics;

namespace StudentSorter
{
    public partial class SortDisplay : Form
    {
        private readonly DataTable Groups = new();

        public SortDisplay()
        {
            InitializeComponent();

            GroupList.DataSource = Groups;
            Groups.Columns.Add("Name", typeof(string));
        }

        /// <summary>
        /// Loads the groups' names into the window
        /// </summary>
        private void SortDisplay_Load(object sender, EventArgs e)
        {
            foreach (Group group in Sorter.GlobalInstance().AllGroups)
                Groups.Rows.Add(group.Name);
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
    }
}

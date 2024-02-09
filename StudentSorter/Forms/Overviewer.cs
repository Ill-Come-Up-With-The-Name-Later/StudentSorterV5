using StudentSorter.Debug;
using System.ComponentModel;
using System.Data;

namespace StudentSorter
{
    public enum SortAlgorithm
    {
        SelectiveShuffle,
        HatDrawShuffle
    }

    public partial class Overviewer : Form
    {
        private readonly DataTable students = new();
        private readonly DataTable groups = new();

        public string StudentFile = "";
        public string GroupFile = "";
        public string IllegalPairFile = "";
        public string ManualAssignmentsFile = "";

        public SortAlgorithm Algorithm = SortAlgorithm.SelectiveShuffle;

        public Overviewer()
        {
            InitializeComponent();

            StudentViewer.DataSource = students;
            students.Columns.Add("Name", typeof(string));

            foreach (Student student in Sorter.GlobalInstance().AllStudents)
                students.Rows.Add(student.Name);

            GroupViewer.DataSource = groups;
            groups.Columns.Add("Name", typeof(string));

            foreach (Group group in Sorter.GlobalInstance().AllGroups)
                groups.Rows.Add(group.Name);
        }

        /// <summary>
        /// Opens a window to create a student or add from a json file
        /// </summary>
        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            CreateStudentWindow studentWindow = new(this);
            studentWindow.Show();
        }

        /// <summary>
        /// Opens a window to create a group or add from a json file
        /// </summary>
        private void AddGroupButton_Click(object sender, EventArgs e)
        {
            CreateGroupWindow window = new(this);
            window.Show();
        }

        /// <summary>
        /// Serializes students into a json file
        /// </summary>
        private void SerializeStudentsButton_Click(object sender, EventArgs e)
        {
            StudentSerialize.ShowDialog();
        }

        /// <summary>
        /// Serializes groups into a json file
        /// </summary>
        private void SerializeGroupsButton_Click(object sender, EventArgs e)
        {
            GroupSerialize.ShowDialog();
        }

        /// <summary>
        /// Saves groups to a json file
        /// </summary>
        private void GroupSerialize_FileOk(object sender, CancelEventArgs e)
        {
            string file = GroupSerialize.FileName;

            Exporter.ExportObjects(Sorter.GlobalInstance().AllGroups, file);
            GroupFile = file;
            GroupSource.Text = $"Group File Source: {file}";

            Debugger.Log($"Saved groups to: {file}");
        }

        /// <summary>
        /// Saves students to a json file
        /// </summary>
        private void StudentSerialize_FileOk(object sender, CancelEventArgs e)
        {
            string file = StudentSerialize.FileName;

            Exporter.ExportObjects(Sorter.GlobalInstance().AllStudents, file);

            StudentFile = file;
            StudentSource.Text = $"Student File Source: {file}";
            Debugger.Log($"Saved students to: {file}");
        }

        /// <summary>
        /// Refreshes the lists of students and groups
        /// </summary>
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshLists();
        }

        /// <summary>
        /// Goes to the sorting window to display the results
        /// </summary>
        private void SortButton_Click(object sender, EventArgs e)
        {
            Debugger.Log("Sort begun");

            ErrorProvider.Clear();

            if (Sorter.GlobalInstance().AllGroups.Count == 0 || Sorter.GlobalInstance().AllGroups.Count == 0)
            {
                ErrorProvider.SetError(SortButton, "At least 1 group and 1 student is required.");
                return;
            }

            Sorter.GlobalInstance().DeterminantRange =
                    Sorter.GlobalInstance().AllStudents.Count / Sorter.GlobalInstance().AllGroups.Count;

            Sorter.GlobalInstance().RandomizeDeterminants();

            // Sort using a different algorithm depending on what is
            // selected
            if (Algorithm == SortAlgorithm.SelectiveShuffle)
            {
                Debugger.Log("Selected Shuffle Sort");
                Sorter.GlobalInstance().ShuffleGroups();
            }
            else
            {
                Debugger.Log("Selected Hat Draw Shuffle");
                Sorter.GlobalInstance().HatDrawShuffle();
            }

            SortDisplay display = new(this, new SorterConfig("None", "", "", "", ""), Algorithm);
            display.Show();
        }

        /// <summary>
        /// Opens information about the selected student
        /// </summary>
        private void StudentViewer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = Sorter.GlobalInstance().AllStudents.IndexOf(
                Sorter.GlobalInstance().GetStudentByName(StudentViewer.CurrentCell.Value.ToString()));

            StudentInfoViewer viewer = new(index, this);
            viewer.Show();

            Debugger.Log($"Showing info for a student");
        }

        /// <summary>
        /// Opens information about the selected group
        /// </summary>
        private void GroupViewer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = Sorter.GlobalInstance().AllGroups.IndexOf(
                Sorter.GlobalInstance().GetGroupByName(GroupViewer.CurrentCell.Value.ToString()));

            GroupInfoViewer viewer = new(index, this);
            viewer.Show();

            Debugger.Log("Showing info for a group");
        }

        /// <summary>
        /// Opens a window to modify illegal pairs
        /// </summary>
        private void DisallowedPairButton_Click(object sender, EventArgs e)
        {
            IllegalPairsOverviewer overviewer = new(this);
            overviewer.Show();
        }

        /// <summary>
        /// Refreshes student and group lists
        /// </summary>
        public void RefreshLists()
        {
            try
            {
                students.Rows.Clear();
            }
            catch (Exception) { }

            foreach (Student student in Sorter.GlobalInstance().AllStudents)
            {
                students.Rows.Add(student.Name);
            }

            StudentLabel.Text = $"Students: {students.Rows.Count}";

            try
            {
                groups.Rows.Clear();
            }
            catch (Exception) { }

            foreach (Group group in Sorter.GlobalInstance().AllGroups)
            {
                groups.Rows.Add(group.Name);
            }

            GroupLabel.Text = $"Groups: {groups.Rows.Count}";

            if (groups.Rows.Count > 0 && students.Rows.Count > 0)
            {
                ManualAssignmentButton.Enabled = true;
            }
            else
            {
                ManualAssignmentButton.Enabled = false;
            }
        }

        /// <summary>
        /// Opens config saver dialog
        /// </summary>
        private void SaveConfigButton_Click(object sender, EventArgs e)
        {
            ConfigSaver.ShowDialog();
        }

        /// <summary>
        /// Saves the current configuration for the sorter
        /// </summary>
        private void ConfigSaver_FileOk(object sender, CancelEventArgs e)
        {
            SorterConfig sort = new("Configuration", StudentFile, GroupFile, IllegalPairFile, ManualAssignmentsFile);

            Exporter.ExportObject(sort, ConfigSaver.FileName);
            Debugger.Log($"Created configuration: {ConfigSaver.FileName}");
        }

        /// <summary>
        /// Open dialog to upload manual assignments
        /// </summary>
        private void ManualAssignmentButton_Click(object sender, EventArgs e)
        {
            OpenAssignments.ShowDialog();
        }

        /// <summary>
        /// Uploads manual assignments
        /// </summary>
        private void OpenAssignments_FileOk(object sender, CancelEventArgs e)
        {
            Importer.Import<ManualAssignment>(OpenAssignments.FileName);

            ManualAssignmentFile.Text = $"Manual Assignment File Source: {OpenAssignments.FileName}";
            Debugger.Log($"Created numerous assignments from {OpenAssignments.FileName}");
        }

        /// <summary>
        /// Opens dialog to save all manual assignments
        /// </summary>
        private void SaveAssignmentsButton_Click(object sender, EventArgs e)
        {
            SaveAssignmentDialog.ShowDialog();
        }

        /// <summary>
        /// Exports manual assignments to
        /// JSON
        /// </summary>
        private void SaveAssignmentDialog_FileOk(object sender, CancelEventArgs e)
        {
            Exporter.ExportObjects(Sorter.GlobalInstance().Assignments, SaveAssignmentDialog.FileName);

            ManualAssignmentFile.Text = $"Manual Assignment File Source: {SaveAssignmentDialog.FileName}";
            Debugger.Log($"Created configuration: {SaveAssignmentDialog.FileName}");
        }

        /// <summary>
        /// Selects the shuffling algorithm:
        /// Selective Shuffle Sort
        /// </summary>
        private void StandardSortButton_CheckedChanged(object sender, EventArgs e)
        {
            if(StandardSortButton.Checked) Algorithm = SortAlgorithm.SelectiveShuffle;
        }

        /// <summary>
        /// Selects the shuffling algorithm:
        /// 'Hat Draw Shuffle
        /// </summary>
        private void HatDrawButton_CheckedChanged(object sender, EventArgs e)
        {
            if(HatDrawButton.Checked) Algorithm = SortAlgorithm.HatDrawShuffle;
        }
    }
}

using StudentSorter.Debug;
using StudentSorter.FileHandling;
using StudentSorter.SorterComponent;

namespace StudentSorter.Forms
{
    public partial class CreateSortConfig : Form
    {
        private string StudentFile = "";
        private string GroupFile = "";
        private string PairsFile = "";
        private string AssignmentsFile = "";
        private SortAlgorithm Algorithm = SortAlgorithm.SelectiveShuffle;

        const string StudentTitle = "Select Student File";
        const string GroupTitle = "Select Group File";
        const string PairFile = "Select Pair File";
        const string AssignFile = "Select Manual Assignments File";

        public CreateSortConfig()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens dialog to select student file
        /// </summary>
        private void AddStudentFile_Click(object sender, EventArgs e)
        {
            SelectFile.Title = StudentTitle;
            SelectFile.ShowDialog();
        }

        /// <summary>
        /// Opens dialog to select group file
        /// </summary>
        private void AddGroupFile_Click(object sender, EventArgs e)
        {
            SelectFile.Title = GroupTitle;
            SelectFile.ShowDialog();
        }

        /// <summary>
        /// Opens dialog to select illegal pairs file
        /// </summary>
        private void AddPairsFile_Click(object sender, EventArgs e)
        {
            SelectFile.Title = PairFile;
            SelectFile.ShowDialog();
        }

        /// <summary>
        /// Adds either the student, group, or
        /// illegal pairs file to the config
        /// </summary>
        private void SelectFile_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            switch (SelectFile.Title)
            {
                case StudentTitle:
                    StudentFile = SelectFile.FileName;
                    break;
                case GroupTitle:
                    GroupFile = SelectFile.FileName;
                    break;
                case PairFile:
                    PairsFile = SelectFile.FileName;
                    break;
                case AssignFile:
                    AssignmentsFile = SelectFile.FileName;
                    break;
            }

            UpdateFileDisplay();
        }

        /// <summary>
        /// Opens save dialog for the sort
        /// config
        /// </summary>
        private void CreateConfigButton_Click(object sender, EventArgs e)
        {
            SaveConfig.ShowDialog();
        }

        /// <summary>
        /// Updates the display for the
        /// student, group, and pairs file names
        /// </summary>
        private void UpdateFileDisplay()
        {
            if (StudentFile.Length > 0)
                StudentFileName.Text = $"Student File: {StudentFile.Split("\\").Last()}";

            if (GroupFile.Length > 0)
                GroupFileName.Text = $"Group File: {GroupFile.Split("\\").Last()}";

            if (PairsFile.Length > 0)
                DisallowedPairsFileName.Text = $"Disallowed Pairs File: {PairsFile.Split("\\").Last()}";

            if (AssignmentsFile.Length > 0)
                DisallowedPairsFileName.Text = $"Manual Assignment File: {AssignmentsFile.Split("\\").Last()}";
        }

        /// <summary>
        /// Creates the sorter configuration
        /// and exports it to JSON
        /// </summary>
        private void SaveConfig_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SorterConfig sort = new(ConfigNameInput.Text, StudentFile, GroupFile, PairsFile, AssignmentsFile, Algorithm);

            Exporter.ExportObject(sort, SaveConfig.FileName);
            Close();

            Debugger.Log($"Created Sorter Config: {sort}");
        }

        /// <summary>
        /// Opens dialog to upload manual assignment file
        /// </summary>
        private void AddAssignmentFileButton_Click(object sender, EventArgs e)
        {
            SelectFile.Title = AssignFile;
            SelectFile.ShowDialog();
        }

        /// <summary>
        /// Selects sorting algorithm:
        /// Selective Shuffle
        /// </summary>
        private void SelectiveShuffleButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectiveShuffleButton.Checked)
            {
                Debugger.Log("Selective Shuffle algorithm selected");
                Algorithm = SortAlgorithm.SelectiveShuffle;
            }
        }

        /// <summary>
        /// Selects sorting algorithm:
        /// 'Hat Draw' Shuffle
        /// </summary>
        private void HatDrawButton_CheckedChanged(object sender, EventArgs e)
        {
            if (HatDrawButton.Checked)
            {
                Debugger.Log("'Hat Draw' shuffle alogrithm selected");
                Algorithm = SortAlgorithm.HatDrawShuffle;
            }
        }

        /// <summary>
        /// Selects sorting algorithm:
        /// 'Dodgeball Team' Shuffle
        /// </summary>
        private void DodgeballTeamButton_CheckedChanged(object sender, EventArgs e)
        {
            if (DodgeballTeamButton.Checked)
            {
                Debugger.Log("'Dodgeball Team' shuffle alogrithm selected");
                Algorithm = SortAlgorithm.DodgeballTeamShuffle;
            }
        }
    }
}

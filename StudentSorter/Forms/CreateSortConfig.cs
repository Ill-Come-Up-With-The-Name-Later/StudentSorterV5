namespace StudentSorter.Forms
{
    public partial class CreateSortConfig : Form
    {
        private string StudentFile = "";
        private string GroupFile = "";
        private string PairsFile = "";

        const string StudentTitle = "Select Student File";
        const string GroupTitle = "Select Group File";
        const string PairFile = "Select Pair File";

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
        }

        /// <summary>
        /// Creates the sorter configuration
        /// and exports it to JSON
        /// </summary>
        private void SaveConfig_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SorterConfig sort = new(ConfigNameInput.Text, StudentFile, GroupFile, PairsFile);

            Exporter.ExportObject(sort, SaveConfig.FileName);
            Close();
        }
    }
}

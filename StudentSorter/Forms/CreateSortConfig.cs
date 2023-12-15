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
        }

        /// <summary>
        /// Opens dialog to select group file
        /// </summary>
        private void AddGroupFile_Click(object sender, EventArgs e)
        {
            SelectFile.Title = GroupTitle;
        }

        /// <summary>
        /// Opens dialog to select illegal pairs file
        /// </summary>
        private void AddPairsFile_Click(object sender, EventArgs e)
        {
            SelectFile.Title = PairFile;
        }

        /// <summary>
        /// Adds either the student, group, or
        /// illegal pairs file to the config
        /// </summary>
        private void SelectFile_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            switch(SelectFile.Title)
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
        /// Creates the sort configuration and opens
        /// save dialog
        /// </summary>
        private void CreateConfigButton_Click(object sender, EventArgs e)
        {
            Sort sort = new(StudentFile, GroupFile, PairsFile);

            List<string> lines = new()
            {
                sort.SerializeJSON()
            };

            Exporter.Export(SaveConfig.FileName, lines);
        }

        /// <summary>
        /// Updates the display for the
        /// student, group, and pairs file names
        /// </summary>
        private void UpdateFileDisplay()
        {
            if(StudentFile.Length > 0)
                StudentFileName.Text = $"Student File: {StudentFile}";

            if(GroupFile.Length > 0)
                GroupFileName.Text = $"Group File: {GroupFile}";

            if(PairsFile.Length > 0)
                DisallowedPairsFileName.Text = $"Disallowed Pairs File: {PairsFile}";
        }
    }
}

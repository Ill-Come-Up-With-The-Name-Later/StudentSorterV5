using System.ComponentModel;

namespace StudentSorter
{
    public partial class CreateStudentWindow : Form
    {
        private Overviewer FormParent;

        public CreateStudentWindow(Overviewer formParent)
        {
            InitializeComponent();
            FormParent = formParent;
        }

        /// <summary>
        /// Uploads the selected JSON File
        /// </summary>
        private void JsonUploader_FileOk(object sender, CancelEventArgs e)
        {
            Importer.Import<Student>(JsonUploader.FileName);
            FormParent.StudentFile = JsonUploader.FileName;

            FormParent.RefreshLists();
            FormParent.StudentSource.Text = $"Student File Source: {JsonUploader.FileName}";

            Close();
        }

        /// <summary>
        /// Sets whether the mannual determinant box is enabled
        /// </summary>
        private void ManualAssignCheck_CheckedChanged(object sender, EventArgs e)
        {
            DeterminantInput.Enabled = ManualAssignCheck.Checked;
            DeterminantInput.ReadOnly = !ManualAssignCheck.Checked;

            if (!DeterminantInput.Enabled) DeterminantInput.Value = 0;
        }

        /// <summary>
        /// Creates the student
        /// </summary>
        private void CreateStudentButton_Click(object sender, EventArgs e)
        {
            if (StudentNameInput.Text == null || StudentNameInput.Text.Equals(""))
            {
                ErrorProvider.SetError(StudentNameInput, "A name is required");
            }

            if (ErrorProvider.HasErrors)
            {
                return;
            }

            if (!ManualAssignCheck.Checked)
            {
                Student student = new(StudentNameInput.Text);
            }
            else
            {
                Student student = new(StudentNameInput.Text, (int)DeterminantInput.Value);
            }

            if (ManualGroupAssignCheck.Checked)
            {
                if (GroupList.SelectedIndex < 0)
                {
                    ErrorProvider.SetError(GroupList, "A group must be selected");
                    return;
                }

                ManualAssignment assignment = new(
                    Sorter.GlobalInstance().GetStudentByName(StudentNameInput.Text).GetHashCode(), Sorter.GlobalInstance().GetGroupByName(
                        GroupList.Items[GroupList.SelectedIndex].ToString()).GetHashCode());
            }

            StudentNameInput.Text = "";
            DeterminantInput.Value = 0;
            ManualAssignCheck.Checked = false;
            GroupList.Enabled = false;
            GroupList.SelectedIndex = -1;

            FormParent.RefreshLists();
        }

        /// <summary>
        /// Opens the File Explorer to upload json
        /// </summary>
        private void JsonUploadButton_Click(object sender, EventArgs e)
        {
            JsonUploader.ShowDialog();
        }

        /// <summary>
        /// Enables/disables manual group assignment
        /// </summary>
        private void ManualGroupAssignCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(Sorter.GlobalInstance().AllGroups.Count > 0)
                GroupList.Enabled = ManualGroupAssignCheck.Checked;
            else
            {
                GroupList.Enabled = false;
                ManualGroupAssignCheck.Checked = false;
                return;
            }
        }

        /// <summary>
        /// Adds all groups to manual assignment group
        /// list
        /// </summary>
        private void CreateStudentWindow_Load(object sender, EventArgs e)
        {
            GroupList.Enabled = false;
            GroupList.Items.Add("");
            Sorter.GlobalInstance().AllGroups.ForEach(group => { GroupList.Items.Add(group.Name); });
        }

        /// <summary>
        /// Opens dialog to upload roster PDF
        /// </summary>
        private void PDFUploadButton_Click(object sender, EventArgs e)
        {
            PDFOpener.ShowDialog();
        }

        /// <summary>
        /// Uploads students through a PDF
        /// </summary>
        private void PDFOpener_FileOk(object sender, CancelEventArgs e)
        {
            string file = PDFOpener.FileName;
            int startPage = (int)PageStartInput.Value - 1;
            int endPage = (int)PageEndInput.Value - 1;

            List<string> names = Sorter.GetNamesFromPDF(file, startPage, endPage);

            foreach (string name in names)
            {
                Student student = new(name);
            }

            Close();
            FormParent.RefreshLists();
        }
    }
}

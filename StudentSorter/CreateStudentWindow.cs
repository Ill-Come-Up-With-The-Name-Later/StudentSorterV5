using System.ComponentModel;

namespace StudentSorter
{
    public partial class CreateStudentWindow : Form
    {
        public CreateStudentWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Uploads the selected JSON File
        /// </summary>
        private void JsonUploader_FileOk(object sender, CancelEventArgs e)
        {
            Importer.Import<Student>(JsonUploader.FileName);
        }

        /// <summary>
        /// Sets whether the mannual determinant box is enabled
        /// </summary>
        private void ManualAssignCheck_CheckedChanged(object sender, EventArgs e)
        {
            DeterminantInput.ReadOnly = !ManualAssignCheck.Checked;

            if (DeterminantInput.ReadOnly) DeterminantInput.Value = 0;
        }

        /// <summary>
        /// Creates the student
        /// </summary>
        private void CreateStudentButton_Click(object sender, EventArgs e)
        {
            if(StudentNameInput.Text == null)
            {
                return;
                throw new ArgumentNullException("Student name was null");
            }
            if(DeterminantInput.ReadOnly)
            {
                Student student = new(StudentNameInput.Text);
                return;
            }
            Student student1 = new(StudentNameInput.Text, (int) DeterminantInput.Value);
        }

        /// <summary>
        /// Opens the File Explorer to upload json
        /// </summary>
        private void JsonUploadButton_Click(object sender, EventArgs e)
        {
            JsonUploader.ShowDialog(this);
        }
    }
}

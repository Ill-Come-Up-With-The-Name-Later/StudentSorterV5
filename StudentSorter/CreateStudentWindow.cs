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
                return;
                throw new ArgumentNullException("Student name was null");
            }
            if (!ManualAssignCheck.Checked)
            {
                Student student = new(StudentNameInput.Text);
            }
            else
            {
                Student student = new(StudentNameInput.Text, (int)DeterminantInput.Value);
            }
            StudentNameInput.Text = "";
            DeterminantInput.Value = 0;

            Console.WriteLine("Created Student!");
        }

        /// <summary>
        /// Opens the File Explorer to upload json
        /// </summary>
        private void JsonUploadButton_Click(object sender, EventArgs e)
        {
            JsonUploader.ShowDialog();
        }
    }
}

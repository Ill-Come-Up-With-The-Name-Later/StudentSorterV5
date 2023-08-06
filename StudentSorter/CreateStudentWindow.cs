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
            DeterminantInput.Enabled = ManualAssignCheck.Checked;

            if (!DeterminantInput.Enabled) DeterminantInput.Value = 0;
        }

        /// <summary>
        /// Creates the student
        /// </summary>
        private void CreateStudentButton_Click(object sender, EventArgs e)
        {
            if (StudentNameInput.Text == null || StudentNameInput.Text.Equals(""))
            {
                return;
                throw new ArgumentNullException("Student name was null");
            }
            if (DeterminantInput.Enabled)
            {
                Student student = new(StudentNameInput.Text);
            }
            else
            {
                Student student = new(StudentNameInput.Text, (int)DeterminantInput.Value);
            }
            StudentNameInput.Text = "";

            Console.WriteLine("Created Student!");
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

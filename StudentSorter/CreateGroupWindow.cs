using System.ComponentModel;

namespace StudentSorter
{
    public partial class CreateGroupWindow : Form
    {
        public CreateGroupWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Uploads the JSON of the groups and creates the objects
        /// </summary>
        private void JsonUploader_FileOk(object sender, CancelEventArgs e)
        {
            Importer.Import<Group>(JsonUploader.FileName);
        }

        /// <summary>
        /// Creates group based on input parameters
        /// </summary>
        private void CreateGroupButton_Click(object sender, EventArgs e)
        {
            if(GroupNameInput.Text.Equals("") || GroupNameInput.Text == null)
            {
                return;
                throw new ArgumentException("No name entered!");
            }

            string name = GroupNameInput.Text;
            int capacity = (int)CapacityInput.Value;
            int minDeterminant = (int)MinDeterminantInput.Value;
            int maxDeterminant = (int)MaxDeterminantInput.Value;

            Group group = new(name, capacity, minDeterminant, maxDeterminant);
            Console.WriteLine("Created group!");
        }

        /// <summary>
        /// Opens the JSON file upload box to add groups
        /// </summary>
        private void JsonImportButton_Click(object sender, EventArgs e)
        {
            JsonUploader.ShowDialog();
        }
    }
}

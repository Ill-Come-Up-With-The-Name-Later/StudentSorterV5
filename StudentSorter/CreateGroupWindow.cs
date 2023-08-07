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
    }
}

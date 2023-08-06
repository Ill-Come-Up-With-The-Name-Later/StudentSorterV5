using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSorter
{
    public partial class CreateGroupWindow : Form
    {
        public CreateGroupWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Uploads the json of the groups and creates the objects
        /// </summary>
        private void JsonUploader_FileOk(object sender, CancelEventArgs e)
        {
            Importer.Import<Group>(JsonUploader.FileName);
        }
    }
}

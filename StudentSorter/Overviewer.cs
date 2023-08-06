using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSorter
{
    public partial class Overviewer : Form
    {
        public Overviewer()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Opens information about the selected student
        /// </summary>
        private void StudentViewer_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Opens information about the selected group
        /// </summary>
        private void GroupViewer_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Opens a window to create a student or add from a json file
        /// </summary>
        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            CreateStudentWindow studentWindow = new();
            studentWindow.Show(this);
        }

        /// <summary>
        /// Opens a window to create a group or add from a json file
        /// </summary>
        private void AddGroupButton_Click(object sender, EventArgs e)
        {

        }
    }
}

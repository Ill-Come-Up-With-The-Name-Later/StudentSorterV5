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
    public partial class StudentInfoViewer : Form
    {
        private Student Student;

        public StudentInfoViewer(Student student)
        {
            Student = student;
            InitializeComponent();
        }

        /// <summary>
        /// Loads student info on to the window
        /// </summary>
        private void StudentInfoViewer_Load(object sender, EventArgs e)
        {
            StudentNameTitle.Text = Student.Name;
        }
    }
}

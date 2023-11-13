using System.Data;

namespace StudentSorter
{
    public partial class GroupStudentList : Form
    {
        private readonly Group DisplayGroup;
        private readonly DataTable StudentData = new();

        public GroupStudentList(Group group)
        {
            InitializeComponent();

            DisplayGroup = group;
            StudentList.DataSource = StudentData;

            StudentData.Columns.Add("Student Name", typeof(string));
            StudentData.Columns.Add("Weight", typeof(int));

            Title.Text = $"Students in {group.Name}";
        }

        /// <summary>
        /// Loads the student names into the list
        /// </summary>
        private void GroupStudentList_Load(object sender, EventArgs e)
        {
            foreach (Student student in DisplayGroup.Students)
            {
                StudentData.Rows.Add(student.Name, student.Determinant);
            }

            foreach (DataGridViewColumn column in StudentList.Columns)
            {
                column.Width = StudentList.Width / 2;
            }
        }
    }
}

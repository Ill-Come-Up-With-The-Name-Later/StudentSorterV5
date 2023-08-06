﻿using System.ComponentModel;
using System.Data;

namespace StudentSorter
{
    public partial class Overviewer : Form
    {
        private readonly DataTable students = new();
        private readonly DataTable groups = new();

        public Overviewer()
        {
            InitializeComponent();
            StudentViewer.DataSource = students;
            students.Columns.Add("Name", typeof(string));

            foreach (Student student in Sorter.GlobalInstance().AllStudents)
            {
                students.Rows.Add(student.Name);
            }

            GroupViewer.DataSource = groups;
            groups.Columns.Add("Name", typeof(string));

            foreach (Group group in Sorter.GlobalInstance().AllGroups)
            {
                groups.Rows.Add(group.Name);
            }
        }

        /// <summary>
        /// Opens information about the selected student
        /// </summary>
        private void StudentViewer_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Student student = Sorter.GlobalInstance().AllStudents[StudentViewer.CurrentCell.RowIndex];
        }

        /// <summary>
        /// Opens information about the selected group
        /// </summary>
        private void GroupViewer_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Group group = Sorter.GlobalInstance().AllGroups[GroupViewer.CurrentCell.RowIndex];
        }

        /// <summary>
        /// Opens a window to create a student or add from a json file
        /// </summary>
        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            CreateStudentWindow studentWindow = new();
            studentWindow.Show();
        }

        /// <summary>
        /// Opens a window to create a group or add from a json file
        /// </summary>
        private void AddGroupButton_Click(object sender, EventArgs e)
        {
            CreateGroupWindow window = new();
            window.Show();
        }

        /// <summary>
        /// Serializes students into a json file
        /// </summary>
        private void SerializeStudentsButton_Click(object sender, EventArgs e)
        {
            StudentSerialize.ShowDialog();
        }

        /// <summary>
        /// Serializes groups into a json file
        /// </summary>
        private void SerializeGroupsButton_Click(object sender, EventArgs e)
        {
            GroupSerialize.ShowDialog();
        }

        /// <summary>
        /// Saves groups to a json file
        /// </summary>
        private void GroupSerialize_FileOk(object sender, CancelEventArgs e)
        {
            string file = GroupSerialize.FileName;
            List<string> groups = new();

            foreach (Group group in Sorter.GlobalInstance().AllGroups)
            {
                groups.Add(group.SerializeJSON());
            }
            Exporter.Export(file, groups);
        }

        /// <summary>
        /// Saves students to a json file
        /// </summary>
        private void StudentSerialize_FileOk(object sender, CancelEventArgs e)
        {
            string file = StudentSerialize.FileName;
            List<string> students = new();

            foreach (Student student in Sorter.GlobalInstance().AllStudents)
            {
                students.Add(student.SerializeJSON());
            }

            Console.WriteLine(students.Count);

            Exporter.Export(file, students);
        }

        /// <summary>
        /// Refreshes the lists of students and groups
        /// </summary>
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (StudentViewer.Rows.Count > 0)
                    StudentViewer.Rows.Clear();

                if (GroupViewer.Rows.Count > 0)
                    GroupViewer.Rows.Clear();

                foreach (Student student in Sorter.GlobalInstance().AllStudents)
                    students.Rows.Add(student.Name);

                foreach (Group group in Sorter.GlobalInstance().AllGroups)
                    groups.Rows.Add(group.Name);
            } catch (Exception) { }
        }

        /// <summary>
        /// Goes to the sorting window to display the results
        /// </summary>
        private void SortButton_Click(object sender, EventArgs e)
        {

        }
    }
}

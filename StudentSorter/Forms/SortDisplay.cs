using System.ComponentModel;
using System.Data;
using System.Threading.Tasks.Dataflow;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using StudentSorter.Debug;

namespace StudentSorter
{
    public partial class SortDisplay : Form
    {
        private readonly DataTable Groups = new();
        private readonly Overviewer FormParent;

        private SortAlgorithm Algorithm;

        private readonly List<GroupStudentList> ChildForms = new();

        public SorterConfig Config { get; set; }

        public SortDisplay(Overviewer formParent, SorterConfig config, SortAlgorithm algorithm)
        {
            InitializeComponent();

            GroupList.DataSource = Groups;
            Groups.Columns.Add("Name", typeof(string));
            FormParent = formParent;
            Config = config;
            Algorithm = algorithm;
        }

        /// <summary>
        /// Loads the groups' names into the window
        /// </summary>
        private void SortDisplay_Load(object sender, EventArgs e)
        {
            foreach (Group group in Sorter.GlobalInstance().AllGroups)
                Groups.Rows.Add(group.Name);

            foreach (DataGridViewColumn column in GroupList.Columns)
            {
                column.Width = GroupList.Width;
            }

            StudentDropDown.Items.Add("");

            Sorter.GlobalInstance().AllStudents.ForEach(student => { StudentDropDown.Items.Add(student.Name); });

            ConfigUsedLabel.Text = $"Configuration used: {Config.Name}";

            Debugger.Log($"Used configuration: {Config.Name}");
        }

        /// <summary>
        /// Opens the list of students in the group
        /// </summary>
        private void GroupList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = GroupList.CurrentCell.RowIndex; if (index < 0) return;
            try
            {
                Group SelectedGroup = Sorter.GlobalInstance()
                    .GetGroupByName(GroupList.Rows[index].Cells[0].Value.ToString());

                GroupStudentList groupStudentList = new(SelectedGroup);
                groupStudentList.Show();

                ChildForms.Add(groupStudentList);
                Debugger.Log($"Showing information for {SelectedGroup.Name}");
            }
            catch (Exception)
            {
                Debugger.Log("Group couldn't be found.");
            }
        }

        /// <summary>
        /// Reshuffles the groups
        /// </summary>
        private void ReshuffleButton_Click(object sender, EventArgs e)
        {
            Debugger.Log("Reshuffling begun");

            Sorter.GlobalInstance().Reset();

            switch (Algorithm)
            {
                case SortAlgorithm.SelectiveShuffle:
                    Sorter.GlobalInstance().ShuffleGroups();
                    break;
                case SortAlgorithm.HatDrawShuffle:
                    Sorter.GlobalInstance().HatDrawShuffle();
                    break;
                case SortAlgorithm.DodgeballTeamShuffle:
                    Sorter.GlobalInstance().DodgeballTeamShuffle();
                    break;
            }

            if (StudentDropDown.SelectedIndex > 0)
            {
                Student student = Sorter.GlobalInstance().
                    GetStudentByName(StudentDropDown.Items[StudentDropDown.SelectedIndex].ToString());

                Debugger.Log($"Searching for {student.Name}");
                ShowStudentGroup(student);
            }

            ChildForms.ForEach(e => { e.Close(); });
        }

        /// <summary>
        /// Opens dialog to export the sorting result
        /// </summary>
        private void ExportSort_Click(object sender, EventArgs e)
        {
            SaveSort.ShowDialog();
        }

        /// <summary>
        /// Exports the sort result to a file
        /// </summary>
        private void SaveSort_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            List<string> lines = new();
            string file = SaveSort.FileName;

            foreach (Group group in Sorter.GlobalInstance().AllGroups)
            {
                lines.Add(group.Name);
                lines.Add("");

                foreach (Student student in group.Students)
                    lines.Add($" - {student.Name}");

                lines.Add("");
            }

            File.WriteAllLines(file, lines);
            Debugger.Log($"Saved sort to {file}");
        }

        /// <summary>
        /// Resets the sorter, wipes all students, 
        /// groups, and illegal pairs
        /// </summary>
        private void ResetSorterButton_Click(object sender, EventArgs e)
        {
            Close();

            Sorter.GlobalInstance().AllStudents.Clear();
            Sorter.GlobalInstance().AllGroups.Clear();
            Sorter.GlobalInstance().IllegalPairs.Clear();
            Sorter.GlobalInstance().SortConfigs.Clear();

            FormParent.RefreshLists();
            Debugger.Log("Wiped the sorter.");
        }

        /// <summary>
        /// Searches groups for the selected
        /// student
        /// </summary>
        private void StudentDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StudentDropDown.SelectedIndex <= 0)
            {
                Groups.Rows.Clear();

                foreach (Group group in Sorter.GlobalInstance().AllGroups)
                    Groups.Rows.Add(group.Name);
                return;
            }

            try
            {
                Student student = Sorter.GlobalInstance().
                    GetStudentByName(StudentDropDown.Items[StudentDropDown.SelectedIndex].ToString());

                ShowStudentGroup(student);
                Debugger.Log($"Searching for {student.Name}");
            }
            catch (Exception)
            {
                Debugger.Log("Couldn't find student");
            }
        }

        /// <summary>
        /// Sets the group list to display
        /// only the group that a student is in
        /// </summary>
        /// <param name="student">
        /// The student whose group to show
        /// </param>
        private void ShowStudentGroup(Student student)
        {
            Groups.Rows.Clear();

            Groups.Rows.Add(Sorter.GlobalInstance().FindStudent(student).Name);
        }

        /// <summary>
        /// Opens dialog to export
        /// sort result to '.docx'
        /// </summary>
        private void ExportToWordButton_Click(object sender, EventArgs e)
        {
            SaveSortDoc.ShowDialog();
        }

        /// <summary>
        /// Exports the sort result into
        /// a word document
        /// </summary>
        private void SaveSortDoc_FileOk(object sender, CancelEventArgs e)
        {
            using WordprocessingDocument doc = WordprocessingDocument.Create(SaveSortDoc.FileName,
                DocumentFormat.OpenXml.WordprocessingDocumentType.Document, true);

            MainDocumentPart mainPart = doc.AddMainDocumentPart();
            mainPart.Document = new Document();

            Body body = mainPart.Document.AppendChild(new Body());
            
            foreach(Group group in Sorter.GlobalInstance().AllGroups) // Write every group in
            {
                Paragraph para = body.AppendChild(new Paragraph());
                Run run = para.AppendChild(new Run());

                run.AppendChild(new Text($"{group.Name}"));
                for(int i = 0; i < group.Students.Count; i++) // Add in all student's names
                {
                    Paragraph paragraph = body.AppendChild(new Paragraph());
                    Run part = paragraph.AppendChild(new Run());
                    part.AppendChild(new Text($"- {group.Students[i].Name}"));

                    if (i + 1 == group.Students.Count) // Skip a line at the end of each group
                    {
                        Paragraph newLine = body.AppendChild(new Paragraph());
                        Run blank = newLine.AppendChild(new Run());
                        blank.AppendChild(new Text(""));
                    }
                }
            }
            
            doc.MainDocumentPart.Document.Save();
        }
    }
}

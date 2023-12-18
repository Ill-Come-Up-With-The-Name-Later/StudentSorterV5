using StudentSorter.Forms;
using System.Diagnostics;

namespace StudentSorter
{
    public partial class TitleWindow : Form
    {
        public TitleWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens the overview window
        /// </summary>
        private void OpenButton_Click(object sender, EventArgs e)
        {
            Overviewer overviewer = new();
            overviewer.Show();
        }

        /// <summary>
        /// Opens dialog to upload a sorter
        /// configuration
        /// </summary>
        private void ConfigSortButton_Click(object sender, EventArgs e)
        {
            OpenConfig.ShowDialog();
        }

        /// <summary>
        /// Performs a sort using a loaded config
        /// </summary>
        private void OpenConfig_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Sorter.GlobalInstance().AllStudents.Clear();
            Sorter.GlobalInstance().AllGroups.Clear();
            Sorter.GlobalInstance().IllegalPairs.Clear();
            Sorter.GlobalInstance().SortConfigs.Clear();

            Importer.Import<SorterConfig>(OpenConfig.FileName);

            SorterConfig sort = Sorter.GlobalInstance().SortConfigs[0];

            if (sort.StudentFile.Length > 0)
            {
                Importer.Import<Student>(sort.StudentFile);
            }
            if (sort.GroupFile.Length > 0)
            {
                Importer.Import<Group>(sort.GroupFile);
            }
            if (sort.IllegalPairsFile.Length > 0)
            {
                Importer.Import<IllegalPair>(sort.IllegalPairsFile);
            }
            if (sort.ManualAssignmentsFile.Length > 0)
            {
                Importer.Import<ManualAssignment>(sort.ManualAssignmentsFile);
            }

            Sorter.GlobalInstance().DeterminantRange =
                    Sorter.GlobalInstance().AllStudents.Count / Sorter.GlobalInstance().AllGroups.Count;

            Sorter.GlobalInstance().RandomizeDeterminants();
            Sorter.GlobalInstance().ShuffleGroups();

            Overviewer overviewer = new();

            SortDisplay display = new(overviewer, sort);
            display.Show();
        }

        /// <summary>
        /// Opens window to create a new sorter
        /// configuration
        /// </summary>
        private void CreateConfigButton_Click(object sender, EventArgs e)
        {
            CreateSortConfig createSort = new();
            createSort.Show();
        }

        /// <summary>
        /// Opens the user manual link
        /// </summary>
        private void UserManualLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer", 
                "https://docs.google.com/document/d/1syxgtfrCE8VfrcJqYIb23z9Q5IooypA6DdlntWSYfoY/edit?usp=sharing");
        }
    }
}
using StudentSorter.Forms;

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

            Importer.Import<Sort>(OpenConfig.FileName);

            Sort sort = Sorter.GlobalInstance().SortConfigs[0];

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

            Sorter.GlobalInstance().DeterminantRange =
                    Sorter.GlobalInstance().AllStudents.Count / Sorter.GlobalInstance().AllGroups.Count;

            Sorter.GlobalInstance().RandomizeDeterminants();
            Sorter.GlobalInstance().ShuffleGroups();

            Overviewer overviewer = new();

            SortDisplay display = new(overviewer);
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
    }
}
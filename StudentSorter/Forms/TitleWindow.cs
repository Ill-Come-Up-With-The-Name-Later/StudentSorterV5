using StudentSorter.CardGames;
using StudentSorter.Debug;
using StudentSorter.Forms;
using System.Diagnostics;
using Debugger = StudentSorter.Debug.Debugger;

namespace StudentSorter
{
    public partial class TitleWindow : Form
    {
        const string ManualDocument = "https://docs.google.com/document/d/1syxgtfrCE8VfrcJqYIb23z9Q5IooypA6DdlntWSYfoY/edit?usp=sharing";
        private const string SecretPassKey = "notacasino";

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
            // Reset the Sorter
            Sorter.GlobalInstance().AllStudents.Clear();
            Sorter.GlobalInstance().AllGroups.Clear();
            Sorter.GlobalInstance().IllegalPairs.Clear();
            Sorter.GlobalInstance().SortConfigs.Clear();

            Importer.Import<SorterConfig>(OpenConfig.FileName);

            // Load data and sort
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

            Debugger.Log("Sorting begun");

            Sorter.GlobalInstance().DeterminantRange =
                    Sorter.GlobalInstance().AllStudents.Count / Sorter.GlobalInstance().AllGroups.Count;

            Sorter.GlobalInstance().RandomizeDeterminants();

            switch (sort.Algorithm)
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

            Overviewer overviewer = new();

            SortDisplay display = new(overviewer, sort, sort.Algorithm);
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
            Process.Start("explorer.exe", "\"" + $"{ManualDocument}" + "\"");
        }

        /// <summary>
        /// Sets the version text
        /// </summary>
        private void TitleWindow_Load(object sender, EventArgs e)
        {
            VersionLabel.Text = $"Version: {Program.Version}";
        }

        /// <summary>
        /// Opens the debug log window
        /// </summary>
        private void OpenDebugButton_Click(object sender, EventArgs e)
        {
            DebugWindow window = new();
            window.Show();
            Program.Debugger = window;

            Debugger.Log("Application debugger opened");
            Debugger.Log($"Version: {Program.Version}");
        }

        /// <summary>
        /// Opens a blackjack game
        /// </summary>
        private void BlackjackButton_Click(object sender, EventArgs e)
        {
            ErrorProvider.Clear();

            if (!SecretPassInput.Text.Equals(SecretPassKey, StringComparison.OrdinalIgnoreCase))
            {
                ErrorProvider.SetError(SecretPassInput, "Incorrect pass code");
                Debugger.Log("An incorrect pass code was entered");
            }

            if (SecretPassInput.Text.Equals(SecretPassKey, StringComparison.OrdinalIgnoreCase) && !ErrorProvider.HasErrors)
            {
                CardGameMenu menu = new();
                menu.Show();

                Debugger.Log("The correct pass code was entered");
            }

            SecretPassInput.Clear();
        }
    }
}
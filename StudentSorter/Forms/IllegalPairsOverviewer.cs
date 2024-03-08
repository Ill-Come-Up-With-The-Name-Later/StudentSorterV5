using StudentSorter.Debug;
using StudentSorter.FileHandling;
using StudentSorter.SorterComponent;
using System.ComponentModel;
using System.Data;

namespace StudentSorter
{
    public partial class IllegalPairsOverviewer : Form
    {
        private readonly DataTable Pairs = new();
        private readonly Overviewer FormParent;

        public IllegalPairsOverviewer(Overviewer formParent)
        {
            InitializeComponent();

            IllegalPairList.DataSource = Pairs;

            Pairs.Columns.Add("Pairs", typeof(string));

            foreach (DataGridViewColumn column in IllegalPairList.Columns)
            {
                column.Width = IllegalPairList.Width;
            }

            FormParent = formParent;
        }

        /// <summary>
        /// Serializes the illegal pairs into a JSON file
        /// </summary>
        private void SerializePairs_FileOk(object sender, CancelEventArgs e)
        {
            string file = SerializePairs.FileName;

            Exporter.ExportObjects(Sorter.GlobalInstance().IllegalPairs, file);
            FormParent.IllegalPairFile = file;
            FormParent.DisallowedPairsSource.Text = $"Disallowed Pairs File Source: {file}";
        }

        /// <summary>
        /// Deserializes illegal pairs from JSON to objects
        /// </summary>
        private void OpenPairsFile_FileOk(object sender, CancelEventArgs e)
        {
            Importer.Import<IllegalPair>(OpenPairsFile.FileName);
            FormParent.IllegalPairFile = OpenPairsFile.FileName;
            FormParent.DisallowedPairsSource.Text = $"Disallowed Pairs File Source: {OpenPairsFile.FileName}";

            RefreshPairList();
            Debugger.Log($"Created numerous disallowed pairs from {OpenPairsFile.FileName}");
        }

        /// <summary>
        /// Opens the dialog to serialize illegal pairs to JSON
        /// </summary>
        private void SerializePairsButton_Click(object sender, EventArgs e)
        {
            SerializePairs.ShowDialog();
        }

        /// <summary>
        /// Opens the dialog to find and import a JSON
        /// file of illegal pairr
        /// </summary>
        private void DeserializePairsButton_Click(object sender, EventArgs e)
        {
            OpenPairsFile.ShowDialog();
        }

        /// <summary>
        /// Opens the window to add a new illegal pair
        /// </summary>
        private void AddPairButton_Click(object sender, EventArgs e)
        {
            ErrorProvider.Clear();

            if (Sorter.GlobalInstance().AllStudents.Count < 2)
            {
                ErrorProvider.SetError(AddPairButton, "At least two students are required for a pair");
                return;
            }

            IllegalPairCreator creator = new(this);
            creator.Show();
        }

        /// <summary>
        /// Window loading
        /// </summary>
        private void IllegalPairsOverviewer_Load(object sender, EventArgs e)
        {
            RefreshPairList();
        }

        /// <summary>
        /// Refreshes the pair list
        /// </summary>
        public void RefreshPairList()
        {
            if (Pairs.Rows.Count > 0)
                Pairs.Rows.Clear();

            foreach (IllegalPair pair in Sorter.GlobalInstance().IllegalPairs)
            {
                Pairs.Rows.Add($"{pair.Student1.Name} and {pair.Student2.Name}");
            }
        }

        /// <summary>
        /// Removes an illegal pair
        /// </summary>
        private void IllegalPairList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = IllegalPairList.CurrentCell.RowIndex;
            Debugger.Log($"Deleted pair: {Sorter.GlobalInstance().IllegalPairs[index]}");

            Sorter.GlobalInstance().IllegalPairs.RemoveAt(index);
            RefreshPairList();
        }
    }
}

using System.ComponentModel;

namespace StudentSorter
{
    public partial class IllegalPairsOverviewer : Form
    {
        public IllegalPairsOverviewer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Serializes the illegal pairs into a JSON file
        /// </summary>
        private void SerializePairs_FileOk(object sender, CancelEventArgs e)
        {
            string file = SerializePairs.FileName;

            List<string> pairs = new();

            foreach(IllegalPair pair in Sorter.GlobalInstance().IllegalPairs)
                pairs.Add(pair.SerializeJSON());

            Exporter.Export(file, pairs);
        }

        /// <summary>
        /// Deserializes illegal pairs from JSON to objects
        /// </summary>
        private void OpenPairsFile_FileOk(object sender, CancelEventArgs e)
        {
            Importer.Import<IllegalPair>(OpenPairsFile.FileName);
            Close();
        }
    }
}

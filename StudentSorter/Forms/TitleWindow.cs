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
    }
}
namespace StudentSorter.Debug
{
    public partial class DebugWindow : Form
    {
        public DebugWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Close the debug window
        /// </summary>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Debugger.Log("Application debugger closed");
            Close();
        }
    }
}

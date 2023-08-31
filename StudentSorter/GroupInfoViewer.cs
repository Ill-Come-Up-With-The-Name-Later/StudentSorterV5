namespace StudentSorter
{
    public partial class GroupInfoViewer : Form
    {
        private readonly int GroupIndex;
        private readonly Group SelectedGroup;

        public GroupInfoViewer(int groupIndex)
        {
            GroupIndex = groupIndex;
            SelectedGroup = Sorter.GlobalInstance().AllGroups[GroupIndex];
            InitializeComponent();
        }

        /// <summary>
        /// Loads the group's information into the window
        /// </summary>
        private void GroupInfoViewer_Load(object sender, EventArgs e)
        {
            GroupNameTitle.Text = SelectedGroup.Name;
            MaxDeterminantInput.Value = SelectedGroup.MaxDeterminant;
            MinDeterminantInput.Value = SelectedGroup.MinDeterminant;
            GroupCapacityInput.Value = SelectedGroup.Capacity;
        }

        /// <summary>
        /// Updates any info that needs to be updated for the group
        /// </summary>
        private void GroupInfoViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            SelectedGroup.Capacity = (int)GroupCapacityInput.Value;
            SelectedGroup.MinDeterminant = (int)MinDeterminantInput.Value;
            SelectedGroup.MaxDeterminant = (int)MaxDeterminantInput.Value;
        }
    }
}

namespace StudentSorter
{
    public partial class GroupInfoViewer : Form
    {
        private readonly int GroupIndex;
        private readonly Group SelectedGroup;
        private Overviewer FormParent;

        public GroupInfoViewer(int groupIndex, Overviewer formParent)
        {
            GroupIndex = groupIndex;
            SelectedGroup = Sorter.GlobalInstance().AllGroups[GroupIndex];
            InitializeComponent();
            FormParent = formParent;
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

        /// <summary>
        /// Closes the window
        /// </summary>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Deletes the group and all manual
        /// assignments associated with it
        /// </summary>
        private void DeleteGroupButton_Click(object sender, EventArgs e)
        {
            Sorter.GlobalInstance().AllGroups.Remove(SelectedGroup);

            foreach(ManualAssignment assignment in Sorter.GlobalInstance().Assignments)
            {
                if(Sorter.GlobalInstance().GetGroupByHashCode(assignment.GroupHashCode) == SelectedGroup)
                {
                    Sorter.GlobalInstance().Assignments.Remove(assignment);
                }
            }

            FormParent.RefreshLists();
            Close();
        }
    }
}

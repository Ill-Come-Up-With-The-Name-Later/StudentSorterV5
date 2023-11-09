using System.ComponentModel;

namespace StudentSorter
{
    public partial class CreateGroupWindow : Form
    {
        public CreateGroupWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Uploads the JSON of the groups and creates the objects
        /// </summary>
        private void JsonUploader_FileOk(object sender, CancelEventArgs e)
        {
            Importer.Import<Group>(JsonUploader.FileName);

            Close();
        }

        /// <summary>
        /// Creates group based on input parameters
        /// </summary>
        private void CreateGroupButton_Click(object sender, EventArgs e)
        {
            if (GroupNameInput.Text.Equals("") || GroupNameInput.Text == null)
            {
                ErrorProvider.SetError(GroupNameInput, "A name is required");
                throw new ArgumentException("No name entered!");
            }

            if (ErrorProvider.HasErrors)
            {
                return;
            }

            string name = GroupNameInput.Text;
            int capacity = (int)CapacityInput.Value;
            int minDeterminant = (int)MinDeterminantInput.Value;
            int maxDeterminant = (int)MaxDeterminantInput.Value;

            if (maxDeterminant <= minDeterminant)
            {
                ErrorProvider.SetError(MinDeterminantInput, "The minimum determinant cannot be greater than the maximum");
                ErrorProvider.SetError(MaxDeterminantInput, "The maximum determinant cannot be less than the minimum");
                throw new ArgumentException("Max determinant must be greater than min determinant");
            }

            if (capacity <= 0)
            {
                ErrorProvider.SetError(CapacityInput, "The capacity cannot be less than or equal to zero");
                throw new ArgumentException("Capacity must be greater than 0");
            }

            if (ErrorProvider.HasErrors)
            {
                return;
            }

            Group group = new(name, minDeterminant, maxDeterminant, capacity);

            GroupNameInput.Text = "";
            CapacityInput.Value = 0;
            MinDeterminantInput.Value = 0;
            MaxDeterminantInput.Value = 0;
        }

        /// <summary>
        /// Opens the JSON file upload box to add groups
        /// </summary>
        private void JsonImportButton_Click(object sender, EventArgs e)
        {
            JsonUploader.ShowDialog();
        }

        /// <summary>
        /// Creates groups based on number of students added
        /// </summary>
        private void CreateOnStudentsButton_Click(object sender, EventArgs e)
        {
            int studentsPerGroup = (int)StudentsPerGroup.Value;
            int numGroups = Sorter.GlobalInstance().AllStudents.Count / studentsPerGroup;

            if (Sorter.GlobalInstance().AllStudents.Count % studentsPerGroup != 0)
            {
                numGroups++;
            }

            int weightDiff = (studentsPerGroup * 2) - 1;
            int currentMin = 1;

            for(int i = 0; i < numGroups; i++)
            {
                Group group = new($"Group {i + 1}", currentMin, currentMin + weightDiff, studentsPerGroup);
                currentMin += weightDiff + 1;
            }

            Close();
        }
    }
}

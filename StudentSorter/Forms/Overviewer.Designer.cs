namespace StudentSorter
{
    partial class Overviewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            StudentViewer = new DataGridView();
            GroupViewer = new DataGridView();
            StudentLabel = new Label();
            GroupLabel = new Label();
            RefreshButton = new Button();
            AddStudentButton = new Button();
            AddGroupButton = new Button();
            SortButton = new Button();
            SerializeStudentsButton = new Button();
            SerializeGroupsButton = new Button();
            StudentSerialize = new SaveFileDialog();
            GroupSerialize = new SaveFileDialog();
            DisallowedPairButton = new Button();
            ErrorProvider = new ErrorProvider(components);
            SaveConfigButton = new Button();
            ConfigSaver = new SaveFileDialog();
            StudentSource = new Label();
            GroupSource = new Label();
            DisallowedPairsSource = new Label();
            ManualAssignmentFile = new Label();
            ManualAssignmentButton = new Button();
            OpenAssignments = new OpenFileDialog();
            SaveAssignmentsButton = new Button();
            SaveAssignmentDialog = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)StudentViewer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GroupViewer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // StudentViewer
            // 
            StudentViewer.AllowUserToAddRows = false;
            StudentViewer.AllowUserToDeleteRows = false;
            StudentViewer.AllowUserToResizeRows = false;
            StudentViewer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StudentViewer.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            StudentViewer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentViewer.ColumnHeadersVisible = false;
            StudentViewer.Location = new Point(49, 102);
            StudentViewer.Margin = new Padding(4);
            StudentViewer.MultiSelect = false;
            StudentViewer.Name = "StudentViewer";
            StudentViewer.ReadOnly = true;
            StudentViewer.RowHeadersVisible = false;
            StudentViewer.RowHeadersWidth = 51;
            StudentViewer.RowTemplate.Height = 29;
            StudentViewer.Size = new Size(367, 229);
            StudentViewer.TabIndex = 0;
            StudentViewer.CellDoubleClick += StudentViewer_CellDoubleClick;
            // 
            // GroupViewer
            // 
            GroupViewer.AllowUserToAddRows = false;
            GroupViewer.AllowUserToDeleteRows = false;
            GroupViewer.AllowUserToResizeColumns = false;
            GroupViewer.AllowUserToResizeRows = false;
            GroupViewer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GroupViewer.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            GroupViewer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GroupViewer.ColumnHeadersVisible = false;
            GroupViewer.Location = new Point(735, 102);
            GroupViewer.Margin = new Padding(4);
            GroupViewer.MultiSelect = false;
            GroupViewer.Name = "GroupViewer";
            GroupViewer.ReadOnly = true;
            GroupViewer.RowHeadersVisible = false;
            GroupViewer.RowHeadersWidth = 51;
            GroupViewer.RowTemplate.Height = 29;
            GroupViewer.Size = new Size(375, 229);
            GroupViewer.TabIndex = 1;
            GroupViewer.CellDoubleClick += GroupViewer_CellDoubleClick;
            // 
            // StudentLabel
            // 
            StudentLabel.AutoSize = true;
            StudentLabel.Location = new Point(167, 53);
            StudentLabel.Margin = new Padding(4, 0, 4, 0);
            StudentLabel.Name = "StudentLabel";
            StudentLabel.Size = new Size(88, 28);
            StudentLabel.TabIndex = 2;
            StudentLabel.Text = "Students";
            // 
            // GroupLabel
            // 
            GroupLabel.AutoSize = true;
            GroupLabel.Location = new Point(870, 53);
            GroupLabel.Name = "GroupLabel";
            GroupLabel.Size = new Size(76, 28);
            GroupLabel.TabIndex = 3;
            GroupLabel.Text = "Groups";
            // 
            // RefreshButton
            // 
            RefreshButton.Location = new Point(475, 190);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(200, 47);
            RefreshButton.TabIndex = 4;
            RefreshButton.Text = "Refresh Lists";
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // AddStudentButton
            // 
            AddStudentButton.Location = new Point(94, 352);
            AddStudentButton.Name = "AddStudentButton";
            AddStudentButton.Size = new Size(294, 46);
            AddStudentButton.TabIndex = 5;
            AddStudentButton.Text = "Add New Student";
            AddStudentButton.UseVisualStyleBackColor = true;
            AddStudentButton.Click += AddStudentButton_Click;
            // 
            // AddGroupButton
            // 
            AddGroupButton.Location = new Point(764, 352);
            AddGroupButton.Name = "AddGroupButton";
            AddGroupButton.Size = new Size(271, 46);
            AddGroupButton.TabIndex = 6;
            AddGroupButton.Text = "Add New Group";
            AddGroupButton.UseVisualStyleBackColor = true;
            AddGroupButton.Click += AddGroupButton_Click;
            // 
            // SortButton
            // 
            SortButton.Location = new Point(446, 406);
            SortButton.Name = "SortButton";
            SortButton.Size = new Size(276, 47);
            SortButton.TabIndex = 7;
            SortButton.Text = "Randomize Groups";
            SortButton.UseVisualStyleBackColor = true;
            SortButton.Click += SortButton_Click;
            // 
            // SerializeStudentsButton
            // 
            SerializeStudentsButton.Location = new Point(94, 406);
            SerializeStudentsButton.Name = "SerializeStudentsButton";
            SerializeStudentsButton.Size = new Size(294, 48);
            SerializeStudentsButton.TabIndex = 8;
            SerializeStudentsButton.Text = "Serialize Students to JSON";
            SerializeStudentsButton.UseVisualStyleBackColor = true;
            SerializeStudentsButton.Click += SerializeStudentsButton_Click;
            // 
            // SerializeGroupsButton
            // 
            SerializeGroupsButton.Location = new Point(764, 407);
            SerializeGroupsButton.Name = "SerializeGroupsButton";
            SerializeGroupsButton.Size = new Size(271, 47);
            SerializeGroupsButton.TabIndex = 9;
            SerializeGroupsButton.Text = "Serialize Groups to JSON";
            SerializeGroupsButton.UseVisualStyleBackColor = true;
            SerializeGroupsButton.Click += SerializeGroupsButton_Click;
            // 
            // StudentSerialize
            // 
            StudentSerialize.FileName = "students.json";
            StudentSerialize.Title = "Save Students to JSON";
            StudentSerialize.FileOk += StudentSerialize_FileOk;
            // 
            // GroupSerialize
            // 
            GroupSerialize.FileName = "groups.json";
            GroupSerialize.Title = "Save Groups to JSON";
            GroupSerialize.FileOk += GroupSerialize_FileOk;
            // 
            // DisallowedPairButton
            // 
            DisallowedPairButton.Location = new Point(446, 352);
            DisallowedPairButton.Name = "DisallowedPairButton";
            DisallowedPairButton.Size = new Size(276, 46);
            DisallowedPairButton.TabIndex = 10;
            DisallowedPairButton.Text = "Edit Disallowed Pairs";
            DisallowedPairButton.UseVisualStyleBackColor = true;
            DisallowedPairButton.Click += DisallowedPairButton_Click;
            // 
            // ErrorProvider
            // 
            ErrorProvider.ContainerControl = this;
            // 
            // SaveConfigButton
            // 
            SaveConfigButton.Location = new Point(475, 475);
            SaveConfigButton.Name = "SaveConfigButton";
            SaveConfigButton.Size = new Size(227, 45);
            SaveConfigButton.TabIndex = 11;
            SaveConfigButton.Text = "Save Sorter Configuration";
            SaveConfigButton.UseVisualStyleBackColor = true;
            SaveConfigButton.Click += SaveConfigButton_Click;
            // 
            // ConfigSaver
            // 
            ConfigSaver.DefaultExt = "json";
            ConfigSaver.FileName = "SorterConfiguration";
            ConfigSaver.Title = "Save Sorter Configuration";
            ConfigSaver.FileOk += ConfigSaver_FileOk;
            // 
            // StudentSource
            // 
            StudentSource.AutoSize = true;
            StudentSource.Location = new Point(12, 608);
            StudentSource.Name = "StudentSource";
            StudentSource.Size = new Size(230, 28);
            StudentSource.TabIndex = 12;
            StudentSource.Text = "Student File Souce: None";
            // 
            // GroupSource
            // 
            GroupSource.AutoSize = true;
            GroupSource.Location = new Point(12, 636);
            GroupSource.Name = "GroupSource";
            GroupSource.Size = new Size(225, 28);
            GroupSource.TabIndex = 13;
            GroupSource.Text = "Group File Source: None";
            // 
            // DisallowedPairsSource
            // 
            DisallowedPairsSource.AutoSize = true;
            DisallowedPairsSource.Location = new Point(12, 664);
            DisallowedPairsSource.Name = "DisallowedPairsSource";
            DisallowedPairsSource.Size = new Size(302, 28);
            DisallowedPairsSource.TabIndex = 14;
            DisallowedPairsSource.Text = "Disallowed Pairs File Souce: None";
            // 
            // ManualAssignmentFile
            // 
            ManualAssignmentFile.AutoSize = true;
            ManualAssignmentFile.Location = new Point(12, 692);
            ManualAssignmentFile.Name = "ManualAssignmentFile";
            ManualAssignmentFile.Size = new Size(341, 28);
            ManualAssignmentFile.TabIndex = 15;
            ManualAssignmentFile.Text = "Manual Assignment File Source: None";
            // 
            // ManualAssignmentButton
            // 
            ManualAssignmentButton.Location = new Point(19, 475);
            ManualAssignmentButton.Name = "ManualAssignmentButton";
            ManualAssignmentButton.Size = new Size(369, 45);
            ManualAssignmentButton.TabIndex = 16;
            ManualAssignmentButton.Text = "Upload Manual Assignment File";
            ManualAssignmentButton.UseVisualStyleBackColor = true;
            ManualAssignmentButton.Click += ManualAssignmentButton_Click;
            // 
            // OpenAssignments
            // 
            OpenAssignments.DefaultExt = "json";
            OpenAssignments.FileName = "openFileDialog1";
            OpenAssignments.Filter = "JSON files|*.json";
            OpenAssignments.Title = "Upload Manual Assignments File";
            OpenAssignments.FileOk += OpenAssignments_FileOk;
            // 
            // SaveAssignmentsButton
            // 
            SaveAssignmentsButton.Location = new Point(19, 526);
            SaveAssignmentsButton.Name = "SaveAssignmentsButton";
            SaveAssignmentsButton.Size = new Size(369, 45);
            SaveAssignmentsButton.TabIndex = 17;
            SaveAssignmentsButton.Text = "Save Manual Assignments";
            SaveAssignmentsButton.UseVisualStyleBackColor = true;
            SaveAssignmentsButton.Click += SaveAssignmentsButton_Click;
            // 
            // SaveAssignmentDialog
            // 
            SaveAssignmentDialog.DefaultExt = "json";
            SaveAssignmentDialog.FileName = "Assignments.json";
            SaveAssignmentDialog.Title = "Save Manual Assignments to JSON";
            SaveAssignmentDialog.FileOk += SaveAssignmentDialog_FileOk;
            // 
            // Overviewer
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 744);
            Controls.Add(SaveAssignmentsButton);
            Controls.Add(ManualAssignmentButton);
            Controls.Add(ManualAssignmentFile);
            Controls.Add(DisallowedPairsSource);
            Controls.Add(GroupSource);
            Controls.Add(StudentSource);
            Controls.Add(SaveConfigButton);
            Controls.Add(DisallowedPairButton);
            Controls.Add(SerializeGroupsButton);
            Controls.Add(SerializeStudentsButton);
            Controls.Add(SortButton);
            Controls.Add(AddGroupButton);
            Controls.Add(AddStudentButton);
            Controls.Add(RefreshButton);
            Controls.Add(GroupLabel);
            Controls.Add(StudentLabel);
            Controls.Add(GroupViewer);
            Controls.Add(StudentViewer);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Overviewer";
            Text = "Overviewer";
            ((System.ComponentModel.ISupportInitialize)StudentViewer).EndInit();
            ((System.ComponentModel.ISupportInitialize)GroupViewer).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView StudentViewer;
        private DataGridView GroupViewer;
        private Label StudentLabel;
        private Label GroupLabel;
        private Button RefreshButton;
        private Button AddStudentButton;
        private Button AddGroupButton;
        private Button SortButton;
        private Button SerializeStudentsButton;
        private Button SerializeGroupsButton;
        private SaveFileDialog StudentSerialize;
        private SaveFileDialog GroupSerialize;
        private Button DisallowedPairButton;
        private ErrorProvider ErrorProvider;
        private Button SaveConfigButton;
        private SaveFileDialog ConfigSaver;
        public Label DisallowedPairsSource;
        public Label GroupSource;
        public Label StudentSource;
        private Button ManualAssignmentButton;
        private Label ManualAssignmentFile;
        private OpenFileDialog OpenAssignments;
        private Button SaveAssignmentsButton;
        private SaveFileDialog SaveAssignmentDialog;
    }
}
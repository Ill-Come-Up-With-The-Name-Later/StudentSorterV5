namespace StudentSorter.Forms
{
    partial class CreateSortConfig
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
            CreateConfigButton = new Button();
            StudentFileName = new Label();
            GroupFileName = new Label();
            DisallowedPairsFileName = new Label();
            SelectFile = new OpenFileDialog();
            AddStudentFile = new Button();
            AddGroupFile = new Button();
            AddPairsFile = new Button();
            SaveConfig = new SaveFileDialog();
            ConfigNameLabel = new Label();
            ConfigNameInput = new TextBox();
            AddAssignmentFileButton = new Button();
            ManualAssignmentFile = new Label();
            SuspendLayout();
            // 
            // CreateConfigButton
            // 
            CreateConfigButton.Location = new Point(239, 254);
            CreateConfigButton.Name = "CreateConfigButton";
            CreateConfigButton.Size = new Size(279, 49);
            CreateConfigButton.TabIndex = 0;
            CreateConfigButton.Text = "Create Sort Configuration";
            CreateConfigButton.UseVisualStyleBackColor = true;
            CreateConfigButton.Click += CreateConfigButton_Click;
            // 
            // StudentFileName
            // 
            StudentFileName.AutoSize = true;
            StudentFileName.Location = new Point(162, 17);
            StudentFileName.Name = "StudentFileName";
            StudentFileName.Size = new Size(172, 28);
            StudentFileName.TabIndex = 1;
            StudentFileName.Text = "Student File: None";
            // 
            // GroupFileName
            // 
            GroupFileName.AutoSize = true;
            GroupFileName.Location = new Point(162, 66);
            GroupFileName.Name = "GroupFileName";
            GroupFileName.Size = new Size(160, 28);
            GroupFileName.TabIndex = 2;
            GroupFileName.Text = "Group File: None";
            // 
            // DisallowedPairsFileName
            // 
            DisallowedPairsFileName.AutoSize = true;
            DisallowedPairsFileName.Location = new Point(162, 112);
            DisallowedPairsFileName.Name = "DisallowedPairsFileName";
            DisallowedPairsFileName.Size = new Size(244, 28);
            DisallowedPairsFileName.TabIndex = 3;
            DisallowedPairsFileName.Text = "Disallowed Pairs File: None";
            // 
            // SelectFile
            // 
            SelectFile.DefaultExt = "json";
            SelectFile.Filter = "JSON files|*.json";
            SelectFile.FileOk += SelectFile_FileOk;
            // 
            // AddStudentFile
            // 
            AddStudentFile.Location = new Point(41, 10);
            AddStudentFile.Name = "AddStudentFile";
            AddStudentFile.Size = new Size(93, 42);
            AddStudentFile.TabIndex = 4;
            AddStudentFile.Text = "Add File";
            AddStudentFile.UseVisualStyleBackColor = true;
            AddStudentFile.Click += AddStudentFile_Click;
            // 
            // AddGroupFile
            // 
            AddGroupFile.Location = new Point(41, 60);
            AddGroupFile.Name = "AddGroupFile";
            AddGroupFile.Size = new Size(93, 40);
            AddGroupFile.TabIndex = 5;
            AddGroupFile.Text = "Add File";
            AddGroupFile.UseVisualStyleBackColor = true;
            AddGroupFile.Click += AddGroupFile_Click;
            // 
            // AddPairsFile
            // 
            AddPairsFile.Location = new Point(41, 106);
            AddPairsFile.Name = "AddPairsFile";
            AddPairsFile.Size = new Size(93, 41);
            AddPairsFile.TabIndex = 6;
            AddPairsFile.Text = "Add File";
            AddPairsFile.UseVisualStyleBackColor = true;
            AddPairsFile.Click += AddPairsFile_Click;
            // 
            // SaveConfig
            // 
            SaveConfig.DefaultExt = "json";
            SaveConfig.FileName = "SorterConfiguration.json";
            SaveConfig.Title = "Save Sorter Configuration";
            SaveConfig.FileOk += SaveConfig_FileOk;
            // 
            // ConfigNameLabel
            // 
            ConfigNameLabel.AutoSize = true;
            ConfigNameLabel.Location = new Point(41, 211);
            ConfigNameLabel.Name = "ConfigNameLabel";
            ConfigNameLabel.Size = new Size(194, 28);
            ConfigNameLabel.TabIndex = 7;
            ConfigNameLabel.Text = "Configuration Name:";
            // 
            // ConfigNameInput
            // 
            ConfigNameInput.Location = new Point(250, 208);
            ConfigNameInput.Name = "ConfigNameInput";
            ConfigNameInput.Size = new Size(253, 34);
            ConfigNameInput.TabIndex = 8;
            ConfigNameInput.Text = "Configuration";
            // 
            // AddAssignmentFileButton
            // 
            AddAssignmentFileButton.Location = new Point(41, 153);
            AddAssignmentFileButton.Name = "AddAssignmentFileButton";
            AddAssignmentFileButton.Size = new Size(94, 41);
            AddAssignmentFileButton.TabIndex = 9;
            AddAssignmentFileButton.Text = "Add File";
            AddAssignmentFileButton.UseVisualStyleBackColor = true;
            AddAssignmentFileButton.Click += AddAssignmentFileButton_Click;
            // 
            // ManualAssignmentFile
            // 
            ManualAssignmentFile.AutoSize = true;
            ManualAssignmentFile.Location = new Point(162, 159);
            ManualAssignmentFile.Name = "ManualAssignmentFile";
            ManualAssignmentFile.Size = new Size(276, 28);
            ManualAssignmentFile.TabIndex = 10;
            ManualAssignmentFile.Text = "Manual Assignment File: None";
            // 
            // CreateSortConfig
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(777, 315);
            Controls.Add(ManualAssignmentFile);
            Controls.Add(AddAssignmentFileButton);
            Controls.Add(ConfigNameInput);
            Controls.Add(ConfigNameLabel);
            Controls.Add(AddPairsFile);
            Controls.Add(AddGroupFile);
            Controls.Add(AddStudentFile);
            Controls.Add(DisallowedPairsFileName);
            Controls.Add(GroupFileName);
            Controls.Add(StudentFileName);
            Controls.Add(CreateConfigButton);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "CreateSortConfig";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Sort Configuration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CreateConfigButton;
        private Label StudentFileName;
        private Label GroupFileName;
        private Label DisallowedPairsFileName;
        private OpenFileDialog SelectFile;
        private Button AddStudentFile;
        private Button AddGroupFile;
        private Button AddPairsFile;
        private SaveFileDialog SaveConfig;
        private Label ConfigNameLabel;
        private TextBox ConfigNameInput;
        private Button AddAssignmentFileButton;
        private Label ManualAssignmentFile;
    }
}
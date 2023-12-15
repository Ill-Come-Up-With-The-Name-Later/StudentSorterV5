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
            SuspendLayout();
            // 
            // CreateConfigButton
            // 
            CreateConfigButton.Location = new Point(266, 181);
            CreateConfigButton.Name = "CreateConfigButton";
            CreateConfigButton.Size = new Size(228, 35);
            CreateConfigButton.TabIndex = 0;
            CreateConfigButton.Text = "Create Sort Configuration";
            CreateConfigButton.UseVisualStyleBackColor = true;
            CreateConfigButton.Click += CreateConfigButton_Click;
            // 
            // StudentFileName
            // 
            StudentFileName.AutoSize = true;
            StudentFileName.Location = new Point(162, 24);
            StudentFileName.Name = "StudentFileName";
            StudentFileName.Size = new Size(136, 21);
            StudentFileName.TabIndex = 1;
            StudentFileName.Text = "Student File: None";
            // 
            // GroupFileName
            // 
            GroupFileName.AutoSize = true;
            GroupFileName.Location = new Point(162, 65);
            GroupFileName.Name = "GroupFileName";
            GroupFileName.Size = new Size(127, 21);
            GroupFileName.TabIndex = 2;
            GroupFileName.Text = "Group File: None";
            // 
            // DisallowedPairsFileName
            // 
            DisallowedPairsFileName.AutoSize = true;
            DisallowedPairsFileName.Location = new Point(162, 105);
            DisallowedPairsFileName.Name = "DisallowedPairsFileName";
            DisallowedPairsFileName.Size = new Size(196, 21);
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
            AddStudentFile.Location = new Point(41, 19);
            AddStudentFile.Name = "AddStudentFile";
            AddStudentFile.Size = new Size(93, 31);
            AddStudentFile.TabIndex = 4;
            AddStudentFile.Text = "Add File";
            AddStudentFile.UseVisualStyleBackColor = true;
            AddStudentFile.Click += AddStudentFile_Click;
            // 
            // AddGroupFile
            // 
            AddGroupFile.Location = new Point(41, 60);
            AddGroupFile.Name = "AddGroupFile";
            AddGroupFile.Size = new Size(93, 31);
            AddGroupFile.TabIndex = 5;
            AddGroupFile.Text = "Add File";
            AddGroupFile.UseVisualStyleBackColor = true;
            AddGroupFile.Click += AddGroupFile_Click;
            // 
            // AddPairsFile
            // 
            AddPairsFile.Location = new Point(41, 100);
            AddPairsFile.Name = "AddPairsFile";
            AddPairsFile.Size = new Size(93, 31);
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
            // CreateSortConfig
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 233);
            Controls.Add(AddPairsFile);
            Controls.Add(AddGroupFile);
            Controls.Add(AddStudentFile);
            Controls.Add(DisallowedPairsFileName);
            Controls.Add(GroupFileName);
            Controls.Add(StudentFileName);
            Controls.Add(CreateConfigButton);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "CreateSortConfig";
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
    }
}
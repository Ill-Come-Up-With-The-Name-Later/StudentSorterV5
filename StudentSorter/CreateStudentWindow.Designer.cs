namespace StudentSorter
{
    partial class CreateStudentWindow
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
            label1 = new Label();
            StudentNameInput = new TextBox();
            StudentNameTitle = new Label();
            ManualAssignCheck = new CheckBox();
            DeterminantInput = new NumericUpDown();
            CreateStudentButton = new Button();
            JsonUploadButton = new Button();
            JsonUploader = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)DeterminantInput).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(306, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 28);
            label1.TabIndex = 0;
            label1.Text = "Create Student";
            // 
            // StudentNameInput
            // 
            StudentNameInput.Location = new Point(22, 108);
            StudentNameInput.Name = "StudentNameInput";
            StudentNameInput.Size = new Size(243, 34);
            StudentNameInput.TabIndex = 1;
            // 
            // StudentNameTitle
            // 
            StudentNameTitle.AutoSize = true;
            StudentNameTitle.Location = new Point(22, 68);
            StudentNameTitle.Name = "StudentNameTitle";
            StudentNameTitle.Size = new Size(141, 28);
            StudentNameTitle.TabIndex = 2;
            StudentNameTitle.Text = "Student Name:";
            // 
            // ManualAssignCheck
            // 
            ManualAssignCheck.AutoSize = true;
            ManualAssignCheck.Location = new Point(22, 180);
            ManualAssignCheck.Name = "ManualAssignCheck";
            ManualAssignCheck.Size = new Size(285, 32);
            ManualAssignCheck.TabIndex = 3;
            ManualAssignCheck.Text = "Manually assign determinant";
            ManualAssignCheck.UseVisualStyleBackColor = true;
            ManualAssignCheck.CheckedChanged += ManualAssignCheck_CheckedChanged;
            // 
            // DeterminantInput
            // 
            DeterminantInput.Enabled = false;
            DeterminantInput.Location = new Point(26, 226);
            DeterminantInput.Name = "DeterminantInput";
            DeterminantInput.ReadOnly = true;
            DeterminantInput.Size = new Size(157, 34);
            DeterminantInput.TabIndex = 4;
            // 
            // CreateStudentButton
            // 
            CreateStudentButton.Location = new Point(22, 289);
            CreateStudentButton.Name = "CreateStudentButton";
            CreateStudentButton.Size = new Size(195, 46);
            CreateStudentButton.TabIndex = 5;
            CreateStudentButton.Text = "Create Student";
            CreateStudentButton.UseVisualStyleBackColor = true;
            CreateStudentButton.Click += CreateStudentButton_Click;
            // 
            // JsonUploadButton
            // 
            JsonUploadButton.Location = new Point(26, 362);
            JsonUploadButton.Name = "JsonUploadButton";
            JsonUploadButton.Size = new Size(259, 47);
            JsonUploadButton.TabIndex = 6;
            JsonUploadButton.Text = "Upload From JSON File";
            JsonUploadButton.UseVisualStyleBackColor = true;
            JsonUploadButton.Click += JsonUploadButton_Click;
            // 
            // JsonUploader
            // 
            JsonUploader.Title = "Upload JSON File";
            JsonUploader.FileOk += JsonUploader_FileOk;
            // 
            // CreateStudentWindow
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 456);
            Controls.Add(JsonUploadButton);
            Controls.Add(CreateStudentButton);
            Controls.Add(DeterminantInput);
            Controls.Add(ManualAssignCheck);
            Controls.Add(StudentNameTitle);
            Controls.Add(StudentNameInput);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "CreateStudentWindow";
            Text = "Create Student";
            ((System.ComponentModel.ISupportInitialize)DeterminantInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox StudentNameInput;
        private Label StudentNameTitle;
        private CheckBox ManualAssignCheck;
        private NumericUpDown DeterminantInput;
        private Button CreateStudentButton;
        private Button JsonUploadButton;
        private OpenFileDialog JsonUploader;
    }
}
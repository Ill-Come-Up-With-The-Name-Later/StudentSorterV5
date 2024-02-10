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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            StudentNameInput = new TextBox();
            StudentNameTitle = new Label();
            ManualAssignCheck = new CheckBox();
            DeterminantInput = new NumericUpDown();
            CreateStudentButton = new Button();
            JsonUploadButton = new Button();
            JsonUploader = new OpenFileDialog();
            ErrorProvider = new ErrorProvider(components);
            ManualGroupAssignCheck = new CheckBox();
            GroupList = new ComboBox();
            PDFUploadButton = new Button();
            PDFOpener = new OpenFileDialog();
            PageStartInput = new NumericUpDown();
            FromLabl = new Label();
            ToLabel = new Label();
            PageEndInput = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)DeterminantInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PageStartInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PageEndInput).BeginInit();
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
            DeterminantInput.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
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
            JsonUploader.DefaultExt = "json";
            JsonUploader.Filter = "JSON files|*.json";
            JsonUploader.Title = "Upload JSON File";
            JsonUploader.FileOk += JsonUploader_FileOk;
            // 
            // ErrorProvider
            // 
            ErrorProvider.ContainerControl = this;
            // 
            // ManualGroupAssignCheck
            // 
            ManualGroupAssignCheck.AutoSize = true;
            ManualGroupAssignCheck.Location = new Point(376, 180);
            ManualGroupAssignCheck.Name = "ManualGroupAssignCheck";
            ManualGroupAssignCheck.Size = new Size(241, 32);
            ManualGroupAssignCheck.TabIndex = 7;
            ManualGroupAssignCheck.Text = "Manually assign group?";
            ManualGroupAssignCheck.UseVisualStyleBackColor = true;
            ManualGroupAssignCheck.CheckedChanged += ManualGroupAssignCheck_CheckedChanged;
            // 
            // GroupList
            // 
            GroupList.FormattingEnabled = true;
            GroupList.Location = new Point(376, 226);
            GroupList.Name = "GroupList";
            GroupList.Size = new Size(238, 36);
            GroupList.TabIndex = 8;
            // 
            // PDFUploadButton
            // 
            PDFUploadButton.Location = new Point(376, 360);
            PDFUploadButton.Name = "PDFUploadButton";
            PDFUploadButton.Size = new Size(256, 49);
            PDFUploadButton.TabIndex = 9;
            PDFUploadButton.Text = "Upload From Roster PDF";
            PDFUploadButton.UseVisualStyleBackColor = true;
            PDFUploadButton.Click += PDFUploadButton_Click;
            // 
            // PDFOpener
            // 
            PDFOpener.DefaultExt = "pdf";
            PDFOpener.Filter = "PDF files|*.pdf";
            PDFOpener.Title = "Upload PDF Roster";
            PDFOpener.FileOk += PDFOpener_FileOk;
            // 
            // PageStartInput
            // 
            PageStartInput.Location = new Point(412, 430);
            PageStartInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            PageStartInput.Name = "PageStartInput";
            PageStartInput.Size = new Size(94, 34);
            PageStartInput.TabIndex = 10;
            PageStartInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            PageStartInput.ValueChanged += PageStartInput_ValueChanged;
            // 
            // FromLabl
            // 
            FromLabl.AutoSize = true;
            FromLabl.Location = new Point(348, 432);
            FromLabl.Name = "FromLabl";
            FromLabl.Size = new Size(58, 28);
            FromLabl.TabIndex = 11;
            FromLabl.Text = "Page:";
            // 
            // ToLabel
            // 
            ToLabel.AutoSize = true;
            ToLabel.Location = new Point(512, 432);
            ToLabel.Name = "ToLabel";
            ToLabel.Size = new Size(35, 28);
            ToLabel.TabIndex = 12;
            ToLabel.Text = "to:";
            // 
            // PageEndInput
            // 
            PageEndInput.Location = new Point(553, 430);
            PageEndInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            PageEndInput.Name = "PageEndInput";
            PageEndInput.Size = new Size(110, 34);
            PageEndInput.TabIndex = 13;
            PageEndInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            PageEndInput.ValueChanged += PageEndInput_ValueChanged;
            // 
            // CreateStudentWindow
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(782, 485);
            Controls.Add(PageEndInput);
            Controls.Add(ToLabel);
            Controls.Add(FromLabl);
            Controls.Add(PageStartInput);
            Controls.Add(PDFUploadButton);
            Controls.Add(GroupList);
            Controls.Add(ManualGroupAssignCheck);
            Controls.Add(JsonUploadButton);
            Controls.Add(CreateStudentButton);
            Controls.Add(DeterminantInput);
            Controls.Add(ManualAssignCheck);
            Controls.Add(StudentNameTitle);
            Controls.Add(StudentNameInput);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "CreateStudentWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Student";
            Load += CreateStudentWindow_Load;
            ((System.ComponentModel.ISupportInitialize)DeterminantInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)PageStartInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)PageEndInput).EndInit();
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
        private ErrorProvider ErrorProvider;
        private ComboBox GroupList;
        private CheckBox ManualGroupAssignCheck;
        private Button PDFUploadButton;
        private OpenFileDialog PDFOpener;
        private NumericUpDown PageEndInput;
        private Label ToLabel;
        private Label FromLabl;
        private NumericUpDown PageStartInput;
    }
}
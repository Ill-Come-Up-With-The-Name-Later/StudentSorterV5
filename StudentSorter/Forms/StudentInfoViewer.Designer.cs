namespace StudentSorter
{
    partial class StudentInfoViewer
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
            DeterminantSetCheck = new CheckBox();
            DeterminantInput = new NumericUpDown();
            DeterminantLabel = new Label();
            label1 = new Label();
            IDLabel = new Label();
            IDVal = new Label();
            CopyIDButton = new Button();
            AssignGroupCheck = new CheckBox();
            GroupList = new ComboBox();
            CloseButton = new Button();
            ErrorProvider = new ErrorProvider(components);
            DeleteStudentButton = new Button();
            StudentNameInput = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DeterminantInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // DeterminantSetCheck
            // 
            DeterminantSetCheck.AutoSize = true;
            DeterminantSetCheck.Location = new Point(28, 77);
            DeterminantSetCheck.Name = "DeterminantSetCheck";
            DeterminantSetCheck.Size = new Size(185, 32);
            DeterminantSetCheck.TabIndex = 1;
            DeterminantSetCheck.Text = "Determinant Set?";
            DeterminantSetCheck.UseVisualStyleBackColor = true;
            DeterminantSetCheck.CheckedChanged += DeterminantSetCheck_CheckedChanged;
            // 
            // DeterminantInput
            // 
            DeterminantInput.Location = new Point(28, 182);
            DeterminantInput.Maximum = new decimal(new int[] { 700, 0, 0, 0 });
            DeterminantInput.Name = "DeterminantInput";
            DeterminantInput.Size = new Size(150, 34);
            DeterminantInput.TabIndex = 2;
            // 
            // DeterminantLabel
            // 
            DeterminantLabel.AutoSize = true;
            DeterminantLabel.Location = new Point(28, 133);
            DeterminantLabel.Name = "DeterminantLabel";
            DeterminantLabel.Size = new Size(125, 28);
            DeterminantLabel.TabIndex = 3;
            DeterminantLabel.Text = "Determinant:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 240);
            label1.Name = "label1";
            label1.Size = new Size(343, 28);
            label1.TabIndex = 4;
            label1.Text = "All information will update on closing.";
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(261, 77);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(35, 28);
            IDLabel.TabIndex = 5;
            IDLabel.Text = "ID:";
            // 
            // IDVal
            // 
            IDVal.AutoSize = true;
            IDVal.Location = new Point(302, 77);
            IDVal.Name = "IDVal";
            IDVal.Size = new Size(58, 28);
            IDVal.TabIndex = 6;
            IDVal.Text = "value";
            // 
            // CopyIDButton
            // 
            CopyIDButton.Location = new Point(261, 127);
            CopyIDButton.Name = "CopyIDButton";
            CopyIDButton.Size = new Size(122, 41);
            CopyIDButton.TabIndex = 7;
            CopyIDButton.Text = "Copy ID";
            CopyIDButton.UseVisualStyleBackColor = true;
            CopyIDButton.Click += CopyIDButton_Click;
            // 
            // AssignGroupCheck
            // 
            AssignGroupCheck.AutoSize = true;
            AssignGroupCheck.Location = new Point(28, 296);
            AssignGroupCheck.Name = "AssignGroupCheck";
            AssignGroupCheck.Size = new Size(241, 32);
            AssignGroupCheck.TabIndex = 8;
            AssignGroupCheck.Text = "Manually assign group?";
            AssignGroupCheck.UseVisualStyleBackColor = true;
            AssignGroupCheck.CheckedChanged += AssignGroupCheck_CheckedChanged;
            // 
            // GroupList
            // 
            GroupList.Enabled = false;
            GroupList.FormattingEnabled = true;
            GroupList.Location = new Point(28, 344);
            GroupList.Name = "GroupList";
            GroupList.Size = new Size(259, 36);
            GroupList.TabIndex = 9;
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(28, 423);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(165, 40);
            CloseButton.TabIndex = 10;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // ErrorProvider
            // 
            ErrorProvider.ContainerControl = this;
            // 
            // DeleteStudentButton
            // 
            DeleteStudentButton.Location = new Point(235, 423);
            DeleteStudentButton.Name = "DeleteStudentButton";
            DeleteStudentButton.Size = new Size(161, 40);
            DeleteStudentButton.TabIndex = 11;
            DeleteStudentButton.Text = "Delete Student";
            DeleteStudentButton.UseVisualStyleBackColor = true;
            DeleteStudentButton.Click += DeleteStudentButton_Click;
            // 
            // StudentNameInput
            // 
            StudentNameInput.Location = new Point(74, 21);
            StudentNameInput.Name = "StudentNameInput";
            StudentNameInput.Size = new Size(336, 34);
            StudentNameInput.TabIndex = 12;
            // 
            // StudentInfoViewer
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(476, 485);
            Controls.Add(StudentNameInput);
            Controls.Add(DeleteStudentButton);
            Controls.Add(CloseButton);
            Controls.Add(GroupList);
            Controls.Add(AssignGroupCheck);
            Controls.Add(CopyIDButton);
            Controls.Add(IDVal);
            Controls.Add(IDLabel);
            Controls.Add(label1);
            Controls.Add(DeterminantLabel);
            Controls.Add(DeterminantInput);
            Controls.Add(DeterminantSetCheck);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "StudentInfoViewer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Info Viewer";
            FormClosing += StudentInfoViewer_FormClosing;
            Load += StudentInfoViewer_Load;
            ((System.ComponentModel.ISupportInitialize)DeterminantInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox DeterminantSetCheck;
        private NumericUpDown DeterminantInput;
        private Label DeterminantLabel;
        private Label label1;
        private Label IDLabel;
        private Label IDVal;
        private Button CopyIDButton;
        private CheckBox AssignGroupCheck;
        private ComboBox GroupList;
        private Button CloseButton;
        private ErrorProvider ErrorProvider;
        private Button DeleteStudentButton;
        private TextBox StudentNameInput;
    }
}
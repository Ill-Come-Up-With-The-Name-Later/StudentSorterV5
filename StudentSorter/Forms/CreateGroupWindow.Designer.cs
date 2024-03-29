﻿namespace StudentSorter
{
    partial class CreateGroupWindow
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
            JsonUploader = new OpenFileDialog();
            GroupCreateTitle = new Label();
            GroupNameLabel = new Label();
            GroupNameInput = new TextBox();
            CapacityInput = new NumericUpDown();
            CapacityLabel = new Label();
            MinAcceptDeterminant = new Label();
            MaxAcceptDeterminant = new Label();
            MinDeterminantInput = new NumericUpDown();
            MaxDeterminantInput = new NumericUpDown();
            CreateGroupButton = new Button();
            JsonImportButton = new Button();
            ErrorProvider = new ErrorProvider(components);
            CreateOnStudentsButton = new Button();
            StudentsPerGroup = new NumericUpDown();
            AutoCreateLabel = new Label();
            StudentsPerGroupLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)CapacityInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinDeterminantInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaxDeterminantInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StudentsPerGroup).BeginInit();
            SuspendLayout();
            // 
            // JsonUploader
            // 
            JsonUploader.DefaultExt = "json";
            JsonUploader.Filter = "JSON files|*.json";
            JsonUploader.Title = "Upload Group JSON";
            JsonUploader.FileOk += JsonUploader_FileOk;
            // 
            // GroupCreateTitle
            // 
            GroupCreateTitle.AutoSize = true;
            GroupCreateTitle.Location = new Point(246, 21);
            GroupCreateTitle.Margin = new Padding(4, 0, 4, 0);
            GroupCreateTitle.Name = "GroupCreateTitle";
            GroupCreateTitle.Size = new Size(129, 28);
            GroupCreateTitle.TabIndex = 0;
            GroupCreateTitle.Text = "Create Group";
            // 
            // GroupNameLabel
            // 
            GroupNameLabel.AutoSize = true;
            GroupNameLabel.Location = new Point(19, 71);
            GroupNameLabel.Name = "GroupNameLabel";
            GroupNameLabel.Size = new Size(129, 28);
            GroupNameLabel.TabIndex = 1;
            GroupNameLabel.Text = "Group Name:";
            // 
            // GroupNameInput
            // 
            GroupNameInput.Location = new Point(28, 112);
            GroupNameInput.Name = "GroupNameInput";
            GroupNameInput.Size = new Size(224, 34);
            GroupNameInput.TabIndex = 2;
            // 
            // CapacityInput
            // 
            CapacityInput.Location = new Point(28, 209);
            CapacityInput.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            CapacityInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            CapacityInput.Name = "CapacityInput";
            CapacityInput.Size = new Size(150, 34);
            CapacityInput.TabIndex = 3;
            CapacityInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // CapacityLabel
            // 
            CapacityLabel.AutoSize = true;
            CapacityLabel.Location = new Point(19, 169);
            CapacityLabel.Name = "CapacityLabel";
            CapacityLabel.Size = new Size(91, 28);
            CapacityLabel.TabIndex = 4;
            CapacityLabel.Text = "Capacity:";
            // 
            // MinAcceptDeterminant
            // 
            MinAcceptDeterminant.AutoSize = true;
            MinAcceptDeterminant.Location = new Point(325, 71);
            MinAcceptDeterminant.Name = "MinAcceptDeterminant";
            MinAcceptDeterminant.Size = new Size(255, 28);
            MinAcceptDeterminant.TabIndex = 5;
            MinAcceptDeterminant.Text = "Min. Accepted Determinant:";
            // 
            // MaxAcceptDeterminant
            // 
            MaxAcceptDeterminant.AutoSize = true;
            MaxAcceptDeterminant.Location = new Point(325, 169);
            MaxAcceptDeterminant.Name = "MaxAcceptDeterminant";
            MaxAcceptDeterminant.Size = new Size(258, 28);
            MaxAcceptDeterminant.TabIndex = 6;
            MaxAcceptDeterminant.Text = "Max. Accepted Determinant:";
            // 
            // MinDeterminantInput
            // 
            MinDeterminantInput.Location = new Point(325, 113);
            MinDeterminantInput.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            MinDeterminantInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            MinDeterminantInput.Name = "MinDeterminantInput";
            MinDeterminantInput.Size = new Size(150, 34);
            MinDeterminantInput.TabIndex = 7;
            MinDeterminantInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            MinDeterminantInput.ValueChanged += MinDeterminantInput_ValueChanged;
            // 
            // MaxDeterminantInput
            // 
            MaxDeterminantInput.Location = new Point(325, 209);
            MaxDeterminantInput.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            MaxDeterminantInput.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            MaxDeterminantInput.Name = "MaxDeterminantInput";
            MaxDeterminantInput.Size = new Size(150, 34);
            MaxDeterminantInput.TabIndex = 8;
            MaxDeterminantInput.Value = new decimal(new int[] { 2, 0, 0, 0 });
            MaxDeterminantInput.ValueChanged += MaxDeterminantInput_ValueChanged;
            // 
            // CreateGroupButton
            // 
            CreateGroupButton.Location = new Point(89, 274);
            CreateGroupButton.Name = "CreateGroupButton";
            CreateGroupButton.Size = new Size(197, 49);
            CreateGroupButton.TabIndex = 9;
            CreateGroupButton.Text = "Create Group";
            CreateGroupButton.UseVisualStyleBackColor = true;
            CreateGroupButton.Click += CreateGroupButton_Click;
            // 
            // JsonImportButton
            // 
            JsonImportButton.Location = new Point(89, 349);
            JsonImportButton.Name = "JsonImportButton";
            JsonImportButton.Size = new Size(197, 78);
            JsonImportButton.TabIndex = 10;
            JsonImportButton.Text = "Upload Groups From a JSON File";
            JsonImportButton.UseVisualStyleBackColor = true;
            JsonImportButton.Click += JsonImportButton_Click;
            // 
            // ErrorProvider
            // 
            ErrorProvider.ContainerControl = this;
            // 
            // CreateOnStudentsButton
            // 
            CreateOnStudentsButton.Location = new Point(352, 379);
            CreateOnStudentsButton.Name = "CreateOnStudentsButton";
            CreateOnStudentsButton.Size = new Size(271, 48);
            CreateOnStudentsButton.TabIndex = 11;
            CreateOnStudentsButton.Text = "Create Based on Students";
            CreateOnStudentsButton.UseVisualStyleBackColor = true;
            CreateOnStudentsButton.Click += CreateOnStudentsButton_Click;
            // 
            // StudentsPerGroup
            // 
            StudentsPerGroup.Location = new Point(490, 339);
            StudentsPerGroup.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            StudentsPerGroup.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            StudentsPerGroup.Name = "StudentsPerGroup";
            StudentsPerGroup.Size = new Size(150, 34);
            StudentsPerGroup.TabIndex = 12;
            StudentsPerGroup.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // AutoCreateLabel
            // 
            AutoCreateLabel.AutoSize = true;
            AutoCreateLabel.Location = new Point(377, 295);
            AutoCreateLabel.Name = "AutoCreateLabel";
            AutoCreateLabel.Size = new Size(263, 28);
            AutoCreateLabel.TabIndex = 13;
            AutoCreateLabel.Text = "Create Groups Automatically";
            // 
            // StudentsPerGroupLabel
            // 
            StudentsPerGroupLabel.AutoSize = true;
            StudentsPerGroupLabel.Location = new Point(351, 341);
            StudentsPerGroupLabel.Name = "StudentsPerGroupLabel";
            StudentsPerGroupLabel.Size = new Size(124, 28);
            StudentsPerGroupLabel.TabIndex = 14;
            StudentsPerGroupLabel.Text = "Students Per:";
            // 
            // CreateGroupWindow
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(679, 439);
            Controls.Add(StudentsPerGroupLabel);
            Controls.Add(AutoCreateLabel);
            Controls.Add(StudentsPerGroup);
            Controls.Add(CreateOnStudentsButton);
            Controls.Add(JsonImportButton);
            Controls.Add(CreateGroupButton);
            Controls.Add(MaxDeterminantInput);
            Controls.Add(MinDeterminantInput);
            Controls.Add(MaxAcceptDeterminant);
            Controls.Add(MinAcceptDeterminant);
            Controls.Add(CapacityLabel);
            Controls.Add(CapacityInput);
            Controls.Add(GroupNameInput);
            Controls.Add(GroupNameLabel);
            Controls.Add(GroupCreateTitle);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "CreateGroupWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Group";
            ((System.ComponentModel.ISupportInitialize)CapacityInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinDeterminantInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaxDeterminantInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)StudentsPerGroup).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog JsonUploader;
        private Label GroupCreateTitle;
        private Label GroupNameLabel;
        private TextBox GroupNameInput;
        private NumericUpDown CapacityInput;
        private Label CapacityLabel;
        private Label MinAcceptDeterminant;
        private Label MaxAcceptDeterminant;
        private NumericUpDown MinDeterminantInput;
        private NumericUpDown MaxDeterminantInput;
        private Button CreateGroupButton;
        private Button JsonImportButton;
        private ErrorProvider ErrorProvider;
        private Button CreateOnStudentsButton;
        private Label StudentsPerGroupLabel;
        private Label AutoCreateLabel;
        private NumericUpDown StudentsPerGroup;
    }
}
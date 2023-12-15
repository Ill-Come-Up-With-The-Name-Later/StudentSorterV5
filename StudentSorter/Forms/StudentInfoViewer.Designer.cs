﻿namespace StudentSorter
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
            StudentNameTitle = new Label();
            DeterminantSetCheck = new CheckBox();
            DeterminantInput = new NumericUpDown();
            DeterminantLabel = new Label();
            label1 = new Label();
            IDLabel = new Label();
            IDVal = new Label();
            CopyIDButton = new Button();
            ((System.ComponentModel.ISupportInitialize)DeterminantInput).BeginInit();
            SuspendLayout();
            // 
            // StudentNameTitle
            // 
            StudentNameTitle.AutoSize = true;
            StudentNameTitle.Location = new Point(177, 22);
            StudentNameTitle.Name = "StudentNameTitle";
            StudentNameTitle.Size = new Size(132, 28);
            StudentNameTitle.TabIndex = 0;
            StudentNameTitle.Text = "StudentName";
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
            label1.Location = new Point(42, 275);
            label1.Name = "label1";
            label1.Size = new Size(392, 28);
            label1.TabIndex = 4;
            label1.Text = "Student determinant will update on closing.";
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
            CopyIDButton.Location = new Point(261, 128);
            CopyIDButton.Name = "CopyIDButton";
            CopyIDButton.Size = new Size(122, 33);
            CopyIDButton.TabIndex = 7;
            CopyIDButton.Text = "Copy ID";
            CopyIDButton.UseVisualStyleBackColor = true;
            CopyIDButton.Click += CopyIDButton_Click;
            // 
            // StudentInfoViewer
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 370);
            Controls.Add(CopyIDButton);
            Controls.Add(IDVal);
            Controls.Add(IDLabel);
            Controls.Add(label1);
            Controls.Add(DeterminantLabel);
            Controls.Add(DeterminantInput);
            Controls.Add(DeterminantSetCheck);
            Controls.Add(StudentNameTitle);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "StudentInfoViewer";
            Text = "Student Info Viewer";
            FormClosing += StudentInfoViewer_FormClosing;
            Load += StudentInfoViewer_Load;
            ((System.ComponentModel.ISupportInitialize)DeterminantInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label StudentNameTitle;
        private CheckBox DeterminantSetCheck;
        private NumericUpDown DeterminantInput;
        private Label DeterminantLabel;
        private Label label1;
        private Label IDLabel;
        private Label IDVal;
        private Button CopyIDButton;
    }
}
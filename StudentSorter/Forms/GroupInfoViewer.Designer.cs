namespace StudentSorter
{
    partial class GroupInfoViewer
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
            GroupNameTitle = new Label();
            CapacityLabel = new Label();
            GroupCapacityInput = new NumericUpDown();
            MinDeterLabel = new Label();
            MaxDeterLabel = new Label();
            MinDeterminantInput = new NumericUpDown();
            MaxDeterminantInput = new NumericUpDown();
            label1 = new Label();
            CloseButton = new Button();
            DeleteGroupButton = new Button();
            ((System.ComponentModel.ISupportInitialize)GroupCapacityInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinDeterminantInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaxDeterminantInput).BeginInit();
            SuspendLayout();
            // 
            // GroupNameTitle
            // 
            GroupNameTitle.AutoSize = true;
            GroupNameTitle.Location = new Point(119, 22);
            GroupNameTitle.Name = "GroupNameTitle";
            GroupNameTitle.Size = new Size(120, 28);
            GroupNameTitle.TabIndex = 0;
            GroupNameTitle.Text = "GroupName";
            // 
            // CapacityLabel
            // 
            CapacityLabel.AutoSize = true;
            CapacityLabel.Location = new Point(11, 75);
            CapacityLabel.Name = "CapacityLabel";
            CapacityLabel.Size = new Size(152, 28);
            CapacityLabel.TabIndex = 1;
            CapacityLabel.Text = "Group Capacity:";
            // 
            // GroupCapacityInput
            // 
            GroupCapacityInput.Location = new Point(13, 117);
            GroupCapacityInput.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            GroupCapacityInput.Name = "GroupCapacityInput";
            GroupCapacityInput.Size = new Size(150, 34);
            GroupCapacityInput.TabIndex = 2;
            // 
            // MinDeterLabel
            // 
            MinDeterLabel.AutoSize = true;
            MinDeterLabel.Location = new Point(11, 172);
            MinDeterLabel.Name = "MinDeterLabel";
            MinDeterLabel.Size = new Size(255, 28);
            MinDeterLabel.TabIndex = 3;
            MinDeterLabel.Text = "Min. Accepted Determinant:";
            // 
            // MaxDeterLabel
            // 
            MaxDeterLabel.AutoSize = true;
            MaxDeterLabel.Location = new Point(11, 268);
            MaxDeterLabel.Name = "MaxDeterLabel";
            MaxDeterLabel.Size = new Size(258, 28);
            MaxDeterLabel.TabIndex = 4;
            MaxDeterLabel.Text = "Max. Accepted Determinant:";
            // 
            // MinDeterminantInput
            // 
            MinDeterminantInput.Location = new Point(13, 217);
            MinDeterminantInput.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            MinDeterminantInput.Name = "MinDeterminantInput";
            MinDeterminantInput.Size = new Size(150, 34);
            MinDeterminantInput.TabIndex = 5;
            // 
            // MaxDeterminantInput
            // 
            MaxDeterminantInput.Location = new Point(13, 313);
            MaxDeterminantInput.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            MaxDeterminantInput.Name = "MaxDeterminantInput";
            MaxDeterminantInput.Size = new Size(150, 34);
            MaxDeterminantInput.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 389);
            label1.Name = "label1";
            label1.Size = new Size(307, 28);
            label1.TabIndex = 7;
            label1.Text = "Group Info will update on closing.";
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(13, 443);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(133, 40);
            CloseButton.TabIndex = 8;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // DeleteGroupButton
            // 
            DeleteGroupButton.Location = new Point(163, 443);
            DeleteGroupButton.Name = "DeleteGroupButton";
            DeleteGroupButton.Size = new Size(173, 41);
            DeleteGroupButton.TabIndex = 9;
            DeleteGroupButton.Text = "Delete Group";
            DeleteGroupButton.UseVisualStyleBackColor = true;
            DeleteGroupButton.Click += DeleteGroupButton_Click;
            // 
            // GroupInfoViewer
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 495);
            Controls.Add(DeleteGroupButton);
            Controls.Add(CloseButton);
            Controls.Add(label1);
            Controls.Add(MaxDeterminantInput);
            Controls.Add(MinDeterminantInput);
            Controls.Add(MaxDeterLabel);
            Controls.Add(MinDeterLabel);
            Controls.Add(GroupCapacityInput);
            Controls.Add(CapacityLabel);
            Controls.Add(GroupNameTitle);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "GroupInfoViewer";
            Text = "Group Info Viewer";
            FormClosing += GroupInfoViewer_FormClosing;
            Load += GroupInfoViewer_Load;
            ((System.ComponentModel.ISupportInitialize)GroupCapacityInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinDeterminantInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaxDeterminantInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label GroupNameTitle;
        private Label CapacityLabel;
        private NumericUpDown GroupCapacityInput;
        private Label MinDeterLabel;
        private Label MaxDeterLabel;
        private NumericUpDown MinDeterminantInput;
        private NumericUpDown MaxDeterminantInput;
        private Label label1;
        private Button CloseButton;
        private Button DeleteGroupButton;
    }
}
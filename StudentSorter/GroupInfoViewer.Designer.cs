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
            SuspendLayout();
            // 
            // GroupNameTitle
            // 
            GroupNameTitle.AutoSize = true;
            GroupNameTitle.Location = new Point(217, 30);
            GroupNameTitle.Name = "GroupNameTitle";
            GroupNameTitle.Size = new Size(120, 28);
            GroupNameTitle.TabIndex = 0;
            GroupNameTitle.Text = "GroupName";
            // 
            // GroupInfoViewer
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 468);
            Controls.Add(GroupNameTitle);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "GroupInfoViewer";
            Text = "Group Info Viewer";
            FormClosing += GroupInfoViewer_FormClosing;
            Load += GroupInfoViewer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label GroupNameTitle;
    }
}
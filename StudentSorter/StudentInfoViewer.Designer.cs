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
            StudentNameTitle = new Label();
            SuspendLayout();
            // 
            // StudentNameTitle
            // 
            StudentNameTitle.AutoSize = true;
            StudentNameTitle.Location = new Point(237, 20);
            StudentNameTitle.Name = "StudentNameTitle";
            StudentNameTitle.Size = new Size(132, 28);
            StudentNameTitle.TabIndex = 0;
            StudentNameTitle.Text = "StudentName";
            // 
            // StudentInfoViewer
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 389);
            Controls.Add(StudentNameTitle);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "StudentInfoViewer";
            Text = "Student Info Viewer";
            Load += StudentInfoViewer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label StudentNameTitle;
    }
}
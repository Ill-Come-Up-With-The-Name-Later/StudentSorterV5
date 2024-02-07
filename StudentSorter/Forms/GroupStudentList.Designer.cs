namespace StudentSorter
{
    partial class GroupStudentList
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
            StudentList = new DataGridView();
            Title = new Label();
            ((System.ComponentModel.ISupportInitialize)StudentList).BeginInit();
            SuspendLayout();
            // 
            // StudentList
            // 
            StudentList.AllowUserToAddRows = false;
            StudentList.AllowUserToDeleteRows = false;
            StudentList.AllowUserToResizeColumns = false;
            StudentList.AllowUserToResizeRows = false;
            StudentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentList.Location = new Point(120, 65);
            StudentList.Margin = new Padding(4);
            StudentList.MultiSelect = false;
            StudentList.Name = "StudentList";
            StudentList.ReadOnly = true;
            StudentList.RowHeadersVisible = false;
            StudentList.RowHeadersWidth = 51;
            StudentList.RowTemplate.Height = 29;
            StudentList.Size = new Size(424, 358);
            StudentList.TabIndex = 0;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(200, 19);
            Title.Margin = new Padding(4, 0, 4, 0);
            Title.Name = "Title";
            Title.Size = new Size(222, 28);
            Title.TabIndex = 1;
            Title.Text = "Students in GroupName";
            // 
            // GroupStudentList
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(651, 465);
            Controls.Add(Title);
            Controls.Add(StudentList);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "GroupStudentList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Group Student List";
            Load += GroupStudentList_Load;
            ((System.ComponentModel.ISupportInitialize)StudentList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView StudentList;
        private Label Title;
    }
}
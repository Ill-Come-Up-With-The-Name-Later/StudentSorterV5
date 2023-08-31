﻿namespace StudentSorter
{
    partial class SortDisplay
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
            GroupList = new DataGridView();
            Title = new Label();
            ReshuffleButton = new Button();
            ((System.ComponentModel.ISupportInitialize)GroupList).BeginInit();
            SuspendLayout();
            // 
            // GroupList
            // 
            GroupList.AllowUserToAddRows = false;
            GroupList.AllowUserToDeleteRows = false;
            GroupList.AllowUserToResizeColumns = false;
            GroupList.AllowUserToResizeRows = false;
            GroupList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GroupList.ColumnHeadersVisible = false;
            GroupList.Location = new Point(147, 78);
            GroupList.Name = "GroupList";
            GroupList.RowHeadersVisible = false;
            GroupList.RowHeadersWidth = 51;
            GroupList.RowTemplate.Height = 29;
            GroupList.Size = new Size(345, 266);
            GroupList.TabIndex = 0;
            GroupList.CellDoubleClick += GroupList_CellDoubleClick;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(250, 24);
            Title.Name = "Title";
            Title.Size = new Size(138, 28);
            Title.TabIndex = 1;
            Title.Text = "Sorting Result:";
            // 
            // ReshuffleButton
            // 
            ReshuffleButton.Location = new Point(207, 362);
            ReshuffleButton.Name = "ReshuffleButton";
            ReshuffleButton.Size = new Size(219, 50);
            ReshuffleButton.TabIndex = 2;
            ReshuffleButton.Text = "Reshuffle Groups";
            ReshuffleButton.UseVisualStyleBackColor = true;
            ReshuffleButton.Click += ReshuffleButton_Click;
            // 
            // SortDisplay
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 424);
            Controls.Add(ReshuffleButton);
            Controls.Add(Title);
            Controls.Add(GroupList);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "SortDisplay";
            Text = "Sort Result Display";
            Load += SortDisplay_Load;
            ((System.ComponentModel.ISupportInitialize)GroupList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GroupList;
        private Label Title;
        private Button ReshuffleButton;
    }
}
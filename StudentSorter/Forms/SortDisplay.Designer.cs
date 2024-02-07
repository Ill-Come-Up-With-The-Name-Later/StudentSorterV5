namespace StudentSorter
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
            ExportSort = new Button();
            SaveSort = new SaveFileDialog();
            ResetSorterButton = new Button();
            FindPersonLabel = new Label();
            StudentDropDown = new ComboBox();
            ConfigUsedLabel = new Label();
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
            GroupList.Location = new Point(146, 156);
            GroupList.MultiSelect = false;
            GroupList.Name = "GroupList";
            GroupList.ReadOnly = true;
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
            ReshuffleButton.Location = new Point(54, 453);
            ReshuffleButton.Name = "ReshuffleButton";
            ReshuffleButton.Size = new Size(219, 50);
            ReshuffleButton.TabIndex = 2;
            ReshuffleButton.Text = "Reshuffle Groups";
            ReshuffleButton.UseVisualStyleBackColor = true;
            ReshuffleButton.Click += ReshuffleButton_Click;
            // 
            // ExportSort
            // 
            ExportSort.Location = new Point(337, 453);
            ExportSort.Name = "ExportSort";
            ExportSort.Size = new Size(237, 50);
            ExportSort.TabIndex = 3;
            ExportSort.Text = "Export Sort to txt";
            ExportSort.UseVisualStyleBackColor = true;
            ExportSort.Click += ExportSort_Click;
            // 
            // SaveSort
            // 
            SaveSort.DefaultExt = "txt";
            SaveSort.FileName = "SortResult.txt";
            SaveSort.Title = "Export Sort to txt";
            SaveSort.FileOk += SaveSort_FileOk;
            // 
            // ResetSorterButton
            // 
            ResetSorterButton.Location = new Point(241, 509);
            ResetSorterButton.Name = "ResetSorterButton";
            ResetSorterButton.Size = new Size(147, 42);
            ResetSorterButton.TabIndex = 4;
            ResetSorterButton.Text = "Reset Sorter";
            ResetSorterButton.UseVisualStyleBackColor = true;
            ResetSorterButton.Click += ResetSorterButton_Click;
            // 
            // FindPersonLabel
            // 
            FindPersonLabel.AutoSize = true;
            FindPersonLabel.Location = new Point(129, 85);
            FindPersonLabel.Name = "FindPersonLabel";
            FindPersonLabel.Size = new Size(54, 28);
            FindPersonLabel.TabIndex = 5;
            FindPersonLabel.Text = "Find:";
            // 
            // StudentDropDown
            // 
            StudentDropDown.FormattingEnabled = true;
            StudentDropDown.Location = new Point(199, 82);
            StudentDropDown.Name = "StudentDropDown";
            StudentDropDown.Size = new Size(309, 36);
            StudentDropDown.TabIndex = 6;
            StudentDropDown.SelectedIndexChanged += StudentDropDown_SelectedIndexChanged;
            // 
            // ConfigUsedLabel
            // 
            ConfigUsedLabel.AutoSize = true;
            ConfigUsedLabel.Location = new Point(54, 568);
            ConfigUsedLabel.Name = "ConfigUsedLabel";
            ConfigUsedLabel.Size = new Size(239, 28);
            ConfigUsedLabel.TabIndex = 7;
            ConfigUsedLabel.Text = "Configuration Used: None";
            // 
            // SortDisplay
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(653, 614);
            Controls.Add(ConfigUsedLabel);
            Controls.Add(StudentDropDown);
            Controls.Add(FindPersonLabel);
            Controls.Add(ResetSorterButton);
            Controls.Add(ExportSort);
            Controls.Add(ReshuffleButton);
            Controls.Add(Title);
            Controls.Add(GroupList);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "SortDisplay";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Button ExportSort;
        private SaveFileDialog SaveSort;
        private Button ResetSorterButton;
        private Label FindPersonLabel;
        private ComboBox StudentDropDown;
        private Label ConfigUsedLabel;
    }
}
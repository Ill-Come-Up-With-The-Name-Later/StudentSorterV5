namespace StudentSorter
{
    partial class IllegalPairsOverviewer
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
            SerializePairs = new SaveFileDialog();
            OpenPairsFile = new OpenFileDialog();
            IllegalPairList = new DataGridView();
            Title = new Label();
            SerializePairsButton = new Button();
            DeserializePairsButton = new Button();
            AddPairButton = new Button();
            ErrorProvider = new ErrorProvider(components);
            RemovalInstruction = new Label();
            ((System.ComponentModel.ISupportInitialize)IllegalPairList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // SerializePairs
            // 
            SerializePairs.FileName = "illegal_pairs.json";
            SerializePairs.Title = "Serialize Pairs";
            SerializePairs.FileOk += SerializePairs_FileOk;
            // 
            // OpenPairsFile
            // 
            OpenPairsFile.DefaultExt = "json";
            OpenPairsFile.Filter = "JSON files|*.json";
            OpenPairsFile.Title = "Deserialize Pairs";
            OpenPairsFile.FileOk += OpenPairsFile_FileOk;
            // 
            // IllegalPairList
            // 
            IllegalPairList.AllowUserToAddRows = false;
            IllegalPairList.AllowUserToDeleteRows = false;
            IllegalPairList.AllowUserToResizeColumns = false;
            IllegalPairList.AllowUserToResizeRows = false;
            IllegalPairList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            IllegalPairList.ColumnHeadersVisible = false;
            IllegalPairList.Location = new Point(109, 59);
            IllegalPairList.Name = "IllegalPairList";
            IllegalPairList.ReadOnly = true;
            IllegalPairList.RowHeadersVisible = false;
            IllegalPairList.RowHeadersWidth = 51;
            IllegalPairList.RowTemplate.Height = 29;
            IllegalPairList.Size = new Size(502, 247);
            IllegalPairList.TabIndex = 0;
            IllegalPairList.CellDoubleClick += IllegalPairList_CellDoubleClick;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(299, 9);
            Title.Name = "Title";
            Title.Size = new Size(152, 28);
            Title.TabIndex = 1;
            Title.Text = "Disallowed Pairs";
            // 
            // SerializePairsButton
            // 
            SerializePairsButton.Location = new Point(37, 397);
            SerializePairsButton.Name = "SerializePairsButton";
            SerializePairsButton.Size = new Size(273, 50);
            SerializePairsButton.TabIndex = 2;
            SerializePairsButton.Text = "Serialize Pairs to JSON";
            SerializePairsButton.UseVisualStyleBackColor = true;
            SerializePairsButton.Click += SerializePairsButton_Click;
            // 
            // DeserializePairsButton
            // 
            DeserializePairsButton.Location = new Point(375, 397);
            DeserializePairsButton.Name = "DeserializePairsButton";
            DeserializePairsButton.Size = new Size(309, 50);
            DeserializePairsButton.TabIndex = 3;
            DeserializePairsButton.Text = "Desearialize Pairs From JSON";
            DeserializePairsButton.UseVisualStyleBackColor = true;
            DeserializePairsButton.Click += DeserializePairsButton_Click;
            // 
            // AddPairButton
            // 
            AddPairButton.Location = new Point(229, 334);
            AddPairButton.Name = "AddPairButton";
            AddPairButton.Size = new Size(243, 45);
            AddPairButton.TabIndex = 4;
            AddPairButton.Text = "Add new Disallowed Pair";
            AddPairButton.UseVisualStyleBackColor = true;
            AddPairButton.Click += AddPairButton_Click;
            // 
            // ErrorProvider
            // 
            ErrorProvider.ContainerControl = this;
            // 
            // RemovalInstruction
            // 
            RemovalInstruction.AutoSize = true;
            RemovalInstruction.Location = new Point(37, 475);
            RemovalInstruction.Name = "RemovalInstruction";
            RemovalInstruction.Size = new Size(295, 28);
            RemovalInstruction.TabIndex = 5;
            RemovalInstruction.Text = "Double-Click a pair to remove it.";
            // 
            // IllegalPairsOverviewer
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(715, 523);
            Controls.Add(RemovalInstruction);
            Controls.Add(AddPairButton);
            Controls.Add(DeserializePairsButton);
            Controls.Add(SerializePairsButton);
            Controls.Add(Title);
            Controls.Add(IllegalPairList);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "IllegalPairsOverviewer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Disallowed Pairs Overviewer";
            Load += IllegalPairsOverviewer_Load;
            ((System.ComponentModel.ISupportInitialize)IllegalPairList).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SaveFileDialog SerializePairs;
        private OpenFileDialog OpenPairsFile;
        private DataGridView IllegalPairList;
        private Label Title;
        private Button SerializePairsButton;
        private Button DeserializePairsButton;
        private Button AddPairButton;
        private ErrorProvider ErrorProvider;
        private Label RemovalInstruction;
    }
}
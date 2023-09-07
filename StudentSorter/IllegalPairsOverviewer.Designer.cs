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
            SerializePairs = new SaveFileDialog();
            OpenPairsFile = new OpenFileDialog();
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
            OpenPairsFile.FileName = "OpenPairFile";
            OpenPairsFile.Title = "Deserialize Pairs";
            OpenPairsFile.FileOk += OpenPairsFile_FileOk;
            // 
            // IllegalPairsOverviewer
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 471);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "IllegalPairsOverviewer";
            Text = "Illegal Pairs Overviewer";
            ResumeLayout(false);
        }

        #endregion

        private SaveFileDialog SerializePairs;
        private OpenFileDialog OpenPairsFile;
    }
}
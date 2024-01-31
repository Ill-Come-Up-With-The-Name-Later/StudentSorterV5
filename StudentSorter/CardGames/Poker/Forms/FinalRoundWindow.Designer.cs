namespace StudentSorter.CardGames.Poker.Forms
{
    partial class FinalRoundWindow
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
            CommunityCardList = new DataGridView();
            PlayerCardList = new DataGridView();
            BestHandList = new DataGridView();
            PlayerCardTitle = new Label();
            CommunityCardTitle = new Label();
            PlayerBestHandTitle = new Label();
            Instructions = new Label();
            EndRoundButton = new Button();
            BestHandInstructions = new Label();
            ((System.ComponentModel.ISupportInitialize)CommunityCardList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayerCardList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BestHandList).BeginInit();
            SuspendLayout();
            // 
            // CommunityCardList
            // 
            CommunityCardList.AllowUserToAddRows = false;
            CommunityCardList.AllowUserToDeleteRows = false;
            CommunityCardList.AllowUserToResizeColumns = false;
            CommunityCardList.AllowUserToResizeRows = false;
            CommunityCardList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CommunityCardList.ColumnHeadersVisible = false;
            CommunityCardList.Location = new Point(376, 12);
            CommunityCardList.Name = "CommunityCardList";
            CommunityCardList.ReadOnly = true;
            CommunityCardList.RowHeadersVisible = false;
            CommunityCardList.RowHeadersWidth = 51;
            CommunityCardList.RowTemplate.Height = 29;
            CommunityCardList.Size = new Size(166, 213);
            CommunityCardList.TabIndex = 2;
            CommunityCardList.CellDoubleClick += CommunityCardList_CellDoubleClick;
            // 
            // PlayerCardList
            // 
            PlayerCardList.AllowUserToAddRows = false;
            PlayerCardList.AllowUserToDeleteRows = false;
            PlayerCardList.AllowUserToResizeColumns = false;
            PlayerCardList.AllowUserToResizeRows = false;
            PlayerCardList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PlayerCardList.ColumnHeadersVisible = false;
            PlayerCardList.Location = new Point(27, 243);
            PlayerCardList.Name = "PlayerCardList";
            PlayerCardList.ReadOnly = true;
            PlayerCardList.RowHeadersVisible = false;
            PlayerCardList.RowHeadersWidth = 51;
            PlayerCardList.RowTemplate.Height = 29;
            PlayerCardList.Size = new Size(166, 213);
            PlayerCardList.TabIndex = 3;
            PlayerCardList.CellDoubleClick += PlayerCardList_CellDoubleClick;
            // 
            // BestHandList
            // 
            BestHandList.AllowUserToAddRows = false;
            BestHandList.AllowUserToDeleteRows = false;
            BestHandList.AllowUserToResizeColumns = false;
            BestHandList.AllowUserToResizeRows = false;
            BestHandList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BestHandList.ColumnHeadersVisible = false;
            BestHandList.Location = new Point(726, 243);
            BestHandList.Name = "BestHandList";
            BestHandList.ReadOnly = true;
            BestHandList.RowHeadersVisible = false;
            BestHandList.RowHeadersWidth = 51;
            BestHandList.RowTemplate.Height = 29;
            BestHandList.Size = new Size(166, 213);
            BestHandList.TabIndex = 4;
            BestHandList.CellDoubleClick += BestHandList_CellDoubleClick;
            // 
            // PlayerCardTitle
            // 
            PlayerCardTitle.AutoSize = true;
            PlayerCardTitle.Location = new Point(27, 197);
            PlayerCardTitle.Name = "PlayerCardTitle";
            PlayerCardTitle.Size = new Size(103, 28);
            PlayerCardTitle.TabIndex = 5;
            PlayerCardTitle.Text = "Your Hand";
            // 
            // CommunityCardTitle
            // 
            CommunityCardTitle.AutoSize = true;
            CommunityCardTitle.Location = new Point(564, 13);
            CommunityCardTitle.Name = "CommunityCardTitle";
            CommunityCardTitle.Size = new Size(168, 28);
            CommunityCardTitle.TabIndex = 6;
            CommunityCardTitle.Text = "Community Cards";
            // 
            // PlayerBestHandTitle
            // 
            PlayerBestHandTitle.AutoSize = true;
            PlayerBestHandTitle.Location = new Point(726, 197);
            PlayerBestHandTitle.Name = "PlayerBestHandTitle";
            PlayerBestHandTitle.Size = new Size(144, 28);
            PlayerBestHandTitle.TabIndex = 7;
            PlayerBestHandTitle.Text = "Your Best Hand";
            // 
            // Instructions
            // 
            Instructions.AutoSize = true;
            Instructions.Location = new Point(230, 243);
            Instructions.Name = "Instructions";
            Instructions.Size = new Size(461, 28);
            Instructions.TabIndex = 8;
            Instructions.Text = "Double-Click a card to make your best 5-card hand.";
            // 
            // EndRoundButton
            // 
            EndRoundButton.Enabled = false;
            EndRoundButton.Location = new Point(373, 414);
            EndRoundButton.Name = "EndRoundButton";
            EndRoundButton.Size = new Size(169, 42);
            EndRoundButton.TabIndex = 9;
            EndRoundButton.Text = "Done";
            EndRoundButton.UseVisualStyleBackColor = true;
            // 
            // BestHandInstructions
            // 
            BestHandInstructions.AutoSize = true;
            BestHandInstructions.Location = new Point(234, 282);
            BestHandInstructions.Name = "BestHandInstructions";
            BestHandInstructions.Size = new Size(457, 28);
            BestHandInstructions.TabIndex = 10;
            BestHandInstructions.Text = "Double-Click a card in Your Best Hand to remove it.";
            // 
            // FinalRoundWindow
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 468);
            Controls.Add(BestHandInstructions);
            Controls.Add(EndRoundButton);
            Controls.Add(Instructions);
            Controls.Add(PlayerBestHandTitle);
            Controls.Add(CommunityCardTitle);
            Controls.Add(PlayerCardTitle);
            Controls.Add(BestHandList);
            Controls.Add(PlayerCardList);
            Controls.Add(CommunityCardList);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FinalRoundWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Final Round Window";
            ((System.ComponentModel.ISupportInitialize)CommunityCardList).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlayerCardList).EndInit();
            ((System.ComponentModel.ISupportInitialize)BestHandList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView CommunityCardList;
        private DataGridView PlayerCardList;
        private DataGridView BestHandList;
        private Label PlayerCardTitle;
        private Label CommunityCardTitle;
        private Label PlayerBestHandTitle;
        private Label Instructions;
        private Button EndRoundButton;
        private Label BestHandInstructions;
    }
}
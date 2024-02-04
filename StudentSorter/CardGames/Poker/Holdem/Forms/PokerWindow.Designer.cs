namespace StudentSorter.CardGames.Poker.Forms
{
    partial class PokerWindow
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
            StartButton = new Button();
            PlayerCards = new DataGridView();
            PlayerCardTitle = new Label();
            Player1BetLabel = new Label();
            Player2Cards = new DataGridView();
            Player3Cards = new DataGridView();
            Player4Cards = new DataGridView();
            Player2Label = new Label();
            Player3Label = new Label();
            Player4Label = new Label();
            CommunityCards = new DataGridView();
            CommunityCardLabel = new Label();
            Player2BetLabel = new Label();
            Player3BetLabel = new Label();
            Player4BetLabel = new Label();
            PotLabel = new Label();
            BettingRoundLabel = new Label();
            Round2Button = new Button();
            Round3Button = new Button();
            FoldButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PlayerCards).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Player2Cards).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Player3Cards).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Player4Cards).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CommunityCards).BeginInit();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.Location = new Point(12, 731);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(123, 46);
            StartButton.TabIndex = 0;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // PlayerCards
            // 
            PlayerCards.AllowUserToAddRows = false;
            PlayerCards.AllowUserToDeleteRows = false;
            PlayerCards.AllowUserToResizeColumns = false;
            PlayerCards.AllowUserToResizeRows = false;
            PlayerCards.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PlayerCards.ColumnHeadersVisible = false;
            PlayerCards.Location = new Point(150, 433);
            PlayerCards.Name = "PlayerCards";
            PlayerCards.ReadOnly = true;
            PlayerCards.RowHeadersVisible = false;
            PlayerCards.RowHeadersWidth = 51;
            PlayerCards.RowTemplate.Height = 29;
            PlayerCards.Size = new Size(166, 213);
            PlayerCards.TabIndex = 1;
            // 
            // PlayerCardTitle
            // 
            PlayerCardTitle.AutoSize = true;
            PlayerCardTitle.Location = new Point(150, 392);
            PlayerCardTitle.Name = "PlayerCardTitle";
            PlayerCardTitle.Size = new Size(132, 28);
            PlayerCardTitle.TabIndex = 2;
            PlayerCardTitle.Text = "Player's Cards";
            // 
            // Player1BetLabel
            // 
            Player1BetLabel.AutoSize = true;
            Player1BetLabel.Location = new Point(152, 668);
            Player1BetLabel.Name = "Player1BetLabel";
            Player1BetLabel.Size = new Size(60, 28);
            Player1BetLabel.TabIndex = 3;
            Player1BetLabel.Text = "Bet: 0";
            // 
            // Player2Cards
            // 
            Player2Cards.AllowUserToAddRows = false;
            Player2Cards.AllowUserToDeleteRows = false;
            Player2Cards.AllowUserToResizeColumns = false;
            Player2Cards.AllowUserToResizeRows = false;
            Player2Cards.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Player2Cards.ColumnHeadersVisible = false;
            Player2Cards.Location = new Point(404, 433);
            Player2Cards.Name = "Player2Cards";
            Player2Cards.ReadOnly = true;
            Player2Cards.RowHeadersVisible = false;
            Player2Cards.RowHeadersWidth = 51;
            Player2Cards.RowTemplate.Height = 29;
            Player2Cards.Size = new Size(166, 213);
            Player2Cards.TabIndex = 4;
            // 
            // Player3Cards
            // 
            Player3Cards.AllowUserToAddRows = false;
            Player3Cards.AllowUserToDeleteRows = false;
            Player3Cards.AllowUserToResizeColumns = false;
            Player3Cards.AllowUserToResizeRows = false;
            Player3Cards.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Player3Cards.ColumnHeadersVisible = false;
            Player3Cards.Location = new Point(668, 433);
            Player3Cards.Name = "Player3Cards";
            Player3Cards.ReadOnly = true;
            Player3Cards.RowHeadersVisible = false;
            Player3Cards.RowHeadersWidth = 51;
            Player3Cards.RowTemplate.Height = 29;
            Player3Cards.Size = new Size(166, 213);
            Player3Cards.TabIndex = 5;
            // 
            // Player4Cards
            // 
            Player4Cards.AllowUserToAddRows = false;
            Player4Cards.AllowUserToDeleteRows = false;
            Player4Cards.AllowUserToResizeColumns = false;
            Player4Cards.AllowUserToResizeRows = false;
            Player4Cards.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Player4Cards.ColumnHeadersVisible = false;
            Player4Cards.Location = new Point(915, 433);
            Player4Cards.Name = "Player4Cards";
            Player4Cards.ReadOnly = true;
            Player4Cards.RowHeadersVisible = false;
            Player4Cards.RowHeadersWidth = 51;
            Player4Cards.RowTemplate.Height = 29;
            Player4Cards.Size = new Size(166, 213);
            Player4Cards.TabIndex = 6;
            // 
            // Player2Label
            // 
            Player2Label.AutoSize = true;
            Player2Label.Location = new Point(404, 392);
            Player2Label.Name = "Player2Label";
            Player2Label.Size = new Size(148, 28);
            Player2Label.TabIndex = 7;
            Player2Label.Text = "Player 2's Cards";
            // 
            // Player3Label
            // 
            Player3Label.AutoSize = true;
            Player3Label.Location = new Point(668, 392);
            Player3Label.Name = "Player3Label";
            Player3Label.Size = new Size(148, 28);
            Player3Label.TabIndex = 8;
            Player3Label.Text = "Player 3's Cards";
            // 
            // Player4Label
            // 
            Player4Label.AutoSize = true;
            Player4Label.Location = new Point(915, 392);
            Player4Label.Name = "Player4Label";
            Player4Label.Size = new Size(148, 28);
            Player4Label.TabIndex = 9;
            Player4Label.Text = "Player 4's Cards";
            // 
            // CommunityCards
            // 
            CommunityCards.AllowUserToAddRows = false;
            CommunityCards.AllowUserToDeleteRows = false;
            CommunityCards.AllowUserToResizeColumns = false;
            CommunityCards.AllowUserToResizeRows = false;
            CommunityCards.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CommunityCards.ColumnHeadersVisible = false;
            CommunityCards.Location = new Point(534, 124);
            CommunityCards.Name = "CommunityCards";
            CommunityCards.ReadOnly = true;
            CommunityCards.RowHeadersVisible = false;
            CommunityCards.RowHeadersWidth = 51;
            CommunityCards.RowTemplate.Height = 29;
            CommunityCards.Size = new Size(166, 213);
            CommunityCards.TabIndex = 10;
            // 
            // CommunityCardLabel
            // 
            CommunityCardLabel.AutoSize = true;
            CommunityCardLabel.Location = new Point(534, 78);
            CommunityCardLabel.Name = "CommunityCardLabel";
            CommunityCardLabel.Size = new Size(168, 28);
            CommunityCardLabel.TabIndex = 11;
            CommunityCardLabel.Text = "Community Cards";
            // 
            // Player2BetLabel
            // 
            Player2BetLabel.AutoSize = true;
            Player2BetLabel.Location = new Point(404, 668);
            Player2BetLabel.Name = "Player2BetLabel";
            Player2BetLabel.Size = new Size(60, 28);
            Player2BetLabel.TabIndex = 12;
            Player2BetLabel.Text = "Bet: 0";
            // 
            // Player3BetLabel
            // 
            Player3BetLabel.AutoSize = true;
            Player3BetLabel.Location = new Point(668, 668);
            Player3BetLabel.Name = "Player3BetLabel";
            Player3BetLabel.Size = new Size(60, 28);
            Player3BetLabel.TabIndex = 13;
            Player3BetLabel.Text = "Bet: 0";
            // 
            // Player4BetLabel
            // 
            Player4BetLabel.AutoSize = true;
            Player4BetLabel.Location = new Point(915, 668);
            Player4BetLabel.Name = "Player4BetLabel";
            Player4BetLabel.Size = new Size(60, 28);
            Player4BetLabel.TabIndex = 14;
            Player4BetLabel.Text = "Bet: 0";
            // 
            // PotLabel
            // 
            PotLabel.AutoSize = true;
            PotLabel.Location = new Point(534, 706);
            PotLabel.Name = "PotLabel";
            PotLabel.Size = new Size(61, 28);
            PotLabel.TabIndex = 15;
            PotLabel.Text = "Pot: 0";
            // 
            // BettingRoundLabel
            // 
            BettingRoundLabel.AutoSize = true;
            BettingRoundLabel.Location = new Point(977, 749);
            BettingRoundLabel.Name = "BettingRoundLabel";
            BettingRoundLabel.Size = new Size(157, 28);
            BettingRoundLabel.TabIndex = 16;
            BettingRoundLabel.Text = "Betting Round: 1";
            // 
            // Round2Button
            // 
            Round2Button.Enabled = false;
            Round2Button.Location = new Point(173, 731);
            Round2Button.Name = "Round2Button";
            Round2Button.Size = new Size(143, 46);
            Round2Button.TabIndex = 17;
            Round2Button.Text = "Round 2 Bet";
            Round2Button.UseVisualStyleBackColor = true;
            Round2Button.Click += Round2Button_Click;
            // 
            // Round3Button
            // 
            Round3Button.Enabled = false;
            Round3Button.Location = new Point(348, 731);
            Round3Button.Name = "Round3Button";
            Round3Button.Size = new Size(139, 46);
            Round3Button.TabIndex = 18;
            Round3Button.Text = "Round 3 Bet";
            Round3Button.UseVisualStyleBackColor = true;
            Round3Button.Click += Round3Button_Click;
            // 
            // FoldButton
            // 
            FoldButton.Enabled = false;
            FoldButton.Location = new Point(615, 731);
            FoldButton.Name = "FoldButton";
            FoldButton.Size = new Size(123, 46);
            FoldButton.TabIndex = 19;
            FoldButton.Text = "Fold";
            FoldButton.UseVisualStyleBackColor = true;
            FoldButton.Click += FoldButton_Click;
            // 
            // PokerWindow
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 789);
            Controls.Add(FoldButton);
            Controls.Add(Round3Button);
            Controls.Add(Round2Button);
            Controls.Add(BettingRoundLabel);
            Controls.Add(PotLabel);
            Controls.Add(Player4BetLabel);
            Controls.Add(Player3BetLabel);
            Controls.Add(Player2BetLabel);
            Controls.Add(CommunityCardLabel);
            Controls.Add(CommunityCards);
            Controls.Add(Player4Label);
            Controls.Add(Player3Label);
            Controls.Add(Player2Label);
            Controls.Add(Player4Cards);
            Controls.Add(Player3Cards);
            Controls.Add(Player2Cards);
            Controls.Add(Player1BetLabel);
            Controls.Add(PlayerCardTitle);
            Controls.Add(PlayerCards);
            Controls.Add(StartButton);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "PokerWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Poker Window";
            ((System.ComponentModel.ISupportInitialize)PlayerCards).EndInit();
            ((System.ComponentModel.ISupportInitialize)Player2Cards).EndInit();
            ((System.ComponentModel.ISupportInitialize)Player3Cards).EndInit();
            ((System.ComponentModel.ISupportInitialize)Player4Cards).EndInit();
            ((System.ComponentModel.ISupportInitialize)CommunityCards).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartButton;
        private DataGridView PlayerCards;
        private Label PlayerCardTitle;
        private Label Player1BetLabel;
        private DataGridView Player2Cards;
        private DataGridView Player3Cards;
        private DataGridView Player4Cards;
        private Label Player2Label;
        private Label Player3Label;
        private Label Player4Label;
        private DataGridView CommunityCards;
        private Label CommunityCardLabel;
        private Label Player2BetLabel;
        private Label Player3BetLabel;
        private Label Player4BetLabel;
        private Label PotLabel;
        private Label BettingRoundLabel;
        private Button Round2Button;
        private Button Round3Button;
        private Button FoldButton;
    }
}
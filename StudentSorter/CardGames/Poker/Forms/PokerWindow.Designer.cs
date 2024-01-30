﻿namespace StudentSorter.CardGames.Poker.Forms
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
            BetLabel = new Label();
            Player2Cards = new DataGridView();
            Player3Cards = new DataGridView();
            Player4Cards = new DataGridView();
            Player2Label = new Label();
            Player3Label = new Label();
            Player4Label = new Label();
            CommunityCards = new DataGridView();
            CommunityCardLabel = new Label();
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
            // BetLabel
            // 
            BetLabel.AutoSize = true;
            BetLabel.Location = new Point(152, 668);
            BetLabel.Name = "BetLabel";
            BetLabel.Size = new Size(60, 28);
            BetLabel.TabIndex = 3;
            BetLabel.Text = "Bet: 0";
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
            // PokerWindow
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 789);
            Controls.Add(CommunityCardLabel);
            Controls.Add(CommunityCards);
            Controls.Add(Player4Label);
            Controls.Add(Player3Label);
            Controls.Add(Player2Label);
            Controls.Add(Player4Cards);
            Controls.Add(Player3Cards);
            Controls.Add(Player2Cards);
            Controls.Add(BetLabel);
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
        private Label BetLabel;
        private DataGridView Player2Cards;
        private DataGridView Player3Cards;
        private DataGridView Player4Cards;
        private Label Player2Label;
        private Label Player3Label;
        private Label Player4Label;
        private DataGridView CommunityCards;
        private Label CommunityCardLabel;
    }
}
namespace StudentSorter.CardGames.Poker.FiveCardDraw.Forms
{
    partial class ShowdownWindow
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
            PlayerCards = new DataGridView();
            PlayerCardTitle = new Label();
            NextHandButton = new Button();
            PreviousHandButton = new Button();
            WinnerLabel = new Label();
            CloseButton = new Button();
            ReplayButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PlayerCards).BeginInit();
            SuspendLayout();
            // 
            // PlayerCards
            // 
            PlayerCards.AllowUserToAddRows = false;
            PlayerCards.AllowUserToDeleteRows = false;
            PlayerCards.AllowUserToResizeColumns = false;
            PlayerCards.AllowUserToResizeRows = false;
            PlayerCards.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PlayerCards.ColumnHeadersVisible = false;
            PlayerCards.Location = new Point(250, 92);
            PlayerCards.Name = "PlayerCards";
            PlayerCards.ReadOnly = true;
            PlayerCards.RowHeadersVisible = false;
            PlayerCards.RowHeadersWidth = 51;
            PlayerCards.RowTemplate.Height = 29;
            PlayerCards.Size = new Size(166, 213);
            PlayerCards.TabIndex = 12;
            // 
            // PlayerCardTitle
            // 
            PlayerCardTitle.AutoSize = true;
            PlayerCardTitle.Location = new Point(250, 52);
            PlayerCardTitle.Name = "PlayerCardTitle";
            PlayerCardTitle.Size = new Size(130, 28);
            PlayerCardTitle.TabIndex = 13;
            PlayerCardTitle.Text = "Player's Hand";
            // 
            // NextHandButton
            // 
            NextHandButton.Location = new Point(362, 330);
            NextHandButton.Name = "NextHandButton";
            NextHandButton.Size = new Size(153, 49);
            NextHandButton.TabIndex = 14;
            NextHandButton.Text = "Next Hand";
            NextHandButton.UseVisualStyleBackColor = true;
            NextHandButton.Click += NextHandButton_Click;
            // 
            // PreviousHandButton
            // 
            PreviousHandButton.Location = new Point(162, 330);
            PreviousHandButton.Name = "PreviousHandButton";
            PreviousHandButton.Size = new Size(173, 49);
            PreviousHandButton.TabIndex = 15;
            PreviousHandButton.Text = "Previous Hand";
            PreviousHandButton.UseVisualStyleBackColor = true;
            PreviousHandButton.Click += PreviousHandButton_Click;
            // 
            // WinnerLabel
            // 
            WinnerLabel.AutoSize = true;
            WinnerLabel.Location = new Point(250, 399);
            WinnerLabel.Name = "WinnerLabel";
            WinnerLabel.Size = new Size(79, 28);
            WinnerLabel.TabIndex = 16;
            WinnerLabel.Text = "Winner:";
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(181, 443);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(94, 41);
            CloseButton.TabIndex = 17;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // ReplayButton
            // 
            ReplayButton.Location = new Point(326, 443);
            ReplayButton.Name = "ReplayButton";
            ReplayButton.Size = new Size(102, 41);
            ReplayButton.TabIndex = 18;
            ReplayButton.Text = "Replay";
            ReplayButton.UseVisualStyleBackColor = true;
            ReplayButton.Click += ReplayButton_Click;
            // 
            // ShowdownWindow
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 496);
            Controls.Add(ReplayButton);
            Controls.Add(CloseButton);
            Controls.Add(WinnerLabel);
            Controls.Add(PreviousHandButton);
            Controls.Add(NextHandButton);
            Controls.Add(PlayerCardTitle);
            Controls.Add(PlayerCards);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "ShowdownWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Showdown";
            ((System.ComponentModel.ISupportInitialize)PlayerCards).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView PlayerCards;
        private Label PlayerCardTitle;
        private Button NextHandButton;
        private Button PreviousHandButton;
        private Label WinnerLabel;
        private Button CloseButton;
        private Button ReplayButton;
    }
}
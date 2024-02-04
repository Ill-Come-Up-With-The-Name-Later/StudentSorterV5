namespace StudentSorter.CardGames
{
    partial class CardGameMenu
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
            BlackjackButton = new Button();
            PokerButton = new Button();
            SlotsButton = new Button();
            Title = new Label();
            BaccaratButton = new Button();
            FiveCardDrawButton = new Button();
            SuspendLayout();
            // 
            // BlackjackButton
            // 
            BlackjackButton.Location = new Point(100, 116);
            BlackjackButton.Name = "BlackjackButton";
            BlackjackButton.Size = new Size(191, 39);
            BlackjackButton.TabIndex = 0;
            BlackjackButton.Text = "Blackjack";
            BlackjackButton.UseVisualStyleBackColor = true;
            BlackjackButton.Click += BlackjackButton_Click;
            // 
            // PokerButton
            // 
            PokerButton.Location = new Point(99, 171);
            PokerButton.Name = "PokerButton";
            PokerButton.Size = new Size(191, 39);
            PokerButton.TabIndex = 1;
            PokerButton.Text = "Poker (Texas Hold'em)";
            PokerButton.UseVisualStyleBackColor = true;
            PokerButton.Click += PokerButton_Click;
            // 
            // SlotsButton
            // 
            SlotsButton.Location = new Point(99, 225);
            SlotsButton.Name = "SlotsButton";
            SlotsButton.Size = new Size(192, 40);
            SlotsButton.TabIndex = 2;
            SlotsButton.Text = "(Lucky) Slots";
            SlotsButton.UseVisualStyleBackColor = true;
            SlotsButton.Click += SlotsButton_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(89, 30);
            Title.Name = "Title";
            Title.Size = new Size(211, 21);
            Title.TabIndex = 3;
            Title.Text = "Definitely not a Vegas Casino";
            // 
            // BaccaratButton
            // 
            BaccaratButton.Location = new Point(99, 280);
            BaccaratButton.Name = "BaccaratButton";
            BaccaratButton.Size = new Size(192, 40);
            BaccaratButton.TabIndex = 4;
            BaccaratButton.Text = "Baccarat";
            BaccaratButton.UseVisualStyleBackColor = true;
            BaccaratButton.Click += BaccaratButton_Click;
            // 
            // FiveCardDrawButton
            // 
            FiveCardDrawButton.Location = new Point(100, 336);
            FiveCardDrawButton.Name = "FiveCardDrawButton";
            FiveCardDrawButton.Size = new Size(191, 40);
            FiveCardDrawButton.TabIndex = 5;
            FiveCardDrawButton.Text = "Poker (5-Card Draw)";
            FiveCardDrawButton.UseVisualStyleBackColor = true;
            FiveCardDrawButton.Click += FiveCardDrawButton_Click;
            // 
            // CardGameMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 464);
            Controls.Add(FiveCardDrawButton);
            Controls.Add(BaccaratButton);
            Controls.Add(Title);
            Controls.Add(SlotsButton);
            Controls.Add(PokerButton);
            Controls.Add(BlackjackButton);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "CardGameMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Card Game Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BlackjackButton;
        private Button PokerButton;
        private Button SlotsButton;
        private Label Title;
        private Button BaccaratButton;
        private Button FiveCardDrawButton;
    }
}
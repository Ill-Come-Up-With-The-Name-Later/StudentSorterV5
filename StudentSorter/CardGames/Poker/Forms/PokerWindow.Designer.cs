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
            ((System.ComponentModel.ISupportInitialize)PlayerCards).BeginInit();
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
            PlayerCardTitle.Location = new Point(165, 392);
            PlayerCardTitle.Name = "PlayerCardTitle";
            PlayerCardTitle.Size = new Size(132, 28);
            PlayerCardTitle.TabIndex = 2;
            PlayerCardTitle.Text = "Player's Cards";
            // 
            // PokerWindow
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 789);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartButton;
        private DataGridView PlayerCards;
        private Label PlayerCardTitle;
    }
}
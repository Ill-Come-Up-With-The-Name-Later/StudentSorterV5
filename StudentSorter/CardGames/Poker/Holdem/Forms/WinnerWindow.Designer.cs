namespace StudentSorter.CardGames.Poker.Forms
{
    partial class WinnerWindow
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
            PlayerHand = new DataGridView();
            Player2Hand = new DataGridView();
            Player3Hand = new DataGridView();
            Player4Hand = new DataGridView();
            Player1BestHandLabel = new Label();
            Player2BestHandLabel = new Label();
            Player3BestHandLabel = new Label();
            Player4BestHandLabel = new Label();
            WinnerLabel = new Label();
            ReplayButton = new Button();
            CloseButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PlayerHand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Player2Hand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Player3Hand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Player4Hand).BeginInit();
            SuspendLayout();
            // 
            // PlayerHand
            // 
            PlayerHand.AllowUserToAddRows = false;
            PlayerHand.AllowUserToDeleteRows = false;
            PlayerHand.AllowUserToResizeColumns = false;
            PlayerHand.AllowUserToResizeRows = false;
            PlayerHand.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PlayerHand.ColumnHeadersVisible = false;
            PlayerHand.Location = new Point(62, 17);
            PlayerHand.Margin = new Padding(4);
            PlayerHand.Name = "PlayerHand";
            PlayerHand.ReadOnly = true;
            PlayerHand.RowHeadersVisible = false;
            PlayerHand.RowHeadersWidth = 51;
            PlayerHand.RowTemplate.Height = 29;
            PlayerHand.Size = new Size(197, 298);
            PlayerHand.TabIndex = 11;
            // 
            // Player2Hand
            // 
            Player2Hand.AllowUserToAddRows = false;
            Player2Hand.AllowUserToDeleteRows = false;
            Player2Hand.AllowUserToResizeColumns = false;
            Player2Hand.AllowUserToResizeRows = false;
            Player2Hand.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Player2Hand.ColumnHeadersVisible = false;
            Player2Hand.Location = new Point(377, 17);
            Player2Hand.Margin = new Padding(4);
            Player2Hand.Name = "Player2Hand";
            Player2Hand.ReadOnly = true;
            Player2Hand.RowHeadersVisible = false;
            Player2Hand.RowHeadersWidth = 51;
            Player2Hand.RowTemplate.Height = 29;
            Player2Hand.Size = new Size(197, 298);
            Player2Hand.TabIndex = 12;
            // 
            // Player3Hand
            // 
            Player3Hand.AllowUserToAddRows = false;
            Player3Hand.AllowUserToDeleteRows = false;
            Player3Hand.AllowUserToResizeColumns = false;
            Player3Hand.AllowUserToResizeRows = false;
            Player3Hand.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Player3Hand.ColumnHeadersVisible = false;
            Player3Hand.Location = new Point(722, 17);
            Player3Hand.Margin = new Padding(4);
            Player3Hand.Name = "Player3Hand";
            Player3Hand.ReadOnly = true;
            Player3Hand.RowHeadersVisible = false;
            Player3Hand.RowHeadersWidth = 51;
            Player3Hand.RowTemplate.Height = 29;
            Player3Hand.Size = new Size(197, 298);
            Player3Hand.TabIndex = 13;
            // 
            // Player4Hand
            // 
            Player4Hand.AllowUserToAddRows = false;
            Player4Hand.AllowUserToDeleteRows = false;
            Player4Hand.AllowUserToResizeColumns = false;
            Player4Hand.AllowUserToResizeRows = false;
            Player4Hand.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Player4Hand.ColumnHeadersVisible = false;
            Player4Hand.Location = new Point(1046, 17);
            Player4Hand.Margin = new Padding(4);
            Player4Hand.Name = "Player4Hand";
            Player4Hand.ReadOnly = true;
            Player4Hand.RowHeadersVisible = false;
            Player4Hand.RowHeadersWidth = 51;
            Player4Hand.RowTemplate.Height = 29;
            Player4Hand.Size = new Size(197, 298);
            Player4Hand.TabIndex = 14;
            // 
            // Player1BestHandLabel
            // 
            Player1BestHandLabel.AutoSize = true;
            Player1BestHandLabel.Location = new Point(62, 333);
            Player1BestHandLabel.Name = "Player1BestHandLabel";
            Player1BestHandLabel.Size = new Size(171, 28);
            Player1BestHandLabel.TabIndex = 15;
            Player1BestHandLabel.Text = "Player's Best Hand";
            // 
            // Player2BestHandLabel
            // 
            Player2BestHandLabel.AutoSize = true;
            Player2BestHandLabel.Location = new Point(377, 333);
            Player2BestHandLabel.Name = "Player2BestHandLabel";
            Player2BestHandLabel.Size = new Size(182, 28);
            Player2BestHandLabel.TabIndex = 16;
            Player2BestHandLabel.Text = "Player2's Best Hand";
            // 
            // Player3BestHandLabel
            // 
            Player3BestHandLabel.AutoSize = true;
            Player3BestHandLabel.Location = new Point(722, 333);
            Player3BestHandLabel.Name = "Player3BestHandLabel";
            Player3BestHandLabel.Size = new Size(182, 28);
            Player3BestHandLabel.TabIndex = 17;
            Player3BestHandLabel.Text = "Player3's Best Hand";
            // 
            // Player4BestHandLabel
            // 
            Player4BestHandLabel.AutoSize = true;
            Player4BestHandLabel.Location = new Point(1046, 333);
            Player4BestHandLabel.Name = "Player4BestHandLabel";
            Player4BestHandLabel.Size = new Size(187, 28);
            Player4BestHandLabel.TabIndex = 18;
            Player4BestHandLabel.Text = "Player 4's Best Hand";
            // 
            // WinnerLabel
            // 
            WinnerLabel.AutoSize = true;
            WinnerLabel.Location = new Point(263, 437);
            WinnerLabel.Name = "WinnerLabel";
            WinnerLabel.Size = new Size(79, 28);
            WinnerLabel.TabIndex = 19;
            WinnerLabel.Text = "Winner:";
            // 
            // ReplayButton
            // 
            ReplayButton.Location = new Point(704, 422);
            ReplayButton.Name = "ReplayButton";
            ReplayButton.Size = new Size(129, 43);
            ReplayButton.TabIndex = 20;
            ReplayButton.Text = "Replay";
            ReplayButton.UseVisualStyleBackColor = true;
            ReplayButton.Click += ReplayButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(853, 423);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(95, 42);
            CloseButton.TabIndex = 21;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // WinnerWindow
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1302, 497);
            Controls.Add(CloseButton);
            Controls.Add(ReplayButton);
            Controls.Add(WinnerLabel);
            Controls.Add(Player4BestHandLabel);
            Controls.Add(Player3BestHandLabel);
            Controls.Add(Player2BestHandLabel);
            Controls.Add(Player1BestHandLabel);
            Controls.Add(Player4Hand);
            Controls.Add(Player3Hand);
            Controls.Add(Player2Hand);
            Controls.Add(PlayerHand);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "WinnerWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Poker Result";
            ((System.ComponentModel.ISupportInitialize)PlayerHand).EndInit();
            ((System.ComponentModel.ISupportInitialize)Player2Hand).EndInit();
            ((System.ComponentModel.ISupportInitialize)Player3Hand).EndInit();
            ((System.ComponentModel.ISupportInitialize)Player4Hand).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView PlayerHand;
        private DataGridView Player2Hand;
        private DataGridView Player3Hand;
        private DataGridView Player4Hand;
        private Label Player1BestHandLabel;
        private Label Player2BestHandLabel;
        private Label Player3BestHandLabel;
        private Label Player4BestHandLabel;
        private Label WinnerLabel;
        private Button ReplayButton;
        private Button CloseButton;
    }
}
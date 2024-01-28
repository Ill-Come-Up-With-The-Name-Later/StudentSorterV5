namespace StudentSorter.Gambling.BlackJack.Forms
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
            WinnerTitle = new Label();
            ReplayButton = new Button();
            CloseButton = new Button();
            DealerCardLabel = new Label();
            DealerCardList = new DataGridView();
            PlayerCardList = new DataGridView();
            PlayerCardLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)DealerCardList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayerCardList).BeginInit();
            SuspendLayout();
            // 
            // WinnerTitle
            // 
            WinnerTitle.AutoSize = true;
            WinnerTitle.Location = new Point(345, 32);
            WinnerTitle.Margin = new Padding(4, 0, 4, 0);
            WinnerTitle.Name = "WinnerTitle";
            WinnerTitle.Size = new Size(42, 28);
            WinnerTitle.TabIndex = 0;
            WinnerTitle.Text = "win";
            // 
            // ReplayButton
            // 
            ReplayButton.Location = new Point(319, 334);
            ReplayButton.Name = "ReplayButton";
            ReplayButton.Size = new Size(111, 39);
            ReplayButton.TabIndex = 1;
            ReplayButton.Text = "Replay";
            ReplayButton.UseVisualStyleBackColor = true;
            ReplayButton.Click += ReplayButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(448, 334);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(113, 39);
            CloseButton.TabIndex = 2;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // DealerCardLabel
            // 
            DealerCardLabel.AutoSize = true;
            DealerCardLabel.Location = new Point(25, 83);
            DealerCardLabel.Name = "DealerCardLabel";
            DealerCardLabel.Size = new Size(272, 28);
            DealerCardLabel.TabIndex = 3;
            DealerCardLabel.Text = "Dealer's Cards - Hand Value: 0";
            // 
            // DealerCardList
            // 
            DealerCardList.AllowUserToAddRows = false;
            DealerCardList.AllowUserToDeleteRows = false;
            DealerCardList.AllowUserToResizeColumns = false;
            DealerCardList.AllowUserToResizeRows = false;
            DealerCardList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DealerCardList.ColumnHeadersVisible = false;
            DealerCardList.Location = new Point(25, 125);
            DealerCardList.Name = "DealerCardList";
            DealerCardList.ReadOnly = true;
            DealerCardList.RowHeadersVisible = false;
            DealerCardList.RowHeadersWidth = 51;
            DealerCardList.RowTemplate.Height = 29;
            DealerCardList.Size = new Size(300, 188);
            DealerCardList.TabIndex = 4;
            // 
            // PlayerCardList
            // 
            PlayerCardList.AllowUserToAddRows = false;
            PlayerCardList.AllowUserToDeleteRows = false;
            PlayerCardList.AllowUserToResizeColumns = false;
            PlayerCardList.AllowUserToResizeRows = false;
            PlayerCardList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PlayerCardList.ColumnHeadersVisible = false;
            PlayerCardList.Location = new Point(564, 125);
            PlayerCardList.Name = "PlayerCardList";
            PlayerCardList.ReadOnly = true;
            PlayerCardList.RowHeadersVisible = false;
            PlayerCardList.RowHeadersWidth = 51;
            PlayerCardList.RowTemplate.Height = 29;
            PlayerCardList.Size = new Size(327, 188);
            PlayerCardList.TabIndex = 5;
            // 
            // PlayerCardLabel
            // 
            PlayerCardLabel.AutoSize = true;
            PlayerCardLabel.Location = new Point(564, 83);
            PlayerCardLabel.Name = "PlayerCardLabel";
            PlayerCardLabel.Size = new Size(280, 28);
            PlayerCardLabel.TabIndex = 6;
            PlayerCardLabel.Text = "Player1's Cards - Hand Value: 0";
            // 
            // WinnerWindow
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 385);
            Controls.Add(PlayerCardLabel);
            Controls.Add(PlayerCardList);
            Controls.Add(DealerCardList);
            Controls.Add(DealerCardLabel);
            Controls.Add(CloseButton);
            Controls.Add(ReplayButton);
            Controls.Add(WinnerTitle);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "WinnerWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Winner";
            ((System.ComponentModel.ISupportInitialize)DealerCardList).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlayerCardList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WinnerTitle;
        private Button ReplayButton;
        private Button CloseButton;
        private Label DealerCardLabel;
        private DataGridView DealerCardList;
        private DataGridView PlayerCardList;
        private Label PlayerCardLabel;
    }
}
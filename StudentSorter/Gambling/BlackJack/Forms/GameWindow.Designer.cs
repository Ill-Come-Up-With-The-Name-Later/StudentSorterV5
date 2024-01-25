namespace StudentSorter.Gambling.BlackJack.Forms
{
    partial class GameWindow
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
            Player1Hand = new DataGridView();
            Player2Hand = new DataGridView();
            Player1Title = new Label();
            Player2Title = new Label();
            HandValue = new Label();
            DrawCardButton = new Button();
            PassButton = new Button();
            InProgLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)Player1Hand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Player2Hand).BeginInit();
            SuspendLayout();
            // 
            // Player1Hand
            // 
            Player1Hand.AllowUserToAddRows = false;
            Player1Hand.AllowUserToDeleteRows = false;
            Player1Hand.AllowUserToResizeColumns = false;
            Player1Hand.AllowUserToResizeRows = false;
            Player1Hand.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Player1Hand.ColumnHeadersVisible = false;
            Player1Hand.Location = new Point(37, 76);
            Player1Hand.Margin = new Padding(4);
            Player1Hand.Name = "Player1Hand";
            Player1Hand.ReadOnly = true;
            Player1Hand.RowHeadersVisible = false;
            Player1Hand.RowHeadersWidth = 51;
            Player1Hand.RowTemplate.Height = 29;
            Player1Hand.Size = new Size(412, 263);
            Player1Hand.TabIndex = 0;
            // 
            // Player2Hand
            // 
            Player2Hand.AllowUserToAddRows = false;
            Player2Hand.AllowUserToDeleteRows = false;
            Player2Hand.AllowUserToResizeColumns = false;
            Player2Hand.AllowUserToResizeRows = false;
            Player2Hand.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Player2Hand.ColumnHeadersVisible = false;
            Player2Hand.Location = new Point(717, 76);
            Player2Hand.Margin = new Padding(4);
            Player2Hand.Name = "Player2Hand";
            Player2Hand.ReadOnly = true;
            Player2Hand.RowHeadersVisible = false;
            Player2Hand.RowHeadersWidth = 51;
            Player2Hand.RowTemplate.Height = 29;
            Player2Hand.Size = new Size(412, 263);
            Player2Hand.TabIndex = 1;
            // 
            // Player1Title
            // 
            Player1Title.AutoSize = true;
            Player1Title.Location = new Point(37, 29);
            Player1Title.Name = "Player1Title";
            Player1Title.Size = new Size(141, 28);
            Player1Title.TabIndex = 2;
            Player1Title.Text = "Player1's Hand";
            // 
            // Player2Title
            // 
            Player2Title.AutoSize = true;
            Player2Title.Location = new Point(717, 29);
            Player2Title.Name = "Player2Title";
            Player2Title.Size = new Size(143, 28);
            Player2Title.TabIndex = 3;
            Player2Title.Text = "Player2's Cards";
            // 
            // HandValue
            // 
            HandValue.AutoSize = true;
            HandValue.Location = new Point(318, 29);
            HandValue.Name = "HandValue";
            HandValue.Size = new Size(131, 28);
            HandValue.TabIndex = 4;
            HandValue.Text = "Hand Value: 0";
            // 
            // DrawCardButton
            // 
            DrawCardButton.Location = new Point(37, 360);
            DrawCardButton.Name = "DrawCardButton";
            DrawCardButton.Size = new Size(158, 41);
            DrawCardButton.TabIndex = 5;
            DrawCardButton.Text = "Draw Card";
            DrawCardButton.UseVisualStyleBackColor = true;
            DrawCardButton.Click += DrawCardButton_Click;
            // 
            // PassButton
            // 
            PassButton.Location = new Point(272, 360);
            PassButton.Name = "PassButton";
            PassButton.Size = new Size(177, 41);
            PassButton.TabIndex = 6;
            PassButton.Text = "Pass";
            PassButton.UseVisualStyleBackColor = true;
            PassButton.Click += PassButton_Click;
            // 
            // InProgLabel
            // 
            InProgLabel.AutoSize = true;
            InProgLabel.Location = new Point(37, 441);
            InProgLabel.Name = "InProgLabel";
            InProgLabel.Size = new Size(164, 28);
            InProgLabel.TabIndex = 7;
            InProgLabel.Text = "Game In Progress";
            // 
            // GameWindow
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 478);
            Controls.Add(InProgLabel);
            Controls.Add(PassButton);
            Controls.Add(DrawCardButton);
            Controls.Add(HandValue);
            Controls.Add(Player2Title);
            Controls.Add(Player1Title);
            Controls.Add(Player2Hand);
            Controls.Add(Player1Hand);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "GameWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game Window";
            ((System.ComponentModel.ISupportInitialize)Player1Hand).EndInit();
            ((System.ComponentModel.ISupportInitialize)Player2Hand).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Player1Hand;
        private DataGridView Player2Hand;
        private Label Player1Title;
        private Label Player2Title;
        private Label HandValue;
        private Button DrawCardButton;
        private Button PassButton;
        public Label InProgLabel;
    }
}
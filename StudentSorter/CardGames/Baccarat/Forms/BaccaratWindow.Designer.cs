namespace StudentSorter.CardGames.Baccarat.Forms
{
    partial class BaccaratWindow
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
            Player1HandValue = new Label();
            Player2HandValue = new Label();
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
            Player1Hand.Location = new Point(30, 107);
            Player1Hand.Margin = new Padding(4);
            Player1Hand.Name = "Player1Hand";
            Player1Hand.ReadOnly = true;
            Player1Hand.RowHeadersVisible = false;
            Player1Hand.RowHeadersWidth = 51;
            Player1Hand.RowTemplate.Height = 29;
            Player1Hand.Size = new Size(235, 263);
            Player1Hand.TabIndex = 1;
            // 
            // Player2Hand
            // 
            Player2Hand.AllowUserToAddRows = false;
            Player2Hand.AllowUserToDeleteRows = false;
            Player2Hand.AllowUserToResizeColumns = false;
            Player2Hand.AllowUserToResizeRows = false;
            Player2Hand.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Player2Hand.ColumnHeadersVisible = false;
            Player2Hand.Location = new Point(493, 107);
            Player2Hand.Margin = new Padding(4);
            Player2Hand.Name = "Player2Hand";
            Player2Hand.ReadOnly = true;
            Player2Hand.RowHeadersVisible = false;
            Player2Hand.RowHeadersWidth = 51;
            Player2Hand.RowTemplate.Height = 29;
            Player2Hand.Size = new Size(235, 263);
            Player2Hand.TabIndex = 2;
            // 
            // Player1Title
            // 
            Player1Title.AutoSize = true;
            Player1Title.Location = new Point(30, 62);
            Player1Title.Name = "Player1Title";
            Player1Title.Size = new Size(141, 28);
            Player1Title.TabIndex = 3;
            Player1Title.Text = "Player1's Hand";
            // 
            // Player2Title
            // 
            Player2Title.AutoSize = true;
            Player2Title.Location = new Point(493, 62);
            Player2Title.Name = "Player2Title";
            Player2Title.Size = new Size(141, 28);
            Player2Title.TabIndex = 4;
            Player2Title.Text = "Player2's Hand";
            // 
            // Player1HandValue
            // 
            Player1HandValue.AutoSize = true;
            Player1HandValue.Location = new Point(30, 384);
            Player1HandValue.Name = "Player1HandValue";
            Player1HandValue.Size = new Size(131, 28);
            Player1HandValue.TabIndex = 5;
            Player1HandValue.Text = "Hand Value: 0";
            // 
            // Player2HandValue
            // 
            Player2HandValue.AutoSize = true;
            Player2HandValue.Location = new Point(493, 384);
            Player2HandValue.Name = "Player2HandValue";
            Player2HandValue.Size = new Size(126, 28);
            Player2HandValue.TabIndex = 6;
            Player2HandValue.Text = "HandValue: 0";
            // 
            // BaccaratWindow
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 496);
            Controls.Add(Player2HandValue);
            Controls.Add(Player1HandValue);
            Controls.Add(Player2Title);
            Controls.Add(Player1Title);
            Controls.Add(Player2Hand);
            Controls.Add(Player1Hand);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "BaccaratWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Baccarat Window";
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
        private Label Player1HandValue;
        private Label Player2HandValue;
    }
}
namespace StudentSorter.CardGames.Poker.Forms
{
    partial class BetWindow
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
            Title = new Label();
            BetInput = new NumericUpDown();
            BetButton = new Button();
            ((System.ComponentModel.ISupportInitialize)BetInput).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(163, 30);
            Title.Name = "Title";
            Title.Size = new Size(140, 28);
            Title.TabIndex = 0;
            Title.Text = "Enter your bet:";
            // 
            // BetInput
            // 
            BetInput.Location = new Point(146, 103);
            BetInput.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            BetInput.Name = "BetInput";
            BetInput.Size = new Size(189, 34);
            BetInput.TabIndex = 1;
            BetInput.ThousandsSeparator = true;
            // 
            // BetButton
            // 
            BetButton.Location = new Point(163, 179);
            BetButton.Name = "BetButton";
            BetButton.Size = new Size(140, 37);
            BetButton.TabIndex = 2;
            BetButton.Text = "Submit Bet";
            BetButton.UseVisualStyleBackColor = true;
            BetButton.Click += BetButton_Click;
            // 
            // BetWindow
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 252);
            Controls.Add(BetButton);
            Controls.Add(BetInput);
            Controls.Add(Title);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "BetWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bet Window";
            ((System.ComponentModel.ISupportInitialize)BetInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private NumericUpDown BetInput;
        private Button BetButton;
    }
}
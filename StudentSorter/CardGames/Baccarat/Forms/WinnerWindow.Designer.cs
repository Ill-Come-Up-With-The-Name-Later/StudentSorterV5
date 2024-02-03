namespace StudentSorter.CardGames.Baccarat.Forms
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
            CloseButton = new Button();
            ReplayButton = new Button();
            SuspendLayout();
            // 
            // WinnerTitle
            // 
            WinnerTitle.AutoSize = true;
            WinnerTitle.Location = new Point(12, 71);
            WinnerTitle.Name = "WinnerTitle";
            WinnerTitle.Size = new Size(0, 28);
            WinnerTitle.TabIndex = 0;
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(270, 12);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(139, 43);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // ReplayButton
            // 
            ReplayButton.Location = new Point(273, 151);
            ReplayButton.Name = "ReplayButton";
            ReplayButton.Size = new Size(136, 40);
            ReplayButton.TabIndex = 2;
            ReplayButton.Text = "Replay";
            ReplayButton.UseVisualStyleBackColor = true;
            ReplayButton.Click += ReplayButton_Click;
            // 
            // WinnerWindow
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 203);
            Controls.Add(ReplayButton);
            Controls.Add(CloseButton);
            Controls.Add(WinnerTitle);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "WinnerWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Winner";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WinnerTitle;
        private Button CloseButton;
        private Button ReplayButton;
    }
}
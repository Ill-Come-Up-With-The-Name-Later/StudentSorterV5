namespace StudentSorter.CardGames.Slots.Forms
{
    partial class WinWindow
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
            WinLabel = new Label();
            CloseButton = new Button();
            ReplayButton = new Button();
            SuspendLayout();
            // 
            // WinLabel
            // 
            WinLabel.AutoSize = true;
            WinLabel.Location = new Point(140, 84);
            WinLabel.Name = "WinLabel";
            WinLabel.Size = new Size(0, 28);
            WinLabel.TabIndex = 0;
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(140, 204);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(136, 41);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // ReplayButton
            // 
            ReplayButton.Location = new Point(334, 204);
            ReplayButton.Name = "ReplayButton";
            ReplayButton.Size = new Size(121, 43);
            ReplayButton.TabIndex = 2;
            ReplayButton.Text = "Replay";
            ReplayButton.UseVisualStyleBackColor = true;
            ReplayButton.Click += ReplayButton_Click;
            // 
            // WinWindow
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 267);
            Controls.Add(ReplayButton);
            Controls.Add(CloseButton);
            Controls.Add(WinLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "WinWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Win";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WinLabel;
        private Button CloseButton;
        private Button ReplayButton;
    }
}
﻿namespace StudentSorter
{
    partial class TitleWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TitleLabel = new Label();
            OpenButton = new Button();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TitleLabel.Location = new Point(145, 31);
            TitleLabel.Margin = new Padding(4, 0, 4, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(251, 28);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Student Group Randomizer";
            // 
            // OpenButton
            // 
            OpenButton.Location = new Point(168, 107);
            OpenButton.Margin = new Padding(4);
            OpenButton.Name = "OpenButton";
            OpenButton.Size = new Size(181, 42);
            OpenButton.TabIndex = 1;
            OpenButton.Text = "Open";
            OpenButton.UseVisualStyleBackColor = true;
            OpenButton.Click += OpenButton_Click;
            // 
            // TitleWindow
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 219);
            Controls.Add(OpenButton);
            Controls.Add(TitleLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "TitleWindow";
            Text = "Random Group Creator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private Button OpenButton;
    }
}
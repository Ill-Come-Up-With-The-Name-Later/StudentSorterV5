namespace StudentSorter.Debug
{
    partial class DebugWindow
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
            DebugLog = new RichTextBox();
            CloseButton = new Button();
            SuspendLayout();
            // 
            // DebugLog
            // 
            DebugLog.Location = new Point(16, 17);
            DebugLog.Margin = new Padding(4);
            DebugLog.Name = "DebugLog";
            DebugLog.ReadOnly = true;
            DebugLog.Size = new Size(1145, 656);
            DebugLog.TabIndex = 0;
            DebugLog.Text = "";
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(517, 700);
            CloseButton.Margin = new Padding(4);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(197, 41);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "Close Debugger";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // DebugWindow
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 767);
            Controls.Add(CloseButton);
            Controls.Add(DebugLog);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "DebugWindow";
            Text = "Debug Window";
            ResumeLayout(false);
        }

        #endregion

        public RichTextBox DebugLog;
        private Button CloseButton;
    }
}
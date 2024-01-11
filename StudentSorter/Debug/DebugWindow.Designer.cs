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
            SuspendLayout();
            // 
            // DebugLog
            // 
            DebugLog.Location = new Point(25, 12);
            DebugLog.Name = "DebugLog";
            DebugLog.ReadOnly = true;
            DebugLog.Size = new Size(763, 426);
            DebugLog.TabIndex = 0;
            DebugLog.Text = "";
            // 
            // DebugWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DebugLog);
            Name = "DebugWindow";
            Text = "Debug Window";
            ResumeLayout(false);
        }

        #endregion

        public RichTextBox DebugLog;
    }
}
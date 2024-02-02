namespace StudentSorter.CardGames.Slots
{
    partial class SlotsWindow
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
            components = new System.ComponentModel.Container();
            Title = new Label();
            Subtitle = new Label();
            SlotMachineTimer = new System.Windows.Forms.Timer(components);
            Symbol1 = new TextBox();
            Symbol2 = new TextBox();
            Symbol3 = new TextBox();
            SymbolTitle = new Label();
            Symbol2Title = new Label();
            Symbol3Title = new Label();
            SpinButton = new Button();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(231, 9);
            Title.Name = "Title";
            Title.Size = new Size(109, 28);
            Title.TabIndex = 0;
            Title.Text = "Lucky Slots";
            // 
            // Subtitle
            // 
            Subtitle.AutoSize = true;
            Subtitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Subtitle.Location = new Point(12, 54);
            Subtitle.Name = "Subtitle";
            Subtitle.Size = new Size(588, 23);
            Subtitle.TabIndex = 1;
            Subtitle.Text = "Spin to win: Match three symbols to win. Match three 'α' to win the Jackpot.";
            // 
            // SlotMachineTimer
            // 
            SlotMachineTimer.Enabled = true;
            SlotMachineTimer.Interval = 45;
            SlotMachineTimer.Tick += SlotMachineTimer_Tick;
            // 
            // Symbol1
            // 
            Symbol1.Enabled = false;
            Symbol1.Location = new Point(51, 160);
            Symbol1.Name = "Symbol1";
            Symbol1.ReadOnly = true;
            Symbol1.Size = new Size(67, 34);
            Symbol1.TabIndex = 2;
            // 
            // Symbol2
            // 
            Symbol2.Enabled = false;
            Symbol2.Location = new Point(262, 160);
            Symbol2.Name = "Symbol2";
            Symbol2.ReadOnly = true;
            Symbol2.Size = new Size(67, 34);
            Symbol2.TabIndex = 3;
            // 
            // Symbol3
            // 
            Symbol3.Enabled = false;
            Symbol3.Location = new Point(474, 160);
            Symbol3.Name = "Symbol3";
            Symbol3.ReadOnly = true;
            Symbol3.Size = new Size(67, 34);
            Symbol3.TabIndex = 4;
            // 
            // SymbolTitle
            // 
            SymbolTitle.AutoSize = true;
            SymbolTitle.Location = new Point(71, 207);
            SymbolTitle.Name = "SymbolTitle";
            SymbolTitle.Size = new Size(26, 28);
            SymbolTitle.TabIndex = 5;
            SymbolTitle.Text = "^";
            // 
            // Symbol2Title
            // 
            Symbol2Title.AutoSize = true;
            Symbol2Title.Location = new Point(281, 207);
            Symbol2Title.Name = "Symbol2Title";
            Symbol2Title.Size = new Size(26, 28);
            Symbol2Title.TabIndex = 6;
            Symbol2Title.Text = "^";
            // 
            // Symbol3Title
            // 
            Symbol3Title.AutoSize = true;
            Symbol3Title.Location = new Point(493, 207);
            Symbol3Title.Name = "Symbol3Title";
            Symbol3Title.Size = new Size(26, 28);
            Symbol3Title.TabIndex = 7;
            Symbol3Title.Text = "^";
            // 
            // SpinButton
            // 
            SpinButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SpinButton.ForeColor = Color.Lime;
            SpinButton.Location = new Point(242, 291);
            SpinButton.Name = "SpinButton";
            SpinButton.Size = new Size(111, 43);
            SpinButton.TabIndex = 8;
            SpinButton.Text = "Spin";
            SpinButton.UseVisualStyleBackColor = true;
            SpinButton.Click += SpinButton_Click;
            // 
            // SlotsWindow
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 346);
            Controls.Add(SpinButton);
            Controls.Add(Symbol3Title);
            Controls.Add(Symbol2Title);
            Controls.Add(SymbolTitle);
            Controls.Add(Symbol3);
            Controls.Add(Symbol2);
            Controls.Add(Symbol1);
            Controls.Add(Subtitle);
            Controls.Add(Title);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "SlotsWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "(Lucky) Slots";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label Subtitle;
        private System.Windows.Forms.Timer SlotMachineTimer;
        private TextBox Symbol1;
        private TextBox Symbol2;
        private TextBox Symbol3;
        private Label SymbolTitle;
        private Label Symbol2Title;
        private Label Symbol3Title;
        private Button SpinButton;
    }
}
namespace StudentSorter.CardGames.Keno.Forms
{
    partial class KenoWindow
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
            AmountOfNumsToBet = new Label();
            NumberAmountInput = new NumericUpDown();
            EnterNumbersInstruction = new Label();
            SetAmountOfNumsButton = new Button();
            ChosenNumInput = new NumericUpDown();
            BetNumButton = new Button();
            PlayerNumbers = new DataGridView();
            PlayerNumsLabel = new Label();
            DrawButton = new Button();
            ErrorProvider = new ErrorProvider(components);
            DrawnNumbers = new DataGridView();
            DrawnTitle = new Label();
            MatchLabel = new Label();
            CloseButton = new Button();
            ReplayButton = new Button();
            ((System.ComponentModel.ISupportInitialize)NumberAmountInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChosenNumInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayerNumbers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DrawnNumbers).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(352, 19);
            Title.Name = "Title";
            Title.Size = new Size(57, 28);
            Title.TabIndex = 0;
            Title.Text = "Keno";
            // 
            // AmountOfNumsToBet
            // 
            AmountOfNumsToBet.AutoSize = true;
            AmountOfNumsToBet.Location = new Point(12, 62);
            AmountOfNumsToBet.Name = "AmountOfNumsToBet";
            AmountOfNumsToBet.Size = new Size(331, 28);
            AmountOfNumsToBet.TabIndex = 1;
            AmountOfNumsToBet.Text = "Amount of Number to bet on: (1-10)";
            // 
            // NumberAmountInput
            // 
            NumberAmountInput.Location = new Point(12, 93);
            NumberAmountInput.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            NumberAmountInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumberAmountInput.Name = "NumberAmountInput";
            NumberAmountInput.Size = new Size(150, 34);
            NumberAmountInput.TabIndex = 2;
            NumberAmountInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // EnterNumbersInstruction
            // 
            EnterNumbersInstruction.AutoSize = true;
            EnterNumbersInstruction.Location = new Point(12, 218);
            EnterNumbersInstruction.Name = "EnterNumbersInstruction";
            EnterNumbersInstruction.Size = new Size(364, 28);
            EnterNumbersInstruction.TabIndex = 3;
            EnterNumbersInstruction.Text = "Enter your numbers one at a time: (1-80)";
            // 
            // SetAmountOfNumsButton
            // 
            SetAmountOfNumsButton.Location = new Point(12, 142);
            SetAmountOfNumsButton.Name = "SetAmountOfNumsButton";
            SetAmountOfNumsButton.Size = new Size(134, 37);
            SetAmountOfNumsButton.TabIndex = 4;
            SetAmountOfNumsButton.Text = "Confirm";
            SetAmountOfNumsButton.UseVisualStyleBackColor = true;
            SetAmountOfNumsButton.Click += SetAmountOfNumsButton_Click;
            // 
            // ChosenNumInput
            // 
            ChosenNumInput.Enabled = false;
            ChosenNumInput.Location = new Point(12, 249);
            ChosenNumInput.Maximum = new decimal(new int[] { 80, 0, 0, 0 });
            ChosenNumInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ChosenNumInput.Name = "ChosenNumInput";
            ChosenNumInput.Size = new Size(150, 34);
            ChosenNumInput.TabIndex = 5;
            ChosenNumInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // BetNumButton
            // 
            BetNumButton.Enabled = false;
            BetNumButton.Location = new Point(12, 299);
            BetNumButton.Name = "BetNumButton";
            BetNumButton.Size = new Size(212, 40);
            BetNumButton.TabIndex = 6;
            BetNumButton.Text = "Bet on This Number";
            BetNumButton.UseVisualStyleBackColor = true;
            BetNumButton.Click += BetNumButton_Click;
            // 
            // PlayerNumbers
            // 
            PlayerNumbers.AllowUserToAddRows = false;
            PlayerNumbers.AllowUserToDeleteRows = false;
            PlayerNumbers.AllowUserToResizeColumns = false;
            PlayerNumbers.AllowUserToResizeRows = false;
            PlayerNumbers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PlayerNumbers.ColumnHeadersVisible = false;
            PlayerNumbers.Location = new Point(305, 330);
            PlayerNumbers.Name = "PlayerNumbers";
            PlayerNumbers.ReadOnly = true;
            PlayerNumbers.RowHeadersVisible = false;
            PlayerNumbers.RowHeadersWidth = 51;
            PlayerNumbers.RowTemplate.Height = 29;
            PlayerNumbers.Size = new Size(166, 161);
            PlayerNumbers.TabIndex = 12;
            // 
            // PlayerNumsLabel
            // 
            PlayerNumsLabel.AutoSize = true;
            PlayerNumsLabel.Location = new Point(305, 299);
            PlayerNumsLabel.Name = "PlayerNumsLabel";
            PlayerNumsLabel.Size = new Size(136, 28);
            PlayerNumsLabel.TabIndex = 13;
            PlayerNumsLabel.Text = "Your Numbers";
            // 
            // DrawButton
            // 
            DrawButton.Enabled = false;
            DrawButton.Location = new Point(12, 459);
            DrawButton.Name = "DrawButton";
            DrawButton.Size = new Size(257, 42);
            DrawButton.TabIndex = 14;
            DrawButton.Text = "Draw Winning Numbers";
            DrawButton.UseVisualStyleBackColor = true;
            DrawButton.Click += DrawButton_Click;
            // 
            // ErrorProvider
            // 
            ErrorProvider.ContainerControl = this;
            // 
            // DrawnNumbers
            // 
            DrawnNumbers.AllowUserToAddRows = false;
            DrawnNumbers.AllowUserToDeleteRows = false;
            DrawnNumbers.AllowUserToResizeColumns = false;
            DrawnNumbers.AllowUserToResizeRows = false;
            DrawnNumbers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DrawnNumbers.ColumnHeadersVisible = false;
            DrawnNumbers.Location = new Point(608, 330);
            DrawnNumbers.Name = "DrawnNumbers";
            DrawnNumbers.ReadOnly = true;
            DrawnNumbers.RowHeadersVisible = false;
            DrawnNumbers.RowHeadersWidth = 51;
            DrawnNumbers.RowTemplate.Height = 29;
            DrawnNumbers.Size = new Size(166, 161);
            DrawnNumbers.TabIndex = 15;
            // 
            // DrawnTitle
            // 
            DrawnTitle.AutoSize = true;
            DrawnTitle.Location = new Point(608, 299);
            DrawnTitle.Name = "DrawnTitle";
            DrawnTitle.Size = new Size(153, 28);
            DrawnTitle.TabIndex = 16;
            DrawnTitle.Text = "Drawn Numbers";
            // 
            // MatchLabel
            // 
            MatchLabel.AutoSize = true;
            MatchLabel.Location = new Point(608, 271);
            MatchLabel.Name = "MatchLabel";
            MatchLabel.Size = new Size(108, 28);
            MatchLabel.TabIndex = 17;
            MatchLabel.Text = "Match: X/X";
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(565, 536);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(130, 38);
            CloseButton.TabIndex = 18;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // ReplayButton
            // 
            ReplayButton.Location = new Point(723, 537);
            ReplayButton.Name = "ReplayButton";
            ReplayButton.Size = new Size(107, 37);
            ReplayButton.TabIndex = 19;
            ReplayButton.Text = "Replay";
            ReplayButton.UseVisualStyleBackColor = true;
            ReplayButton.Click += ReplayButton_Click;
            // 
            // KenoWindow
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 586);
            Controls.Add(ReplayButton);
            Controls.Add(CloseButton);
            Controls.Add(MatchLabel);
            Controls.Add(DrawnTitle);
            Controls.Add(DrawnNumbers);
            Controls.Add(DrawButton);
            Controls.Add(PlayerNumsLabel);
            Controls.Add(PlayerNumbers);
            Controls.Add(BetNumButton);
            Controls.Add(ChosenNumInput);
            Controls.Add(SetAmountOfNumsButton);
            Controls.Add(EnterNumbersInstruction);
            Controls.Add(NumberAmountInput);
            Controls.Add(AmountOfNumsToBet);
            Controls.Add(Title);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "KenoWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Keno";
            ((System.ComponentModel.ISupportInitialize)NumberAmountInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChosenNumInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlayerNumbers).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)DrawnNumbers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label AmountOfNumsToBet;
        private NumericUpDown NumberAmountInput;
        private Label EnterNumbersInstruction;
        private Button SetAmountOfNumsButton;
        private NumericUpDown ChosenNumInput;
        private Button BetNumButton;
        private DataGridView PlayerNumbers;
        private Label PlayerNumsLabel;
        private Button DrawButton;
        private ErrorProvider ErrorProvider;
        private Label DrawnTitle;
        private DataGridView DrawnNumbers;
        private Label MatchLabel;
        private Button ReplayButton;
        private Button CloseButton;
    }
}
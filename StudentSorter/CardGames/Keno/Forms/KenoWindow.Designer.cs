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
            label1 = new Label();
            SetAmountOfNumsButton = new Button();
            ChosenNumInput = new NumericUpDown();
            BetNumButton = new Button();
            PlayerNumbers = new DataGridView();
            PlayerNumsLabel = new Label();
            DrawButton = new Button();
            ErrorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)NumberAmountInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChosenNumInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayerNumbers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).BeginInit();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 218);
            label1.Name = "label1";
            label1.Size = new Size(364, 28);
            label1.TabIndex = 3;
            label1.Text = "Enter your numbers one at a time: (1-80)";
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
            PlayerNumbers.Location = new Point(275, 330);
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
            PlayerNumsLabel.Location = new Point(294, 299);
            PlayerNumsLabel.Name = "PlayerNumsLabel";
            PlayerNumsLabel.Size = new Size(136, 28);
            PlayerNumsLabel.TabIndex = 13;
            PlayerNumsLabel.Text = "Your Numbers";
            // 
            // DrawButton
            // 
            DrawButton.Location = new Point(12, 459);
            DrawButton.Name = "DrawButton";
            DrawButton.Size = new Size(257, 42);
            DrawButton.TabIndex = 14;
            DrawButton.Text = "Draw Winning Numbers";
            DrawButton.UseVisualStyleBackColor = true;
            // 
            // ErrorProvider
            // 
            ErrorProvider.ContainerControl = this;
            // 
            // KenoWindow
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 532);
            Controls.Add(DrawButton);
            Controls.Add(PlayerNumsLabel);
            Controls.Add(PlayerNumbers);
            Controls.Add(BetNumButton);
            Controls.Add(ChosenNumInput);
            Controls.Add(SetAmountOfNumsButton);
            Controls.Add(label1);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label AmountOfNumsToBet;
        private NumericUpDown NumberAmountInput;
        private Label label1;
        private Button SetAmountOfNumsButton;
        private NumericUpDown ChosenNumInput;
        private Button BetNumButton;
        private DataGridView PlayerNumbers;
        private Label PlayerNumsLabel;
        private Button DrawButton;
        private ErrorProvider ErrorProvider;
    }
}
namespace StudentSorter.CardGames.Poker.FiveCardDraw.Forms
{
    partial class FiveCardDrawWindow
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
            PlayerCards = new DataGridView();
            Title = new Label();
            PlayerHandTitle = new Label();
            OtherPlayerTitle = new Label();
            PlayerList = new DataGridView();
            DiscardButton = new Button();
            PassButton = new Button();
            FoldButton = new Button();
            DoneButton = new Button();
            Instructions = new Label();
            ShowdownButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PlayerCards).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayerList).BeginInit();
            SuspendLayout();
            // 
            // PlayerCards
            // 
            PlayerCards.AllowUserToAddRows = false;
            PlayerCards.AllowUserToDeleteRows = false;
            PlayerCards.AllowUserToResizeColumns = false;
            PlayerCards.AllowUserToResizeRows = false;
            PlayerCards.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PlayerCards.ColumnHeadersVisible = false;
            PlayerCards.Location = new Point(23, 92);
            PlayerCards.Name = "PlayerCards";
            PlayerCards.ReadOnly = true;
            PlayerCards.RowHeadersVisible = false;
            PlayerCards.RowHeadersWidth = 51;
            PlayerCards.RowTemplate.Height = 29;
            PlayerCards.Size = new Size(166, 213);
            PlayerCards.TabIndex = 11;
            PlayerCards.CellDoubleClick += PlayerCards_CellDoubleClick;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(201, 19);
            Title.Name = "Title";
            Title.Size = new Size(122, 28);
            Title.TabIndex = 12;
            Title.Text = "5-Card Draw";
            // 
            // PlayerHandTitle
            // 
            PlayerHandTitle.AutoSize = true;
            PlayerHandTitle.Location = new Point(23, 58);
            PlayerHandTitle.Name = "PlayerHandTitle";
            PlayerHandTitle.Size = new Size(103, 28);
            PlayerHandTitle.TabIndex = 13;
            PlayerHandTitle.Text = "Your Hand";
            // 
            // OtherPlayerTitle
            // 
            OtherPlayerTitle.AutoSize = true;
            OtherPlayerTitle.Location = new Point(308, 58);
            OtherPlayerTitle.Name = "OtherPlayerTitle";
            OtherPlayerTitle.Size = new Size(128, 28);
            OtherPlayerTitle.TabIndex = 15;
            OtherPlayerTitle.Text = "Other Players";
            // 
            // PlayerList
            // 
            PlayerList.AllowUserToAddRows = false;
            PlayerList.AllowUserToDeleteRows = false;
            PlayerList.AllowUserToResizeColumns = false;
            PlayerList.AllowUserToResizeRows = false;
            PlayerList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PlayerList.ColumnHeadersVisible = false;
            PlayerList.Location = new Point(308, 92);
            PlayerList.Name = "PlayerList";
            PlayerList.ReadOnly = true;
            PlayerList.RowHeadersVisible = false;
            PlayerList.RowHeadersWidth = 51;
            PlayerList.RowTemplate.Height = 29;
            PlayerList.Size = new Size(218, 144);
            PlayerList.TabIndex = 16;
            // 
            // DiscardButton
            // 
            DiscardButton.Location = new Point(23, 347);
            DiscardButton.Name = "DiscardButton";
            DiscardButton.Size = new Size(199, 45);
            DiscardButton.TabIndex = 17;
            DiscardButton.Text = "Discard Cards";
            DiscardButton.UseVisualStyleBackColor = true;
            DiscardButton.Click += DiscardButton_Click;
            // 
            // PassButton
            // 
            PassButton.Location = new Point(254, 347);
            PassButton.Name = "PassButton";
            PassButton.Size = new Size(139, 45);
            PassButton.TabIndex = 18;
            PassButton.Text = "Stand";
            PassButton.UseVisualStyleBackColor = true;
            PassButton.Click += PassButton_Click;
            // 
            // FoldButton
            // 
            FoldButton.Location = new Point(409, 347);
            FoldButton.Name = "FoldButton";
            FoldButton.Size = new Size(134, 45);
            FoldButton.TabIndex = 19;
            FoldButton.Text = "Fold";
            FoldButton.UseVisualStyleBackColor = true;
            FoldButton.Click += FoldButton_Click;
            // 
            // DoneButton
            // 
            DoneButton.Enabled = false;
            DoneButton.Location = new Point(23, 398);
            DoneButton.Name = "DoneButton";
            DoneButton.Size = new Size(199, 45);
            DoneButton.TabIndex = 20;
            DoneButton.Text = "Finish Discarding";
            DoneButton.UseVisualStyleBackColor = true;
            DoneButton.Click += DoneButton_Click;
            // 
            // Instructions
            // 
            Instructions.AutoSize = true;
            Instructions.Location = new Point(206, 277);
            Instructions.Name = "Instructions";
            Instructions.Size = new Size(320, 28);
            Instructions.TabIndex = 21;
            Instructions.Text = "Double-Click on a card to discard it";
            Instructions.Visible = false;
            // 
            // ShowdownButton
            // 
            ShowdownButton.Enabled = false;
            ShowdownButton.Location = new Point(264, 398);
            ShowdownButton.Name = "ShowdownButton";
            ShowdownButton.Size = new Size(156, 45);
            ShowdownButton.TabIndex = 22;
            ShowdownButton.Text = "Showdown";
            ShowdownButton.UseVisualStyleBackColor = true;
            ShowdownButton.Click += ShowdownButton_Click;
            // 
            // FiveCardDrawWindow
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 462);
            Controls.Add(ShowdownButton);
            Controls.Add(Instructions);
            Controls.Add(DoneButton);
            Controls.Add(FoldButton);
            Controls.Add(PassButton);
            Controls.Add(DiscardButton);
            Controls.Add(PlayerList);
            Controls.Add(OtherPlayerTitle);
            Controls.Add(PlayerHandTitle);
            Controls.Add(Title);
            Controls.Add(PlayerCards);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FiveCardDrawWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Five-Card Draw";
            ((System.ComponentModel.ISupportInitialize)PlayerCards).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlayerList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView PlayerCards;
        private Label Title;
        private Label PlayerHandTitle;
        private Label OtherPlayerTitle;
        private DataGridView PlayerList;
        private Button DiscardButton;
        private Button PassButton;
        private Button FoldButton;
        private Button DoneButton;
        private Label Instructions;
        private Button ShowdownButton;
    }
}
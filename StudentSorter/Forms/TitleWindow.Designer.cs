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
            components = new System.ComponentModel.Container();
            TitleLabel = new Label();
            OpenButton = new Button();
            ConfigSortButton = new Button();
            OpenConfig = new OpenFileDialog();
            CreateConfigButton = new Button();
            UserManualLink = new LinkLabel();
            VersionLabel = new Label();
            OpenDebugButton = new Button();
            BlackJackLabel = new Label();
            BlackjackButton = new Button();
            SecretPassInput = new TextBox();
            ErrorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TitleLabel.Location = new Point(144, 38);
            TitleLabel.Margin = new Padding(4, 0, 4, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(251, 28);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Student Group Randomizer";
            // 
            // OpenButton
            // 
            OpenButton.Location = new Point(114, 106);
            OpenButton.Margin = new Padding(4);
            OpenButton.Name = "OpenButton";
            OpenButton.Size = new Size(307, 43);
            OpenButton.TabIndex = 1;
            OpenButton.Text = "Open";
            OpenButton.UseVisualStyleBackColor = true;
            OpenButton.Click += OpenButton_Click;
            // 
            // ConfigSortButton
            // 
            ConfigSortButton.Location = new Point(114, 204);
            ConfigSortButton.Name = "ConfigSortButton";
            ConfigSortButton.Size = new Size(307, 43);
            ConfigSortButton.TabIndex = 2;
            ConfigSortButton.Text = "Shuffle Using a Configuration";
            ConfigSortButton.UseVisualStyleBackColor = true;
            ConfigSortButton.Click += ConfigSortButton_Click;
            // 
            // OpenConfig
            // 
            OpenConfig.DefaultExt = "json";
            OpenConfig.Filter = "JSON files|*.json";
            OpenConfig.Title = "Open JSON of configuration";
            OpenConfig.FileOk += OpenConfig_FileOk;
            // 
            // CreateConfigButton
            // 
            CreateConfigButton.Location = new Point(114, 156);
            CreateConfigButton.Name = "CreateConfigButton";
            CreateConfigButton.Size = new Size(307, 42);
            CreateConfigButton.TabIndex = 3;
            CreateConfigButton.Text = "Create New Configuration";
            CreateConfigButton.UseVisualStyleBackColor = true;
            CreateConfigButton.Click += CreateConfigButton_Click;
            // 
            // UserManualLink
            // 
            UserManualLink.AutoSize = true;
            UserManualLink.Location = new Point(196, 276);
            UserManualLink.Name = "UserManualLink";
            UserManualLink.Size = new Size(121, 28);
            UserManualLink.TabIndex = 4;
            UserManualLink.TabStop = true;
            UserManualLink.Text = "User Manual";
            UserManualLink.LinkClicked += UserManualLink_LinkClicked;
            // 
            // VersionLabel
            // 
            VersionLabel.AutoSize = true;
            VersionLabel.Location = new Point(12, 346);
            VersionLabel.Name = "VersionLabel";
            VersionLabel.Size = new Size(85, 28);
            VersionLabel.TabIndex = 5;
            VersionLabel.Text = "Version: ";
            // 
            // OpenDebugButton
            // 
            OpenDebugButton.Location = new Point(311, 341);
            OpenDebugButton.Name = "OpenDebugButton";
            OpenDebugButton.Size = new Size(226, 39);
            OpenDebugButton.TabIndex = 6;
            OpenDebugButton.Text = "Open Debug Window";
            OpenDebugButton.UseVisualStyleBackColor = true;
            OpenDebugButton.Click += OpenDebugButton_Click;
            // 
            // BlackJackLabel
            // 
            BlackJackLabel.AutoSize = true;
            BlackJackLabel.Location = new Point(12, 416);
            BlackJackLabel.Name = "BlackJackLabel";
            BlackJackLabel.Size = new Size(69, 28);
            BlackJackLabel.TabIndex = 7;
            BlackJackLabel.Text = "Bonus:";
            // 
            // BlackjackButton
            // 
            BlackjackButton.Location = new Point(382, 409);
            BlackjackButton.Name = "BlackjackButton";
            BlackjackButton.Size = new Size(141, 43);
            BlackjackButton.TabIndex = 8;
            BlackjackButton.Text = "???";
            BlackjackButton.UseVisualStyleBackColor = true;
            BlackjackButton.Click += BlackjackButton_Click;
            // 
            // SecretPassInput
            // 
            SecretPassInput.Location = new Point(87, 413);
            SecretPassInput.Name = "SecretPassInput";
            SecretPassInput.PasswordChar = '*';
            SecretPassInput.PlaceholderText = "Enter the secret code.";
            SecretPassInput.Size = new Size(230, 34);
            SecretPassInput.TabIndex = 9;
            // 
            // ErrorProvider
            // 
            ErrorProvider.ContainerControl = this;
            // 
            // TitleWindow
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(549, 457);
            Controls.Add(SecretPassInput);
            Controls.Add(BlackjackButton);
            Controls.Add(BlackJackLabel);
            Controls.Add(OpenDebugButton);
            Controls.Add(VersionLabel);
            Controls.Add(UserManualLink);
            Controls.Add(CreateConfigButton);
            Controls.Add(ConfigSortButton);
            Controls.Add(OpenButton);
            Controls.Add(TitleLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "TitleWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Random Group Creator";
            Load += TitleWindow_Load;
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private Button OpenButton;
        private Button ConfigSortButton;
        private OpenFileDialog OpenConfig;
        private Button CreateConfigButton;
        private LinkLabel UserManualLink;
        private Label VersionLabel;
        private Button OpenDebugButton;
        private Label BlackJackLabel;
        private Button BlackjackButton;
        private TextBox SecretPassInput;
        private ErrorProvider ErrorProvider;
    }
}
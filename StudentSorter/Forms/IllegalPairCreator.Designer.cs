namespace StudentSorter
{
    partial class IllegalPairCreator
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
            SelectStudent1 = new ComboBox();
            SelectStudent2 = new ComboBox();
            Title = new Label();
            Student1Label = new Label();
            Student2Label = new Label();
            AddPairButton = new Button();
            ErrorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // SelectStudent1
            // 
            SelectStudent1.FormattingEnabled = true;
            SelectStudent1.Location = new Point(12, 112);
            SelectStudent1.Name = "SelectStudent1";
            SelectStudent1.Size = new Size(272, 36);
            SelectStudent1.TabIndex = 0;
            SelectStudent1.SelectedIndexChanged += SelectStudent1_SelectedIndexChanged;
            // 
            // SelectStudent2
            // 
            SelectStudent2.FormattingEnabled = true;
            SelectStudent2.Location = new Point(12, 260);
            SelectStudent2.Name = "SelectStudent2";
            SelectStudent2.Size = new Size(273, 36);
            SelectStudent2.TabIndex = 1;
            SelectStudent2.SelectedIndexChanged += SelectStudent2_SelectedIndexChanged;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(133, 20);
            Title.Name = "Title";
            Title.Size = new Size(191, 28);
            Title.TabIndex = 2;
            Title.Text = "Add Disallowedl Pair";
            // 
            // Student1Label
            // 
            Student1Label.AutoSize = true;
            Student1Label.Location = new Point(12, 71);
            Student1Label.Name = "Student1Label";
            Student1Label.Size = new Size(96, 28);
            Student1Label.TabIndex = 3;
            Student1Label.Text = "Student 1";
            // 
            // Student2Label
            // 
            Student2Label.AutoSize = true;
            Student2Label.Location = new Point(12, 219);
            Student2Label.Name = "Student2Label";
            Student2Label.Size = new Size(96, 28);
            Student2Label.TabIndex = 4;
            Student2Label.Text = "Student 2";
            // 
            // AddPairButton
            // 
            AddPairButton.Location = new Point(157, 347);
            AddPairButton.Name = "AddPairButton";
            AddPairButton.Size = new Size(143, 48);
            AddPairButton.TabIndex = 5;
            AddPairButton.Text = "Add Pair";
            AddPairButton.UseVisualStyleBackColor = true;
            AddPairButton.Click += AddPairButton_Click;
            // 
            // ErrorProvider
            // 
            ErrorProvider.ContainerControl = this;
            // 
            // IllegalPairCreator
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(450, 430);
            Controls.Add(AddPairButton);
            Controls.Add(Student2Label);
            Controls.Add(Student1Label);
            Controls.Add(Title);
            Controls.Add(SelectStudent2);
            Controls.Add(SelectStudent1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "IllegalPairCreator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Disallowedl Pair Creator";
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox SelectStudent1;
        private ComboBox SelectStudent2;
        private Label Title;
        private Label Student1Label;
        private Label Student2Label;
        private Button AddPairButton;
        private ErrorProvider ErrorProvider;
    }
}
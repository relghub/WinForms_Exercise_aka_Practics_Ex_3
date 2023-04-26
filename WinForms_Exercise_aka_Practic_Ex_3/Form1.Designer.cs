namespace WinForms_Exercise_aka_Practic_Ex_3
{
    partial class Form1
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
            BronzeMedalCountBox = new TextBox();
            SilverMedalCountBox = new TextBox();
            CountryBox = new TextBox();
            GoldMedalCountBox = new TextBox();
            ContestCountBox = new TextBox();
            SubmitButton = new Button();
            ResultBox = new TextBox();
            groupBox1 = new GroupBox();
            BronzeMedalCountLabel = new Label();
            SilverMedalCountLabel = new Label();
            GoldMedalsCountLabel = new Label();
            ContestantsCountLabel = new Label();
            CountryLabel = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // BronzeMedalCountBox
            // 
            BronzeMedalCountBox.Location = new Point(157, 161);
            BronzeMedalCountBox.Name = "BronzeMedalCountBox";
            BronzeMedalCountBox.Size = new Size(53, 23);
            BronzeMedalCountBox.TabIndex = 0;
            // 
            // SilverMedalCountBox
            // 
            SilverMedalCountBox.Location = new Point(157, 132);
            SilverMedalCountBox.Name = "SilverMedalCountBox";
            SilverMedalCountBox.Size = new Size(53, 23);
            SilverMedalCountBox.TabIndex = 1;
            // 
            // CountryBox
            // 
            CountryBox.Location = new Point(6, 45);
            CountryBox.Name = "CountryBox";
            CountryBox.Size = new Size(204, 23);
            CountryBox.TabIndex = 2;
            // 
            // GoldMedalCountBox
            // 
            GoldMedalCountBox.Location = new Point(157, 103);
            GoldMedalCountBox.Name = "GoldMedalCountBox";
            GoldMedalCountBox.Size = new Size(53, 23);
            GoldMedalCountBox.TabIndex = 3;
            // 
            // ContestCountBox
            // 
            ContestCountBox.Location = new Point(157, 74);
            ContestCountBox.Name = "ContestCountBox";
            ContestCountBox.Size = new Size(53, 23);
            ContestCountBox.TabIndex = 4;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(133, 198);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(100, 23);
            SubmitButton.TabIndex = 5;
            SubmitButton.Text = "Додати";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // ResultBox
            // 
            ResultBox.Location = new Point(239, 16);
            ResultBox.Multiline = true;
            ResultBox.Name = "ResultBox";
            ResultBox.ReadOnly = true;
            ResultBox.Size = new Size(373, 168);
            ResultBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BronzeMedalCountLabel);
            groupBox1.Controls.Add(SilverMedalCountLabel);
            groupBox1.Controls.Add(GoldMedalsCountLabel);
            groupBox1.Controls.Add(ContestantsCountLabel);
            groupBox1.Controls.Add(CountryLabel);
            groupBox1.Controls.Add(ContestCountBox);
            groupBox1.Controls.Add(BronzeMedalCountBox);
            groupBox1.Controls.Add(SilverMedalCountBox);
            groupBox1.Controls.Add(GoldMedalCountBox);
            groupBox1.Controls.Add(CountryBox);
            groupBox1.Location = new Point(6, -1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(227, 193);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Інформація";
            // 
            // BronzeMedalCountLabel
            // 
            BronzeMedalCountLabel.AutoSize = true;
            BronzeMedalCountLabel.Location = new Point(55, 164);
            BronzeMedalCountLabel.Name = "BronzeMedalCountLabel";
            BronzeMedalCountLabel.Size = new Size(96, 15);
            BronzeMedalCountLabel.TabIndex = 9;
            BronzeMedalCountLabel.Text = "Бронзові медалі";
            // 
            // SilverMedalCountLabel
            // 
            SilverMedalCountLabel.AutoSize = true;
            SilverMedalCountLabel.Location = new Point(69, 135);
            SilverMedalCountLabel.Name = "SilverMedalCountLabel";
            SilverMedalCountLabel.Size = new Size(82, 15);
            SilverMedalCountLabel.TabIndex = 8;
            SilverMedalCountLabel.Text = "Срібні медалі";
            // 
            // GoldMedalsCountLabel
            // 
            GoldMedalsCountLabel.AutoSize = true;
            GoldMedalsCountLabel.Location = new Point(68, 106);
            GoldMedalsCountLabel.Name = "GoldMedalsCountLabel";
            GoldMedalsCountLabel.Size = new Size(83, 15);
            GoldMedalsCountLabel.TabIndex = 7;
            GoldMedalsCountLabel.Text = "Золоті медалі";
            // 
            // ContestantsCountLabel
            // 
            ContestantsCountLabel.AutoSize = true;
            ContestantsCountLabel.Location = new Point(38, 77);
            ContestantsCountLabel.Name = "ContestantsCountLabel";
            ContestantsCountLabel.Size = new Size(113, 15);
            ContestantsCountLabel.TabIndex = 6;
            ContestantsCountLabel.Text = "Кількість учасників";
            // 
            // CountryLabel
            // 
            CountryLabel.AutoSize = true;
            CountryLabel.Location = new Point(7, 24);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(43, 15);
            CountryLabel.TabIndex = 5;
            CountryLabel.Text = "Країна";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 227);
            Controls.Add(ResultBox);
            Controls.Add(SubmitButton);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Олімпіадний залік";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox BronzeMedalCountBox;
        private TextBox SilverMedalCountBox;
        private TextBox CountryBox;
        private TextBox GoldMedalCountBox;
        private TextBox ContestCountBox;
        private Button SubmitButton;
        private TextBox ResultBox;
        private GroupBox groupBox1;
        private Label BronzeMedalCountLabel;
        private Label SilverMedalCountLabel;
        private Label GoldMedalsCountLabel;
        private Label ContestantsCountLabel;
        private Label CountryLabel;
    }
}
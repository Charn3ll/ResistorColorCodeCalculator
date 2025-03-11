namespace ResistorColorCodeCalculator
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
            bandNumbersComboBox = new ComboBox();
            band1ComboBox = new ComboBox();
            band2ComboBox = new ComboBox();
            band3ComboBox = new ComboBox();
            temperatureComboBox = new ComboBox();
            toleranceComboBox = new ComboBox();
            multiplierComboBox = new ComboBox();
            resistanceResultLabel = new Label();
            resistorImagePictureBox = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)resistorImagePictureBox).BeginInit();
            SuspendLayout();
            // 
            // bandNumbersComboBox
            // 
            bandNumbersComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            bandNumbersComboBox.FormattingEnabled = true;
            bandNumbersComboBox.Items.AddRange(new object[] { "Cztery", "Pięć", "Sześć" });
            bandNumbersComboBox.Location = new Point(38, 35);
            bandNumbersComboBox.Name = "bandNumbersComboBox";
            bandNumbersComboBox.Size = new Size(121, 23);
            bandNumbersComboBox.TabIndex = 0;
            bandNumbersComboBox.SelectedIndexChanged += bandNumbersComboBox_SelectedIndexChanged;
            // 
            // band1ComboBox
            // 
            band1ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            band1ComboBox.FormattingEnabled = true;
            band1ComboBox.Items.AddRange(new object[] { "Brak", "0 - czarny", "1 - brązowy", "2 - czerwony", "3 - pomarańczowy", "4 - żółty", "5 - zielony", "6 -niebieski", "7 - fioletowy", "8 - szary", "9 - biały" });
            band1ComboBox.Location = new Point(165, 35);
            band1ComboBox.Name = "band1ComboBox";
            band1ComboBox.Size = new Size(121, 23);
            band1ComboBox.TabIndex = 1;
            // 
            // band2ComboBox
            // 
            band2ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            band2ComboBox.FormattingEnabled = true;
            band2ComboBox.Items.AddRange(new object[] { "Brak", "0 - czarny", "1 - brązowy", "2 - czerwony", "3 - pomarańczowy", "4 - żółty", "5 - zielony", "6 -niebieski", "7 - fioletowy", "8 - szary", "9 - biały" });
            band2ComboBox.Location = new Point(292, 35);
            band2ComboBox.Name = "band2ComboBox";
            band2ComboBox.Size = new Size(121, 23);
            band2ComboBox.TabIndex = 2;
            // 
            // band3ComboBox
            // 
            band3ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            band3ComboBox.FormattingEnabled = true;
            band3ComboBox.Items.AddRange(new object[] { "Brak", "0 - czarny", "1 - brązowy", "2 - czerwony", "3 - pomarańczowy", "4 - żółty", "5 - zielony", "6 -niebieski", "7 - fioletowy", "8 - szary", "9 - biały" });
            band3ComboBox.Location = new Point(419, 35);
            band3ComboBox.Name = "band3ComboBox";
            band3ComboBox.Size = new Size(121, 23);
            band3ComboBox.TabIndex = 3;
            // 
            // temperatureComboBox
            // 
            temperatureComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            temperatureComboBox.FormattingEnabled = true;
            temperatureComboBox.Items.AddRange(new object[] { "Brak", "100 ppm - brązowy", "15 ppm - pomarańczowy", "25 ppm - żółty" });
            temperatureComboBox.Location = new Point(165, 107);
            temperatureComboBox.Name = "temperatureComboBox";
            temperatureComboBox.Size = new Size(163, 23);
            temperatureComboBox.TabIndex = 4;
            // 
            // toleranceComboBox
            // 
            toleranceComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            toleranceComboBox.FormattingEnabled = true;
            toleranceComboBox.Items.AddRange(new object[] { "Brak", "1% (F) - brązowy", "2% (G) -czerwony", "0,5% (D) - zielony", "0,25% (C) - niebieski", "0,10% (B) - fioletowy", "0,05% - szary", "5% (J) - złoty", "10% (K) - srebny" });
            toleranceComboBox.Location = new Point(38, 107);
            toleranceComboBox.Name = "toleranceComboBox";
            toleranceComboBox.Size = new Size(121, 23);
            toleranceComboBox.TabIndex = 5;
            // 
            // multiplierComboBox
            // 
            multiplierComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            multiplierComboBox.FormattingEnabled = true;
            multiplierComboBox.Items.AddRange(new object[] { "1 Ω - czarny", "10 Ω - brązowy", "100 Ω - czerwony", "1 K Ω - pomarańczowy", "10K Ω - żółty", "100K Ω - zielony", "1M Ω - niebieski", "10M Ω - fioletowy", "0,1 Ω - złoty", "0,01 Ω - srebny" });
            multiplierComboBox.Location = new Point(546, 35);
            multiplierComboBox.Name = "multiplierComboBox";
            multiplierComboBox.Size = new Size(121, 23);
            multiplierComboBox.TabIndex = 6;
            // 
            // resistanceResultLabel
            // 
            resistanceResultLabel.AutoSize = true;
            resistanceResultLabel.BorderStyle = BorderStyle.Fixed3D;
            resistanceResultLabel.Location = new Point(38, 204);
            resistanceResultLabel.Name = "resistanceResultLabel";
            resistanceResultLabel.Size = new Size(27, 17);
            resistanceResultLabel.TabIndex = 7;
            resistanceResultLabel.Text = "000";
            resistanceResultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // resistorImagePictureBox
            // 
            resistorImagePictureBox.Location = new Point(165, 204);
            resistorImagePictureBox.Name = "resistorImagePictureBox";
            resistorImagePictureBox.Size = new Size(623, 234);
            resistorImagePictureBox.TabIndex = 8;
            resistorImagePictureBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 17);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 9;
            label1.Text = "Wybierz liczbę pasków:\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 17);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 10;
            label2.Text = "Pasek nr 1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(292, 17);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 11;
            label3.Text = "Pasek nr 2:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(419, 17);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 12;
            label4.Text = "Pasek nr 3:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(546, 17);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 13;
            label5.Text = "Mnożnik";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 89);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 14;
            label6.Text = "Tolerancja";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(165, 74);
            label7.Name = "label7";
            label7.Size = new Size(88, 30);
            label7.TabIndex = 15;
            label7.Text = "Współczynnik \r\ntemperaturowy";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 172);
            label8.Name = "label8";
            label8.Size = new Size(92, 15);
            label8.TabIndex = 16;
            label8.Text = "Rezystancja w Ω";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(resistorImagePictureBox);
            Controls.Add(resistanceResultLabel);
            Controls.Add(multiplierComboBox);
            Controls.Add(toleranceComboBox);
            Controls.Add(temperatureComboBox);
            Controls.Add(band3ComboBox);
            Controls.Add(band2ComboBox);
            Controls.Add(band1ComboBox);
            Controls.Add(bandNumbersComboBox);
            Name = "Form1";
            Text = "ResistorColorCodeCalculator";
            ((System.ComponentModel.ISupportInitialize)resistorImagePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox bandNumbersComboBox;
        private ComboBox band1ComboBox;
        private ComboBox band2ComboBox;
        private ComboBox band3ComboBox;
        private ComboBox temperatureComboBox;
        private ComboBox toleranceComboBox;
        private ComboBox multiplierComboBox;
        private Label resistanceResultLabel;
        private PictureBox resistorImagePictureBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
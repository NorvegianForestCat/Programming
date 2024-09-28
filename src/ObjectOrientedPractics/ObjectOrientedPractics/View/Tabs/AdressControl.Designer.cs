namespace ObjectOrientedPractics.View.Tabs
{
    partial class AdressControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ApartmentTextBox = new TextBox();
            CityTextBox = new TextBox();
            BuildingTextBox = new TextBox();
            StreetTextBox = new TextBox();
            CountryTextBox = new TextBox();
            PostIndexTextBox = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(2, 3);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 0;
            label1.Text = "Delivery Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 28);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "Post index:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 86);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Street:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 115);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "Building:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(202, 115);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 4;
            label5.Text = "Apartment:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 57);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 5;
            label6.Text = "Country:";
            // 
            // ApartmentTextBox
            // 
            ApartmentTextBox.Location = new Point(275, 115);
            ApartmentTextBox.Name = "ApartmentTextBox";
            ApartmentTextBox.Size = new Size(100, 23);
            ApartmentTextBox.TabIndex = 6;
            ApartmentTextBox.TextChanged += ApartmentTextBox_TextChanged;
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(312, 54);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(107, 23);
            CityTextBox.TabIndex = 7;
            CityTextBox.TextChanged += CityTextBox_TextChanged;
            // 
            // BuildingTextBox
            // 
            BuildingTextBox.Location = new Point(73, 112);
            BuildingTextBox.Name = "BuildingTextBox";
            BuildingTextBox.Size = new Size(100, 23);
            BuildingTextBox.TabIndex = 8;
            BuildingTextBox.TextChanged += BuildingTextBox_TextChanged;
            // 
            // StreetTextBox
            // 
            StreetTextBox.Location = new Point(73, 83);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(346, 23);
            StreetTextBox.TabIndex = 9;
            StreetTextBox.TextChanged += StreetTextBox_TextChanged;
            // 
            // CountryTextBox
            // 
            CountryTextBox.Location = new Point(73, 54);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(196, 23);
            CountryTextBox.TabIndex = 10;
            CountryTextBox.TextChanged += CountryTextBox_TextChanged;
            // 
            // PostIndexTextBox
            // 
            PostIndexTextBox.Location = new Point(73, 25);
            PostIndexTextBox.Name = "PostIndexTextBox";
            PostIndexTextBox.Size = new Size(100, 23);
            PostIndexTextBox.TabIndex = 11;
            PostIndexTextBox.TextChanged += PostIndexTextBox_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(275, 57);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 12;
            label7.Text = "City:";
            // 
            // AdressControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label7);
            Controls.Add(PostIndexTextBox);
            Controls.Add(label1);
            Controls.Add(CountryTextBox);
            Controls.Add(label2);
            Controls.Add(StreetTextBox);
            Controls.Add(label3);
            Controls.Add(BuildingTextBox);
            Controls.Add(label4);
            Controls.Add(CityTextBox);
            Controls.Add(label5);
            Controls.Add(ApartmentTextBox);
            Controls.Add(label6);
            Name = "AdressControl";
            Size = new Size(425, 143);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox ApartmentTextBox;
        private TextBox CityTextBox;
        private TextBox BuildingTextBox;
        private TextBox StreetTextBox;
        private TextBox CountryTextBox;
        private TextBox PostIndexTextBox;
        private Label label7;
    }
}

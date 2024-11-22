namespace ObjectOrientedPractics.View.Controls
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
            this.DeliveryAddressLabel = new System.Windows.Forms.Label();
            this.PostIndexLabel = new System.Windows.Forms.Label();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.StreetLabel = new System.Windows.Forms.Label();
            this.BuildingLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.ApartmentLabel = new System.Windows.Forms.Label();
            this.PostIndexTextBox = new System.Windows.Forms.TextBox();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.BuildingTextBox = new System.Windows.Forms.TextBox();
            this.ApartmentTextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.WrongInputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeliveryAddressLabel
            // 
            this.DeliveryAddressLabel.AutoSize = true;
            this.DeliveryAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.DeliveryAddressLabel.Location = new System.Drawing.Point(3, 0);
            this.DeliveryAddressLabel.Name = "DeliveryAddressLabel";
            this.DeliveryAddressLabel.Size = new System.Drawing.Size(102, 13);
            this.DeliveryAddressLabel.TabIndex = 0;
            this.DeliveryAddressLabel.Text = "Delivery Address";
            // 
            // PostIndexLabel
            // 
            this.PostIndexLabel.AutoSize = true;
            this.PostIndexLabel.Location = new System.Drawing.Point(3, 28);
            this.PostIndexLabel.Name = "PostIndexLabel";
            this.PostIndexLabel.Size = new System.Drawing.Size(60, 13);
            this.PostIndexLabel.TabIndex = 1;
            this.PostIndexLabel.Text = "Post Index:";
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Location = new System.Drawing.Point(3, 58);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(46, 13);
            this.CountryLabel.TabIndex = 2;
            this.CountryLabel.Text = "Country:";
            // 
            // StreetLabel
            // 
            this.StreetLabel.AutoSize = true;
            this.StreetLabel.Location = new System.Drawing.Point(3, 88);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(38, 13);
            this.StreetLabel.TabIndex = 3;
            this.StreetLabel.Text = "Street:";
            // 
            // BuildingLabel
            // 
            this.BuildingLabel.AutoSize = true;
            this.BuildingLabel.Location = new System.Drawing.Point(3, 118);
            this.BuildingLabel.Name = "BuildingLabel";
            this.BuildingLabel.Size = new System.Drawing.Size(47, 13);
            this.BuildingLabel.TabIndex = 4;
            this.BuildingLabel.Text = "Building:";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(263, 58);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(27, 13);
            this.CityLabel.TabIndex = 5;
            this.CityLabel.Text = "City:";
            // 
            // ApartmentLabel
            // 
            this.ApartmentLabel.AutoSize = true;
            this.ApartmentLabel.Location = new System.Drawing.Point(165, 118);
            this.ApartmentLabel.Name = "ApartmentLabel";
            this.ApartmentLabel.Size = new System.Drawing.Size(58, 13);
            this.ApartmentLabel.TabIndex = 6;
            this.ApartmentLabel.Text = "Apartment:";
            // 
            // PostIndexTextBox
            // 
            this.PostIndexTextBox.Location = new System.Drawing.Point(69, 25);
            this.PostIndexTextBox.Name = "PostIndexTextBox";
            this.PostIndexTextBox.Size = new System.Drawing.Size(128, 20);
            this.PostIndexTextBox.TabIndex = 7;
            this.PostIndexTextBox.TextChanged += new System.EventHandler(this.PostIndexTextBox_TextChanged);
            this.PostIndexTextBox.Enter += new System.EventHandler(this.PostIndexTextBox_Enter);
            this.PostIndexTextBox.Leave += new System.EventHandler(this.PostIndexTextBox_Leave);
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(69, 55);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(175, 20);
            this.CountryTextBox.TabIndex = 8;
            this.CountryTextBox.TextChanged += new System.EventHandler(this.CountryTextBox_TextChanged);
            this.CountryTextBox.Enter += new System.EventHandler(this.CountryTextBox_Enter);
            this.CountryTextBox.Leave += new System.EventHandler(this.CountryTextBox_Leave);
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StreetTextBox.Location = new System.Drawing.Point(69, 85);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(421, 20);
            this.StreetTextBox.TabIndex = 9;
            this.StreetTextBox.TextChanged += new System.EventHandler(this.StreetTextBox_TextChanged);
            this.StreetTextBox.Enter += new System.EventHandler(this.StreetTextBox_Enter);
            this.StreetTextBox.Leave += new System.EventHandler(this.StreetTextBox_Leave);
            // 
            // BuildingTextBox
            // 
            this.BuildingTextBox.Location = new System.Drawing.Point(69, 115);
            this.BuildingTextBox.Name = "BuildingTextBox";
            this.BuildingTextBox.Size = new System.Drawing.Size(75, 20);
            this.BuildingTextBox.TabIndex = 10;
            this.BuildingTextBox.TextChanged += new System.EventHandler(this.BuildingTextBox_TextChanged);
            this.BuildingTextBox.Enter += new System.EventHandler(this.BuildingTextBox_Enter);
            this.BuildingTextBox.Leave += new System.EventHandler(this.BuildingTextBox_Leave);
            // 
            // ApartmentTextBox
            // 
            this.ApartmentTextBox.Location = new System.Drawing.Point(229, 115);
            this.ApartmentTextBox.Name = "ApartmentTextBox";
            this.ApartmentTextBox.Size = new System.Drawing.Size(75, 20);
            this.ApartmentTextBox.TabIndex = 11;
            this.ApartmentTextBox.TextChanged += new System.EventHandler(this.ApartmentTextBox_TextChanged);
            this.ApartmentTextBox.Enter += new System.EventHandler(this.ApartmentTextBox_Enter);
            this.ApartmentTextBox.Leave += new System.EventHandler(this.ApartmentTextBox_Leave);
            // 
            // CityTextBox
            // 
            this.CityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CityTextBox.Location = new System.Drawing.Point(296, 55);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(194, 20);
            this.CityTextBox.TabIndex = 12;
            this.CityTextBox.TextChanged += new System.EventHandler(this.CityTextBox_TextChanged);
            this.CityTextBox.Enter += new System.EventHandler(this.CityTextBox_Enter);
            this.CityTextBox.Leave += new System.EventHandler(this.CityTextBox_Leave);
            // 
            // WrongInputLabel
            // 
            this.WrongInputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WrongInputLabel.AutoSize = true;
            this.WrongInputLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.WrongInputLabel.Location = new System.Drawing.Point(203, 28);
            this.WrongInputLabel.Name = "WrongInputLabel";
            this.WrongInputLabel.Size = new System.Drawing.Size(29, 13);
            this.WrongInputLabel.TabIndex = 13;
            this.WrongInputLabel.Text = "Error";
            // 
            // AddressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WrongInputLabel);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.ApartmentTextBox);
            this.Controls.Add(this.BuildingTextBox);
            this.Controls.Add(this.StreetTextBox);
            this.Controls.Add(this.CountryTextBox);
            this.Controls.Add(this.PostIndexTextBox);
            this.Controls.Add(this.ApartmentLabel);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.BuildingLabel);
            this.Controls.Add(this.StreetLabel);
            this.Controls.Add(this.CountryLabel);
            this.Controls.Add(this.PostIndexLabel);
            this.Controls.Add(this.DeliveryAddressLabel);
            this.Name = "AddressControl";
            this.Size = new System.Drawing.Size(493, 192);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DeliveryAddressLabel;
        private System.Windows.Forms.Label PostIndexLabel;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.Label StreetLabel;
        private System.Windows.Forms.Label BuildingLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label ApartmentLabel;
        private System.Windows.Forms.TextBox PostIndexTextBox;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.TextBox BuildingTextBox;
        private System.Windows.Forms.TextBox ApartmentTextBox;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Label WrongInputLabel;
    }
}
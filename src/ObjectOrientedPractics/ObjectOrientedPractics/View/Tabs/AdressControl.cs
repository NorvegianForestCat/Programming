using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class AdressControl : UserControl
    {
        private Form errorMessageForm;
        private Label errorLabel;

        public Adress? Address { get; set; }
        public AdressControl()
        {
            errorMessageForm = new Form();
            errorLabel = new Label();
            errorLabel.Dock = DockStyle.Fill;

            errorMessageForm.Controls.Add(errorLabel);

            Address = new Adress();
            InitializeComponent();
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (BuildingTextBox.Text == String.Empty) return;

            BuildingTextBox.Focus();
            try
            {
                BuildingTextBox.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                Address.Building = BuildingTextBox.Text;
            }
            catch (Exception exception) 
            {
                // if exception
                BuildingTextBox.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                errorLabel.Text = String.Empty;
                errorLabel.Text = exception.Message;

                errorMessageForm.ShowDialog();
            }
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ApartmentTextBox.Text == String.Empty) return;

            ApartmentTextBox.Focus();
            try
            {
                Address.Apartment = ApartmentTextBox.Text;
                ApartmentTextBox.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            }
            catch (Exception exception) 
            {
                // if exception
                ApartmentTextBox.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                errorLabel.Text = String.Empty;
                errorLabel.Text = exception.Message;

                errorMessageForm.ShowDialog();
            }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            if (StreetTextBox.Text == String.Empty) return;

            StreetTextBox.Focus();
            try
            {
                Address.Street = StreetTextBox.Text;
                StreetTextBox.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            }
            catch (Exception exception)
            {
                // if exception
                StreetTextBox.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                errorLabel.Text = String.Empty;
                errorLabel.Text = exception.Message;

                errorMessageForm.ShowDialog();
            }
        }

        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
       {
            if (PostIndexTextBox.Text == String.Empty) return;

            PostIndexTextBox.Focus();
            try
            {
                Address.Index = int.Parse(PostIndexTextBox.Text);
                PostIndexTextBox.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            }
            catch (Exception exception)
            {
                // if exception
                PostIndexTextBox.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                errorLabel.Text = String.Empty;
                errorLabel.Text = exception.Message;

                errorMessageForm.ShowDialog();
            }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CityTextBox.Text == String.Empty) return;

            CityTextBox.Focus();
            try
            {
                Address.City = CityTextBox.Text;
                CityTextBox.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            }
            catch (Exception exception)
            {
                // if exception
                CityTextBox.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                errorLabel.Text = String.Empty;
                errorLabel.Text = exception.Message;

                errorMessageForm.ShowDialog();
            }
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CountryTextBox.Text == String.Empty) return;

            CountryTextBox.Focus();
            try
            {
                Address.Country = CountryTextBox.Text;
                CountryTextBox.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            }
            catch (Exception exception)
            {
                // if exception
                CountryTextBox.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                errorLabel.Text = String.Empty;
                errorLabel.Text = exception.Message;

                errorMessageForm.ShowDialog();
            }
        }

        public void Clear()
        {
            PostIndexTextBox.Clear();
            CountryTextBox.Clear();
            CityTextBox.Clear();
            StreetTextBox.Clear();
            BuildingTextBox.Clear();
            ApartmentTextBox.Clear();
        }

        public void AdressUpdate()
        {
            PostIndexTextBox.Text = Address.Index.ToString();
            CountryTextBox.Text = Address.Country.ToString();
            CityTextBox.Text = Address.City.ToString();
            StreetTextBox.Text = Address.Street.ToString();
            BuildingTextBox.Text = Address.Building.ToString();
            ApartmentTextBox.Text = Address.Apartment.ToString();
        }
    }
}

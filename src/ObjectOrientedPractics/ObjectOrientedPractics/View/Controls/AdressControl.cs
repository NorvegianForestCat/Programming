using System;
using System.Net;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Controls
{
    /// <summary>
    /// Adress control unit
    /// </summary>
    public partial class AdressControl : UserControl
    {
        /// <summary>
        /// Class fields
        /// </summary>
        private Adress _address;

        /// <summary>
        /// Gets and sets <see cref="Model.Address"/>.
        /// </summary>
        public Adress Address
        {
            get => _address;
            set
            {
                _address = value;
                UpdateTextBoxes();
            }
        }

        /// <summary>
        /// Gets error message
        /// </summary>
        private string LimitErrorMessage { get; } = "Field greater than limit";

        /// <summary>
        /// Gets and sets IsControlEnabled
        /// </summary>
        private bool IsControlEnabled { get; set; }

        /// <summary>
        /// Gets and sets IsTextBoxesEnabled
        /// </summary>
        public bool IsTextBoxesEnabled { get; set; } = true;

        /// <summary>
        /// Constructor
        /// </summary>
        public AdressControl()
        {
            InitializeComponent();

            Address = null;
            WrongInputLabel.Text = string.Empty;
        }

        /// <summary>
        /// Update list boxes
        /// </summary>
        private void UpdateTextBoxes()
        {
            IsControlEnabled = Address != null;

            PostIndexTextBox.Enabled = IsControlEnabled;
            CountryTextBox.Enabled = IsControlEnabled;
            CityTextBox.Enabled = IsControlEnabled;
            StreetTextBox.Enabled = IsControlEnabled;
            BuildingTextBox.Enabled = IsControlEnabled;
            ApartmentTextBox.Enabled = IsControlEnabled;

            if (IsControlEnabled)
            {
                PostIndexTextBox.Text = Address.Index.ToString();
                CountryTextBox.Text = Address.Country;
                CityTextBox.Text = Address.City;
                StreetTextBox.Text = Address.Street;
                BuildingTextBox.Text = Address.Building;
                ApartmentTextBox.Text = Address.Apartment;
            }
            else
            {
                PostIndexTextBox.Text = string.Empty;
                CountryTextBox.Text = string.Empty;
                CityTextBox.Text = string.Empty;
                StreetTextBox.Text = string.Empty;
                BuildingTextBox.Text = string.Empty;
                ApartmentTextBox.Text = string.Empty;
            }
        }
        
        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!IsControlEnabled) return;

            if (PostIndexTextBox.Text.Length == Adress.INDEX_DIGIT &&
                                int.TryParse(PostIndexTextBox.Text, out var temp))
            {
                WrongInputLabel.Text = string.Empty;
                PostIndexTextBox.BackColor = AppColors.RightInputColor;
            }
            else
            {
                WrongInputLabel.Text = "Invalid input";
                PostIndexTextBox.BackColor = AppColors.WrongInputColor;
            }
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!IsControlEnabled) return;

            if (CountryTextBox.Text.Length <= Adress.COUNTRY_LENGTH_LIMIT)
            {
                WrongInputLabel.Text = string.Empty;
                CountryTextBox.BackColor = AppColors.RightInputColor;
            }
            else
            {
                WrongInputLabel.Text = LimitErrorMessage;
                CountryTextBox.BackColor = AppColors.WrongInputColor;
            }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!IsControlEnabled) return;

            if (CityTextBox.Text.Length <= Adress.CITY_LENGTH_LIMIT)
            {
                WrongInputLabel.Text = string.Empty;
                CityTextBox.BackColor = AppColors.RightInputColor;
            }
            else
            {
                WrongInputLabel.Text = LimitErrorMessage;
                CityTextBox.BackColor = AppColors.WrongInputColor;
            }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!IsControlEnabled) return;

            if (StreetTextBox.Text.Length <= Adress.STREET_LENGTH_LIMIT)
            {
                WrongInputLabel.Text = string.Empty;
                StreetTextBox.BackColor = AppColors.RightInputColor;
            }
            else
            {
                WrongInputLabel.Text = LimitErrorMessage;
                StreetTextBox.BackColor = AppColors.WrongInputColor;
            }
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!IsControlEnabled) return;
            if (BuildingTextBox.Text.Length <= Adress.BUILDING_LENGTH_LIMIT)
            {
                WrongInputLabel.Text = string.Empty;
                BuildingTextBox.BackColor = AppColors.RightInputColor;
            }
            else
            {
                WrongInputLabel.Text = LimitErrorMessage;
                BuildingTextBox.BackColor = AppColors.WrongInputColor;
            }
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!IsControlEnabled) return;

            if (ApartmentTextBox.Text.Length <= Adress.APARTMENT_LENGTH_LIMIT)
            {
                WrongInputLabel.Text = string.Empty;
                ApartmentTextBox.BackColor = AppColors.RightInputColor;
            }
            else
            {
                WrongInputLabel.Text = LimitErrorMessage;
                ApartmentTextBox.BackColor = AppColors.WrongInputColor;
            }
        }

        private void PostIndexTextBox_Leave(object sender, EventArgs e)
        {
            if (!IsControlEnabled) return;

            if (PostIndexTextBox.BackColor == AppColors.RightInputColor)
            {
                Address.Index = int.Parse(PostIndexTextBox.Text);
            }

            PostIndexTextBox.Text = Address.Index.ToString();
        }

        private void CountryTextBox_Leave(object sender, EventArgs e)
        {
            if (!IsControlEnabled) return;

            if (CountryTextBox.BackColor == AppColors.RightInputColor)
            {
                Address.Country = CountryTextBox.Text;
            }

            CountryTextBox.Text = Address.Country;
        }

        private void CityTextBox_Leave(object sender, EventArgs e)
        {
            if (!IsControlEnabled) return;

            if (CityTextBox.BackColor == AppColors.RightInputColor)
            {
                Address.City = CityTextBox.Text;
            }

            CityTextBox.Text = Address.City;
        }

        private void StreetTextBox_Leave(object sender, EventArgs e)
        {
            if (!IsControlEnabled) return;

            if (StreetTextBox.BackColor == AppColors.RightInputColor)
            {
                Address.Street = StreetTextBox.Text;
            }

            StreetTextBox.Text = Address.Street;
        }

        private void BuildingTextBox_Leave(object sender, EventArgs e)
        {
            if (!IsControlEnabled) return;

            if (BuildingTextBox.BackColor == AppColors.RightInputColor)
            {
                Address.Building = BuildingTextBox.Text;
            }

            BuildingTextBox.Text = Address.Building;
        }

        private void ApartmentTextBox_Leave(object sender, EventArgs e)
        {
            if (!IsControlEnabled) return;

            if (ApartmentTextBox.BackColor == AppColors.RightInputColor)
            {
                Address.Apartment = ApartmentTextBox.Text;
            }

            ApartmentTextBox.Text = Address.Apartment;
        }

        private void PostIndexTextBox_Enter(object sender, EventArgs e)
        {
            PostIndexTextBox.Focus();
        }


        private void CountryTextBox_Enter(object sender, EventArgs e)
        {
            CountryTextBox.Focus();
        }

        private void CityTextBox_Enter(object sender, EventArgs e)
        {
            CityTextBox.Focus();
        }

        private void StreetTextBox_Enter(object sender, EventArgs e)
        {
            StreetTextBox.Focus();
        }

        private void BuildingTextBox_Enter(object sender, EventArgs e)
        {
            BuildingTextBox.Focus();
        }

        private void ApartmentTextBox_Enter(object sender, EventArgs e)
        {
            ApartmentTextBox.Focus();
        }
    }
}
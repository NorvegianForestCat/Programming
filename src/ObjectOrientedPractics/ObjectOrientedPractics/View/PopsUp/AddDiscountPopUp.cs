using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Pop_ups
{
    /// <summary>
    /// Add discount popUp
    /// </summary>
    public partial class AddDiscountPopUp : Form
    {
        /// <summary>
        /// Gets and set category
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Get and set customer
        /// </summary>
        public Customer Customer { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="customer">Customer</param>
        public AddDiscountPopUp(Customer customer)
        {
            InitializeComponent();

            Customer = customer;
            UpdateCategoryComboBox();
        }

        /// <summary>
        /// Updating category combobox
        /// </summary>
        private void UpdateCategoryComboBox()
        {
            List<Category> customerCategories = new List<Category>();
            foreach (var discount in Customer.Discounts)
            {
                if (discount is PercentDiscount)
                {
                    var percentDiscount = discount as PercentDiscount;
                    customerCategories.Add(percentDiscount.Category);
                }
            }

            List<Category> dataCategories = new List<Category>();

            foreach (Category category in Enum.GetValues(typeof(Category)).Cast<Category>().ToList())
            {
                if (!customerCategories.Contains(category))
                {
                    dataCategories.Add(category);
                }
            }

            CategoryComboBox.DataSource = dataCategories;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Category = (Category)Enum.Parse(
                typeof(Category),
                CategoryComboBox.SelectedItem.ToString());

            this.DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OkButton.Enabled = CategoryComboBox.SelectedIndex >= 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Controls;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Gets and sets <see cref="Customer"/>.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Gets and sets list of <see cref="Customer"/>.
        /// </summary>
        public List<Customer> Customers
        {
            get => _customers;
            set
            {
                _customers = value;
                if (value != null)
                {
                    UpdateCustomersListBox();
                }
            }
        }

        /// <summary>
        /// Class fields
        /// </summary>
        private Form errorMessageBox;
        private Label errorLabel;

        /// <summary>
        /// Constructor
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();

            WrongFullNameLabel.Text = string.Empty;

            errorMessageBox = new Form();
            errorLabel = new Label();

            errorMessageBox.Controls.Add(errorLabel);
            errorLabel.Dock = DockStyle.Fill;
        }

        /// <summary>
        /// Update customers list box
        /// </summary>
        private void UpdateCustomersListBox()
        {
            CustomersListBox.Items.Clear();

            foreach (Customer customer in Customers)
            {
                CustomersListBox.Items.Add(customer.Fullname);
            }
        }

        /// <summary>
        /// Set text boxes
        /// </summary>
        /// <param name="selectedIndex">Item index</param>
        private void SetTextBoxes(int selectedIndex)
        {
            bool isSelectedIndexCorrect = selectedIndex >= 0;

            FullNameTextBox.Enabled = isSelectedIndexCorrect;
            IsPriorityCheckBox.Enabled = isSelectedIndexCorrect;

            if (isSelectedIndexCorrect)
            {
                IdTextBox.Text = Customers[CustomersListBox.SelectedIndex].Id.ToString();
                FullNameTextBox.Text = Customers[CustomersListBox.SelectedIndex].Fullname;
                AddressControl.Address = Customers[CustomersListBox.SelectedIndex].Address;
                IsPriorityCheckBox.Checked = Customers[CustomersListBox.SelectedIndex].IsPriority;
            }
            else
            {
                FullNameTextBox.Text = string.Empty;
                IdTextBox.Text = string.Empty;
                AddressControl.Address = null;
                IsPriorityCheckBox.Checked = false;
            }
        }

        /// <summary>
        /// Selected index changed
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Args</param>
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetTextBoxes(CustomersListBox.SelectedIndex);
        }

        /// <summary>
        /// AddButton Click
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Args</param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            Customer newCustomer = new Customer();

            newCustomer.Fullname = $"#{newCustomer.Id}";

            Customers.Add(newCustomer);
            CustomersListBox.Items.Add(newCustomer.Fullname);
            CustomersListBox.SelectedIndex = CustomersListBox.Items.Count - 1;
        }

        /// <summary>
        /// Click remove button
        /// </summary>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int removeIndex = CustomersListBox.SelectedIndex;

            if (removeIndex < 0) return;

            IdGenerator.ReleaseId(Customers[removeIndex].Id);

            foreach (Order order in Customers[removeIndex].Orders)
            {
                IdGenerator.ReleaseId(order.Id);
            }

            CustomersListBox.Items.RemoveAt(removeIndex);
            Customers.RemoveAt(removeIndex);

            if (CustomersListBox.Items.Count <= 0) return;

            if (removeIndex < CustomersListBox.Items.Count)
            {
                CustomersListBox.SelectedIndex = removeIndex;
            }
            else
            {
                CustomersListBox.SelectedIndex = removeIndex - 1;
            }
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex < 0)
            {
                WrongFullNameLabel.Text = string.Empty;
                FullNameTextBox.BackColor = AppColors.RightInputColor;
                return;
            }

            Color currentColor = AppColors.WrongInputColor;
            WrongFullNameLabel.Text = string.Empty;
            currentColor = AppColors.RightInputColor;

            try
            {
                if (FullNameTextBox.Text.Length == 0) throw new Exception("Name must be");

                ValueValidator.AssertStringOnLength(FullNameTextBox.Text, Customer.FULLNAME_LENGTH_LIMIT, "Name");
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
                WrongFullNameLabel.Text = ex.Message;
                currentColor = AppColors.WrongInputColor;
            }
            FullNameTextBox.BackColor = currentColor;
        }

        private void FullNameTextBox_Leave(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex < 0) return;

            if (FullNameTextBox.BackColor == AppColors.RightInputColor)
            {
                Customers[CustomersListBox.SelectedIndex].Fullname = FullNameTextBox.Text;
                CustomersListBox.Items[CustomersListBox.SelectedIndex] = FullNameTextBox.Text;
            }
            else
            {
                FullNameTextBox.Text = Customers[CustomersListBox.SelectedIndex].Fullname;
            }
        }

        /// <summary>
        /// Show error messagebox
        /// </summary>
        /// <param name="message">Message</param>
        private void ShowErrorMessage(string message)
        {
            errorLabel.Text = "";
            errorLabel.Text = message;
            errorMessageBox.ShowDialog();
        }

        /// <summary>
        /// Change priority event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void IsPriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex < 0) return;

            Customers[CustomersListBox.SelectedIndex].IsPriority = IsPriorityCheckBox.Checked;
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {

        private BindingList<Customer> _customers;
        private Customer? _customer;
        private Form errorMessageForm;
        private Label errorLabel;

        public CustomersTab()
        {
            _customers = new BindingList<Customer>();
            errorMessageForm = new Form();
            errorLabel = new Label();
            errorLabel.Dock = DockStyle.Fill;

            errorMessageForm.Controls.Add(errorLabel);

            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(FullnameTextBox.Text) || String.IsNullOrEmpty(AdressTextBox.Text)) return;
            try
            {
                Customer customer = new Customer((string)FullnameTextBox.Text, (string)AdressTextBox.Text);
                _customers.Add(customer);

                CustomersListBox.SelectedIndex = -1;

                CustomersListBox.DataSource = _customers;
            }
            catch (Exception exception)
            {
                {
                    errorLabel.Text = String.Empty;
                    errorLabel.Text = exception.Message;

                    errorMessageForm.ShowDialog();
                }
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem == null) return;

            _customers.Remove((Customer)CustomersListBox.SelectedItem);
            CustomersListBox.SelectedItem = null;
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem == null) return;
            ClearFields();

            _customer = (Customer)CustomersListBox.SelectedItem;

            IdTextBox.Text = _customer.Id.ToString();
            FullnameTextBox.Text = _customer.Fullname.ToString();
            AdressTextBox.Text = _customer.Adress.ToString();

            if (CustomersListBox.SelectedIndex == -1)
            {
                ClearFields();
            }
        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_customer == null) return;

            if (_customer.Id.ToString() != IdTextBox.Text)
            {
                IdTextBox.Text = _customer.Id.ToString();
            }
        }

        private void FullnameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_customer == null || FullnameTextBox.Text == String.Empty || CustomersListBox.SelectedIndex == -1) return;
            try
            {
                FullnameTextBox.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                _customers[CustomersListBox.SelectedIndex].Fullname = FullnameTextBox.Text;
                UpdateListBox(_customers);
            }
            catch (Exception exception)
            {
                FullnameTextBox.BackColor = ColorTranslator.FromHtml("#FFB6C1");

                errorLabel.Text = String.Empty;
                errorLabel.Text = exception.Message;

                errorMessageForm.ShowDialog();
            }
        }

        private void ClearFields()
        {
            IdTextBox.Text = String.Empty;
            FullnameTextBox.Text = String.Empty;
            AdressTextBox.Text = String.Empty;
        }

        private void UpdateListBox(BindingList<Customer> list)
        {
            list.Add(new Customer());
            list.RemoveAt(list.Count - 1);

            CustomersListBox.DataSource = _customers;
        }

        private void SelectedCustomersPanel_Click(object sender, EventArgs e)
        {
            CustomersListBox.SelectedIndex = -1;
        }

        private void AdressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_customer == null || AdressTextBox.Text == String.Empty || CustomersListBox.SelectedIndex == -1) return;
            try
            {
                AdressTextBox.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                _customers[CustomersListBox.SelectedIndex].Adress = AdressTextBox.Text;
                UpdateListBox(_customers);
            }
            catch (Exception exception)
            {
                AdressTextBox.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                errorLabel.Text = String.Empty;
                errorLabel.Text = exception.Message;

                errorMessageForm.ShowDialog();
            }
        }
    }
}

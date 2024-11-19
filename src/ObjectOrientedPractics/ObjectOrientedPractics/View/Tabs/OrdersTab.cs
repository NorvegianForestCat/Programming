using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Order tab logic
    /// </summary>
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Gets and sets list of customers
        /// </summary>
        public List<Customer> Customers { get; set; }

        /// <summary>
        /// Gets list of orders
        /// </summary>
        private List<Order> Orders { get; } = new List<Order>();

        /// <summary>
        /// Constructor
        /// </summary>
        public OrdersTab()
        {
            InitializeComponent();
            StatusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));
            AddressControl.IsTextBoxesEnabled = false;
        }

        /// <summary>
        /// Refresh orders data
        /// </summary>
        public void RefreshData()
        {
            UpdateOrders();
        }

        /// <summary>
        /// Updating orders table
        /// </summary>
        private void UpdateOrders()
        {
            Orders.Clear();
            OrdersDataGridView.Rows.Clear();

            foreach (Customer customer in Customers)
            {
                string address = $"{customer.Address.Country}, {customer.Address.City}, ";
                address += $"{customer.Address.Street} {customer.Address.Building}, ";
                address += $"{customer.Address.Apartment}";

                foreach (var order in customer.Orders)
                {
                    Orders.Add(order);
                    OrdersDataGridView.Rows.Add(
                        order.Id, order.CreationDate, order.Status, customer.Fullname,
                        address, order.Amount);
                }
            }
        }

        /// <summary>
        /// Returns list of item names
        /// </summary>
        /// <param name="items"><see cref="List{Item}"/></param>
        /// <returns><see cref="List{string}"/></returns>
        private List<string> GetItemNames(List<Item> items)
        {
            List<string> itemNames = new List<string>();
            foreach (Item item in items)
            {
                itemNames.Add(item.Name);
            }
            return itemNames;
        }

        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (OrdersDataGridView.SelectedCells.Count == 0)
            {
                IdTextBox.Text = string.Empty;
                CreatedTextBox.Text = string.Empty;
                StatusComboBox.SelectedIndex = -1;
                StatusComboBox.Enabled = false;
                AddressControl.Address = null;
                OrderItemsListBox.DataSource = new List<string>();
                AmountLabel.Text = string.Empty;

                return;
            }
            int selectedIndex = OrdersDataGridView.SelectedCells[0].RowIndex;

            IdTextBox.Text = Orders[selectedIndex].Id.ToString();
            CreatedTextBox.Text = Orders[selectedIndex].CreationDate.ToString();
            StatusComboBox.SelectedItem = Orders[selectedIndex].Status;
            StatusComboBox.Enabled = true;
            AddressControl.Address = Orders[selectedIndex].Address;
            OrderItemsListBox.DataSource = GetItemNames(Orders[selectedIndex].Items);
            AmountLabel.Text = Orders[selectedIndex].Amount.ToString();
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrdersDataGridView.SelectedCells.Count == 0) return;

            int selectedIndex = OrdersDataGridView.SelectedCells[0].RowIndex;
            Orders[selectedIndex].Status = (OrderStatus)StatusComboBox.SelectedItem;
            OrdersDataGridView[2, selectedIndex].Value =
                Enum.GetName(typeof(OrderStatus), Orders[selectedIndex].Status);
        }
    }
}
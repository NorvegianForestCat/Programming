using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Order tab logic
    /// </summary>
    public partial class PriorityOrdersTab : UserControl
    {
        /// <summary>
        /// Class fields
        /// </summary>
        private bool _isPriorityOrder = false;
        private int _selectedIndex = -1;
        private Random _random = new Random();

        /// <summary>
        /// Gets and sets list of customers
        /// </summary>
        public List<Customer> Customers { get; set; }

        /// <summary>
        /// Gets list of orders
        /// </summary>
        private List<Order> Orders { get; } = new List<Order>();

        /// <summary>
        /// Gets list of store items
        /// </summary>
        private List<Item> Items { get; } = new List<Item>();

        /// <summary>
        /// Gets and sets selected index
        /// </summary>
        private int SelectedIndex
        {
            get => _selectedIndex;
            set
            {
                _selectedIndex = value;
                UpdateAllBoxes();
            }
        }

        /// <summary>
        /// Gets and sets if order is priority
        /// </summary>
        private bool IsPriorityOrder
        {
            get => _isPriorityOrder;
            set
            {
                _isPriorityOrder = value;

                if (value)
                {
                    PriorityOprionPanel.Visible = value;
                    var priorityOrder = (PriorityOrder)Orders[SelectedIndex];
                    DeliveryTimeComboBox.SelectedIndex = (int)priorityOrder.DeliveryTime;
                }
                else
                {
                    PriorityOprionPanel.Visible = false;
                }
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public PriorityOrdersTab()
        {
            InitializeComponent();
            StatusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));
            AddressControl.IsTextBoxesEnabled = false;
            PriorityOprionPanel.Visible = false;
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
                    int index = OrdersDataGridView.Rows.Add(
                        order.Id, order.CreationDate, order.Status, customer.Fullname,
                        address, order.Amount);

                    if (order is PriorityOrder)
                    {
                        OrdersDataGridView.Rows[index].Cells[0].Value = "\u2605";
                    }


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

        /// <summary>
        /// Обновляет данные всех ячеек.
        /// </summary>
        private void UpdateAllBoxes()
        {
            if (SelectedIndex == -1)
            {
                IdTextBox.Text = string.Empty;
                CreatedTextBox.Text = string.Empty;
                StatusComboBox.SelectedIndex = -1;
                StatusComboBox.Enabled = false;
                AddressControl.Address = null;
                OrderItemsListBox.DataSource = new List<string>();
                AmountLabel.Text = string.Empty;
                IsPriorityOrder = false;
            }
            else
            {
                IdTextBox.Text = Orders[SelectedIndex].Id.ToString();
                CreatedTextBox.Text = Orders[SelectedIndex].CreationDate.ToString();
                StatusComboBox.SelectedItem = Orders[SelectedIndex].Status;
                StatusComboBox.Enabled = true;
                AddressControl.Address = Orders[SelectedIndex].Address;
                OrderItemsListBox.DataSource = GetItemNames(Orders[SelectedIndex].Items);
                AmountLabel.Text = Orders[SelectedIndex].Amount.ToString();
                IsPriorityOrder = Orders[SelectedIndex] is PriorityOrder;
            }
        }

        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (OrdersDataGridView.SelectedCells.Count == 0)
            {
                SelectedIndex = -1;
            }
            else
            {
                SelectedIndex = OrdersDataGridView.SelectedCells[0].RowIndex;
            }
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedIndex == -1)
            {
                return;
            }

            Orders[SelectedIndex].Status = (OrderStatus)StatusComboBox.SelectedItem;
            OrdersDataGridView[3, SelectedIndex].Value =
                Enum.GetName(typeof(OrderStatus), Orders[SelectedIndex].Status);
        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedIndex == -1 || !IsPriorityOrder) return;

            var priorityOrder = (PriorityOrder)Orders[SelectedIndex];
            priorityOrder.DeliveryTime = (OrderTime)DeliveryTimeComboBox.SelectedIndex;
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            if (Items.Count < 0 || SelectedIndex < 0) return;

            int randomItemIndex = _random.Next(Items.Count);

            Orders[SelectedIndex].Items.Add(Items[randomItemIndex]);
        }

        private void DeleteItemButton_Click(object sender, EventArgs e)
        {
            if (Items.Count < 0 || SelectedIndex < 0) return;

            int selectedIndex = OrderItemsListBox.SelectedIndex;

            Orders[SelectedIndex].Items.RemoveAt(selectedIndex);

            if (selectedIndex >= OrderItemsListBox.Items.Count - 1)
            {
                SelectedIndex -= 1;
            }

            UpdateAllBoxes();
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            if (SelectedIndex < 0) return;

            Orders[SelectedIndex].Items.Clear();
            UpdateAllBoxes();
        }
    }
}

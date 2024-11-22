using ObjectOrientedPractics.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Customer cart logic
    /// </summary>
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Gets and sets current customer number
        /// </summary>
        private int CurrentCustomer { get; set; } = -1;

        /// <summary>
        /// Gets and sets list of items
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Sets and gets list of customers
        /// </summary>
        public List<Customer> Customers { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public CartsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Refresh all data
        /// </summary>
        public void RefreshData()
        {
            UpdateItemsListBox();
            UpdateCustomersComboBox();
            UpdateCartListBox();
        }

        /// <summary>
        /// Update customers carts info
        /// </summary>
        public void UpdateCustomerCarts()
        {
            foreach (Customer customer in Customers)
            {
                UpdateCartItems(customer.Cart);
            }
        }

        /// <summary>
        /// Uodate cart contain
        /// </summary>
        /// <param name="cart">Customer <see cref="Cart"/></param>
        private void UpdateCartItems(Cart cart)
        {
            List<Item> linkedItems = new List<Item>();
            foreach (Item cartItem in cart.Items)
            {
                foreach (Item item in Items)
                {
                    if (cartItem.Id == item.Id)
                    {
                        linkedItems.Add(item);
                    }
                }
            }
            cart.Items = linkedItems;
        }

        /// <summary>
        /// Update items list box show
        /// </summary>
        private void UpdateItemsListBox()
        {
            List<string> itemsData = new List<string>();

            foreach (Item item in Items)
            {
                itemsData.Add(item.Name);
            }

            ItemsListBox.DataSource = itemsData;
            ItemsListBox.Enabled = itemsData.Count != 0;
        }

        /// <summary>
        /// Update customers list box show
        /// </summary>
        private void UpdateCustomersComboBox()
        {
            List<string> customersData = new List<string>();

            foreach (Customer customer in Customers)
            {
                customersData.Add(customer.Fullname);
            }

            CustomerComboBox.DataSource = customersData;
            CustomerComboBox.Enabled = customersData.Count != 0;
            AmountLabel.Text = string.Empty;
            CustomerComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Update cart show data
        /// </summary>
        /// <param name="nextIndex">Next index</param>
        private void UpdateCartListBox(int nextIndex = -1)
        {
            if (Customers.Count == 0 || CurrentCustomer < 0)
            {
                CartListBox.DataSource = null;
                CartListBox.Enabled = false;
                return;
            }

            List<string> cartsData = new List<string>();

            foreach (Item item in Customers[CurrentCustomer].Cart.Items)
            {
                cartsData.Add(item.Name);
            }

            CartListBox.DataSource = cartsData;
            CartListBox.Enabled = cartsData.Count != 0;
            CartListBox.SelectedIndex = nextIndex;

            AmountLabel.Text = Customers[CurrentCustomer].Cart.Amount.ToString();
        }

        private void AddToCartButton_Click(object sender, System.EventArgs e)
        {
            if (CurrentCustomer < 0 || ItemsListBox.SelectedIndex < 0) return;

            foreach (Item item in Items)
            {
                if (item == Items[ItemsListBox.SelectedIndex])
                {
                    Customers[CurrentCustomer].Cart.Items.Add(item);
                }
            }


            UpdateCartListBox();
        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            CurrentCustomer = CustomerComboBox.SelectedIndex;
            UpdateCartListBox();
        }

        private void RemoveItemButton_Click(object sender, System.EventArgs e)
        {
            if (CurrentCustomer < 0 || CartListBox.SelectedIndex < 0) return;

            int selectedIndex = CartListBox.SelectedIndex;
            Customers[CurrentCustomer].Cart.Items.RemoveAt(selectedIndex);

            if (selectedIndex >= CartListBox.Items.Count - 1)
            {
                selectedIndex -= 1;
            }

            UpdateCartListBox(selectedIndex);
        }

        private void ClearCartButton_Click(object sender, System.EventArgs e)
        {
            if (CurrentCustomer < 0) return;

            Customers[CurrentCustomer].Cart.Items.Clear();
            UpdateCartListBox();
        }

        private void CreateOrderButton_Click(object sender, System.EventArgs e)
        {
            if (CurrentCustomer < 0 || CartListBox.Items.Count == 0) return;

            List<Item> items = new List<Item>();
            Order order;

            foreach (Item item in Customers[CurrentCustomer].Cart.Items)
            {
                items.Add(new Item(item));
            }

            if (Customers[CurrentCustomer].IsPriority)
            {
                order = new PriorityOrder(
                    OrderStatus.New,
                    Customers[CurrentCustomer].Address,
                    items);
            }

            else
            {
                order = new Order(
                    OrderStatus.New,
                    Customers[CurrentCustomer].Address,
                    items);
            }

            Customers[CurrentCustomer].Orders.Add(order);
            Customers[CurrentCustomer].Cart.Items.Clear();
            UpdateCartListBox();
        }
    }
}
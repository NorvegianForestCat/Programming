using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System.Windows.Forms;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Gets and sets <see cref="Model.Store"/>,
        /// </summary>
        public Store Store { get; } = Serializer.GetStore();

        /// <summary>
        /// Form closed
        /// </summary>
        /// <param name="sender">Event sender</param>
        /// <param name="e">Event args</param>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Serializer.SetStore(Store);
        }


        /// <summary>
        /// Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            ItemsTab.Items = Store.Items;
            CustomersTab.Customers = Store.Customers;
            CartsTab.Items = Store.Items;
            CartsTab.Customers = Store.Customers;
            OrdersTab.Customers = Store.Customers;
        }

        /// <summary>
        /// Tab changed
        /// </summary>
        private void MainTabControl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            switch (MainTabControl.SelectedIndex)
            {
                case 2:
                    CartsTab.RefreshData();
                    break;
                case 3:
                    OrdersTab.RefreshData();
                    break;
            }
        }

        /// <summary>
        /// Form loaded
        /// </summary>       
        private void MainForm_Load(object sender, System.EventArgs e)
        {
            CartsTab.UpdateCustomerCarts();
        }

    }
}

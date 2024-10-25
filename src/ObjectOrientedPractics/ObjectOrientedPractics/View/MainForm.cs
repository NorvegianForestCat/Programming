using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        // fields of MainForm class
        private Store _store;

        /// <summary>
        /// MainForm constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            _store = new Store();

            ItemsTab.Items = _store.Items;
            CustomersTab.Customers = _store.Customers;
        }
    }
}

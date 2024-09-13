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
    public partial class ItemsTab : UserControl
    {
        private BindingList<Item> _items;
        private Item? _item;

        public ItemsTab()
        {
            _items = new BindingList<Item>();
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text == String.Empty || CostTextBox.Text == string.Empty || NameTextBox.Text == null) return;
            try
            {
                Double.TryParse(CostTextBox.Text, out double cost);
                Item item = new Item((string)NameTextBox.Text, (string)DescriptionTextBox.Text, cost);
                _items.Add(item);

                ItemsListBox.DataSource = _items;
            }
            catch (Exception exception)
            {
                {
                    Form errorMessageForm = new Form();
                    Label errorLabel = new Label();

                    errorMessageForm.Controls.Add(errorLabel);
                    errorLabel.Text = exception.Message;

                    errorMessageForm.ShowDialog();
                }
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem == null) return;

            _items.Remove((Item)ItemsListBox.SelectedItem);

            ItemsListBox.SelectedItem = null;
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem == null) return;

            _item = (Item)ItemsListBox.SelectedItem;

            IdTextBox.Text = _item.Id.ToString();
            CostTextBox.Text = _item.Cost.ToString();
            NameTextBox.Text = _item.Name;
            DescriptionTextBox.Text = _item.Info;
        }
    }
}

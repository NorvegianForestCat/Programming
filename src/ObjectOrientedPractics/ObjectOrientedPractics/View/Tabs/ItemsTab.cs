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
        // class fields
        private BindingList<Item> _items;
        private Item? _item;
        private Form errorMessageForm;
        private Label errorLabel;

        public ItemsTab()
        {
            // Component initializing
            _items = new BindingList<Item>();

            errorMessageForm = new Form();
            errorLabel = new Label();
            errorLabel.Dock = DockStyle.Fill;

            errorMessageForm.Controls.Add(errorLabel);

            InitializeComponent();

            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
        }

        // AddButtom logic
        private void AddButton_Click(object sender, EventArgs e)
        {
            // fool-check
            if (String.IsNullOrEmpty(NameTextBox.Text) || String.IsNullOrEmpty(CostTextBox.Text) ||
                String.IsNullOrEmpty(DescriptionTextBox.Text)) return;
            try
            {
                Item item = new Item
                    (
                    (string)NameTextBox.Text, (string)DescriptionTextBox.Text, Double.Parse(CostTextBox.Text),
                    (Category)CategoryComboBox.SelectedItem
                    );
                _items.Add(item);

                ItemsListBox.SelectedIndex = -1;

                ItemsListBox.DataSource = _items;
            }
            catch (Exception exception)
            {
                //if exception
                {
                    errorLabel.Text = String.Empty;
                    errorLabel.Text = exception.Message;

                    errorMessageForm.ShowDialog();
                }
            }
        }

        // RemoveButton logic
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            // fool-check
            if (ItemsListBox.SelectedItem == null) return;

            _items.Remove((Item)ItemsListBox.SelectedItem);
            ItemsListBox.SelectedItem = null;
        }

        // ItemsListBox logic
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // fool-check
            if (ItemsListBox.SelectedItem == null) return;

            ClearFields();
            // Changing fields
            _item = (Item)ItemsListBox.SelectedItem;
            IdTextBox.Text = _item.Id.ToString();
            CostTextBox.Text = _item.Cost.ToString();
            NameTextBox.Text = _item.Name;
            DescriptionTextBox.Text = _item.Info;
            CategoryComboBox.SelectedItem = _item.Category;

            if (ItemsListBox.SelectedIndex == -1)
            {
                ClearFields();
            }
        }

        // IdTextBox logic
        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {
            // fool-check
            if (_item == null) return;

            if (_item.Id.ToString() != IdTextBox.Text)
            {
                IdTextBox.Text = _item.Id.ToString();
            }
        }

        // CostTextBox logic
        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            // fool-check
            if (_item == null || CostTextBox.Text == String.Empty || ItemsListBox.SelectedIndex == -1) return;
            try
            {
                CostTextBox.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                _items[ItemsListBox.SelectedIndex].Cost = double.Parse(CostTextBox.Text);
                UpdateListBox(_items);
            }
            catch (Exception exception)
            {
                // if exception
                CostTextBox.BackColor = ColorTranslator.FromHtml("#FFB6C1");

                errorLabel.Text = String.Empty;
                errorLabel.Text = exception.Message;

                errorMessageForm.ShowDialog();
            }
        }

        // Clearing the fields
        private void ClearFields()
        {
            IdTextBox.Text = String.Empty;
            CostTextBox.Text = String.Empty;
            NameTextBox.Text = String.Empty;
            DescriptionTextBox.Text = String.Empty;
        }

        // Updating listbox
        private void UpdateListBox(BindingList<Item> list)
        {
            list.Add(new Item());
            list.RemoveAt(list.Count - 1);

            ItemsListBox.DataSource = _items;
        }

        // Clearing selected index
        private void SelectedItemsPanel_Click(object sender, EventArgs e)
        {
            ItemsListBox.SelectedIndex = -1;
        }

        // NameTextBox logic
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            // fool-check
            if (_item == null || NameTextBox.Text == String.Empty || ItemsListBox.SelectedIndex == -1) return;
            try
            {
                NameTextBox.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                _items[ItemsListBox.SelectedIndex].Name = NameTextBox.Text;
                UpdateListBox(_items);
            }
            catch (Exception exception)
            {
                // if exception
                NameTextBox.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                errorLabel.Text = String.Empty;
                errorLabel.Text = exception.Message;

                errorMessageForm.ShowDialog();
            }
        }

        // DescriptionTextBox logic
        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            // fool-check
            if (_item == null || ItemsListBox.SelectedIndex == -1 || DescriptionTextBox.Text == String.Empty) return;
            try
            {
                DescriptionTextBox.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                _items[ItemsListBox.SelectedIndex].Info = DescriptionTextBox.Text;
            }
            catch (Exception exception)
            {
                // if exception
                DescriptionTextBox.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                errorLabel.Text = String.Empty;
                errorLabel.Text = exception.Message;

                errorMessageForm.ShowDialog();
            }
        }

        // CategoryComboBox logic
        private void CategoryComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            // fool-check
            if (_item == null || ItemsListBox.SelectedIndex == -1 || CategoryComboBox.SelectedItem == null) return;

            _items[ItemsListBox.SelectedIndex].Category = (Category)CategoryComboBox.SelectedItem;
        }
    }
}

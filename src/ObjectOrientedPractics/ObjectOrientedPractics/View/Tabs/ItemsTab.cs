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
        private Form errorMessageForm;
        private Label errorLabel;

        public ItemsTab()
        {
            _items = new BindingList<Item>();
            errorMessageForm = new Form();
            errorLabel = new Label();
            errorLabel.Dock = DockStyle.Fill;

            errorMessageForm.Controls.Add(errorLabel);

            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NameTextBox.Text) || String.IsNullOrEmpty(CostTextBox.Text) ||
                String.IsNullOrEmpty(DescriptionTextBox.Text)) return;
            try
            {
                Item item = new Item((string)NameTextBox.Text, (string)DescriptionTextBox.Text, Double.Parse(CostTextBox.Text));
                _items.Add(item);

                ItemsListBox.SelectedIndex = -1;

                ItemsListBox.DataSource = _items;
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
            if (ItemsListBox.SelectedItem == null) return;

            _items.Remove((Item)ItemsListBox.SelectedItem);
            ItemsListBox.SelectedItem = null;
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem == null) return;
            ClearFields();

            _item = (Item)ItemsListBox.SelectedItem;

            IdTextBox.Text = _item.Id.ToString();
            CostTextBox.Text = _item.Cost.ToString();
            NameTextBox.Text = _item.Name;
            DescriptionTextBox.Text = _item.Info;

            if (ItemsListBox.SelectedIndex == -1)
            {
                ClearFields();
            }
        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_item == null) return;

            if (_item.Id.ToString() != IdTextBox.Text)
            {
                IdTextBox.Text = _item.Id.ToString();
            }
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_item == null || CostTextBox.Text == String.Empty || ItemsListBox.SelectedIndex == -1) return;
            try
            {
                CostTextBox.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                _items[ItemsListBox.SelectedIndex].Cost = double.Parse(CostTextBox.Text);
                UpdateListBox(_items);
            }
            catch (Exception exception)
            {
                CostTextBox.BackColor = ColorTranslator.FromHtml("#FFB6C1");

                errorLabel.Text = String.Empty;
                errorLabel.Text = exception.Message;

                errorMessageForm.ShowDialog();
            }
        }

        private void ClearFields()
        {
            IdTextBox.Text = String.Empty;
            CostTextBox.Text = String.Empty;
            NameTextBox.Text = String.Empty;
            DescriptionTextBox.Text = String.Empty;
        }

        private void UpdateListBox(BindingList<Item> list)
        {
            list.Add(new Item());
            list.RemoveAt(list.Count - 1);

            ItemsListBox.DataSource = _items;
        }

        private void SelectedItemsPanel_Click(object sender, EventArgs e)
        {
            ItemsListBox.SelectedIndex = -1;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_item == null || NameTextBox.Text == String.Empty || ItemsListBox.SelectedIndex == -1) return;
            try
            {
                NameTextBox.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                _items[ItemsListBox.SelectedIndex].Name = NameTextBox.Text;
                UpdateListBox(_items);
            }
            catch (Exception exception)
            {
                NameTextBox.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                errorLabel.Text = String.Empty;
                errorLabel.Text = exception.Message;

                errorMessageForm.ShowDialog();
            }
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_item == null || ItemsListBox.SelectedIndex == -1 || DescriptionTextBox.Text == String.Empty) return;
            try
            {
                DescriptionTextBox.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                _items[ItemsListBox.SelectedIndex].Info = DescriptionTextBox.Text;
            }
            catch (Exception exception)
            {
                DescriptionTextBox.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                errorLabel.Text = String.Empty;
                errorLabel.Text = exception.Message;

                errorMessageForm.ShowDialog();
            }
        }
    }
}

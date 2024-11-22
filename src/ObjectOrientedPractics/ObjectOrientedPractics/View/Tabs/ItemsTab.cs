using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// List of <see cref="Model.Item"/>.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Gets and sets list of <see cref="Model.Item"/>.
        /// </summary>
        public List<Item> Items
        {
            get => _items;
            set
            {
                _items = value;
                if (value != null)
                {
                    UpdateItemsListBox();
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
        public ItemsTab()
        {
            InitializeComponent();

            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));

            CategoryComboBox.SelectedIndex = -1;
            WrongCostLabel.Text = string.Empty;
            WrongNameLabel.Text = string.Empty;
            WrongDescriptionLabel.Text = string.Empty;

            errorMessageBox = new Form();
            errorLabel = new Label();

            errorMessageBox.Controls.Add(errorLabel);
            errorLabel.Dock = DockStyle.Fill;

        }

        /// <summary>
        /// Update items list box
        /// </summary>
        private void UpdateItemsListBox()
        {
            ItemsListBox.Items.Clear();

            foreach (Item item in Items)
            {
                ItemsListBox.Items.Add(item.Name);
            }
        }

        /// <summary>
        /// Init text boxes
        /// </summary>
        /// <param name="selectedIndex">index</param>
        private void SetTextBoxes(int selectedIndex)
        {
            bool isSelectedIndexCorrect = selectedIndex >= 0;

            CostTextBox.Enabled = isSelectedIndexCorrect;
            NameTextBox.Enabled = isSelectedIndexCorrect;
            DescriptionTextBox.Enabled = isSelectedIndexCorrect;
            CategoryComboBox.Enabled = isSelectedIndexCorrect;

            if (isSelectedIndexCorrect)
            {
                NameTextBox.Text = Items[ItemsListBox.SelectedIndex].Name;
                CostTextBox.Text = Items[ItemsListBox.SelectedIndex].Cost.ToString();
                IdTextBox.Text = Items[ItemsListBox.SelectedIndex].Id.ToString();
                DescriptionTextBox.Text = Items[ItemsListBox.SelectedIndex].Info;
                CategoryComboBox.SelectedIndex = (int)Items[ItemsListBox.SelectedIndex].Category;
            }
            else
            {
                NameTextBox.Text = string.Empty;
                CostTextBox.Text = string.Empty;
                IdTextBox.Text = string.Empty;
                DescriptionTextBox.Text = string.Empty;
                CategoryComboBox.SelectedIndex = -1;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Item newItem = new Item();
            newItem.Name = $"Item{newItem.Id}";

            Items.Add(newItem);
            ItemsListBox.Items.Add(newItem.Name);
            ItemsListBox.SelectedIndex = ItemsListBox.Items.Count - 1;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int removeIndex = ItemsListBox.SelectedIndex;

            if (removeIndex == -1) return;

            IdGenerator.ReleaseId(Items[removeIndex].Id);
            ItemsListBox.Items.RemoveAt(removeIndex);
            Items.RemoveAt(removeIndex);

            if (ItemsListBox.Items.Count <= 0) return;

            if (removeIndex < ItemsListBox.Items.Count)
            {
                ItemsListBox.SelectedIndex = removeIndex;
            }
            else
            {
                ItemsListBox.SelectedIndex = removeIndex - 1;
            }
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetTextBoxes(ItemsListBox.SelectedIndex);
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex < 0)
            {
                WrongCostLabel.Text = string.Empty;
                CostTextBox.BackColor = AppColors.RightInputColor;
                return;
            }

            Color currentColor = AppColors.WrongInputColor;
            double getParse = 0;

            if (!double.TryParse(CostTextBox.Text, out getParse))
            {
                WrongCostLabel.Text = "Cost must be a double number.";
                ShowErrorMessage(WrongCostLabel.Text);
            }

            WrongCostLabel.Text = string.Empty;
            currentColor = AppColors.RightInputColor;

            try
            {
                ValueValidator.AssertDoubleOnLimits(getParse, Item.MINIMUM_COST, Item.MAXIMUM_COST, "Cost");
            }
            catch (Exception ex) 
            {
                ShowErrorMessage(ex.Message);
                WrongCostLabel.Text = ex.Message;
                currentColor= AppColors.WrongInputColor;
            }

            CostTextBox.BackColor = currentColor;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex < 0)
            {
                WrongNameLabel.Text = string.Empty;
                NameTextBox.BackColor = AppColors.RightInputColor;
                return;
            }

            Color currentColor = AppColors.WrongInputColor;
            WrongNameLabel.Text = string.Empty;
            currentColor = AppColors.RightInputColor;

            try
            {
                if (NameTextBox.Text.Length == 0) throw new Exception("Name must be");

                ValueValidator.AssertStringOnLength(NameTextBox.Text, Item.NAME_LENGTH_LIMIT, "Name");
            }
            catch(Exception ex) 
            {
                ShowErrorMessage(ex.Message);
                WrongCostLabel.Text = ex.Message;
                currentColor = AppColors.WrongInputColor;
            }

            NameTextBox.BackColor = currentColor;
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex < 0)
            {
                WrongDescriptionLabel.Text = string.Empty;
                DescriptionTextBox.BackColor = AppColors.RightInputColor;
                return;
            }

            Color currentColor = AppColors.WrongInputColor;
            WrongNameLabel.Text = string.Empty;
            currentColor = AppColors.RightInputColor;

            try
            {
                if (DescriptionTextBox.Text.Length == 0) throw new Exception("Info must be");

                ValueValidator.AssertStringOnLength(NameTextBox.Text, Item.INFO_LENGTH_LIMIT, "Desciption");
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
                WrongCostLabel.Text = ex.Message;
                currentColor = AppColors.WrongInputColor;
            }
            DescriptionTextBox.BackColor = currentColor;
        }

        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex < 0) return;

            if (NameTextBox.BackColor == AppColors.RightInputColor)
            {
                Items[ItemsListBox.SelectedIndex].Name = NameTextBox.Text;
                ItemsListBox.Items[ItemsListBox.SelectedIndex] = NameTextBox.Text;
            }
            else
            {
                NameTextBox.Text = Items[ItemsListBox.SelectedIndex].Name;
            }
        }

        private void CostTextBox_Leave(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex < 0) return;

            if (CostTextBox.BackColor == AppColors.RightInputColor)
            {
                Items[ItemsListBox.SelectedIndex].Cost = float.Parse(CostTextBox.Text);
            }
            CostTextBox.Text = Items[ItemsListBox.SelectedIndex].Cost.ToString();
        }

        private void DescriptionTextBox_Leave(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex < 0) return;

            if (DescriptionTextBox.BackColor == AppColors.RightInputColor)
            {
                Items[ItemsListBox.SelectedIndex].Info = DescriptionTextBox.Text;
            }
            else
            {
                DescriptionTextBox.Text = Items[ItemsListBox.SelectedIndex].Info;
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex < 0) return;

            Items[ItemsListBox.SelectedIndex].Category = (Category)CategoryComboBox.SelectedIndex;
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
    }
}
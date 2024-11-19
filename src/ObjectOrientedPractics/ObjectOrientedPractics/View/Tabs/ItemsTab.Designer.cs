namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ItemsListPanel = new Panel();
            ButtonPanel = new TableLayoutPanel();
            RemoveButton = new Button();
            AddButton = new Button();
            ItemsListBox = new ListBox();
            ItemsLabel = new Label();
            SelectedItemLabel = new Label();
            IdLabel = new Label();
            CostLabel = new Label();
            NameLabel = new Label();
            DiscriptionLabel = new Label();
            IdTextBox = new TextBox();
            CostTextBox = new TextBox();
            NameTextBox = new TextBox();
            DescriptionTextBox = new TextBox();
            SelectedItemPanel = new Panel();
            CategoryComboBox = new ComboBox();
            CategoryLabel = new Label();
            WrongDescriptionLabel = new Label();
            WrongNameLabel = new Label();
            WrongCostLabel = new Label();
            MainTableLayoutPanel = new TableLayoutPanel();
            colorDialog1 = new ColorDialog();
            ItemsListPanel.SuspendLayout();
            ButtonPanel.SuspendLayout();
            SelectedItemPanel.SuspendLayout();
            MainTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsListPanel
            // 
            ItemsListPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListPanel.Controls.Add(ButtonPanel);
            ItemsListPanel.Controls.Add(ItemsListBox);
            ItemsListPanel.Controls.Add(ItemsLabel);
            ItemsListPanel.Location = new Point(4, 3);
            ItemsListPanel.Margin = new Padding(4, 3, 4, 3);
            ItemsListPanel.Name = "ItemsListPanel";
            ItemsListPanel.Size = new Size(458, 802);
            ItemsListPanel.TabIndex = 0;
            // 
            // ButtonPanel
            // 
            ButtonPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonPanel.ColumnCount = 3;
            ButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            ButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            ButtonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            ButtonPanel.Controls.Add(RemoveButton, 1, 0);
            ButtonPanel.Controls.Add(AddButton, 0, 0);
            ButtonPanel.Location = new Point(4, 738);
            ButtonPanel.Margin = new Padding(4, 3, 4, 3);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.RowCount = 1;
            ButtonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ButtonPanel.Size = new Size(451, 60);
            ButtonPanel.TabIndex = 1;
            // 
            // RemoveButton
            // 
            RemoveButton.Dock = DockStyle.Fill;
            RemoveButton.Location = new Point(154, 3);
            RemoveButton.Margin = new Padding(4, 3, 4, 3);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(142, 54);
            RemoveButton.TabIndex = 2;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.Dock = DockStyle.Fill;
            AddButton.Location = new Point(4, 3);
            AddButton.Margin = new Padding(4, 3, 4, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(142, 54);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(4, 18);
            ItemsListBox.Margin = new Padding(4, 3, 4, 3);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(450, 709);
            ItemsListBox.TabIndex = 1;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // ItemsLabel
            // 
            ItemsLabel.AutoSize = true;
            ItemsLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 254);
            ItemsLabel.Location = new Point(4, 0);
            ItemsLabel.Margin = new Padding(4, 0, 4, 0);
            ItemsLabel.Name = "ItemsLabel";
            ItemsLabel.Size = new Size(37, 13);
            ItemsLabel.TabIndex = 0;
            ItemsLabel.Text = "Items";
            // 
            // SelectedItemLabel
            // 
            SelectedItemLabel.AutoSize = true;
            SelectedItemLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 254);
            SelectedItemLabel.Location = new Point(4, 0);
            SelectedItemLabel.Margin = new Padding(4, 0, 4, 0);
            SelectedItemLabel.Name = "SelectedItemLabel";
            SelectedItemLabel.Size = new Size(85, 13);
            SelectedItemLabel.TabIndex = 0;
            SelectedItemLabel.Text = "Selected Item";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(4, 36);
            IdLabel.Margin = new Padding(4, 0, 4, 0);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(21, 15);
            IdLabel.TabIndex = 1;
            IdLabel.Text = "ID:";
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Location = new Point(5, 69);
            CostLabel.Margin = new Padding(4, 0, 4, 0);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(34, 15);
            CostLabel.TabIndex = 2;
            CostLabel.Text = "Cost:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(4, 138);
            NameLabel.Margin = new Padding(4, 0, 4, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(42, 15);
            NameLabel.TabIndex = 3;
            NameLabel.Text = "Name:";
            // 
            // DiscriptionLabel
            // 
            DiscriptionLabel.AutoSize = true;
            DiscriptionLabel.Location = new Point(4, 286);
            DiscriptionLabel.Margin = new Padding(4, 0, 4, 0);
            DiscriptionLabel.Name = "DiscriptionLabel";
            DiscriptionLabel.Size = new Size(70, 15);
            DiscriptionLabel.TabIndex = 4;
            DiscriptionLabel.Text = "Description:";
            // 
            // IdTextBox
            // 
            IdTextBox.Enabled = false;
            IdTextBox.Location = new Point(86, 32);
            IdTextBox.Margin = new Padding(4, 3, 4, 3);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(140, 23);
            IdTextBox.TabIndex = 5;
            // 
            // CostTextBox
            // 
            CostTextBox.Enabled = false;
            CostTextBox.Location = new Point(86, 66);
            CostTextBox.Margin = new Padding(4, 3, 4, 3);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(140, 23);
            CostTextBox.TabIndex = 6;
            CostTextBox.TextChanged += CostTextBox_TextChanged;
            CostTextBox.Leave += CostTextBox_Leave;
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.Enabled = false;
            NameTextBox.Location = new Point(4, 157);
            NameTextBox.Margin = new Padding(4, 3, 4, 3);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(685, 108);
            NameTextBox.TabIndex = 7;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            NameTextBox.Leave += NameTextBox_Leave;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionTextBox.Enabled = false;
            DescriptionTextBox.Location = new Point(4, 305);
            DescriptionTextBox.Margin = new Padding(4, 3, 4, 3);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(685, 181);
            DescriptionTextBox.TabIndex = 8;
            DescriptionTextBox.TextChanged += DescriptionTextBox_TextChanged;
            DescriptionTextBox.Leave += DescriptionTextBox_Leave;
            // 
            // SelectedItemPanel
            // 
            SelectedItemPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SelectedItemPanel.Controls.Add(CategoryComboBox);
            SelectedItemPanel.Controls.Add(CategoryLabel);
            SelectedItemPanel.Controls.Add(WrongDescriptionLabel);
            SelectedItemPanel.Controls.Add(WrongNameLabel);
            SelectedItemPanel.Controls.Add(WrongCostLabel);
            SelectedItemPanel.Controls.Add(DescriptionTextBox);
            SelectedItemPanel.Controls.Add(NameTextBox);
            SelectedItemPanel.Controls.Add(CostTextBox);
            SelectedItemPanel.Controls.Add(IdTextBox);
            SelectedItemPanel.Controls.Add(DiscriptionLabel);
            SelectedItemPanel.Controls.Add(NameLabel);
            SelectedItemPanel.Controls.Add(CostLabel);
            SelectedItemPanel.Controls.Add(IdLabel);
            SelectedItemPanel.Controls.Add(SelectedItemLabel);
            SelectedItemPanel.Location = new Point(470, 3);
            SelectedItemPanel.Margin = new Padding(4, 3, 4, 3);
            SelectedItemPanel.Name = "SelectedItemPanel";
            SelectedItemPanel.Size = new Size(693, 802);
            SelectedItemPanel.TabIndex = 1;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.Enabled = false;
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(86, 99);
            CategoryComboBox.Margin = new Padding(4, 3, 4, 3);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(140, 23);
            CategoryComboBox.TabIndex = 16;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(5, 103);
            CategoryLabel.Margin = new Padding(4, 0, 4, 0);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(58, 15);
            CategoryLabel.TabIndex = 13;
            CategoryLabel.Text = "Category:";
            // 
            // WrongDescriptionLabel
            // 
            WrongDescriptionLabel.AutoSize = true;
            WrongDescriptionLabel.ForeColor = SystemColors.AppWorkspace;
            WrongDescriptionLabel.Location = new Point(84, 286);
            WrongDescriptionLabel.Margin = new Padding(4, 0, 4, 0);
            WrongDescriptionLabel.Name = "WrongDescriptionLabel";
            WrongDescriptionLabel.Size = new Size(32, 15);
            WrongDescriptionLabel.TabIndex = 12;
            WrongDescriptionLabel.Text = "Error";
            // 
            // WrongNameLabel
            // 
            WrongNameLabel.AutoSize = true;
            WrongNameLabel.ForeColor = SystemColors.AppWorkspace;
            WrongNameLabel.Location = new Point(55, 138);
            WrongNameLabel.Margin = new Padding(4, 0, 4, 0);
            WrongNameLabel.Name = "WrongNameLabel";
            WrongNameLabel.Size = new Size(32, 15);
            WrongNameLabel.TabIndex = 11;
            WrongNameLabel.Text = "Error";
            // 
            // WrongCostLabel
            // 
            WrongCostLabel.AutoSize = true;
            WrongCostLabel.ForeColor = SystemColors.AppWorkspace;
            WrongCostLabel.Location = new Point(234, 69);
            WrongCostLabel.Margin = new Padding(4, 0, 4, 0);
            WrongCostLabel.Name = "WrongCostLabel";
            WrongCostLabel.Size = new Size(32, 15);
            WrongCostLabel.TabIndex = 10;
            WrongCostLabel.Text = "Error";
            // 
            // MainTableLayoutPanel
            // 
            MainTableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainTableLayoutPanel.ColumnCount = 2;
            MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            MainTableLayoutPanel.Controls.Add(ItemsListPanel, 0, 0);
            MainTableLayoutPanel.Controls.Add(SelectedItemPanel, 1, 0);
            MainTableLayoutPanel.Location = new Point(0, 0);
            MainTableLayoutPanel.Margin = new Padding(4, 3, 4, 3);
            MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            MainTableLayoutPanel.RowCount = 1;
            MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            MainTableLayoutPanel.Size = new Size(1167, 808);
            MainTableLayoutPanel.TabIndex = 2;
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MainTableLayoutPanel);
            Margin = new Padding(4, 3, 4, 3);
            MaximumSize = new Size(1167, 808);
            MinimumSize = new Size(700, 462);
            Name = "ItemsTab";
            Size = new Size(1167, 808);
            ItemsListPanel.ResumeLayout(false);
            ItemsListPanel.PerformLayout();
            ButtonPanel.ResumeLayout(false);
            SelectedItemPanel.ResumeLayout(false);
            SelectedItemPanel.PerformLayout();
            MainTableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel ItemsListPanel;
        private System.Windows.Forms.Label ItemsLabel;
        private System.Windows.Forms.TableLayoutPanel ButtonPanel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Label SelectedItemLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label DiscriptionLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Panel SelectedItemPanel;
        private System.Windows.Forms.Label WrongDescriptionLabel;
        private System.Windows.Forms.Label WrongNameLabel;
        private System.Windows.Forms.Label WrongCostLabel;
        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}
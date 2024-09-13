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
            ItemsShowPanel = new Panel();
            ButtonsPanel = new Panel();
            AnotherButtonPanel = new Panel();
            AddButtonPanel = new Panel();
            AddButton = new Button();
            RemoveButtonPanel = new Panel();
            RemoveButton = new Button();
            ItemsLabel = new Label();
            ItemsListBox = new ListBox();
            SelectedItemsPanel = new Panel();
            label5 = new Label();
            IdLabel = new Label();
            DescriptionLabel = new Label();
            NameLabel = new Label();
            CostLabel = new Label();
            NameTextBox = new TextBox();
            CostTextBox = new TextBox();
            IdTextBox = new TextBox();
            DescriptionTextBox = new TextBox();
            panel2 = new Panel();
            ItemsShowPanel.SuspendLayout();
            ButtonsPanel.SuspendLayout();
            AddButtonPanel.SuspendLayout();
            RemoveButtonPanel.SuspendLayout();
            SelectedItemsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsShowPanel
            // 
            ItemsShowPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsShowPanel.Controls.Add(ButtonsPanel);
            ItemsShowPanel.Controls.Add(ItemsLabel);
            ItemsShowPanel.Controls.Add(ItemsListBox);
            ItemsShowPanel.Location = new Point(0, 0);
            ItemsShowPanel.Name = "ItemsShowPanel";
            ItemsShowPanel.Size = new Size(334, 545);
            ItemsShowPanel.TabIndex = 0;
            // 
            // ButtonsPanel
            // 
            ButtonsPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonsPanel.Controls.Add(AnotherButtonPanel);
            ButtonsPanel.Controls.Add(AddButtonPanel);
            ButtonsPanel.Controls.Add(RemoveButtonPanel);
            ButtonsPanel.Location = new Point(3, 489);
            ButtonsPanel.Name = "ButtonsPanel";
            ButtonsPanel.Size = new Size(328, 53);
            ButtonsPanel.TabIndex = 0;
            // 
            // AnotherButtonPanel
            // 
            AnotherButtonPanel.Dock = DockStyle.Right;
            AnotherButtonPanel.Location = new Point(219, 0);
            AnotherButtonPanel.Margin = new Padding(0);
            AnotherButtonPanel.Name = "AnotherButtonPanel";
            AnotherButtonPanel.Size = new Size(109, 53);
            AnotherButtonPanel.TabIndex = 24;
            // 
            // AddButtonPanel
            // 
            AddButtonPanel.Controls.Add(AddButton);
            AddButtonPanel.Dock = DockStyle.Left;
            AddButtonPanel.Location = new Point(0, 0);
            AddButtonPanel.Margin = new Padding(0);
            AddButtonPanel.Name = "AddButtonPanel";
            AddButtonPanel.Size = new Size(109, 53);
            AddButtonPanel.TabIndex = 24;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddButton.AutoSize = true;
            AddButton.Location = new Point(5, 5);
            AddButton.Margin = new Padding(5);
            AddButton.Name = "AddButton";
            AddButton.Padding = new Padding(10);
            AddButton.Size = new Size(99, 45);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // RemoveButtonPanel
            // 
            RemoveButtonPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            RemoveButtonPanel.Controls.Add(RemoveButton);
            RemoveButtonPanel.Location = new Point(109, 0);
            RemoveButtonPanel.Margin = new Padding(0);
            RemoveButtonPanel.Name = "RemoveButtonPanel";
            RemoveButtonPanel.Size = new Size(109, 53);
            RemoveButtonPanel.TabIndex = 23;
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RemoveButton.AutoSize = true;
            RemoveButton.Location = new Point(5, 5);
            RemoveButton.Margin = new Padding(5);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Padding = new Padding(10);
            RemoveButton.Size = new Size(99, 45);
            RemoveButton.TabIndex = 2;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // ItemsLabel
            // 
            ItemsLabel.AutoSize = true;
            ItemsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ItemsLabel.Location = new Point(3, 11);
            ItemsLabel.Name = "ItemsLabel";
            ItemsLabel.Size = new Size(39, 15);
            ItemsLabel.TabIndex = 1;
            ItemsLabel.Text = "Items";
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(3, 29);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(328, 454);
            ItemsListBox.TabIndex = 0;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // SelectedItemsPanel
            // 
            SelectedItemsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            SelectedItemsPanel.Controls.Add(label5);
            SelectedItemsPanel.Controls.Add(IdLabel);
            SelectedItemsPanel.Controls.Add(DescriptionLabel);
            SelectedItemsPanel.Controls.Add(NameLabel);
            SelectedItemsPanel.Controls.Add(CostLabel);
            SelectedItemsPanel.Controls.Add(NameTextBox);
            SelectedItemsPanel.Controls.Add(CostTextBox);
            SelectedItemsPanel.Controls.Add(IdTextBox);
            SelectedItemsPanel.Controls.Add(DescriptionTextBox);
            SelectedItemsPanel.Controls.Add(panel2);
            SelectedItemsPanel.Location = new Point(334, 0);
            SelectedItemsPanel.Name = "SelectedItemsPanel";
            SelectedItemsPanel.Size = new Size(467, 545);
            SelectedItemsPanel.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(11, 11);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 22;
            label5.Text = "Selected Items";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(11, 52);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(21, 15);
            IdLabel.TabIndex = 21;
            IdLabel.Text = "ID:";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(11, 249);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(70, 15);
            DescriptionLabel.TabIndex = 20;
            DescriptionLabel.Text = "Description:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(11, 114);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(42, 15);
            NameLabel.TabIndex = 19;
            NameLabel.Text = "Name:";
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Location = new Point(11, 81);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(34, 15);
            CostLabel.TabIndex = 18;
            CostLabel.Text = "Cost:";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(2, 132);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(462, 114);
            NameTextBox.TabIndex = 17;
            // 
            // CostTextBox
            // 
            CostTextBox.Location = new Point(55, 78);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(215, 23);
            CostTextBox.TabIndex = 16;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(55, 49);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(215, 23);
            IdTextBox.TabIndex = 15;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(2, 267);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(462, 162);
            DescriptionTextBox.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(467, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(0, 545);
            panel2.TabIndex = 13;
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SelectedItemsPanel);
            Controls.Add(ItemsShowPanel);
            Name = "ItemsTab";
            Size = new Size(801, 545);
            ItemsShowPanel.ResumeLayout(false);
            ItemsShowPanel.PerformLayout();
            ButtonsPanel.ResumeLayout(false);
            AddButtonPanel.ResumeLayout(false);
            AddButtonPanel.PerformLayout();
            RemoveButtonPanel.ResumeLayout(false);
            RemoveButtonPanel.PerformLayout();
            SelectedItemsPanel.ResumeLayout(false);
            SelectedItemsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ItemsShowPanel;
        private Label ItemsLabel;
        private ListBox ItemsListBox;
        private Panel ButtonsPanel;
        private Panel SelectedItemsPanel;
        private Label label5;
        private Label IdLabel;
        private Label DescriptionLabel;
        private Label NameLabel;
        private Label CostLabel;
        private TextBox NameTextBox;
        private TextBox CostTextBox;
        private TextBox IdTextBox;
        private TextBox DescriptionTextBox;
        private Panel panel2;
        private Panel AnotherButtonPanel;
        private Panel AddButtonPanel;
        private Panel RemoveButtonPanel;
        private Button AddButton;
        private Button RemoveButton;
    }
}

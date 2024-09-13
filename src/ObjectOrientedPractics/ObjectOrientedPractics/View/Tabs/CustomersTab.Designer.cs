namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            ItemsLabel = new Label();
            label5 = new Label();
            IdLabel = new Label();
            AdressLabel = new Label();
            FullnameLabel = new Label();
            AdressTextBox = new TextBox();
            FullnameTextBox = new TextBox();
            IdTextBox = new TextBox();
            panel2 = new Panel();
            SelectedItemsPanel = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            ButtonsPanel = new Panel();
            RemoveButtonPanel = new Panel();
            RemoveButton = new Button();
            AddButtonPanel = new Panel();
            AddButton = new Button();
            CustomerLabel = new Label();
            CustomersListBox = new ListBox();
            SelectedItemsPanel.SuspendLayout();
            panel3.SuspendLayout();
            ButtonsPanel.SuspendLayout();
            RemoveButtonPanel.SuspendLayout();
            AddButtonPanel.SuspendLayout();
            SuspendLayout();
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(11, 11);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 22;
            label5.Text = "Selected Customer";
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
            // AdressLabel
            // 
            AdressLabel.AutoSize = true;
            AdressLabel.Location = new Point(11, 114);
            AdressLabel.Name = "AdressLabel";
            AdressLabel.Size = new Size(45, 15);
            AdressLabel.TabIndex = 19;
            AdressLabel.Text = "Adress:";
            // 
            // FullnameLabel
            // 
            FullnameLabel.AutoSize = true;
            FullnameLabel.Location = new Point(11, 81);
            FullnameLabel.Name = "FullnameLabel";
            FullnameLabel.Size = new Size(64, 15);
            FullnameLabel.TabIndex = 18;
            FullnameLabel.Text = "Full Name:";
            // 
            // AdressTextBox
            // 
            AdressTextBox.Location = new Point(81, 114);
            AdressTextBox.Multiline = true;
            AdressTextBox.Name = "AdressTextBox";
            AdressTextBox.Size = new Size(383, 210);
            AdressTextBox.TabIndex = 17;
            AdressTextBox.TextChanged += AdressTextBox_TextChanged;
            // 
            // FullnameTextBox
            // 
            FullnameTextBox.Location = new Point(81, 78);
            FullnameTextBox.Name = "FullnameTextBox";
            FullnameTextBox.Size = new Size(215, 23);
            FullnameTextBox.TabIndex = 16;
            FullnameTextBox.TextChanged += FullnameTextBox_TextChanged;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(81, 49);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(215, 23);
            IdTextBox.TabIndex = 15;
            IdTextBox.TextChanged += IdTextBox_TextChanged;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(467, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(0, 328);
            panel2.TabIndex = 13;
            // 
            // SelectedItemsPanel
            // 
            SelectedItemsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            SelectedItemsPanel.Controls.Add(label5);
            SelectedItemsPanel.Controls.Add(IdLabel);
            SelectedItemsPanel.Controls.Add(AdressLabel);
            SelectedItemsPanel.Controls.Add(FullnameLabel);
            SelectedItemsPanel.Controls.Add(AdressTextBox);
            SelectedItemsPanel.Controls.Add(FullnameTextBox);
            SelectedItemsPanel.Controls.Add(IdTextBox);
            SelectedItemsPanel.Controls.Add(panel2);
            SelectedItemsPanel.Location = new Point(334, 0);
            SelectedItemsPanel.Name = "SelectedItemsPanel";
            SelectedItemsPanel.Size = new Size(467, 328);
            SelectedItemsPanel.TabIndex = 3;
            SelectedItemsPanel.Click += SelectedCustomersPanel_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(334, 330);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 212);
            panel1.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(ButtonsPanel);
            panel3.Controls.Add(CustomerLabel);
            panel3.Controls.Add(CustomersListBox);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(339, 542);
            panel3.TabIndex = 5;
            // 
            // ButtonsPanel
            // 
            ButtonsPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonsPanel.Controls.Add(RemoveButtonPanel);
            ButtonsPanel.Controls.Add(AddButtonPanel);
            ButtonsPanel.Location = new Point(0, 489);
            ButtonsPanel.Name = "ButtonsPanel";
            ButtonsPanel.Size = new Size(336, 50);
            ButtonsPanel.TabIndex = 24;
            // 
            // RemoveButtonPanel
            // 
            RemoveButtonPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            RemoveButtonPanel.Controls.Add(RemoveButton);
            RemoveButtonPanel.Location = new Point(114, 0);
            RemoveButtonPanel.Margin = new Padding(0);
            RemoveButtonPanel.Name = "RemoveButtonPanel";
            RemoveButtonPanel.Size = new Size(109, 50);
            RemoveButtonPanel.TabIndex = 26;
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
            // AddButtonPanel
            // 
            AddButtonPanel.Controls.Add(AddButton);
            AddButtonPanel.Dock = DockStyle.Left;
            AddButtonPanel.Location = new Point(0, 0);
            AddButtonPanel.Margin = new Padding(0);
            AddButtonPanel.Name = "AddButtonPanel";
            AddButtonPanel.Size = new Size(109, 50);
            AddButtonPanel.TabIndex = 25;
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
            // CustomerLabel
            // 
            CustomerLabel.AutoSize = true;
            CustomerLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CustomerLabel.Location = new Point(3, 11);
            CustomerLabel.Name = "CustomerLabel";
            CustomerLabel.Size = new Size(66, 15);
            CustomerLabel.TabIndex = 23;
            CustomerLabel.Text = "Customers";
            // 
            // CustomersListBox
            // 
            CustomersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 15;
            CustomersListBox.Location = new Point(3, 35);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(333, 454);
            CustomersListBox.TabIndex = 6;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(SelectedItemsPanel);
            Name = "CustomersTab";
            Size = new Size(801, 545);
            SelectedItemsPanel.ResumeLayout(false);
            SelectedItemsPanel.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ButtonsPanel.ResumeLayout(false);
            RemoveButtonPanel.ResumeLayout(false);
            RemoveButtonPanel.PerformLayout();
            AddButtonPanel.ResumeLayout(false);
            AddButtonPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ItemsShowPanel;
        private Label ItemsLabel;
        private Label label5;
        private Label IdLabel;
        private Label AdressLabel;
        private Label FullnameLabel;
        private TextBox AdressTextBox;
        private TextBox FullnameTextBox;
        private TextBox IdTextBox;
        private Panel panel2;
        private Panel SelectedItemsPanel;
        private Panel panel1;
        private Panel panel3;
        private ListBox CustomersListBox;
        private Panel ButtonsPanel;
        private Label CustomerLabel;
        private Panel AddButtonPanel;
        private Button AddButton;
        private Panel RemoveButtonPanel;
        private Button RemoveButton;
    }
}

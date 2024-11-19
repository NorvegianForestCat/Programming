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
            CustomersListPanel = new Panel();
            ButtonsPanel = new TableLayoutPanel();
            RemoveButton = new Button();
            AddButton = new Button();
            CustomersListBox = new ListBox();
            CustomersLabel = new Label();
            MainTableLayoutPanel = new TableLayoutPanel();
            SplitedTableLayoutPanel = new TableLayoutPanel();
            SelectedItemPanel = new Panel();
            AddressControl = new Controls.AdressControl();
            WrongFullNameLabel = new Label();
            FullNameTextBox = new TextBox();
            IdTextBox = new TextBox();
            FullNameLabel = new Label();
            IdLabel = new Label();
            SelectedCustomerLabel = new Label();
            panel1 = new Panel();
            CustomersListPanel.SuspendLayout();
            ButtonsPanel.SuspendLayout();
            MainTableLayoutPanel.SuspendLayout();
            SplitedTableLayoutPanel.SuspendLayout();
            SelectedItemPanel.SuspendLayout();
            SuspendLayout();
            // 
            // CustomersListPanel
            // 
            CustomersListPanel.Controls.Add(ButtonsPanel);
            CustomersListPanel.Controls.Add(CustomersListBox);
            CustomersListPanel.Controls.Add(CustomersLabel);
            CustomersListPanel.Dock = DockStyle.Fill;
            CustomersListPanel.Location = new Point(4, 3);
            CustomersListPanel.Margin = new Padding(4, 3, 4, 3);
            CustomersListPanel.Name = "CustomersListPanel";
            CustomersListPanel.Size = new Size(295, 629);
            CustomersListPanel.TabIndex = 0;
            // 
            // ButtonsPanel
            // 
            ButtonsPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonsPanel.ColumnCount = 3;
            ButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            ButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            ButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            ButtonsPanel.Controls.Add(RemoveButton, 1, 0);
            ButtonsPanel.Controls.Add(AddButton, 0, 0);
            ButtonsPanel.Location = new Point(4, 565);
            ButtonsPanel.Margin = new Padding(4, 3, 4, 3);
            ButtonsPanel.Name = "ButtonsPanel";
            ButtonsPanel.RowCount = 1;
            ButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            ButtonsPanel.Size = new Size(288, 60);
            ButtonsPanel.TabIndex = 2;
            // 
            // RemoveButton
            // 
            RemoveButton.Dock = DockStyle.Fill;
            RemoveButton.Location = new Point(99, 3);
            RemoveButton.Margin = new Padding(4, 3, 4, 3);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(87, 54);
            RemoveButton.TabIndex = 1;
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
            AddButton.Size = new Size(87, 54);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // CustomersListBox
            // 
            CustomersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 15;
            CustomersListBox.Location = new Point(4, 25);
            CustomersListBox.Margin = new Padding(4, 3, 4, 3);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(288, 529);
            CustomersListBox.TabIndex = 1;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // CustomersLabel
            // 
            CustomersLabel.AutoSize = true;
            CustomersLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 254);
            CustomersLabel.Location = new Point(4, 3);
            CustomersLabel.Margin = new Padding(4, 3, 4, 3);
            CustomersLabel.Name = "CustomersLabel";
            CustomersLabel.Size = new Size(65, 13);
            CustomersLabel.TabIndex = 0;
            CustomersLabel.Text = "Customers";
            // 
            // MainTableLayoutPanel
            // 
            MainTableLayoutPanel.ColumnCount = 2;
            MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            MainTableLayoutPanel.Controls.Add(CustomersListPanel, 0, 0);
            MainTableLayoutPanel.Controls.Add(SplitedTableLayoutPanel, 1, 0);
            MainTableLayoutPanel.Dock = DockStyle.Fill;
            MainTableLayoutPanel.Location = new Point(0, 0);
            MainTableLayoutPanel.Margin = new Padding(4, 3, 4, 3);
            MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            MainTableLayoutPanel.RowCount = 1;
            MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            MainTableLayoutPanel.Size = new Size(758, 635);
            MainTableLayoutPanel.TabIndex = 2;
            // 
            // SplitedTableLayoutPanel
            // 
            SplitedTableLayoutPanel.ColumnCount = 1;
            SplitedTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            SplitedTableLayoutPanel.Controls.Add(SelectedItemPanel, 0, 0);
            SplitedTableLayoutPanel.Controls.Add(panel1, 0, 1);
            SplitedTableLayoutPanel.Dock = DockStyle.Fill;
            SplitedTableLayoutPanel.Location = new Point(307, 3);
            SplitedTableLayoutPanel.Margin = new Padding(4, 3, 4, 3);
            SplitedTableLayoutPanel.Name = "SplitedTableLayoutPanel";
            SplitedTableLayoutPanel.RowCount = 2;
            SplitedTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            SplitedTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            SplitedTableLayoutPanel.Size = new Size(447, 629);
            SplitedTableLayoutPanel.TabIndex = 1;
            // 
            // SelectedItemPanel
            // 
            SelectedItemPanel.Controls.Add(AddressControl);
            SelectedItemPanel.Controls.Add(WrongFullNameLabel);
            SelectedItemPanel.Controls.Add(FullNameTextBox);
            SelectedItemPanel.Controls.Add(IdTextBox);
            SelectedItemPanel.Controls.Add(FullNameLabel);
            SelectedItemPanel.Controls.Add(IdLabel);
            SelectedItemPanel.Controls.Add(SelectedCustomerLabel);
            SelectedItemPanel.Dock = DockStyle.Fill;
            SelectedItemPanel.Location = new Point(4, 3);
            SelectedItemPanel.Margin = new Padding(4, 3, 4, 3);
            SelectedItemPanel.Name = "SelectedItemPanel";
            SelectedItemPanel.Size = new Size(439, 308);
            SelectedItemPanel.TabIndex = 3;
            // 
            // AddressControl
            // 
            AddressControl.Address = null;
            AddressControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddressControl.Location = new Point(4, 138);
            AddressControl.Margin = new Padding(5, 3, 5, 3);
            AddressControl.Name = "AddressControl";
            AddressControl.Size = new Size(432, 248);
            AddressControl.TabIndex = 10;
            // 
            // WrongFullNameLabel
            // 
            WrongFullNameLabel.AutoSize = true;
            WrongFullNameLabel.ForeColor = SystemColors.AppWorkspace;
            WrongFullNameLabel.Location = new Point(74, 70);
            WrongFullNameLabel.Margin = new Padding(4, 0, 4, 0);
            WrongFullNameLabel.Name = "WrongFullNameLabel";
            WrongFullNameLabel.Size = new Size(32, 15);
            WrongFullNameLabel.TabIndex = 9;
            WrongFullNameLabel.Text = "Error";
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FullNameTextBox.Enabled = false;
            FullNameTextBox.Location = new Point(77, 89);
            FullNameTextBox.Margin = new Padding(4, 3, 4, 3);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(358, 23);
            FullNameTextBox.TabIndex = 6;
            FullNameTextBox.TextChanged += FullNameTextBox_TextChanged;
            FullNameTextBox.Leave += FullNameTextBox_Leave;
            // 
            // IdTextBox
            // 
            IdTextBox.Enabled = false;
            IdTextBox.Location = new Point(77, 36);
            IdTextBox.Margin = new Padding(4, 3, 4, 3);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(116, 23);
            IdTextBox.TabIndex = 5;
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Location = new Point(4, 92);
            FullNameLabel.Margin = new Padding(4, 0, 4, 0);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(64, 15);
            FullNameLabel.TabIndex = 3;
            FullNameLabel.Text = "Full Name:";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(4, 39);
            IdLabel.Margin = new Padding(4, 0, 4, 0);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(21, 15);
            IdLabel.TabIndex = 2;
            IdLabel.Text = "ID:";
            // 
            // SelectedCustomerLabel
            // 
            SelectedCustomerLabel.AutoSize = true;
            SelectedCustomerLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 254);
            SelectedCustomerLabel.Location = new Point(4, 3);
            SelectedCustomerLabel.Margin = new Padding(4, 0, 4, 0);
            SelectedCustomerLabel.Name = "SelectedCustomerLabel";
            SelectedCustomerLabel.Size = new Size(113, 13);
            SelectedCustomerLabel.TabIndex = 1;
            SelectedCustomerLabel.Text = "Selected Customer";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(4, 317);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(439, 309);
            panel1.TabIndex = 4;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MainTableLayoutPanel);
            Margin = new Padding(4, 3, 4, 3);
            MaximumSize = new Size(1167, 808);
            MinimumSize = new Size(758, 635);
            Name = "CustomersTab";
            Size = new Size(758, 635);
            CustomersListPanel.ResumeLayout(false);
            CustomersListPanel.PerformLayout();
            ButtonsPanel.ResumeLayout(false);
            MainTableLayoutPanel.ResumeLayout(false);
            SplitedTableLayoutPanel.ResumeLayout(false);
            SelectedItemPanel.ResumeLayout(false);
            SelectedItemPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel CustomersListPanel;
        private System.Windows.Forms.Label CustomersLabel;
        private System.Windows.Forms.TableLayoutPanel ButtonsPanel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel SplitedTableLayoutPanel;
        private System.Windows.Forms.Panel SelectedItemPanel;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label SelectedCustomerLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label WrongFullNameLabel;
        private Controls.AdressControl AddressControl;
    }
}
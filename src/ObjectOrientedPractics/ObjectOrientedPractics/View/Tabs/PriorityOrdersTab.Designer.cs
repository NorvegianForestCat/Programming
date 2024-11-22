namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
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
            OrdersDataGridView = new DataGridView();
            Priority = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            CreatedDate = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            MainTableLayoutPanel = new TableLayoutPanel();
            DataPanel = new Panel();
            OrdersLabel = new Label();
            SelectedOrderPanel = new Panel();
            PriorityOprionPanel = new Panel();
            PriorityOptionLabel = new Label();
            DeliveryTimeComboBox = new ComboBox();
            DeliveryTimeLabel = new Label();
            AmountLabel = new Label();
            OrderItemsListBox = new ListBox();
            StatusComboBox = new ComboBox();
            CreatedTextBox = new TextBox();
            IdTextBox = new TextBox();
            AmountHeaderLabel = new Label();
            StatusLabel = new Label();
            CreatedLabel = new Label();
            IdLabel = new Label();
            OrderItemsLabel = new Label();
            SelectedOrderLabel = new Label();
            AddressControl = new Controls.AdressControl();
            AddItemButton = new Button();
            DeleteItemButton = new Button();
            ClearCartButton = new Button();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).BeginInit();
            MainTableLayoutPanel.SuspendLayout();
            DataPanel.SuspendLayout();
            SelectedOrderPanel.SuspendLayout();
            PriorityOprionPanel.SuspendLayout();
            SuspendLayout();
            // 
            // OrdersDataGridView
            // 
            OrdersDataGridView.AllowUserToAddRows = false;
            OrdersDataGridView.AllowUserToDeleteRows = false;
            OrdersDataGridView.AllowUserToResizeColumns = false;
            OrdersDataGridView.AllowUserToResizeRows = false;
            OrdersDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrdersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            OrdersDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            OrdersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersDataGridView.Columns.AddRange(new DataGridViewColumn[] { Priority, Id, CreatedDate, Status, FullName, Address, Amount });
            OrdersDataGridView.Location = new Point(4, 18);
            OrdersDataGridView.Margin = new Padding(4, 3, 4, 3);
            OrdersDataGridView.MultiSelect = false;
            OrdersDataGridView.Name = "OrdersDataGridView";
            OrdersDataGridView.ReadOnly = true;
            OrdersDataGridView.RowHeadersVisible = false;
            OrdersDataGridView.Size = new Size(311, 549);
            OrdersDataGridView.TabIndex = 0;
            OrdersDataGridView.SelectionChanged += OrdersDataGridView_SelectionChanged;
            // 
            // Priority
            // 
            Priority.HeaderText = "";
            Priority.Name = "Priority";
            Priority.ReadOnly = true;
            Priority.Resizable = DataGridViewTriState.False;
            Priority.Width = 19;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Resizable = DataGridViewTriState.False;
            Id.SortMode = DataGridViewColumnSortMode.NotSortable;
            Id.Width = 24;
            // 
            // CreatedDate
            // 
            CreatedDate.HeaderText = "Created";
            CreatedDate.Name = "CreatedDate";
            CreatedDate.ReadOnly = true;
            CreatedDate.Resizable = DataGridViewTriState.False;
            CreatedDate.SortMode = DataGridViewColumnSortMode.NotSortable;
            CreatedDate.Width = 54;
            // 
            // Status
            // 
            Status.HeaderText = "Order Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Resizable = DataGridViewTriState.False;
            Status.SortMode = DataGridViewColumnSortMode.NotSortable;
            Status.Width = 70;
            // 
            // FullName
            // 
            FullName.HeaderText = "Customer Full Name";
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            FullName.Resizable = DataGridViewTriState.False;
            FullName.SortMode = DataGridViewColumnSortMode.NotSortable;
            FullName.Width = 81;
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.Name = "Address";
            Address.ReadOnly = true;
            Address.Resizable = DataGridViewTriState.False;
            Address.SortMode = DataGridViewColumnSortMode.NotSortable;
            Address.Width = 55;
            // 
            // Amount
            // 
            Amount.HeaderText = "Total Cost";
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            Amount.Resizable = DataGridViewTriState.False;
            Amount.SortMode = DataGridViewColumnSortMode.NotSortable;
            Amount.Width = 59;
            // 
            // MainTableLayoutPanel
            // 
            MainTableLayoutPanel.ColumnCount = 2;
            MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            MainTableLayoutPanel.Controls.Add(DataPanel, 0, 0);
            MainTableLayoutPanel.Controls.Add(SelectedOrderPanel, 1, 0);
            MainTableLayoutPanel.Dock = DockStyle.Fill;
            MainTableLayoutPanel.Location = new Point(0, 0);
            MainTableLayoutPanel.Margin = new Padding(4, 3, 4, 3);
            MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            MainTableLayoutPanel.RowCount = 1;
            MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            MainTableLayoutPanel.Size = new Size(817, 577);
            MainTableLayoutPanel.TabIndex = 1;
            // 
            // DataPanel
            // 
            DataPanel.Controls.Add(OrdersLabel);
            DataPanel.Controls.Add(OrdersDataGridView);
            DataPanel.Dock = DockStyle.Fill;
            DataPanel.Location = new Point(4, 3);
            DataPanel.Margin = new Padding(4, 3, 4, 3);
            DataPanel.Name = "DataPanel";
            DataPanel.Size = new Size(318, 571);
            DataPanel.TabIndex = 1;
            // 
            // OrdersLabel
            // 
            OrdersLabel.AutoSize = true;
            OrdersLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 254);
            OrdersLabel.Location = new Point(0, 0);
            OrdersLabel.Margin = new Padding(4, 0, 4, 0);
            OrdersLabel.Name = "OrdersLabel";
            OrdersLabel.Size = new Size(44, 13);
            OrdersLabel.TabIndex = 1;
            OrdersLabel.Text = "Orders";
            // 
            // SelectedOrderPanel
            // 
            SelectedOrderPanel.Controls.Add(ClearCartButton);
            SelectedOrderPanel.Controls.Add(DeleteItemButton);
            SelectedOrderPanel.Controls.Add(AddItemButton);
            SelectedOrderPanel.Controls.Add(PriorityOprionPanel);
            SelectedOrderPanel.Controls.Add(AmountLabel);
            SelectedOrderPanel.Controls.Add(OrderItemsListBox);
            SelectedOrderPanel.Controls.Add(StatusComboBox);
            SelectedOrderPanel.Controls.Add(CreatedTextBox);
            SelectedOrderPanel.Controls.Add(IdTextBox);
            SelectedOrderPanel.Controls.Add(AmountHeaderLabel);
            SelectedOrderPanel.Controls.Add(StatusLabel);
            SelectedOrderPanel.Controls.Add(CreatedLabel);
            SelectedOrderPanel.Controls.Add(IdLabel);
            SelectedOrderPanel.Controls.Add(OrderItemsLabel);
            SelectedOrderPanel.Controls.Add(SelectedOrderLabel);
            SelectedOrderPanel.Controls.Add(AddressControl);
            SelectedOrderPanel.Dock = DockStyle.Fill;
            SelectedOrderPanel.Location = new Point(330, 3);
            SelectedOrderPanel.Margin = new Padding(4, 3, 4, 3);
            SelectedOrderPanel.Name = "SelectedOrderPanel";
            SelectedOrderPanel.Size = new Size(483, 571);
            SelectedOrderPanel.TabIndex = 2;
            // 
            // PriorityOprionPanel
            // 
            PriorityOprionPanel.Controls.Add(PriorityOptionLabel);
            PriorityOprionPanel.Controls.Add(DeliveryTimeComboBox);
            PriorityOprionPanel.Controls.Add(DeliveryTimeLabel);
            PriorityOprionPanel.Location = new Point(237, 5);
            PriorityOprionPanel.Margin = new Padding(4, 3, 4, 3);
            PriorityOprionPanel.Name = "PriorityOprionPanel";
            PriorityOprionPanel.Size = new Size(239, 66);
            PriorityOprionPanel.TabIndex = 21;
            // 
            // PriorityOptionLabel
            // 
            PriorityOptionLabel.AutoSize = true;
            PriorityOptionLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 254);
            PriorityOptionLabel.Location = new Point(-4, 0);
            PriorityOptionLabel.Margin = new Padding(4, 0, 4, 0);
            PriorityOptionLabel.Name = "PriorityOptionLabel";
            PriorityOptionLabel.Size = new Size(87, 13);
            PriorityOptionLabel.TabIndex = 18;
            PriorityOptionLabel.Text = "Priority Option";
            // 
            // DeliveryTimeComboBox
            // 
            DeliveryTimeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DeliveryTimeComboBox.FormattingEnabled = true;
            DeliveryTimeComboBox.Items.AddRange(new object[] { "9:00 - 11:00", "11:00 - 13:00", "13:00 - 15:00", "15:00 - 17:00", "17:00 - 19:00", "19:00 - 21:00" });
            DeliveryTimeComboBox.Location = new Point(90, 31);
            DeliveryTimeComboBox.Margin = new Padding(4, 3, 4, 3);
            DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            DeliveryTimeComboBox.Size = new Size(140, 23);
            DeliveryTimeComboBox.TabIndex = 20;
            DeliveryTimeComboBox.SelectedIndexChanged += DeliveryTimeComboBox_SelectedIndexChanged;
            // 
            // DeliveryTimeLabel
            // 
            DeliveryTimeLabel.AutoSize = true;
            DeliveryTimeLabel.Location = new Point(2, 35);
            DeliveryTimeLabel.Margin = new Padding(4, 0, 4, 0);
            DeliveryTimeLabel.Name = "DeliveryTimeLabel";
            DeliveryTimeLabel.Size = new Size(81, 15);
            DeliveryTimeLabel.TabIndex = 19;
            DeliveryTimeLabel.Text = "Delivery Time:";
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AmountLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 254);
            AmountLabel.Location = new Point(-189, 535);
            AmountLabel.Margin = new Padding(4, 0, 4, 0);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(668, 24);
            AmountLabel.TabIndex = 14;
            AmountLabel.Text = "49 999,90";
            AmountLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // OrderItemsListBox
            // 
            OrderItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            OrderItemsListBox.FormattingEnabled = true;
            OrderItemsListBox.ItemHeight = 15;
            OrderItemsListBox.Location = new Point(4, 330);
            OrderItemsListBox.Margin = new Padding(4, 3, 4, 3);
            OrderItemsListBox.Name = "OrderItemsListBox";
            OrderItemsListBox.SelectionMode = SelectionMode.None;
            OrderItemsListBox.Size = new Size(475, 184);
            OrderItemsListBox.TabIndex = 13;
            // 
            // StatusComboBox
            // 
            StatusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(77, 100);
            StatusComboBox.Margin = new Padding(4, 3, 4, 3);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(140, 23);
            StatusComboBox.TabIndex = 11;
            StatusComboBox.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;
            // 
            // CreatedTextBox
            // 
            CreatedTextBox.Enabled = false;
            CreatedTextBox.Location = new Point(77, 66);
            CreatedTextBox.Margin = new Padding(4, 3, 4, 3);
            CreatedTextBox.Name = "CreatedTextBox";
            CreatedTextBox.Size = new Size(140, 23);
            CreatedTextBox.TabIndex = 10;
            // 
            // IdTextBox
            // 
            IdTextBox.Enabled = false;
            IdTextBox.Location = new Point(77, 31);
            IdTextBox.Margin = new Padding(4, 3, 4, 3);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(140, 23);
            IdTextBox.TabIndex = 9;
            // 
            // AmountHeaderLabel
            // 
            AmountHeaderLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AmountHeaderLabel.AutoSize = true;
            AmountHeaderLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 254);
            AmountHeaderLabel.Location = new Point(418, 518);
            AmountHeaderLabel.Margin = new Padding(4, 0, 4, 0);
            AmountHeaderLabel.Name = "AmountHeaderLabel";
            AmountHeaderLabel.Size = new Size(53, 13);
            AmountHeaderLabel.TabIndex = 8;
            AmountHeaderLabel.Text = "Amount:";
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(0, 104);
            StatusLabel.Margin = new Padding(4, 0, 4, 0);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(42, 15);
            StatusLabel.TabIndex = 7;
            StatusLabel.Text = "Status:";
            // 
            // CreatedLabel
            // 
            CreatedLabel.AutoSize = true;
            CreatedLabel.Location = new Point(0, 69);
            CreatedLabel.Margin = new Padding(4, 0, 4, 0);
            CreatedLabel.Name = "CreatedLabel";
            CreatedLabel.Size = new Size(51, 15);
            CreatedLabel.TabIndex = 6;
            CreatedLabel.Text = "Created:";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(0, 35);
            IdLabel.Margin = new Padding(4, 0, 4, 0);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(24, 15);
            IdLabel.TabIndex = 5;
            IdLabel.Text = "ID: ";
            // 
            // OrderItemsLabel
            // 
            OrderItemsLabel.AutoSize = true;
            OrderItemsLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 254);
            OrderItemsLabel.Location = new Point(0, 312);
            OrderItemsLabel.Margin = new Padding(4, 0, 4, 0);
            OrderItemsLabel.Name = "OrderItemsLabel";
            OrderItemsLabel.Size = new Size(72, 13);
            OrderItemsLabel.TabIndex = 3;
            OrderItemsLabel.Text = "Order Items";
            // 
            // SelectedOrderLabel
            // 
            SelectedOrderLabel.AutoSize = true;
            SelectedOrderLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 254);
            SelectedOrderLabel.Location = new Point(0, 0);
            SelectedOrderLabel.Margin = new Padding(4, 0, 4, 0);
            SelectedOrderLabel.Name = "SelectedOrderLabel";
            SelectedOrderLabel.Size = new Size(92, 13);
            SelectedOrderLabel.TabIndex = 2;
            SelectedOrderLabel.Text = "Selected Order";
            // 
            // AddressControl
            // 
            AddressControl.Address = null;
            AddressControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddressControl.IsTextBoxesEnabled = true;
            AddressControl.Location = new Point(4, 134);
            AddressControl.Margin = new Padding(5, 3, 5, 3);
            AddressControl.Name = "AddressControl";
            AddressControl.Size = new Size(472, 158);
            AddressControl.TabIndex = 12;
            // 
            // AddItemButton
            // 
            AddItemButton.Location = new Point(4, 531);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(75, 23);
            AddItemButton.TabIndex = 22;
            AddItemButton.Text = "Add";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // DeleteItemButton
            // 
            DeleteItemButton.Location = new Point(118, 531);
            DeleteItemButton.Name = "DeleteItemButton";
            DeleteItemButton.Size = new Size(75, 23);
            DeleteItemButton.TabIndex = 23;
            DeleteItemButton.Text = "Delete";
            DeleteItemButton.UseVisualStyleBackColor = true;
            DeleteItemButton.Click += DeleteItemButton_Click;
            // 
            // ClearCartButton
            // 
            ClearCartButton.Location = new Point(245, 531);
            ClearCartButton.Name = "ClearCartButton";
            ClearCartButton.Size = new Size(75, 23);
            ClearCartButton.TabIndex = 24;
            ClearCartButton.Text = "Clear";
            ClearCartButton.UseVisualStyleBackColor = true;
            ClearCartButton.Click += ClearCartButton_Click;
            // 
            // PriorityOrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MainTableLayoutPanel);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(817, 577);
            Name = "PriorityOrdersTab";
            Size = new Size(817, 577);
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).EndInit();
            MainTableLayoutPanel.ResumeLayout(false);
            DataPanel.ResumeLayout(false);
            DataPanel.PerformLayout();
            SelectedOrderPanel.ResumeLayout(false);
            SelectedOrderPanel.PerformLayout();
            PriorityOprionPanel.ResumeLayout(false);
            PriorityOprionPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView OrdersDataGridView;
        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.Panel DataPanel;
        private System.Windows.Forms.Panel SelectedOrderPanel;
        private System.Windows.Forms.Label OrdersLabel;
        private System.Windows.Forms.Label OrderItemsLabel;
        private System.Windows.Forms.Label SelectedOrderLabel;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.TextBox CreatedTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label AmountHeaderLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label CreatedLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.ListBox OrderItemsListBox;
        private Controls.AdressControl AddressControl;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.ComboBox DeliveryTimeComboBox;
        private System.Windows.Forms.Label DeliveryTimeLabel;
        private System.Windows.Forms.Label PriorityOptionLabel;
        private System.Windows.Forms.Panel PriorityOprionPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private Button ClearCartButton;
        private Button DeleteItemButton;
        private Button AddItemButton;
    }
}
namespace ObjectOrientedPractics
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            OrdersTabPage = new TabPage();
            OrdersTab = new View.Tabs.OrdersTab();
            CartsPage = new TabPage();
            CartsTab = new View.Tabs.CartsTab();
            CustomersTabPage = new TabPage();
            CustomersTab = new View.Tabs.CustomersTab();
            ItemsTabPage = new TabPage();
            ItemsTab = new View.Tabs.ItemsTab();
            MainTabControl = new TabControl();
            OrdersTabPage.SuspendLayout();
            CartsPage.SuspendLayout();
            CustomersTabPage.SuspendLayout();
            ItemsTabPage.SuspendLayout();
            MainTabControl.SuspendLayout();
            SuspendLayout();
            // 
            // OrdersTabPage
            // 
            OrdersTabPage.Controls.Add(OrdersTab);
            OrdersTabPage.Location = new Point(4, 24);
            OrdersTabPage.Margin = new Padding(4, 3, 4, 3);
            OrdersTabPage.Name = "OrdersTabPage";
            OrdersTabPage.Padding = new Padding(4, 3, 4, 3);
            OrdersTabPage.Size = new Size(848, 631);
            OrdersTabPage.TabIndex = 3;
            OrdersTabPage.Text = "Orders";
            OrdersTabPage.UseVisualStyleBackColor = true;
            // 
            // OrdersTab
            // 
            OrdersTab.Customers = null;
            OrdersTab.Dock = DockStyle.Fill;
            OrdersTab.Location = new Point(4, 3);
            OrdersTab.Margin = new Padding(5, 3, 5, 3);
            OrdersTab.MinimumSize = new Size(700, 540);
            OrdersTab.Name = "OrdersTab";
            OrdersTab.Size = new Size(840, 625);
            OrdersTab.TabIndex = 0;
            // 
            // CartsPage
            // 
            CartsPage.Controls.Add(CartsTab);
            CartsPage.Location = new Point(4, 24);
            CartsPage.Margin = new Padding(4, 3, 4, 3);
            CartsPage.Name = "CartsPage";
            CartsPage.Padding = new Padding(4, 3, 4, 3);
            CartsPage.Size = new Size(848, 631);
            CartsPage.TabIndex = 2;
            CartsPage.Text = "Carts";
            CartsPage.UseVisualStyleBackColor = true;
            // 
            // CartsTab
            // 
            CartsTab.Customers = null;
            CartsTab.Dock = DockStyle.Fill;
            CartsTab.Items = null;
            CartsTab.Location = new Point(4, 3);
            CartsTab.Margin = new Padding(5, 3, 5, 3);
            CartsTab.MinimumSize = new Size(537, 354);
            CartsTab.Name = "CartsTab";
            CartsTab.Size = new Size(840, 625);
            CartsTab.TabIndex = 0;
            // 
            // CustomersTabPage
            // 
            CustomersTabPage.Controls.Add(CustomersTab);
            CustomersTabPage.Location = new Point(4, 24);
            CustomersTabPage.Margin = new Padding(4, 3, 4, 3);
            CustomersTabPage.Name = "CustomersTabPage";
            CustomersTabPage.Padding = new Padding(4, 3, 4, 3);
            CustomersTabPage.Size = new Size(848, 631);
            CustomersTabPage.TabIndex = 1;
            CustomersTabPage.Text = "Customers";
            CustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // CustomersTab
            // 
            CustomersTab.Customers = null;
            CustomersTab.Dock = DockStyle.Fill;
            CustomersTab.Location = new Point(4, 3);
            CustomersTab.Margin = new Padding(5, 3, 5, 3);
            CustomersTab.MaximumSize = new Size(1167, 808);
            CustomersTab.MinimumSize = new Size(700, 462);
            CustomersTab.Name = "CustomersTab";
            CustomersTab.Size = new Size(840, 625);
            CustomersTab.TabIndex = 0;
            // 
            // ItemsTabPage
            // 
            ItemsTabPage.Controls.Add(ItemsTab);
            ItemsTabPage.Location = new Point(4, 24);
            ItemsTabPage.Margin = new Padding(4, 3, 4, 3);
            ItemsTabPage.Name = "ItemsTabPage";
            ItemsTabPage.Padding = new Padding(4, 3, 4, 3);
            ItemsTabPage.Size = new Size(848, 631);
            ItemsTabPage.TabIndex = 0;
            ItemsTabPage.Text = "Items";
            ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // ItemsTab
            // 
            ItemsTab.Dock = DockStyle.Fill;
            ItemsTab.Items = null;
            ItemsTab.Location = new Point(4, 3);
            ItemsTab.Margin = new Padding(5, 3, 5, 3);
            ItemsTab.MaximumSize = new Size(1113, 763);
            ItemsTab.MinimumSize = new Size(726, 467);
            ItemsTab.Name = "ItemsTab";
            ItemsTab.Size = new Size(840, 625);
            ItemsTab.TabIndex = 0;
            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(ItemsTabPage);
            MainTabControl.Controls.Add(CustomersTabPage);
            MainTabControl.Controls.Add(CartsPage);
            MainTabControl.Controls.Add(OrdersTabPage);
            MainTabControl.Dock = DockStyle.Fill;
            MainTabControl.Location = new Point(0, 0);
            MainTabControl.Margin = new Padding(4, 3, 4, 3);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(856, 659);
            MainTabControl.TabIndex = 0;
            MainTabControl.SelectedIndexChanged += MainTabControl_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 659);
            Controls.Add(MainTabControl);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(1164, 802);
            MinimumSize = new Size(872, 698);
            Name = "MainForm";
            Text = "Object Oriented Practics";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            OrdersTabPage.ResumeLayout(false);
            CartsPage.ResumeLayout(false);
            CustomersTabPage.ResumeLayout(false);
            ItemsTabPage.ResumeLayout(false);
            MainTabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage OrdersTabPage;
        private View.Tabs.OrdersTab OrdersTab;
        private TabPage CartsPage;
        private View.Tabs.CartsTab CartsTab;
        private TabPage CustomersTabPage;
        private View.Tabs.CustomersTab CustomersTab;
        private TabPage ItemsTabPage;
        private View.Tabs.ItemsTab ItemsTab;
        private TabControl MainTabControl;
    }
}
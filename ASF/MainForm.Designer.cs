namespace ASF
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tSSL_User = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_New = new System.Windows.Forms.ToolStripButton();
            this.OrdersPanel = new System.Windows.Forms.Panel();
            this.OrdersGrid = new SourceGrid.Grid();
            this.contextMenuStripGrid1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tSCB_Filter = new System.Windows.Forms.ToolStripComboBox();
            this.tSTB_Filter = new System.Windows.Forms.ToolStripTextBox();
            this.tabList1 = new Cyotek.Windows.Forms.TabList();
            this.tabListPageOrders = new Cyotek.Windows.Forms.TabListPage();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tabListPageCustomers = new Cyotek.Windows.Forms.TabListPage();
            this.CustomersPanel = new System.Windows.Forms.Panel();
            this.CustomersGrid = new SourceGrid.Grid();
            this.tabListPageEmployees = new Cyotek.Windows.Forms.TabListPage();
            this.EmployeesPanel = new System.Windows.Forms.Panel();
            this.EmployeesGrid = new SourceGrid.Grid();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.OrdersPanel.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.tabList1.SuspendLayout();
            this.tabListPageOrders.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tabListPageCustomers.SuspendLayout();
            this.CustomersPanel.SuspendLayout();
            this.tabListPageEmployees.SuspendLayout();
            this.EmployeesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(816, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSSL_User});
            this.statusStrip1.Location = new System.Drawing.Point(0, 518);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(816, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tSSL_User
            // 
            this.tSSL_User.AutoSize = false;
            this.tSSL_User.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tSSL_User.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.tSSL_User.IsLink = true;
            this.tSSL_User.Name = "tSSL_User";
            this.tSSL_User.Size = new System.Drawing.Size(200, 17);
            this.tSSL_User.Click += new System.EventHandler(this.tSSL_User_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_New});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(816, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_New
            // 
            this.toolStripButton_New.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_New.Image = global::ASF.Properties.Resources.NewDocument;
            this.toolStripButton_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_New.Name = "toolStripButton_New";
            this.toolStripButton_New.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_New.ToolTipText = "New document";
            this.toolStripButton_New.Click += new System.EventHandler(this.toolStripButton_New_Click);
            // 
            // OrdersPanel
            // 
            this.OrdersPanel.Controls.Add(this.OrdersGrid);
            this.OrdersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersPanel.Location = new System.Drawing.Point(0, 0);
            this.OrdersPanel.Name = "OrdersPanel";
            this.OrdersPanel.Size = new System.Drawing.Size(656, 434);
            this.OrdersPanel.TabIndex = 3;
            // 
            // OrdersGrid
            // 
            this.OrdersGrid.ContextMenuStrip = this.contextMenuStripGrid1;
            this.OrdersGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersGrid.EnableSort = true;
            this.OrdersGrid.Location = new System.Drawing.Point(0, 0);
            this.OrdersGrid.Name = "OrdersGrid";
            this.OrdersGrid.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.OrdersGrid.SelectionMode = SourceGrid.GridSelectionMode.Row;
            this.OrdersGrid.Size = new System.Drawing.Size(656, 434);
            this.OrdersGrid.TabIndex = 0;
            this.OrdersGrid.TabStop = true;
            this.OrdersGrid.ToolTipText = "";
            // 
            // contextMenuStripGrid1
            // 
            this.contextMenuStripGrid1.Name = "contextMenuStripGrid1";
            this.contextMenuStripGrid1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSCB_Filter,
            this.tSTB_Filter});
            this.toolStrip2.Location = new System.Drawing.Point(3, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(228, 25);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tSCB_Filter
            // 
            this.tSCB_Filter.Name = "tSCB_Filter";
            this.tSCB_Filter.Size = new System.Drawing.Size(121, 25);
            // 
            // tSTB_Filter
            // 
            this.tSTB_Filter.Name = "tSTB_Filter";
            this.tSTB_Filter.Size = new System.Drawing.Size(100, 25);
            // 
            // tabList1
            // 
            this.tabList1.Controls.Add(this.tabListPageOrders);
            this.tabList1.Controls.Add(this.tabListPageCustomers);
            this.tabList1.Controls.Add(this.tabListPageEmployees);
            this.tabList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabList1.Location = new System.Drawing.Point(0, 49);
            this.tabList1.Name = "tabList1";
            this.tabList1.Size = new System.Drawing.Size(816, 469);
            this.tabList1.TabIndex = 4;
            // 
            // tabListPageOrders
            // 
            this.tabListPageOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabListPageOrders.Controls.Add(this.toolStripContainer1);
            this.tabListPageOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabListPageOrders.Name = "tabListPageOrders";
            this.tabListPageOrders.Size = new System.Drawing.Size(658, 461);
            this.tabListPageOrders.TabIndex = 0;
            this.tabListPageOrders.Tag = "idocWindowOrder";
            this.tabListPageOrders.Text = "Замовлення";
            this.tabListPageOrders.Paint += new System.Windows.Forms.PaintEventHandler(this.tabListPageOrders_Paint);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.OrdersPanel);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(656, 434);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(656, 459);
            this.toolStripContainer1.TabIndex = 4;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip2);
            // 
            // tabListPageCustomers
            // 
            this.tabListPageCustomers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabListPageCustomers.Controls.Add(this.CustomersPanel);
            this.tabListPageCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabListPageCustomers.Name = "tabListPageCustomers";
            this.tabListPageCustomers.Size = new System.Drawing.Size(42, 192);
            this.tabListPageCustomers.TabIndex = 1;
            this.tabListPageCustomers.Tag = "idocCustomer";
            this.tabListPageCustomers.Text = "Клієнти";
            this.tabListPageCustomers.Paint += new System.Windows.Forms.PaintEventHandler(this.tabListPageCustomers_Paint);
            // 
            // CustomersPanel
            // 
            this.CustomersPanel.Controls.Add(this.CustomersGrid);
            this.CustomersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersPanel.Location = new System.Drawing.Point(0, 0);
            this.CustomersPanel.Name = "CustomersPanel";
            this.CustomersPanel.Size = new System.Drawing.Size(40, 190);
            this.CustomersPanel.TabIndex = 0;
            // 
            // CustomersGrid
            // 
            this.CustomersGrid.ContextMenuStrip = this.contextMenuStripGrid1;
            this.CustomersGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersGrid.EnableSort = true;
            this.CustomersGrid.Location = new System.Drawing.Point(0, 0);
            this.CustomersGrid.Name = "CustomersGrid";
            this.CustomersGrid.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.CustomersGrid.SelectionMode = SourceGrid.GridSelectionMode.Row;
            this.CustomersGrid.Size = new System.Drawing.Size(40, 190);
            this.CustomersGrid.TabIndex = 1;
            this.CustomersGrid.TabStop = true;
            this.CustomersGrid.ToolTipText = "";
            // 
            // tabListPageEmployees
            // 
            this.tabListPageEmployees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabListPageEmployees.Controls.Add(this.EmployeesPanel);
            this.tabListPageEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabListPageEmployees.Name = "tabListPageEmployees";
            this.tabListPageEmployees.Size = new System.Drawing.Size(42, 192);
            this.tabListPageEmployees.TabIndex = 2;
            this.tabListPageEmployees.Tag = "idocEmployee";
            this.tabListPageEmployees.Text = "Співробітники";
            this.tabListPageEmployees.Paint += new System.Windows.Forms.PaintEventHandler(this.tabListPageEmployees_Paint);
            // 
            // EmployeesPanel
            // 
            this.EmployeesPanel.Controls.Add(this.EmployeesGrid);
            this.EmployeesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeesPanel.Location = new System.Drawing.Point(0, 0);
            this.EmployeesPanel.Name = "EmployeesPanel";
            this.EmployeesPanel.Size = new System.Drawing.Size(40, 190);
            this.EmployeesPanel.TabIndex = 3;
            // 
            // EmployeesGrid
            // 
            this.EmployeesGrid.ContextMenuStrip = this.contextMenuStripGrid1;
            this.EmployeesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeesGrid.EnableSort = true;
            this.EmployeesGrid.Location = new System.Drawing.Point(0, 0);
            this.EmployeesGrid.Name = "EmployeesGrid";
            this.EmployeesGrid.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.EmployeesGrid.SelectionMode = SourceGrid.GridSelectionMode.Row;
            this.EmployeesGrid.Size = new System.Drawing.Size(40, 190);
            this.EmployeesGrid.TabIndex = 2;
            this.EmployeesGrid.TabStop = true;
            this.EmployeesGrid.ToolTipText = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 540);
            this.Controls.Add(this.tabList1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База даних компанії";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.OrdersPanel.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabList1.ResumeLayout(false);
            this.tabListPageOrders.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tabListPageCustomers.ResumeLayout(false);
            this.CustomersPanel.ResumeLayout(false);
            this.tabListPageEmployees.ResumeLayout(false);
            this.EmployeesPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel OrdersPanel;
        private SourceGrid.Grid OrdersGrid;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripGrid1;
        private System.Windows.Forms.ToolStripButton toolStripButton_New;
        private System.Windows.Forms.Panel CustomersPanel;
        private SourceGrid.Grid CustomersGrid;
        private SourceGrid.Grid EmployeesGrid;
        private System.Windows.Forms.Panel EmployeesPanel;
        private Cyotek.Windows.Forms.TabList tabList1;
        private Cyotek.Windows.Forms.TabListPage tabListPageOrders;
        private Cyotek.Windows.Forms.TabListPage tabListPageCustomers;
        private Cyotek.Windows.Forms.TabListPage tabListPageEmployees;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripComboBox tSCB_Filter;
        private System.Windows.Forms.ToolStripTextBox tSTB_Filter;
        private System.Windows.Forms.ToolStripStatusLabel tSSL_User;
    }
}


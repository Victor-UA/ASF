using Victors;

namespace ASF.Documents
{
    partial class WindowOrderForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.документToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusIsChanged = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusOwner = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tabList1 = new Cyotek.Windows.Forms.TabList();
            this.tabListPageMain = new Cyotek.Windows.Forms.TabListPage();
            this.MainPanel1 = new System.Windows.Forms.Panel();
            this.tB_RComment = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tB_AgreementNo = new System.Windows.Forms.TextBox();
            this.dTP_AgreementDate = new Victors.DateTimePicker();
            this.tB_OrderNo = new System.Windows.Forms.TextBox();
            this.dTP_ProdDate = new Victors.DateTimePicker();
            this.tB_Customer = new System.Windows.Forms.TextBox();
            this.dTP_DateOrder = new Victors.DateTimePicker();
            this.tB_TotalCost = new System.Windows.Forms.TextBox();
            this.tB_TotalPrice = new System.Windows.Forms.TextBox();
            this.tB_Currency = new System.Windows.Forms.TextBox();
            this.b_SelectCurrency = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.b_SelectCustomer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabListPageStates = new Cyotek.Windows.Forms.TabListPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grid_OrderStates = new SourceGrid.Grid();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Save = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tabList1.SuspendLayout();
            this.tabListPageMain.SuspendLayout();
            this.MainPanel1.SuspendLayout();
            this.tabListPageStates.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.документToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(930, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // документToolStripMenuItem
            // 
            this.документToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зберегтиToolStripMenuItem});
            this.документToolStripMenuItem.Name = "документToolStripMenuItem";
            this.документToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.документToolStripMenuItem.Text = "Документ";
            // 
            // зберегтиToolStripMenuItem
            // 
            this.зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            this.зберегтиToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.зберегтиToolStripMenuItem.Text = "Зберегти";
            this.зберегтиToolStripMenuItem.Click += new System.EventHandler(this.зберегтиToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusIsChanged,
            this.toolStripStatusOwner});
            this.statusStrip1.Location = new System.Drawing.Point(0, 485);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(930, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusIsChanged
            // 
            this.toolStripStatusIsChanged.AutoSize = false;
            this.toolStripStatusIsChanged.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusIsChanged.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusIsChanged.Name = "toolStripStatusIsChanged";
            this.toolStripStatusIsChanged.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusIsChanged.Size = new System.Drawing.Size(70, 17);
            this.toolStripStatusIsChanged.Text = "toolStripStatusIsChanged";
            // 
            // toolStripStatusOwner
            // 
            this.toolStripStatusOwner.AutoSize = false;
            this.toolStripStatusOwner.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusOwner.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusOwner.Name = "toolStripStatusOwner";
            this.toolStripStatusOwner.Size = new System.Drawing.Size(200, 17);
            this.toolStripStatusOwner.Text = "toolStripStatusOwner";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tabList1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(930, 436);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 24);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(930, 461);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // tabList1
            // 
            this.tabList1.Controls.Add(this.tabListPageMain);
            this.tabList1.Controls.Add(this.tabListPageStates);
            this.tabList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabList1.Location = new System.Drawing.Point(0, 0);
            this.tabList1.Name = "tabList1";
            this.tabList1.Size = new System.Drawing.Size(930, 436);
            this.tabList1.TabIndex = 0;
            // 
            // tabListPageMain
            // 
            this.tabListPageMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabListPageMain.Controls.Add(this.MainPanel1);
            this.tabListPageMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabListPageMain.Name = "tabListPageMain";
            this.tabListPageMain.Size = new System.Drawing.Size(772, 428);
            this.tabListPageMain.TabIndex = 0;
            this.tabListPageMain.Text = "Загальне";
            // 
            // MainPanel1
            // 
            this.MainPanel1.AutoScroll = true;
            this.MainPanel1.Controls.Add(this.tB_RComment);
            this.MainPanel1.Controls.Add(this.label9);
            this.MainPanel1.Controls.Add(this.tB_AgreementNo);
            this.MainPanel1.Controls.Add(this.dTP_AgreementDate);
            this.MainPanel1.Controls.Add(this.tB_OrderNo);
            this.MainPanel1.Controls.Add(this.dTP_ProdDate);
            this.MainPanel1.Controls.Add(this.tB_Customer);
            this.MainPanel1.Controls.Add(this.dTP_DateOrder);
            this.MainPanel1.Controls.Add(this.tB_TotalCost);
            this.MainPanel1.Controls.Add(this.tB_TotalPrice);
            this.MainPanel1.Controls.Add(this.tB_Currency);
            this.MainPanel1.Controls.Add(this.b_SelectCurrency);
            this.MainPanel1.Controls.Add(this.label8);
            this.MainPanel1.Controls.Add(this.b_SelectCustomer);
            this.MainPanel1.Controls.Add(this.label7);
            this.MainPanel1.Controls.Add(this.label6);
            this.MainPanel1.Controls.Add(this.label5);
            this.MainPanel1.Controls.Add(this.label1);
            this.MainPanel1.Controls.Add(this.label3);
            this.MainPanel1.Controls.Add(this.label2);
            this.MainPanel1.Controls.Add(this.label4);
            this.MainPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel1.Location = new System.Drawing.Point(0, 0);
            this.MainPanel1.Name = "MainPanel1";
            this.MainPanel1.Size = new System.Drawing.Size(770, 426);
            this.MainPanel1.TabIndex = 0;
            // 
            // tB_RComment
            // 
            this.tB_RComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_RComment.Location = new System.Drawing.Point(99, 133);
            this.tB_RComment.Multiline = true;
            this.tB_RComment.Name = "tB_RComment";
            this.tB_RComment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tB_RComment.Size = new System.Drawing.Size(631, 293);
            this.tB_RComment.TabIndex = 19;
            this.tB_RComment.WordWrap = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Коментар";
            // 
            // tB_AgreementNo
            // 
            this.tB_AgreementNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_AgreementNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tB_AgreementNo.Location = new System.Drawing.Point(99, 29);
            this.tB_AgreementNo.Name = "tB_AgreementNo";
            this.tB_AgreementNo.Size = new System.Drawing.Size(404, 20);
            this.tB_AgreementNo.TabIndex = 2;
            this.tB_AgreementNo.TextChanged += new System.EventHandler(this.tB_AgreementNo_TextChanged);
            // 
            // dTP_AgreementDate
            // 
            this.dTP_AgreementDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dTP_AgreementDate.Location = new System.Drawing.Point(621, 29);
            this.dTP_AgreementDate.Name = "dTP_AgreementDate";
            this.dTP_AgreementDate.Size = new System.Drawing.Size(146, 20);
            this.dTP_AgreementDate.TabIndex = 3;
            this.dTP_AgreementDate.Value = new System.DateTime(2015, 10, 7, 22, 52, 46, 0);
            this.dTP_AgreementDate.ValueChanged += new System.EventHandler(this.dTP_AgreementDate_ValueChanged);
            // 
            // tB_OrderNo
            // 
            this.tB_OrderNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_OrderNo.Location = new System.Drawing.Point(99, 3);
            this.tB_OrderNo.Name = "tB_OrderNo";
            this.tB_OrderNo.Size = new System.Drawing.Size(404, 20);
            this.tB_OrderNo.TabIndex = 0;
            this.tB_OrderNo.TextChanged += new System.EventHandler(this.tB_OrderNo_TextChanged);
            // 
            // dTP_ProdDate
            // 
            this.dTP_ProdDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dTP_ProdDate.Location = new System.Drawing.Point(621, 3);
            this.dTP_ProdDate.Name = "dTP_ProdDate";
            this.dTP_ProdDate.Size = new System.Drawing.Size(146, 20);
            this.dTP_ProdDate.TabIndex = 1;
            this.dTP_ProdDate.Value = new System.DateTime(2015, 10, 7, 22, 52, 46, 0);
            this.dTP_ProdDate.ValueChanged += new System.EventHandler(this.dTP_ProdDate_ValueChanged);
            // 
            // tB_Customer
            // 
            this.tB_Customer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_Customer.BackColor = System.Drawing.SystemColors.Window;
            this.tB_Customer.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tB_Customer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tB_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_Customer.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tB_Customer.Location = new System.Drawing.Point(99, 55);
            this.tB_Customer.Name = "tB_Customer";
            this.tB_Customer.ReadOnly = true;
            this.tB_Customer.Size = new System.Drawing.Size(371, 20);
            this.tB_Customer.TabIndex = 4;
            this.tB_Customer.Click += new System.EventHandler(this.tB_Customer_Click);
            this.tB_Customer.TextChanged += new System.EventHandler(this.tB_Customer_TextChanged);
            // 
            // dTP_DateOrder
            // 
            this.dTP_DateOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dTP_DateOrder.Location = new System.Drawing.Point(621, 55);
            this.dTP_DateOrder.Name = "dTP_DateOrder";
            this.dTP_DateOrder.Size = new System.Drawing.Size(146, 20);
            this.dTP_DateOrder.TabIndex = 6;
            this.dTP_DateOrder.Value = new System.DateTime(2015, 10, 7, 22, 51, 11, 34);
            this.dTP_DateOrder.ValueChanged += new System.EventHandler(this.dTP_DateOrder_ValueChanged);
            // 
            // tB_TotalCost
            // 
            this.tB_TotalCost.Location = new System.Drawing.Point(99, 81);
            this.tB_TotalCost.Name = "tB_TotalCost";
            this.tB_TotalCost.Size = new System.Drawing.Size(156, 20);
            this.tB_TotalCost.TabIndex = 7;
            this.tB_TotalCost.Tag = "0";
            this.tB_TotalCost.TextChanged += new System.EventHandler(this.tB_TotalCost_TextChanged);
            this.tB_TotalCost.Enter += new System.EventHandler(this.tB_TotalCost_Enter);
            this.tB_TotalCost.Leave += new System.EventHandler(this.tB_TotalCost_Leave);
            // 
            // tB_TotalPrice
            // 
            this.tB_TotalPrice.Location = new System.Drawing.Point(99, 107);
            this.tB_TotalPrice.Name = "tB_TotalPrice";
            this.tB_TotalPrice.Size = new System.Drawing.Size(156, 20);
            this.tB_TotalPrice.TabIndex = 8;
            this.tB_TotalPrice.Tag = "0";
            this.tB_TotalPrice.TextChanged += new System.EventHandler(this.tB_TotalPrice_TextChanged);
            this.tB_TotalPrice.Enter += new System.EventHandler(this.tB_TotalPrice_Enter);
            this.tB_TotalPrice.Leave += new System.EventHandler(this.tB_TotalPrice_Leave);
            // 
            // tB_Currency
            // 
            this.tB_Currency.BackColor = System.Drawing.SystemColors.Window;
            this.tB_Currency.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tB_Currency.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tB_Currency.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_Currency.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tB_Currency.Location = new System.Drawing.Point(261, 107);
            this.tB_Currency.Name = "tB_Currency";
            this.tB_Currency.ReadOnly = true;
            this.tB_Currency.Size = new System.Drawing.Size(60, 20);
            this.tB_Currency.TabIndex = 9;
            this.tB_Currency.TextChanged += new System.EventHandler(this.tB_Currency_TextChanged);
            // 
            // b_SelectCurrency
            // 
            this.b_SelectCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.b_SelectCurrency.Location = new System.Drawing.Point(327, 105);
            this.b_SelectCurrency.Name = "b_SelectCurrency";
            this.b_SelectCurrency.Size = new System.Drawing.Size(27, 23);
            this.b_SelectCurrency.TabIndex = 10;
            this.b_SelectCurrency.Text = "...";
            this.b_SelectCurrency.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Вартість";
            // 
            // b_SelectCustomer
            // 
            this.b_SelectCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_SelectCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.b_SelectCustomer.Location = new System.Drawing.Point(476, 53);
            this.b_SelectCustomer.Name = "b_SelectCustomer";
            this.b_SelectCustomer.Size = new System.Drawing.Size(27, 23);
            this.b_SelectCustomer.TabIndex = 5;
            this.b_SelectCustomer.Text = "...";
            this.b_SelectCustomer.UseVisualStyleBackColor = true;
            this.b_SelectCustomer.Click += new System.EventHandler(this.b_SelectCustomer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Собівартість";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(509, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Дата виготовлення";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Клієнт";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Найменування";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата договору";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Дата готовності";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Номер договору";
            // 
            // tabListPageStates
            // 
            this.tabListPageStates.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabListPageStates.Controls.Add(this.panel2);
            this.tabListPageStates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabListPageStates.Name = "tabListPageStates";
            this.tabListPageStates.Size = new System.Drawing.Size(42, 192);
            this.tabListPageStates.TabIndex = 1;
            this.tabListPageStates.Text = "Стан";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grid_OrderStates);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(38, 188);
            this.panel2.TabIndex = 0;
            // 
            // grid_OrderStates
            // 
            this.grid_OrderStates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_OrderStates.EnableSort = true;
            this.grid_OrderStates.Location = new System.Drawing.Point(0, 0);
            this.grid_OrderStates.Name = "grid_OrderStates";
            this.grid_OrderStates.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid_OrderStates.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid_OrderStates.Size = new System.Drawing.Size(38, 188);
            this.grid_OrderStates.TabIndex = 1;
            this.grid_OrderStates.TabStop = true;
            this.grid_OrderStates.ToolTipText = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Save});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(35, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripButton_Save
            // 
            this.toolStripButton_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Save.Image = global::ASF.Properties.Resources.Save;
            this.toolStripButton_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Save.Name = "toolStripButton_Save";
            this.toolStripButton_Save.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Save.Text = "toolStripButton1";
            this.toolStripButton_Save.Click += new System.EventHandler(this.toolStripButton_Save_Click);
            // 
            // WindowOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 507);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "WindowOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Замовлення";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WindowOrderForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tabList1.ResumeLayout(false);
            this.tabListPageMain.ResumeLayout(false);
            this.MainPanel1.ResumeLayout(false);
            this.MainPanel1.PerformLayout();
            this.tabListPageStates.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private Cyotek.Windows.Forms.TabList tabList1;
        private Cyotek.Windows.Forms.TabListPage tabListPageMain;
        public Victors.DateTimePicker dTP_AgreementDate;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tB_AgreementNo;
        private System.Windows.Forms.Label label4;
        public Victors.DateTimePicker dTP_DateOrder;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tB_OrderNo;
        private System.Windows.Forms.Label label1;
        private Cyotek.Windows.Forms.TabListPage tabListPageStates;
        private System.Windows.Forms.Panel MainPanel1;
        private System.Windows.Forms.Panel panel2;
        private SourceGrid.Grid grid_OrderStates;
        private System.Windows.Forms.ToolStripMenuItem документToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusIsChanged;
        public System.Windows.Forms.TextBox tB_Customer;
        private System.Windows.Forms.Label label5;
        public DateTimePicker dTP_ProdDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button b_SelectCustomer;
        public System.Windows.Forms.TextBox tB_TotalCost;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox tB_TotalPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button b_SelectCurrency;
        public System.Windows.Forms.TextBox tB_Currency;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusOwner;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem зберегтиToolStripMenuItem;
        public System.Windows.Forms.TextBox tB_RComment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Save;
    }
}
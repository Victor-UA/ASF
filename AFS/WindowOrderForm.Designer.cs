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
        private void InitializeComponent(string key)
        {
            Key = key;
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tabList1 = new Cyotek.Windows.Forms.TabList();
            this.tabListPageMain = new Cyotek.Windows.Forms.TabListPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tB_OrderNo = new System.Windows.Forms.TextBox();
            this.dTP_AgreementDate = new Victors.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_AgreementNo = new System.Windows.Forms.TextBox();
            this.dTP_DateOrder = new Victors.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tabListPageStates = new Cyotek.Windows.Forms.TabListPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grid_OrderStates = new SourceGrid.Grid();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tabList1.SuspendLayout();
            this.tabListPageMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabListPageStates.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(921, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 464);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(921, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tabList1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(921, 415);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 24);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(921, 440);
            this.toolStripContainer1.TabIndex = 4;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // tabList1
            // 
            this.tabList1.Controls.Add(this.tabListPageMain);
            this.tabList1.Controls.Add(this.tabListPageStates);
            this.tabList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabList1.Location = new System.Drawing.Point(0, 0);
            this.tabList1.Name = "tabList1";
            this.tabList1.Size = new System.Drawing.Size(921, 415);
            this.tabList1.TabIndex = 0;
            // 
            // tabListPageMain
            // 
            this.tabListPageMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabListPageMain.Controls.Add(this.panel1);
            this.tabListPageMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabListPageMain.Name = "tabListPageMain";
            this.tabListPageMain.Size = new System.Drawing.Size(763, 407);
            this.tabListPageMain.TabIndex = 0;
            this.tabListPageMain.Text = "Загальне";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tB_OrderNo);
            this.panel1.Controls.Add(this.dTP_AgreementDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tB_AgreementNo);
            this.panel1.Controls.Add(this.dTP_DateOrder);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 405);
            this.panel1.TabIndex = 32;
            // 
            // tB_OrderNo
            // 
            this.tB_OrderNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_OrderNo.Location = new System.Drawing.Point(99, 3);
            this.tB_OrderNo.Name = "tB_OrderNo";
            this.tB_OrderNo.Size = new System.Drawing.Size(413, 20);
            this.tB_OrderNo.TabIndex = 25;
            // 
            // dTP_AgreementDate
            // 
            this.dTP_AgreementDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dTP_AgreementDate.Location = new System.Drawing.Point(612, 29);
            this.dTP_AgreementDate.Name = "dTP_AgreementDate";
            this.dTP_AgreementDate.Size = new System.Drawing.Size(146, 20);
            this.dTP_AgreementDate.TabIndex = 31;
            this.dTP_AgreementDate.Value = new System.DateTime(2015, 10, 7, 22, 52, 46, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Найменування";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Дата договору";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(518, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Дата реєстрації";
            // 
            // tB_AgreementNo
            // 
            this.tB_AgreementNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_AgreementNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tB_AgreementNo.Location = new System.Drawing.Point(99, 29);
            this.tB_AgreementNo.Name = "tB_AgreementNo";
            this.tB_AgreementNo.Size = new System.Drawing.Size(413, 20);
            this.tB_AgreementNo.TabIndex = 29;
            // 
            // dTP_DateOrder
            // 
            this.dTP_DateOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dTP_DateOrder.Location = new System.Drawing.Point(612, 3);
            this.dTP_DateOrder.Name = "dTP_DateOrder";
            this.dTP_DateOrder.Size = new System.Drawing.Size(146, 20);
            this.dTP_DateOrder.TabIndex = 27;
            this.dTP_DateOrder.Value = new System.DateTime(2015, 10, 7, 22, 51, 11, 34);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 28;
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
            // WindowOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 486);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(600, 38);
            this.Name = "WindowOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WindowForm";
            this.Load += new System.EventHandler(this.WindowOrderForm_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tabList1.ResumeLayout(false);
            this.tabListPageMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabListPageStates.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        public string Key { get; private set; }
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private Cyotek.Windows.Forms.TabList tabList1;
        private Cyotek.Windows.Forms.TabListPage tabListPageMain;
        private Victors.DateTimePicker dTP_AgreementDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_AgreementNo;
        private System.Windows.Forms.Label label4;
        private Victors.DateTimePicker dTP_DateOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tB_OrderNo;
        private System.Windows.Forms.Label label1;
        private Cyotek.Windows.Forms.TabListPage tabListPageStates;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private SourceGrid.Grid grid_OrderStates;
    }
}
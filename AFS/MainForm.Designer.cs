﻿namespace AFS
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grid1 = new SourceGrid.Grid();
            this.contextMenuStripGrid1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabList1 = new Cyotek.Windows.Forms.TabList();
            this.tabListPageOrders = new Cyotek.Windows.Forms.TabListPage();
            this.tabListPageContragents = new Cyotek.Windows.Forms.TabListPage();
            this.tabListPageEmployee = new Cyotek.Windows.Forms.TabListPage();
            this.panel1.SuspendLayout();
            this.tabList1.SuspendLayout();
            this.tabListPageOrders.SuspendLayout();
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 518);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(816, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(816, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grid1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 459);
            this.panel1.TabIndex = 3;
            // 
            // grid1
            // 
            this.grid1.ContextMenuStrip = this.contextMenuStripGrid1;
            this.grid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid1.EnableSort = true;
            this.grid1.Location = new System.Drawing.Point(0, 0);
            this.grid1.Name = "grid1";
            this.grid1.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid1.SelectionMode = SourceGrid.GridSelectionMode.Row;
            this.grid1.Size = new System.Drawing.Size(656, 459);
            this.grid1.TabIndex = 0;
            this.grid1.TabStop = true;
            this.grid1.ToolTipText = "";
            // 
            // contextMenuStripGrid1
            // 
            this.contextMenuStripGrid1.Name = "contextMenuStripGrid1";
            this.contextMenuStripGrid1.Size = new System.Drawing.Size(61, 4);
            // 
            // tabList1
            // 
            this.tabList1.Controls.Add(this.tabListPageOrders);
            this.tabList1.Controls.Add(this.tabListPageContragents);
            this.tabList1.Controls.Add(this.tabListPageEmployee);
            this.tabList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabList1.Location = new System.Drawing.Point(0, 49);
            this.tabList1.Name = "tabList1";
            this.tabList1.Size = new System.Drawing.Size(816, 469);
            this.tabList1.TabIndex = 4;
            // 
            // tabListPageOrders
            // 
            this.tabListPageOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabListPageOrders.Controls.Add(this.panel1);
            this.tabListPageOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabListPageOrders.Name = "tabListPageOrders";
            this.tabListPageOrders.Size = new System.Drawing.Size(658, 461);
            this.tabListPageOrders.TabIndex = 0;
            this.tabListPageOrders.Text = "Замовлення";
            this.tabListPageOrders.Paint += new System.Windows.Forms.PaintEventHandler(this.tabListPageOrders_Paint);
            // 
            // tabListPageContragents
            // 
            this.tabListPageContragents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabListPageContragents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabListPageContragents.Name = "tabListPageContragents";
            this.tabListPageContragents.Size = new System.Drawing.Size(658, 461);
            this.tabListPageContragents.TabIndex = 1;
            this.tabListPageContragents.Text = "Клієнти";
            // 
            // tabListPageEmployee
            // 
            this.tabListPageEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabListPageEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabListPageEmployee.Name = "tabListPageEmployee";
            this.tabListPageEmployee.Size = new System.Drawing.Size(658, 461);
            this.tabListPageEmployee.TabIndex = 2;
            this.tabListPageEmployee.Text = "Співробітники";
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
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.tabList1.ResumeLayout(false);
            this.tabListPageOrders.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private SourceGrid.Grid grid1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripGrid1;
        private Cyotek.Windows.Forms.TabList tabList1;
        private Cyotek.Windows.Forms.TabListPage tabListPageOrders;
        private Cyotek.Windows.Forms.TabListPage tabListPageContragents;
        private Cyotek.Windows.Forms.TabListPage tabListPageEmployee;
    }
}

namespace ASF.Documents
{
    partial class OrderStateForm
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
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tB_RComment = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tB_StateType = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tB_Switchover = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tB_Index = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tB_Level = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_Code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Save = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusIsChanged = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusOwner = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.документToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.b_SelectOrderState = new System.Windows.Forms.Button();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(584, 286);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 24);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(584, 311);
            this.toolStripContainer1.TabIndex = 3;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.b_SelectOrderState);
            this.panel1.Controls.Add(this.tB_RComment);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.tB_StateType);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tB_Switchover);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tB_Index);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tB_Level);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tB_Code);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tB_Name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 286);
            this.panel1.TabIndex = 0;
            // 
            // tB_RComment
            // 
            this.tB_RComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_RComment.Location = new System.Drawing.Point(108, 159);
            this.tB_RComment.Multiline = true;
            this.tB_RComment.Name = "tB_RComment";
            this.tB_RComment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tB_RComment.Size = new System.Drawing.Size(462, 123);
            this.tB_RComment.TabIndex = 6;
            this.tB_RComment.WordWrap = false;
            this.tB_RComment.TextChanged += new System.EventHandler(this.tB_RComment_TextChanged);
            this.tB_RComment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Global_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Коментар";
            // 
            // tB_StateType
            // 
            this.tB_StateType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_StateType.Location = new System.Drawing.Point(108, 55);
            this.tB_StateType.Name = "tB_StateType";
            this.tB_StateType.ReadOnly = true;
            this.tB_StateType.Size = new System.Drawing.Size(462, 20);
            this.tB_StateType.TabIndex = 2;
            this.tB_StateType.Text = "0";
            this.tB_StateType.TextChanged += new System.EventHandler(this.tB_StateType_TextChanged);
            this.tB_StateType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Global_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Тип";
            // 
            // tB_Switchover
            // 
            this.tB_Switchover.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_Switchover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_Switchover.ForeColor = System.Drawing.Color.Blue;
            this.tB_Switchover.Location = new System.Drawing.Point(108, 133);
            this.tB_Switchover.Name = "tB_Switchover";
            this.tB_Switchover.Size = new System.Drawing.Size(429, 20);
            this.tB_Switchover.TabIndex = 5;
            this.tB_Switchover.Click += new System.EventHandler(this.tB_Switchover_Click);
            this.tB_Switchover.TextChanged += new System.EventHandler(this.tB_Switchover_TextChanged);
            this.tB_Switchover.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Global_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Стан переходу";
            // 
            // tB_Index
            // 
            this.tB_Index.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_Index.Location = new System.Drawing.Point(108, 107);
            this.tB_Index.Name = "tB_Index";
            this.tB_Index.Size = new System.Drawing.Size(462, 20);
            this.tB_Index.TabIndex = 4;
            this.tB_Index.TextChanged += new System.EventHandler(this.tB_Index_TextChanged);
            this.tB_Index.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Global_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Індекс";
            // 
            // tB_Level
            // 
            this.tB_Level.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_Level.Location = new System.Drawing.Point(108, 81);
            this.tB_Level.Name = "tB_Level";
            this.tB_Level.Size = new System.Drawing.Size(462, 20);
            this.tB_Level.TabIndex = 3;
            this.tB_Level.TextChanged += new System.EventHandler(this.tB_Level_TextChanged);
            this.tB_Level.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Global_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Рівень";
            // 
            // tB_Code
            // 
            this.tB_Code.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_Code.Location = new System.Drawing.Point(108, 29);
            this.tB_Code.Name = "tB_Code";
            this.tB_Code.Size = new System.Drawing.Size(462, 20);
            this.tB_Code.TabIndex = 1;
            this.tB_Code.TextChanged += new System.EventHandler(this.tB_Code_TextChanged);
            this.tB_Code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Global_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Код";
            // 
            // tB_Name
            // 
            this.tB_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_Name.Location = new System.Drawing.Point(108, 3);
            this.tB_Name.Name = "tB_Name";
            this.tB_Name.Size = new System.Drawing.Size(462, 20);
            this.tB_Name.TabIndex = 0;
            this.tB_Name.TextChanged += new System.EventHandler(this.tB_Name_TextChanged);
            this.tB_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Global_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Найменування";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Save});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(26, 25);
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusIsChanged,
            this.toolStripStatusOwner});
            this.statusStrip1.Location = new System.Drawing.Point(0, 335);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.TabIndex = 2;
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
            this.toolStripStatusOwner.IsLink = true;
            this.toolStripStatusOwner.Name = "toolStripStatusOwner";
            this.toolStripStatusOwner.Size = new System.Drawing.Size(200, 17);
            this.toolStripStatusOwner.Text = "toolStripStatusOwner";
            this.toolStripStatusOwner.Click += new System.EventHandler(this.toolStripStatusOwner_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.документToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 1;
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
            // b_SelectOrderState
            // 
            this.b_SelectOrderState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_SelectOrderState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.b_SelectOrderState.Location = new System.Drawing.Point(543, 130);
            this.b_SelectOrderState.Name = "b_SelectOrderState";
            this.b_SelectOrderState.Size = new System.Drawing.Size(27, 23);
            this.b_SelectOrderState.TabIndex = 30;
            this.b_SelectOrderState.Text = "...";
            this.b_SelectOrderState.UseVisualStyleBackColor = true;
            // 
            // OrderStateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 357);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(600, 294);
            this.Name = "OrderStateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Стан замовлення";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderStateForm_FormClosing);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem документToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusIsChanged;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusOwner;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Save;
        public System.Windows.Forms.TextBox tB_Name;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tB_Code;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tB_Switchover;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tB_Index;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tB_Level;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tB_StateType;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox tB_RComment;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button b_SelectOrderState;
    }
}
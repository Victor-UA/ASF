namespace ASF.Documents
{
    partial class EmployeeForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dTP_Birthday = new Victors.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.tB_Middlename = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tB_Name = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tB_Surname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tB_RComment = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tB_Email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tB_PostalCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tB_Country = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tB_District = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tB_Region = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tB_City = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tB_Address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_Phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_Title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.cB_Locked = new System.Windows.Forms.CheckBox();
            this.tB_UserPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tB_UserName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Save = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusIsChanged = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusOwner = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.документToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tabControl1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(584, 501);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 24);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(584, 526);
            this.toolStripContainer1.TabIndex = 3;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(584, 501);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Global_KeyPress);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(576, 475);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Загальна інформація";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dTP_Birthday);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.tB_Middlename);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.tB_Name);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.tB_Surname);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.tB_RComment);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.tB_Email);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tB_PostalCode);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tB_Country);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tB_District);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tB_Region);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tB_City);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tB_Address);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tB_Phone);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tB_Title);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 469);
            this.panel1.TabIndex = 0;
            // 
            // dTP_Birthday
            // 
            this.dTP_Birthday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dTP_Birthday.CustomFormat = " ";
            this.dTP_Birthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP_Birthday.Location = new System.Drawing.Point(116, 315);
            this.dTP_Birthday.Name = "dTP_Birthday";
            this.dTP_Birthday.Size = new System.Drawing.Size(146, 20);
            this.dTP_Birthday.TabIndex = 38;
            this.dTP_Birthday.Value = new System.DateTime(2015, 12, 27, 9, 14, 17, 0);
            this.dTP_Birthday.ValueChanged += new System.EventHandler(this.dTP_Birthday_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 318);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "День народження";
            // 
            // tB_Middlename
            // 
            this.tB_Middlename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_Middlename.Location = new System.Drawing.Point(116, 81);
            this.tB_Middlename.Name = "tB_Middlename";
            this.tB_Middlename.Size = new System.Drawing.Size(448, 20);
            this.tB_Middlename.TabIndex = 3;
            this.tB_Middlename.Tag = "wasEmpty";
            this.tB_Middlename.TextChanged += new System.EventHandler(this.tB_Middlename_TextChanged);
            this.tB_Middlename.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Global_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "По батькові";
            // 
            // tB_Name
            // 
            this.tB_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_Name.Location = new System.Drawing.Point(116, 55);
            this.tB_Name.Name = "tB_Name";
            this.tB_Name.Size = new System.Drawing.Size(448, 20);
            this.tB_Name.TabIndex = 2;
            this.tB_Name.Tag = "wasEmpty";
            this.tB_Name.TextChanged += new System.EventHandler(this.tB_Name_TextChanged);
            this.tB_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Global_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Ім\'я";
            // 
            // tB_Surname
            // 
            this.tB_Surname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_Surname.Location = new System.Drawing.Point(116, 29);
            this.tB_Surname.Name = "tB_Surname";
            this.tB_Surname.Size = new System.Drawing.Size(448, 20);
            this.tB_Surname.TabIndex = 1;
            this.tB_Surname.Tag = "wasEmpty";
            this.tB_Surname.TextChanged += new System.EventHandler(this.tB_Surname_TextChanged);
            this.tB_Surname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Global_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Прізвище";
            // 
            // tB_RComment
            // 
            this.tB_RComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_RComment.Location = new System.Drawing.Point(116, 341);
            this.tB_RComment.Multiline = true;
            this.tB_RComment.Name = "tB_RComment";
            this.tB_RComment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tB_RComment.Size = new System.Drawing.Size(448, 123);
            this.tB_RComment.TabIndex = 12;
            this.tB_RComment.WordWrap = false;
            this.tB_RComment.TextChanged += new System.EventHandler(this.tB_RComment_TextChanged);
            this.tB_RComment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Global_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 344);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Коментар";
            // 
            // tB_Email
            // 
            this.tB_Email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_Email.Location = new System.Drawing.Point(116, 133);
            this.tB_Email.Name = "tB_Email";
            this.tB_Email.Size = new System.Drawing.Size(448, 20);
            this.tB_Email.TabIndex = 5;
            this.tB_Email.TextChanged += new System.EventHandler(this.tB_Email_TextChanged);
            this.tB_Email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Global_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Email";
            // 
            // tB_PostalCode
            // 
            this.tB_PostalCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_PostalCode.Location = new System.Drawing.Point(116, 289);
            this.tB_PostalCode.Name = "tB_PostalCode";
            this.tB_PostalCode.Size = new System.Drawing.Size(448, 20);
            this.tB_PostalCode.TabIndex = 11;
            this.tB_PostalCode.TextChanged += new System.EventHandler(this.tB_PostalCode_TextChanged);
            this.tB_PostalCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Global_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Поштовий код";
            // 
            // tB_Country
            // 
            this.tB_Country.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_Country.Location = new System.Drawing.Point(116, 263);
            this.tB_Country.Name = "tB_Country";
            this.tB_Country.Size = new System.Drawing.Size(448, 20);
            this.tB_Country.TabIndex = 10;
            this.tB_Country.TextChanged += new System.EventHandler(this.tB_Country_TextChanged);
            this.tB_Country.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Global_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Країна";
            // 
            // tB_District
            // 
            this.tB_District.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_District.Location = new System.Drawing.Point(116, 237);
            this.tB_District.Name = "tB_District";
            this.tB_District.Size = new System.Drawing.Size(448, 20);
            this.tB_District.TabIndex = 9;
            this.tB_District.TextChanged += new System.EventHandler(this.tB_District_TextChanged);
            this.tB_District.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Global_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Область";
            // 
            // tB_Region
            // 
            this.tB_Region.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_Region.Location = new System.Drawing.Point(116, 211);
            this.tB_Region.Name = "tB_Region";
            this.tB_Region.Size = new System.Drawing.Size(448, 20);
            this.tB_Region.TabIndex = 8;
            this.tB_Region.TextChanged += new System.EventHandler(this.tB_Region_TextChanged);
            this.tB_Region.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Global_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Район";
            // 
            // tB_City
            // 
            this.tB_City.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_City.Location = new System.Drawing.Point(116, 185);
            this.tB_City.Name = "tB_City";
            this.tB_City.Size = new System.Drawing.Size(448, 20);
            this.tB_City.TabIndex = 7;
            this.tB_City.TextChanged += new System.EventHandler(this.tB_City_TextChanged);
            this.tB_City.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Global_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Місто";
            // 
            // tB_Address
            // 
            this.tB_Address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_Address.Location = new System.Drawing.Point(116, 159);
            this.tB_Address.Name = "tB_Address";
            this.tB_Address.Size = new System.Drawing.Size(448, 20);
            this.tB_Address.TabIndex = 6;
            this.tB_Address.TextChanged += new System.EventHandler(this.tB_Address_TextChanged);
            this.tB_Address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Global_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Адреса";
            // 
            // tB_Phone
            // 
            this.tB_Phone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_Phone.Location = new System.Drawing.Point(116, 107);
            this.tB_Phone.Name = "tB_Phone";
            this.tB_Phone.Size = new System.Drawing.Size(448, 20);
            this.tB_Phone.TabIndex = 4;
            this.tB_Phone.TextChanged += new System.EventHandler(this.tB_Phone_TextChanged);
            this.tB_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Global_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "№ телефону";
            // 
            // tB_Title
            // 
            this.tB_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_Title.Location = new System.Drawing.Point(116, 3);
            this.tB_Title.Name = "tB_Title";
            this.tB_Title.Size = new System.Drawing.Size(448, 20);
            this.tB_Title.TabIndex = 0;
            this.tB_Title.Tag = "wasEmpty";
            this.tB_Title.TextChanged += new System.EventHandler(this.tB_Title_TextChanged);
            this.tB_Title.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Global_KeyPress);
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
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(576, 475);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Дані користувача";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.cB_Locked);
            this.panel2.Controls.Add(this.tB_UserPassword);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.tB_UserName);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(570, 469);
            this.panel2.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 56);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "Заблоковано";
            // 
            // cB_Locked
            // 
            this.cB_Locked.AutoSize = true;
            this.cB_Locked.Location = new System.Drawing.Point(116, 55);
            this.cB_Locked.Name = "cB_Locked";
            this.cB_Locked.Size = new System.Drawing.Size(15, 14);
            this.cB_Locked.TabIndex = 36;
            this.cB_Locked.UseVisualStyleBackColor = true;
            this.cB_Locked.Click += new System.EventHandler(this.cB_Locked_Click);
            // 
            // tB_UserPassword
            // 
            this.tB_UserPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_UserPassword.Location = new System.Drawing.Point(116, 29);
            this.tB_UserPassword.Name = "tB_UserPassword";
            this.tB_UserPassword.PasswordChar = '*';
            this.tB_UserPassword.Size = new System.Drawing.Size(448, 20);
            this.tB_UserPassword.TabIndex = 33;
            this.tB_UserPassword.Tag = "wasEmpty";
            this.tB_UserPassword.TextChanged += new System.EventHandler(this.tB_Password_TextChanged);
            this.tB_UserPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Global_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Пароль";
            this.label10.DoubleClick += new System.EventHandler(this.label10_DoubleClick);
            // 
            // tB_UserName
            // 
            this.tB_UserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_UserName.Location = new System.Drawing.Point(116, 3);
            this.tB_UserName.Name = "tB_UserName";
            this.tB_UserName.Size = new System.Drawing.Size(448, 20);
            this.tB_UserName.TabIndex = 32;
            this.tB_UserName.Tag = "wasEmpty";
            this.tB_UserName.TextChanged += new System.EventHandler(this.tB_Login_TextChanged);
            this.tB_UserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Global_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "Ім\'я коистувача";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Save});
            this.toolStrip1.Location = new System.Drawing.Point(6, 0);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 550);
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
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 572);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(600, 294);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Працівник";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeForm_FormClosing);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        public System.Windows.Forms.TextBox tB_Title;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tB_Phone;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tB_District;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tB_Region;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tB_City;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tB_Address;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tB_Country;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox tB_PostalCode;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox tB_Email;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox tB_RComment;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox tB_Middlename;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox tB_Name;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox tB_Surname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox tB_UserPassword;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox tB_UserName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.CheckBox cB_Locked;
        private System.Windows.Forms.Label label17;
        public Victors.DateTimePicker dTP_Birthday;
    }
}
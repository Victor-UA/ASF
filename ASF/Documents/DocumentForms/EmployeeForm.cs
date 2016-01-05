using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ASF.Documents
{
    public partial class EmployeeForm : DocumentForm
    {
        public EmployeeForm(idocEmployee document) : base()
        {
            Document = document;
            InitializeComponent();
            dTP_Birthday.Value = DateTime.Now;
            dTP_Birthday.Format = DateTimePickerFormat.Long;
        }
        private idocEmployee Document { get; set; }

        public bool ReadOnly
        {
            get
            {
                return _ReadOnly;
            }
            set
            {
                _ReadOnly = value;
            }
        }

        public override bool isChanged
        {
            get
            {
                return _isChanged;
            }
            set
            {
                _isChanged = value;
                CheckFieldsMain();
                toolStripStatusIsChanged.Text = value ? "Змінено" : "";
                toolStripStatusIsChanged.ForeColor = CanBeSaved ? Color.DarkGreen : Color.DarkRed;
            }
        }
        public bool CanBeSaved
        {
            get
            {
                return _CanBeSaved;
            }
            set
            {
                _CanBeSaved = value;
                зберегтиToolStripMenuItem.Enabled = value;
                toolStripButton_Save.Enabled = value;
            }
        }

        private void CheckFieldsMain()
        {
            CanBeSaved = isChanged;
            foreach (Control x in panel1.Controls)
            {
                if (x is TextBox)
                {
                    if ((new[] { tB_Title }).Contains(x))
                    {
                        if ((x as TextBox).Text == "")
                        {
                            CanBeSaved = false;
                            x.BackColor = Color.LightYellow;
                        }
                        else
                        {
                            x.BackColor = SystemColors.Window;
                        }
                    }
                }
            }
        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Document.Save();
        }
        private void toolStripButton_Save_Click(object sender, EventArgs e)
        {
            Document.Save();
        }

        private void tB_Title_TextChanged(object sender, EventArgs e)
        {
            Text = tB_Title.Text;
            tB_Title.Tag = tB_Title.Text == "" ? "wasEmpty" : "";
            string[] words = tB_Title.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (tB_Surname.Tag.ToString() == "wasEmpty" & words.Length > 0)
            {
                tB_Surname.TextChanged -= tB_Surname_TextChanged;
                tB_Surname.Text = words[0];
                tB_Surname.TextChanged += tB_Surname_TextChanged;
            }
            if (tB_Name.Tag.ToString() == "wasEmpty" & words.Length > 1)
            {
                tB_Name.TextChanged -= tB_Name_TextChanged;
                tB_Name.Text = words[1];
                tB_Name.TextChanged += tB_Name_TextChanged;
            }
            if (tB_Middlename.Tag.ToString() == "wasEmpty" & words.Length >2)
            {
                tB_Middlename.TextChanged -= tB_Middlename_TextChanged;
                tB_Middlename.Text = words[2];
                tB_Middlename.TextChanged += tB_Middlename_TextChanged;
            }

            isChanged = true;
        }
        private void tB_Surname_TextChanged(object sender, EventArgs e)
        {
            tB_Surname.Tag = tB_Surname.Text == "" ? "wasEmpty" : "";
            if (tB_Title.Text == "" | tB_Title.Tag.ToString() == "wasEmpty")
            {
                tB_Title.TextChanged -= tB_Title_TextChanged;
                tB_Title.Text = tB_Surname.Text;
                tB_Title.Text += tB_Title.Text == "" ? tB_Name.Text : " " + tB_Name.Text;
                tB_Title.Text += tB_Title.Text == "" ? tB_Name.Text : " " + tB_Middlename.Text;
                Text = tB_Title.Text;
                tB_Title.TextChanged += tB_Title_TextChanged;
                tB_Title.Tag = "wasEmpty";
            }
            isChanged = true;
        }
        private void tB_Name_TextChanged(object sender, EventArgs e)
        {
            tB_Name.Tag = tB_Name.Text == "" ? "wasEmpty" : "";
            if (tB_Title.Text == "" | tB_Title.Tag.ToString() == "wasEmpty")
            {
                tB_Title.TextChanged -= tB_Title_TextChanged;
                tB_Title.Text = tB_Surname.Text;
                tB_Title.Text += tB_Title.Text == "" ? tB_Name.Text : " " + tB_Name.Text;
                tB_Title.Text += tB_Title.Text == "" ? tB_Name.Text : " " + tB_Middlename.Text;
                Text = tB_Title.Text;
                tB_Title.TextChanged += tB_Title_TextChanged;
                tB_Title.Tag = "wasEmpty";
            }
            
            isChanged = true;
        }
        private void tB_Middlename_TextChanged(object sender, EventArgs e)
        {
            tB_Middlename.Tag = tB_Middlename.Text == "" ? "wasEmpty" : "";
            if (tB_Title.Text == "" | tB_Title.Tag.ToString() == "wasEmpty")
            {
                tB_Title.TextChanged -= tB_Title_TextChanged;
                tB_Title.Text = tB_Surname.Text;
                tB_Title.Text += tB_Title.Text == "" ? tB_Name.Text : " " + tB_Name.Text;
                tB_Title.Text += tB_Title.Text == "" ? tB_Middlename.Text : " " + tB_Middlename.Text;
                Text = tB_Title.Text;
                tB_Title.TextChanged += tB_Title_TextChanged;
                tB_Title.Tag = "wasEmpty";
            }
            isChanged = true;
        }
        private void tB_Phone_TextChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }
        private void tB_Email_TextChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }
        private void tB_Address_TextChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }
        private void tB_City_TextChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }
        private void tB_Region_TextChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }
        private void tB_District_TextChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }
        private void tB_Country_TextChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }
        private void tB_PostalCode_TextChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }
        private void tB_Website_TextChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }
        private void tB_RComment_TextChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }
        private void tB_Login_TextChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }
        private void tB_Password_TextChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }
        private void cB_Locked_Click(object sender, EventArgs e)
        {
            isChanged = true;
        }
        private void dTP_Birthday_ValueChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }

        private void EmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isChanged)
            {
                dynamic mb = MessageBox.Show("Зберегти зміни?", "Увага!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (mb == DialogResult.Yes)
                {
                    if (CanBeSaved)
                    {
                        Document.Save();
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
                else
                {
                    e.Cancel = mb == DialogResult.Cancel;
                }
            }
        }

        private void label10_DoubleClick(object sender, EventArgs e)
        {
            tB_UserPassword.PasswordChar = tB_UserPassword.PasswordChar == '\0' ? '*' : '\0';
        }

        private void toolStripStatusOwner_Click(object sender, EventArgs e)
        {
            try
            {
                idocEmployee emp = new idocEmployee(Document.Owner.Key, Document.Client);
                emp.Show();
            }
            catch { }
        }

        private void Global_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '\u001b':
                    Close();
                    break;
            }
        }
    }
}

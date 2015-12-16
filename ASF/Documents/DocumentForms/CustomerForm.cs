using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASF;
using Victors;
using System.Windows.Forms;

namespace ASF.Documents
{
    public partial class CustomerForm : DocumentForm
    {
        public CustomerForm(idocCustomer document) : base()
        {
            Document = document;
            InitializeComponent();
        }
        private idocCustomer Document { get; set; }

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
            CanBeSaved = true;
            foreach (Control x in panel1.Controls)
            {
                if (x is TextBox)
                {
                    if ((new[] { tB_Name, tB_Phone }).Contains(x))
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

        private void tB_Name_TextChanged(object sender, EventArgs e)
        {
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

        private void CustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isChanged)
            {
                dynamic mb = MessageBox.Show("Зберегти зміни?", "Увага!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (mb == DialogResult.Yes)
                {
                    Document.Save();
                }
                e.Cancel = mb == DialogResult.Cancel;
            }
        }
    }
}

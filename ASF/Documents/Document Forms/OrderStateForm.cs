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
    public partial class OrderStateForm : DocumentForm
    {
        public OrderStateForm(idocOrderState document) : base()
        {
            Document = document;
            InitializeComponent();
        }
        private idocOrderState Document { get; set; }

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
                    if ((new[] { tB_Name, tB_Code}).Contains(x))
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
                    if ((new[] { tB_Level, tB_Index }).Contains(x))
                    {
                        try
                        {
                            Convert.ToInt32((x as TextBox).Text);
                            x.BackColor = SystemColors.Window;
                        }
                        catch
                        {
                            CanBeSaved = false;
                            x.BackColor = Color.LightYellow;
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
            Text = tB_Name.Text;
            isChanged = true;
        }
        private void tB_Code_TextChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }
        private void tB_StateType_TextChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }
        private void tB_Level_TextChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }
        private void tB_Index_TextChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }
        private void tB_Switchover_TextChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }
        private void tB_RComment_TextChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }

        private void OrderStateForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void tB_Switchover_Click(object sender, EventArgs e)
        {
            idocOrderState OrderState = new idocOrderState(tB_Switchover.Tag.ToString(), Document.Client);
            OrderState.Show();
        }
    }
}

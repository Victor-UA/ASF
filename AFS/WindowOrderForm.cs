using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AFS;
using Victors;
using System.Globalization;

namespace ASF.Documents
{
    public partial class WindowOrderForm : Form
    {
        public WindowOrderForm(idocWindowOrder document)
        {
            InitializeComponent(document);
        }
        private void WindowOrderForm_Load(object sender, EventArgs e)
        {
        }
        private class OrderStatesGridController : GridController
        {
            private FBClient Client;
            private SourceGrid.Grid Grid;
            public OrderStatesGridController(SourceGrid.Grid grid, DataTable dt, string key, FBClient client)
            {
                Client = client;
                Grid = grid;
            }
            public override void OnDoubleClick(SourceGrid.CellContext sender, EventArgs e)
            {
                if (sender.Position.Row > 0)
                {
                    SourceGridUtilities.RowTag rt = (SourceGridUtilities.RowTag)Grid.Rows[sender.Position.Row].Tag;
                    MessageBox.Show("Редагуємо стан: id=" + rt.Key.ToString(), sender.Value.ToString());
                }
            }
        }
        public void OrderStatesLoad()
        {
//            CheckFieldsMain();

            DataTable dtOrderStates = Document.Client.QueryRecordsList(qryOrderStates.ToString().Replace(":orderid", Document.Key));
            grid_OrderStates.Controller.AddController(new OrderStatesGridController(grid_OrderStates, dtOrderStates, "orderstatesregid", Document.Client));
            SourceGridUtilities.Grid.Fill(grid_OrderStates, dtOrderStates, "orderstatesregid", new Dictionary(new List<dynamic>
                {
                    "Дата", "changedate",
                    "Стан", "name",
                    "Коментар", "rcomment",
                    "Менеджер", "persontitle"
                }));
        }

        public void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Document.Save();
        }
        private void WindowOrderForm_FormClosing(object sender, FormClosingEventArgs e)
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
        private void dTP_DateOrder_ValueChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }
        private void dTP_AgreementDate_ValueChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }

        //Запити SQL
        private string qryOrderStates { get; set; } =
            @"
select
    coalesce(osr.changedate, '<null>') changedate,
    coalesce(os.name, '<null>') name,
    coalesce(osr.rcomment, '<null>') rcomment,
    coalesce(p.persontitle, '<null>') persontitle,
    coalesce(osr.orderstatesregid, '<null>') orderstatesregid
from orderstatesreg osr
    join orderstates os on os.orderstateid=osr.orderstateid
    left join employee e on e.empid=osr.empid
    left join persons p on p.personid=e.personid
where osr.orderid=:orderid
order by osr.changedate
            ";
        //Запити SQL

        private idocWindowOrder Document { get; set; }
        public  bool isCreated { get; set; } = true;
        private bool _ReadOnly = false;
        public  bool ReadOnly
        {
            get
            {
                return _ReadOnly;
            }
            set
            {
                _ReadOnly = value;
                foreach (Control x in MainPanel1.Controls)
                {
                    if (x is TextBox)
                    {
                        (x as TextBox).ReadOnly = _ReadOnly;
                    }
                    if (x is Victors.DateTimePicker)
                    {
                        (x as Victors.DateTimePicker).Enabled = _ReadOnly;
                    }
                }
            }
        }
        private bool _isChanged;
        public  bool isChanged
        {
            get
            {
                return _isChanged;
            }
            set
            {
                _isChanged = value;              
                toolStripStatusIsChanged.Text = value ? "Змінено" : "";
                toolStripStatusIsChanged.ForeColor = CanBeSaved ? Color.DarkGreen : Color.DarkRed;
                CheckFieldsMain();
            }
        }
        private bool _CanBeSaved = true;
        public  bool CanBeSaved
        {
            get
            {
                return _CanBeSaved;
            }
            set
            {
                _CanBeSaved = value;
                зберегтиToolStripMenuItem.Enabled = value;
            }
        }
        private void CheckFieldsMain()
        {
            CanBeSaved = true;
            foreach (Control x in MainPanel1.Controls)
            {
                if (x is TextBox)
                {
                    if ((new[] { tB_OrderNo, tB_Customer, tB_Currency }).Contains(x))
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
                    if (new[] { tB_TotalCost, tB_TotalPrice }.Contains(x))
                    {
                        if (!Extension.IsNumeric((x as TextBox).Text) && (x as TextBox).Text != "")
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

        private void tB_OrderNo_TextChanged(object sender, EventArgs e)
        {
            Text = tB_OrderNo.Text;
            isChanged = true;
        }
        private void tB_AgreementNo_TextChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }
        private void tB_Customer_TextChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }
        private void dTP_ProdDate_ValueChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }
        private void tB_TotalCost_TextChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }
        private void tB_TotalPrice_TextChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }
        private void tB_Currency_TextChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }

        private void tB_TotalPrice_Leave(object sender, EventArgs e)
        {
            //MessageBox.Show(string.Format(CultureInfo.InvariantCulture, "{0:0,0}", Convert.ToSingle(tB_TotalPrice.Text)));
            tB_TotalPrice.Text = string.Format(CultureInfo.InvariantCulture,"{0:0,0}", Convert.ToDecimal(tB_TotalPrice.Text));
            tB_TotalPrice.Text = tB_TotalPrice.Text.Replace(",", " ");
        }

        private void tB_TotalPrice_Enter(object sender, EventArgs e)
        {
            tB_TotalPrice.Text = tB_TotalPrice.Text.Replace(" ", "");
        }
    }
}

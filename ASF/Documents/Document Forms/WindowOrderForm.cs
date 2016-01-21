using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ASF;
using Victors;
using System.Globalization;
using ASF.Dialogs.Dialog_Classes;

namespace ASF.Documents
{
    public partial class WindowOrderForm : DocumentForm
    {
        public WindowOrderForm(idocWindowOrder document) : base()
        {
            Document = document;
            InitializeComponent();
            dTP_AgreementDate.Value = DateTime.Now;
            dTP_AgreementDate.Format = DateTimePickerFormat.Long;
            dTP_DateOrder.Value = DateTime.Now;
            dTP_DateOrder.Format = DateTimePickerFormat.Long;
            dTP_ProdDate.Value = DateTime.Now;
            dTP_ProdDate.Format = DateTimePickerFormat.Long;
        }
        private idocWindowOrder Document { get; set; }
        private void WindowOrderForm_FormClosing(object sender, FormClosingEventArgs e)
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
                    /*
                    SourceGridUtilities.RowTag rt = (SourceGridUtilities.RowTag)Grid.Rows[sender.Position.Row].Tag;
                    MessageBox.Show("Редагуємо стан: id=" + rt.Key.ToString(), sender.Value.ToString());
                    */
                    /* Має бути OrderStateReg
                    idocOrderState OrderState = new idocOrderState(rt.Key.ToString(), Client);
                    OrderState.Show();
                    */
                }
            }
        }
        public void OrderStatesLoad()
        {
//            CheckFieldsMain();

            DataTable dt = Document.Client.QueryRecordsList(qryOrderStatesReg.ToString().Replace(":orderid", Document.Key));
            grid_OrderStates.Controller.AddController(new OrderStatesGridController(grid_OrderStates, dt, "orderstatesregid", Document.Client));
            SourceGridUtilities.Grid.Fill(grid_OrderStates, dt, "orderstatesregid", new Dictionary(new List<dynamic>
                {
                    "Дата", "changedate",
                    "Стан", "name",
                    "Коментар", "rcomment",
                    "Менеджер", "persontitle"
                }));
            dt = Document.Client.QueryRecordsList(qryOrderStates.ToString().Replace(":orderid", Document.Key));
            foreach (DataRow row in dt.Rows)
            {
                ToolStripItem tsitem = new ToolStripMenuItem
                    (
                        row["name"].ToString(), 
                        null, 
                        new EventHandler(toolStripMenuItemAddOrderState_Click)
                    );
                tsitem.Tag = row["orderstateid"].ToString();
                toolStripMenuItemAddOrderState.DropDownItems.Add(tsitem);
            }

        }
        private void toolStripMenuItemAddOrderState_Click(object sender, EventArgs e)
        {
            string rcomment = Prompt.InputDialog(sender.ToString(), "Додайте коментар");
            MessageBox.Show((sender as ToolStripMenuItem).Tag.ToString());
        }

        public void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Document.Save();
        }
        private void dTP_DateOrder_ValueChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }
        private void dTP_AgreementDate_ValueChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }

        #region Запити SQL
        private string qryOrderStatesReg { get; } =
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
        private string qryOrderStates { get; } =
            @"
select
  os.statelevel,
  coalesce(os.recindex, 0) recindex,
  os.name,
  os.orderstateid
from orderstates os
where os.statelevel > coalesce((select os1.statelevel from orderstates os1 where os1.orderstateid=(select o.orderstateid from orders o where o.orderid=:orderid)), 0)
  or (
        os.statelevel = coalesce((select os1.statelevel from orderstates os1 where os1.orderstateid=(select o.orderstateid from orders o where o.orderid=:orderid)), 0)
    and os.recindex > coalesce((select os1.recindex from orderstates os1 where os1.orderstateid=(select o.orderstateid from orders o where o.orderid=:orderid)), 0)
  )
order by 1,2,3
            ";
        #endregion

        //public override bool isCreated { get; set; } = true;
        public bool ReadOnly
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
                toolStripButton_Save.Enabled = value;
            }
        }

        private void CheckFieldsMain()
        {
            CanBeSaved = isChanged;
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
            try
            {
                tB_TotalCost.Tag = Convert.ToDecimal(tB_TotalCost.Text);
            }
            catch
            {
                tB_TotalCost.Tag = 0;
            }
        }
        private void tB_TotalCost_Enter(object sender, EventArgs e)
        {
            tB_TotalCost.TextChanged -= tB_TotalCost_TextChanged;
            tB_TotalCost.Text = tB_TotalCost.Text.Replace(" ", "");
            tB_TotalCost.TextChanged += tB_TotalCost_TextChanged;
        }
        private void tB_TotalCost_Leave(object sender, EventArgs e)
        {
            try
            {
                Document.TotalCost = (decimal)tB_TotalCost.Tag;
            }
            catch
            {
                Document.TotalCost = 0;
            }
        }

        private void tB_TotalPrice_TextChanged(object sender, EventArgs e)
        {
            isChanged = true;
            try
            {
                tB_TotalPrice.Tag = Convert.ToDecimal(tB_TotalPrice.Text);
            }
            catch
            {
                tB_TotalPrice.Tag = 0;
            }
        }
        private void tB_TotalPrice_Enter(object sender, EventArgs e)
        {
            tB_TotalPrice.TextChanged -= tB_TotalPrice_TextChanged;
            tB_TotalPrice.Text = tB_TotalPrice.Text.Replace(" ", "");
            tB_TotalPrice.TextChanged += tB_TotalPrice_TextChanged;
        }
        private void tB_TotalPrice_Leave(object sender, EventArgs e)
        {
            try
            {
                Document.TotalPrice = (decimal)tB_TotalPrice.Tag;
            }
            catch
            {
                Document.TotalPrice = 0;
            }
        }

        private void tB_Currency_TextChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }

        private void toolStripButton_Save_Click(object sender, EventArgs e)
        {
            Document.Save();
        }

        private void tB_Customer_Click(object sender, EventArgs e)
        {
            try
            {
                Document.Customer.Show();
            }
            catch(Exception) { }
        }

        private void b_SelectCustomer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вибір клієнта");
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

        private void tB_RComment_TextChanged(object sender, EventArgs e)
        {
            isChanged = true;
        }
    }
}

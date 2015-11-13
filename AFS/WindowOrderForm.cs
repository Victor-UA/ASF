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
            DataTable dt = Document.Client.QueryRecordsList("select * from vtorders o where o.orderid=" + Document.Key);
            
            if (dt.Rows.Count > 0)
            {
                tB_OrderNo.Text = dt.Rows[0]["orderno"].ToString();
                Text = tB_OrderNo.Text;
                dTP_DateOrder.Value = dt.Rows[0]["dateorder"].ToString() == "" ? DateTime.MinValue : (DateTime)dt.Rows[0]["dateorder"];
                tB_AgreementNo.Text = dt.Rows[0]["AgreementNo"].ToString();
                dTP_AgreementDate.Value = dt.Rows[0]["AgreementDate"].ToString() == "" ? DateTime.MinValue : (DateTime)dt.Rows[0]["AgreementDate"];

                //OrdersStates
                string SQL =
                    @"select
                        osr.changedate,
                        os.name,
                        osr.rcomment,
                        p.persontitle,
                        osr.orderstatesregid
                    from orderstatesreg osr
                        join orderstates os on os.orderstateid=osr.orderstateid
                        left join employee e on e.empid=osr.empid
                        left join persons p on p.personid=e.personid
                    where osr.orderid=:orderid
                    order by osr.changedate";
                SQL = SQL.Replace(":orderid", Document.Key);
                DataTable dtOrderStates = Document.Client.QueryRecordsList(SQL);
                grid_OrderStates.Controller.AddController(new GridController(dtOrderStates, "orderstatesregid"));
                SourceGridUtilities.Fill(grid_OrderStates, dtOrderStates);
            }
            else
            {
                dTP_DateOrder.Value = DateTime.Now;
                dTP_AgreementDate.Value = DateTime.Now;
            }

        }
        public void Save()
        {
            MessageBox.Show("Збереження...");
        }

        public void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void WindowOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isChanged)
            {
                dynamic mb = MessageBox.Show("Зберегти зміни?", "Увага!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (mb == DialogResult.Yes)
                {
                    Save();
                }
                e.Cancel = mb == DialogResult.Cancel;
            }
        }

        private void tB_OrderNo_ModifiedChanged(object sender, EventArgs e)
        {
            Text = tB_OrderNo.Text;
            isChanged = true;
        }
    }
}

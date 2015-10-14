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
        public WindowOrderForm(string key)
        {
            InitializeComponent(key);
        }

        private void WindowOrderForm_Load(object sender, EventArgs e)
        {
            DataTable dt = VFBClient.QueryRecordsList("select * from vtorders o where o.orderid=" + Key);
            
            if (dt.Rows.Count > 0)
            {
                tB_OrderNo.Text = dt.Rows[0]["orderno"].ToString();
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
                SQL = SQL.Replace(":orderid", Key);
                DataTable dtOrderStates = VFBClient.QueryRecordsList(SQL);
                grid_OrderStates.Controller.AddController(new GridController(dtOrderStates, "orderstatesregid"));
                VFBClient.SGridFill(grid_OrderStates, dtOrderStates);
            }
            else
            {

            }

        }
    }
}

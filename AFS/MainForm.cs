using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Victors;
using ASF.Documents;
using System.Collections.Generic;
using Cyotek.Windows.Forms;

namespace AFS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private FBClient Client = new FBClient(@"character set=WIN1251;data source=localhost;initial catalog=D:\NASTROECHNAYA_2015.GDB ;user id=SYSDBA;password=masterkey");
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (TabListPage page in tabList1.TabListPages)
            {
                page.Tag = false; //Ознака, що сторінка не завантажена
            }
        }
        private class MainFormGridController : GridController
        {
            private FBClient Client;
            public MainFormGridController(DataTable dt, string key, FBClient client) : base(dt, key)
            {
                Client = client;
            }
            public override void OnDoubleClick(SourceGrid.CellContext sender, EventArgs e)
            {
                if (sender.Position.Row > 0)
                {
                    idocWindowOrder Order = new idocWindowOrder(DT.Rows[sender.Position.Row - 1][Key].ToString(), Client);
                    Order.Show();
                }
            }
        }
        private void tabListPageOrders_Paint(object sender, PaintEventArgs e)
        {
            TabListPage page = (TabListPage)sender;
            if (!(bool)page.Tag)
            {
                DataTable dt = Client.QueryRecordsList(qryOrders);
                grid1.Controller.AddController(new MainFormGridController(dt, "orderid", Client));
                SourceGridUtilities.Fill(grid1, dt, new Dictionary(new List<dynamic>
                {
                    "Номер замовлення", "orderno",
                    "Дата готовності", "dateorder"
                }));
                page.Tag = true;
            }
        }

        //Скрипти SQL
        private string qryOrders { get; set; } = 
            @"
select * from vtorders
            ";
    }
}

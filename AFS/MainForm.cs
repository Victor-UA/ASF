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
            private SourceGrid.Grid Grid;
            public MainFormGridController(SourceGrid.Grid grid, DataTable dt, string key, FBClient client) : base(dt, key)
            {
                Client = client;
                Grid = grid;
            }
            public override void OnDoubleClick(SourceGrid.CellContext sender, EventArgs e)
            {
                if (sender.Position.Row > 0)
                {
                    SourceGridUtilities.RowTag rt = (SourceGridUtilities.RowTag)Grid.Rows[sender.Position.Row].Tag;
                    idocWindowOrder Order = new idocWindowOrder(rt.Key.ToString(), Client);
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
                grid1.Controller.AddController(new MainFormGridController(grid1, dt, "orderid", Client));
                SourceGridUtilities.Grid.Fill(grid1, dt, "orderid", new Dictionary(new List<dynamic>
                {
                    "Номер замовлення", "orderno",
                    "Дата готовності", "dateorder",
                    "Стан", "VORDERSTATENAME"
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

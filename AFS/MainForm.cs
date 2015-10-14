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

namespace AFS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        protected DataTable DT { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {
            VFBClient.ConnectionStr = @"character set=WIN1251;data source=localhost;initial catalog=D:\NASTROECHNAYA_2015.GDB ;user id=SYSDBA;password=masterkey";
            DT = VFBClient.QueryRecordsList("select * from orders");
            grid1.Controller.AddController(new MainFormGridController(DT,"orderid"));
            VFBClient.SGridFill(grid1, DT, new Dictionary("Номер замовлення", "orderno"));
        }
        private class MainFormGridController : GridController
        {
            public MainFormGridController(DataTable dt, string key) : base(dt, key)
            {
            }
            public override void OnDoubleClick(SourceGrid.CellContext sender, EventArgs e)
            {
                if (sender.Position.Row > 0)
                {
                    idocWindowOrder Order = new idocWindowOrder(DT.Rows[sender.Position.Row - 1][Key].ToString());
                    Order.Show();
                }
            }
        }
    }
}

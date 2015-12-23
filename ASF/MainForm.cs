﻿using System;
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

namespace ASF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Program.UserContext = new idocEmployee(0, Client);
        }

        private FBClient Client = new FBClient(@"character set=WIN1251;data source=localhost;initial catalog=D:\NASTROECHNAYA_2015.GDB ;user id=SYSDBA;password=masterkey");
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (TabListPage page in tabList1.TabListPages)
            {
                page.Tag = false; //Ознака, що сторінка не завантажена
            }
        }

        private class OrdersGridController : GridController
        {
            private FBClient Client;
            private SourceGrid.Grid Grid;
            public OrdersGridController(SourceGrid.Grid grid, DataTable dt, string key, FBClient client)
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
        private class CustomersGridController : GridController
        {
            private FBClient Client;
            private SourceGrid.Grid Grid;
            public CustomersGridController(SourceGrid.Grid grid, DataTable dt, string key, FBClient client)
            {
                Client = client;
                Grid = grid;
            }
            public override void OnDoubleClick(SourceGrid.CellContext sender, EventArgs e)
            {
                if (sender.Position.Row > 0)
                {
                    SourceGridUtilities.RowTag rt = (SourceGridUtilities.RowTag)Grid.Rows[sender.Position.Row].Tag;
                    idocCustomer Customer = new idocCustomer(rt.Key.ToString(), Client);
                    Customer.Show();
                }
            }
        }
        private class EmployeesGridController : GridController
        {
            private FBClient Client;
            private SourceGrid.Grid Grid;
            public EmployeesGridController(SourceGrid.Grid grid, DataTable dt, string key, FBClient client)
            {
                Client = client;
                Grid = grid;
            }
            public override void OnDoubleClick(SourceGrid.CellContext sender, EventArgs e)
            {
                if (sender.Position.Row > 0)
                {
                    SourceGridUtilities.RowTag rt = (SourceGridUtilities.RowTag)Grid.Rows[sender.Position.Row].Tag;
                    idocEmployee Customer = new idocEmployee(rt.Key.ToString(), Client);
                    Customer.Show();
                }
            }
        }

        private void tabListPageOrders_Paint(object sender, PaintEventArgs e)
        {          
            TabListPage page = (TabListPage)sender;
            if (Program.OrdersAreChanged)
            {
                OrdersGrid.Visible = false;
                DataTable dt = Client.QueryRecordsList(qryOrders);
                OrdersGrid.Controller.AddController(new OrdersGridController(OrdersGrid, dt, "orderid", Client));
                SourceGridUtilities.Grid.Fill(OrdersGrid, dt, "orderid", new Dictionary(new List<dynamic>
                    {
                        "Номер замовлення", "orderno",
                        "Дата готовності", "dateorder",
                        "Стан", "VORDERSTATENAME",
                        "Клієнт", "VCUSTOMERNAME"
                    }));
                OrdersGrid.Visible = true;
                Program.OrdersAreChanged = false;
            }
        }
        private void tabListPageCustomers_Paint(object sender, PaintEventArgs e)
        {
            TabListPage page = (TabListPage)sender;
            if (Program.CustomersAreChanged)
            {
                CustomersGrid.Visible = false;
                DataTable dt = Client.QueryRecordsList(qryCustomers);
                CustomersGrid.Controller.AddController(new CustomersGridController(CustomersGrid, dt, "customerid", Client));
                SourceGridUtilities.Grid.Fill(CustomersGrid, dt, "customerid", new Dictionary(new List<dynamic>
                    {
                        "Найменування", "Name",
                        "Адреса", "adress",
                        "Номер телефону", "phone"
                    }));
                CustomersGrid.Visible = true;
                Program.CustomersAreChanged = false;
            }
        }
        private void tabListPageEmployees_Paint(object sender, PaintEventArgs e)
        {
            TabListPage page = (TabListPage)sender;
            if (Program.EmployeesAreChanged)
            {
                EmployeesGrid.Visible = false;
                DataTable dt = Client.QueryRecordsList(qryEmployees);
                EmployeesGrid.Controller.AddController(new EmployeesGridController(EmployeesGrid, dt, "empid", Client));
                SourceGridUtilities.Grid.Fill(EmployeesGrid, dt, "empid", new Dictionary(new List<dynamic>
                    {
                        "Найменування", "title",
                        "Прізвище", "Surname",
                        "Ім'я", "Name",
                        "По батькові", "Middlename",
                        "Адреса", "address",
                        "Номер телефону", "phone",
                        "Дата народження", "dateborn",
                        "Ім'я користувача", "username",
                        "Коментар", "RComment"
                    }));
                EmployeesGrid.Visible = true;
                Program.EmployeesAreChanged = false;
            }
        }

        private void toolStripButton_New_Click(object sender, EventArgs e)
        {
            switch (tabList1.SelectedPage.Text)
            {
                case "Замовлення":
                    idocWindowOrder Order = new idocWindowOrder(Client);
                    Order.Show();
                    break;
                case "Клієнти":
                    idocCustomer Customer = new idocCustomer(Client);
                    Customer.Show();
                    break;
                case "Співробітники":
                    idocEmployee Employee = new idocEmployee(Client);
                    Employee.Show();
                    break;
            }
        }

        #region Скрипти SQL
        private string qryOrders { get; set; } = 
            @"
select * from vtorders
where deleted = 0
            ";
        private string qryCustomers { get; set; } =
            @"
select * from getcustomers
where deleted = 0
            ";
        private string qryEmployees { get; set; } =
            @"
select
  ve.*,
  veo.title,
  veo.empid ownerid,
  ad.*,
  ea.*
from vtemployee ve
  join vtemployee veo on veo.empid = ve.ownerid
  left join addresses ad on ad.addressid=ve.mainaddressid
left join EMAILADDRESSES ea on ea.emailid=ve.mainemailid
where ve.deleted = 0
            ";

        #endregion

    }
}

using System;
using System.Data;
using System.Windows.Forms;
using Victors;
using ASF.Documents;
using System.Collections.Generic;
using Cyotek.Windows.Forms;
using SourceGrid;

namespace ASF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();        
            OrdersGrid.Controller.AddController(new OrdersGridController(OrdersGrid, Client));
            CustomersGrid.Controller.AddController(new CustomersGridController(CustomersGrid, Client));
            EmployeesGrid.Controller.AddController(new EmployeesGridController(EmployeesGrid, Client));
            try
            {
                tSSL_User.Text = Program.UserContext.Title;
            }
            catch
            {
                tSSL_User.Text = "Невідомо";
            }
            
        }

        private FBClient Client = new FBClient(Program.BaseConnectionString);
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
            public OrdersGridController(SourceGrid.Grid grid, FBClient client)
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
            public CustomersGridController(SourceGrid.Grid grid, FBClient client)
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
            public EmployeesGridController(SourceGrid.Grid grid, FBClient client)
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
            Dictionary Filter = new Dictionary();
            if (!string.IsNullOrEmpty(tSTB_OrdersFilterText.Text) & !string.IsNullOrEmpty(tSCB_OrdersFilter.Text))
            {
                Filter.Add(tSCB_OrdersFilter.Text, tSTB_OrdersFilterText.Text);
            }
            if (Program.OrdersAreChanged | sender == null)
            {
                OrdersGrid.Visible = false;
                DataTable dt = Client.QueryRecordsList(qryOrders);
                SourceGridUtilities.Grid.Fill(OrdersGrid, dt, "orderid", 
                    new Dictionary(new List<dynamic>
                    {
                        "Номер замовлення", "orderno",
                        "Дата готовності", "dateorder",
                        "Стан", "VORDERSTATENAME",
                        "Клієнт", "VCUSTOMERNAME"
                    }),
                    Filter
                );
                OrdersGrid.Visible = true;
                FilterFill(tSCB_OrdersFilter, OrdersGrid);

                Program.OrdersAreChanged = false;
            }
        }
        public void OrdersRepaint()
        {
            tabListPageOrders_Paint(null, null);
        }

        private void tabListPageCustomers_Paint(object sender, PaintEventArgs e)
        {
            Dictionary Filter = new Dictionary();
            if (!string.IsNullOrEmpty(tSTB_CustomersFilterText.Text) & !string.IsNullOrEmpty(tSCB_CustomersFilter.Text))
            {
                Filter.Add(tSCB_CustomersFilter.Text, tSTB_CustomersFilterText.Text);
            }
            if (Program.CustomersAreChanged | sender == null)
            {
                CustomersGrid.Visible = false;
                DataTable dt = Client.QueryRecordsList(qryCustomers);
                SourceGridUtilities.Grid.Fill(CustomersGrid, dt, "customerid", new Dictionary(new List<dynamic>
                    {
                        "Найменування", "Name",
                        "Адреса", "adress",
                        "Номер телефону", "phone"
                    }),
                    Filter
                );
                CustomersGrid.Visible = true;
                FilterFill(tSCB_CustomersFilter, CustomersGrid);

                Program.CustomersAreChanged = false;
            }
        }
        public void CustomersRepaint()
        {
            tabListPageCustomers_Paint(null, null);
        }

        private void tabListPageEmployees_Paint(object sender, PaintEventArgs e)
        {
            Dictionary Filter = new Dictionary();
            if (!string.IsNullOrEmpty(tSTB_EmployeesFilterText.Text) & !string.IsNullOrEmpty(tSCB_EmployeesFilter.Text))
            {
                Filter.Add(tSCB_EmployeesFilter.Text, tSTB_EmployeesFilterText.Text);
            }
            if (Program.EmployeesAreChanged | sender == null)
            {
                EmployeesGrid.Visible = false;
                DataTable dt = Client.QueryRecordsList(qryEmployees);
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
                        "Коментар", "RComment",
                        "Заблоковано", "Locked"
                    }),
                    Filter
                );
                EmployeesGrid.Visible = true;
                FilterFill(tSCB_EmployeesFilter, EmployeesGrid);

                Program.EmployeesAreChanged = false;
            }
        }

        public void RefreshOrder(idocWindowOrder Order)
        {
            foreach (GridRow Row in OrdersGrid.Rows)
            {
                if (Row.Tag != null)
                {
                    SourceGridUtilities.RowTag rt = (SourceGridUtilities.RowTag)Row.Tag;
                    if (Convert.ToString(rt.Key) == Order.Key)
                    {
                        foreach (GridColumn Column in OrdersGrid.Columns)
                        {
                            switch (OrdersGrid[0, Column.Index].DisplayText)
                            {
                                case "Номер замовлення":
                                    OrdersGrid[Row.Index, Column.Index].Value = Order.OrderNo;
                                    break;
                                case "Дата готовності":
                                    OrdersGrid[Row.Index, Column.Index].Value = Order.DateOrder;
                                    break;
                                case "Стан":
                                    OrdersGrid[Row.Index, Column.Index].Value = Order.OrderState.Name;
                                    break;
                                case "Клієнт":
                                    OrdersGrid[Row.Index, Column.Index].Value = Order.Customer.Name;
                                    break;
                            }
                        }
                        break;
                    }
                }
            }
        }

        public void EmployeesRepaint()
        {
            tabListPageEmployees_Paint(null, null);
        }
        public void RefreshEmployee(idocEmployee Employee)
        {
            foreach (GridRow Row in EmployeesGrid.Rows)
            {
                if (Row.Tag != null)
                {
                    SourceGridUtilities.RowTag rt = (SourceGridUtilities.RowTag)Row.Tag;
                    if (Convert.ToString(rt.Key) == Employee.Key)
                    {
                        foreach (GridColumn Column in EmployeesGrid.Columns)
                        {
                            switch (EmployeesGrid[0, Column.Index].DisplayText)
                            {
                                case "Найменування":
                                    EmployeesGrid[Row.Index, Column.Index].Value = Employee.Title;
                                    break;
                                case "Прізвище":
                                    EmployeesGrid[Row.Index, Column.Index].Value = Employee.Surname;
                                    break;
                                case "Ім'я":
                                    EmployeesGrid[Row.Index, Column.Index].Value = Employee.Name;
                                    break;
                                case "По батькові":
                                    EmployeesGrid[Row.Index, Column.Index].Value = Employee.Middlename;
                                    break;
                                case "Адреса":
                                    EmployeesGrid[Row.Index, Column.Index].Value = Employee.Address;
                                    break;
                                case "Номер телефону":
                                    EmployeesGrid[Row.Index, Column.Index].Value = Employee.Phone;
                                    break;
                                case "Дата народження":
                                    EmployeesGrid[Row.Index, Column.Index].Value = Employee.Birthday;
                                    break;
                                case "Ім'я користувача":
                                    EmployeesGrid[Row.Index, Column.Index].Value = Employee.UserName;
                                    break;
                                case "Коментар":
                                    EmployeesGrid[Row.Index, Column.Index].Value = Employee.RComment;
                                    break;
                                case "Заблоковано":
                                    EmployeesGrid[Row.Index, Column.Index].Value = Employee.Locked ? "1" : "0";
                                    break;
                            }
                        }
                        break;
                    }
                }
            }
            try
            {
                if (Program.UserContext.Key.ToString() == Employee.Key.ToString())
                {
                    try
                    {
                        Program.UserContext.Load();
                        tSSL_User.Text = Program.UserContext.Title;
                    }
                    catch
                    {
                        tSSL_User.Text = "Невідомо";
                    }
                }
            }
            catch
            {
                tSSL_User.Text = "Невідомо";
            }
        }

        private void FilterFill(ToolStripComboBox cb_filter, Grid grid)
        {
            try
            {
                if (cb_filter.Items.Count == 0)
                {
                    for (int i = 0; i < grid.ColumnsCount; i++)
                    {
                        cb_filter.Items.Add(grid[0, i].Value.ToString());
                    }
                    cb_filter.Text = cb_filter.Items[0].ToString();
                }
            }
            catch { }
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
        private void tSSL_User_Click(object sender, EventArgs e)
        {
            try
            {
                idocEmployee emp = new idocEmployee(Program.UserContext.Key, Client);
                emp.Show();
            }
            catch { }
        }

        private void tSTB_OrdersFilterText_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '\r':
                    OrdersRepaint();
                    break;
            }
        }
        private void tSTB_CustomersFilterText_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '\r':
                    CustomersRepaint();
                    break;
            }
        }
        private void tSTB_EmployeesFilterText_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '\r':
                    EmployeesRepaint();
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

using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Victors;

namespace ASF.Documents
{
    public class idocEmployee : idocDocument
    {
        protected override void Constructor(string key, FBClient client, string type)
        {
            MainForm = new EmployeeForm(this);
            base.Constructor(key, client, type);
        }
        public idocEmployee(string key, FBClient client) : base(key, client, "idocEmployee") { }
        public idocEmployee(int key, FBClient client) : base(key, client, "idocEmployee") { }
        public idocEmployee(FBClient client) : base("", client, "idocEmployee") { }

        private EmployeeForm MainForm;

        public string Name
        {
            get
            {
                return MainForm.tB_Name.Text;
            }
            set
            {
                MainForm.tB_Name.Text = value.ToString();
            }
        }
        public string Phone
        {
            get
            {
                return MainForm.tB_Phone.Text.ToString();
            }
            set
            {
                MainForm.tB_Phone.Text = value.ToString();
            }
        }
        public string Email
        {
            get
            {
                return MainForm.tB_Email.Text;
            }
            set
            {
                MainForm.tB_Email.Text = value.ToString();
            }
        }
        public string Address
        {
            get
            {
                return MainForm.tB_Address.Text;
            }
            set
            {
                MainForm.tB_Address.Text = value.ToString();
            }
        }
        public string City
        {
            get
            {
                return MainForm.tB_City.Text;
            }
            set
            {
                MainForm.tB_City.Text = value.ToString();
            }
        }
        public string Region
        {
            get
            {
                return MainForm.tB_Region.Text;
            }
            set
            {
                MainForm.tB_Region.Text = value.ToString();
            }
        }
        public string District
        {
            get
            {
                return MainForm.tB_District.Text;
            }
            set
            {
                MainForm.tB_District.Text = value.ToString();
            }
        }
        public string Country
        {
            get
            {
                return MainForm.tB_Country.Text;
            }
            set
            {
                MainForm.tB_Country.Text = value.ToString();
            }
        }
        public string PostalCode
        {
            get
            {
                return MainForm.tB_PostalCode.Text;
            }
            set
            {
                MainForm.tB_PostalCode.Text = value.ToString();
            }
        }
        public string WebSite
        {
            get
            {
                return MainForm.tB_Website.Text;
            }
            set
            {
                MainForm.tB_Website.Text = value.ToString();
            }
        }
        public string RComment
        {
            get
            {
                return MainForm.tB_RComment.Text;
            }
            set
            {
                MainForm.tB_RComment.Text = value.ToString();
            }
        }

        public string Owner
        {
            get
            {
                return MainForm.toolStripStatusOwner.Text;
            }
            set
            {
                MainForm.toolStripStatusOwner.Text = value;
            }
        }

        public override bool isCreated
        {
            get
            {
                return MainForm.isCreated;
            }
            protected set
            {
                MainForm.isCreated = value;
            }
        }
        public override bool isChanged
        {
            get
            {
                return MainForm.isChanged;
            }
            protected set
            {
                MainForm.isChanged = value;
            }
        }

        public override void Create()
        {
            long key = Client.QueryValue(@"select gen_id(gen_customers, 1) from rdb$database");
            Key = key.ToString();
            isCreated = false;
            isChanged = true;
        }
        public override void Load()
        {
            MessageBox.Show("Завантаження");
            if (Key == "")
            {
                isCreated = false;
                Create();
                MainForm.Text = "Нове замовлення";
                Owner = "Administrator";
            }
            else
            {
                DataTable dt = Client.QueryRecordsList(qryEmployeeLoad.ToString().Replace(":customerid", Key));
                if (dt != null && dt.Rows.Count > 0)
                {
                    Name = dt.Rows[0]["Name"].ToString();
                    MainForm.Text = Name;
                    Phone = dt.Rows[0]["Phone"].ToString();
                    Email = dt.Rows[0]["Email"].ToString();

                    Address = dt.Rows[0]["Adress"].ToString();
                    City = dt.Rows[0]["City"].ToString();
                    Region = dt.Rows[0]["Region"].ToString();
                    District = dt.Rows[0]["District"].ToString();
                    Country = dt.Rows[0]["Country"].ToString();
                    PostalCode = dt.Rows[0]["PostalCode"].ToString();
                    WebSite = dt.Rows[0]["WebSite"].ToString();
                    RComment = dt.Rows[0]["RComment"].ToString();

                    Owner = dt.Rows[0]["ownerpersontitle"].ToString();

                    isCreated = true;
                    isChanged = false;
                }
            }
        }
        public override void Show()
        {
            try
            {
                MainForm.Visible = true;
            }
            catch (ObjectDisposedException)
            {
                MainForm = new EmployeeForm(this);
                Load();
                MainForm.Visible = true;
            }
        }
        public override void Save()
        {

            string SQL = qryEmployeeSave;
            try
            {
                MessageBox.Show("Збереження");
                /*
                SQL = SQL.Replace(":customerid", Key.ToString());
                SQL = SQL.Replace(":name", "'" + Name.ToString() + "'");
                SQL = SQL.Replace(":_phone", Phone.ToString() == "" ? "null" : "'" + Phone.ToString() + "'");
                SQL = SQL.Replace(":country", "'" + Country.ToString() + "'");
                SQL = SQL.Replace(":region", "'" + Region.ToString() + "'");
                SQL = SQL.Replace(":district", "'" + District.ToString() + "'");
                SQL = SQL.Replace(":_address", "'" + Address.ToString() + "'");
                SQL = SQL.Replace(":postalcode", "'" + PostalCode.ToString() + "'");
                SQL = SQL.Replace(":_email", "'" + Email.ToString() + "'");
                SQL = SQL.Replace(":website", "'" + WebSite.ToString() + "'");
                SQL = SQL.Replace(":rcomment", "'" + RComment.ToString() + "'");
                SQL = SQL.Replace(":ownerid", "0"); //Тимчасово!
                SQL = SQL.Replace(":city", "'" + City.ToString() + "'");
                Client.ExecuteSQLCommit(SQL);
                */

                isChanged = false;
                isCreated = true;
                Program.EmployeesAreChanged = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n");
            }
        }
        public override void Close()
        {
            MainForm.Close();
        }
        public override void Delete()
        {
            MessageBox.Show("Видалення...");
        }

        #region Скрипти SQL
        private string qryEmployeeLoad { get; set; } =
            @"
select
  ve.*,
  veo.title
from vtemployee ve
  left join vtemployee veo on veo.empid = ve.ownerid
where ve.empid=:empid
            ";
        private string qryEmployeeSave { get; set; } =
            @"

            ";
        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Victors;

namespace ASF.Documents
{
    public interface idoc
    {
        string Type { get; }
        string Key { get; }
        bool isCreated { get; }
        bool isChanged { get; }
        void Create();
        void Show();
        void Close();
        void Save();
        void Delete();
    }
    public class idocDocument : idoc
    {
        protected virtual void Constructor(string key, FBClient client, string type)
        {
            Type = type;
            Key = key;
            Client = client;
            Load();
        }
        
        public idocDocument(string key, FBClient client, string type)
        {
            Constructor(key, client, type);
        }
        public idocDocument(int key, FBClient client, string type)
        {
            Constructor(key.ToString(), client, type);
        }
        public idocDocument(FBClient client, string type)
        {
            Constructor("", client, type);
        }

        public string Type { get; protected set; }
        public string Key { get; protected set; }

        public FBClient Client { get; private set; }

        virtual public void Load() { }

        public virtual bool isCreated { get; protected set; }
        public virtual bool isChanged { get; protected set; }

        virtual public void Create() { }
        virtual public void Show() { }
        virtual public void Close() { }
        virtual public void Save() { }
        virtual public void Delete() { }
    }
    public class idocWindowOrder : idocDocument
    {
        protected override void Constructor(string key, FBClient client, string type)
        {
            MainForm = new WindowOrderForm(this);
            base.Constructor(key, client, type);
        }
        public idocWindowOrder(string key, FBClient client) : base(key, client, "idocWindowOrder") { }
        public idocWindowOrder(int key, FBClient client) : base(key, client, "idocWindowOrder") { }
        public idocWindowOrder(FBClient client) : base("", client, "idocWindowOrder") { }
        public override void Load()
        {
            if (Key == "")
            {
                Create();

                AgreementDate = DateTime.Now;
                ProdDate = DateTime.MinValue;
                DateOrder = DateTime.MinValue;

                MainForm.Text = "Нове замовлення";
                Currency = "грн.";
                Owner = "Administrator";
            }
            else
            {
                DataTable dt = Client.QueryRecordsList(qryOrderLoad.ToString().Replace(":orderid", Key));
                if (dt != null && dt.Rows.Count > 0)
                {
                    AgreementDate = dt.Rows[0]["AgreementDate"].ToString() == "" ? DateTime.MinValue : (DateTime)dt.Rows[0]["AgreementDate"];
                    ProdDate = dt.Rows[0]["ProdDate"].ToString() == "" ? DateTime.MinValue : (DateTime)dt.Rows[0]["ProdDate"];
                    DateOrder = dt.Rows[0]["dateorder"].ToString() == "" ? DateTime.MinValue : (DateTime)dt.Rows[0]["dateorder"];

                    OrderNo = dt.Rows[0]["orderno"].ToString();
                    MainForm.Text = OrderNo;
                    AgreementNo = dt.Rows[0]["AgreementNo"].ToString();
                    Customer = new idocCustomer(dt.Rows[0]["CUSTOMERID"].ToString(), Client);
                    MainForm.tB_Customer.Text = dt.Rows[0]["VCUSTOMERNAME"].ToString(); 
                    TotalCost = 0;
                    TotalPrice = (decimal)dt.Rows[0]["TOTALPRICE"];
                    Currency = dt.Rows[0]["VCURRENCYNAME"].ToString();
                    RComment = dt.Rows[0]["RCOMMENT"].ToString();
                    Owner = dt.Rows[0]["VMANAGERNAME"].ToString();

                    isCreated = true;
                    isChanged = false;

                    MainForm.OrderStatesLoad();
                }
            }
        }

        private WindowOrderForm MainForm;
        
        public string OrderNo
        {
            get
            {
                return MainForm.tB_OrderNo.Text;
            }
            set
            {
                MainForm.tB_OrderNo.Text = value;
            }
        }
        public string AgreementNo
        {
            get
            {
                return MainForm.tB_AgreementNo.Text;
            }
            set
            {
                MainForm.tB_AgreementNo.Text = value;
            }
        }
        public DateTime DateOrder
        {
            get
            {
                return MainForm.dTP_DateOrder.Value;
            }
            set
            {
                MainForm.dTP_DateOrder.Value = value;
            }
        }
        public DateTime AgreementDate
        {
            get
            {
                return MainForm.dTP_AgreementDate.Value;
            }
            set
            {
                MainForm.dTP_AgreementDate.Value = value;
            }
        }
        private idocCustomer _Customer;
        public idocCustomer Customer
        {
            get
            {
                return _Customer;
            }
            set
            {
                MainForm.tB_Customer.Text = value.Name;
                _Customer = value;
            }
        }
        public string Currency
        {
            get
            {
                return MainForm.tB_Currency.Text;
            }
            set
            {
                MainForm.tB_Currency.Text = value;
            }

        }
        public DateTime ProdDate
        {
            get
            {
                return MainForm.dTP_ProdDate.Value;
            }
            set
            {
                MainForm.dTP_ProdDate.Value = value;
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
        public decimal TotalCost
        {
            get
            {
                return (decimal)MainForm.tB_TotalCost.Tag;
            }
            set
            {
                MainForm.tB_TotalCost.Tag = value;
                string text = string.Format(CultureInfo.InvariantCulture, "{0:#,0.00}", value);
                text = text.Replace(",", " ");
                MainForm.tB_TotalCost.Text = text;
            }
        }
        public decimal TotalPrice
        {
            get
            {
                return (decimal)MainForm.tB_TotalPrice.Tag;
            }
            set
            {
                MainForm.tB_TotalPrice.Tag = value;
                string text = string.Format(CultureInfo.InvariantCulture, "{0:#,0.00}", value);
                text = text.Replace(",", " ");
                MainForm.tB_TotalPrice.Text = text;
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
                MainForm.tB_RComment.Text = value;
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
            long key = Client.QueryValue(@"select gen_id(gen_orders, 1) from rdb$database");
            Key = key.ToString();
            isCreated = false;
            isChanged = true;
        }
        public override void Show()
        {
            try
            {
                MainForm.Visible = true;
            }
            catch (ObjectDisposedException)
            {
                MainForm = new CustomerForm(this);
                Load();
                MainForm.Visible = true;
            }
        }
        public override void Close()
        {
            MainForm.Close();
        }

        public override void Save()
        {
            if (isCreated)
            {
                string SQL = qryUpdateOrders;
            }
            else
            {
                string SQL = qryInsertIntoOrders;
            }
            MessageBox.Show("Збереження...");
        }
        public override void Delete()
        {
            MessageBox.Show("Видалення...");
        }

        #region Скрипти SQL
        private string qryOrderLoad { get; set; } =
            @"
select * from vtorders o where o.orderid=:orderid
            ";

        private string qryInsertIntoOrders { get; set; } =
            @"
insert into ORDERS
    (ORDERID,
    VALID, 
    GUIDHI,
    GUIDLO,
    PARENTID,
    OWNERTYPE,
    ORDERNO,
    AGREEMENTNO,
    AGREEMENTDATE,
    CUSTOMERID,
    CURRENCYID,
    CROSSRATE,
    SELLERID,
    OWNERID,
    ORDERSTATEID,
    PAYTYPEID,
    TOTALPRICE,
    TOTALPRICELOCK,
    PAYMENT,
    ADRESSINSTALL,
    FLOORINSTALL,
    PHONEINSTALL,
    DATEORDER,
    RCOMMENT,
    ORDERSTATUS,
    LASTGENITEM,
    ITEMSTATUSMODE,
    LABORIOUSNESS,
    PRODDATE,
    ISDEALERADD,
    ISDEALERSTARTADD,
    DEALERGUIDHI,
    DEALERGUIDLO,
    ISRESERVED,
    DATECREATED,
    ACCOUNTID)
values
    (:ORDERID, 
    :VALID,
    :GUIDHI,
    :GUIDLO,
    :PARENTID,
    :OWNERTYPE,
    :ORDERNO,
    :AGREEMENTNO,
    :AGREEMENTDATE,
    :CUSTOMERID,
    :CURRENCYID,
    :CROSSRATE,
    :SELLERID,
    :OWNERID,
    :ORDERSTATEID,
    :PAYTYPEID,
    :TOTALPRICE,
    :TOTALPRICELOCK,
    :PAYMENT,
    :ADRESSINSTALL,
    :FLOORINSTALL,
    :PHONEINSTALL,
    :DATEORDER,
    :RCOMMENT,
    :ORDERSTATUS,
    :LASTGENITEM,
    :ITEMSTATUSMODE,
    :LABORIOUSNESS,
    :PRODDATE,
    :ISDEALERADD,
    :ISDEALERSTARTADD,
    :DEALERGUIDHI,
    :DEALERGUIDLO,
    :ISRESERVED,
    current_timestamp,
    :ACCOUNTID)
            ";
        private string qryUpdateOrders { get; set; } =
            @"
update ORDERS set
    VALID = :VALID,
    GUIDHI = :GUIDHI,
    GUIDLO = :GUIDLO,
    PARENTID = :PARENTID,
    ORDERNO = :ORDERNO,
    AGREEMENTNO = :AGREEMENTNO,
    AGREEMENTDATE = :AGREEMENTDATE,
    CUSTOMERID = :CUSTOMERID,
    CURRENCYID = :CURRENCYID,
    CROSSRATE = :CROSSRATE,
    SELLERID = :SELLERID,
    OWNERID = :OWNERID,
    ORDERSTATEID = :ORDERSTATEID,
    PAYTYPEID = :PAYTYPEID,
    TOTALPRICE = :TOTALPRICE,
    TOTALPRICELOCK = :TOTALPRICELOCK,
    PAYMENT = :PAYMENT,
    ADRESSINSTALL = :ADRESSINSTALL,
    FLOORINSTALL = :FLOORINSTALL,
    PHONEINSTALL = :PHONEINSTALL,
    DATEORDER = :DATEORDER,
    RCOMMENT = :RCOMMENT,
    ORDERSTATUS = :ORDERSTATUS,
    LASTGENITEM = :LASTGENITEM,
    ITEMSTATUSMODE = :ITEMSTATUSMODE,
    LABORIOUSNESS = :LABORIOUSNESS,
    PRODDATE = :PRODDATE,
    FACTORYNUM = :FACTORYNUM,
    ISDEALERSTARTADD=:ISDEALERSTARTADD,
    ISRESERVED=:ISRESERVED,
    DATEMODIFIED = current_timestamp,
    ACCOUNTID = :ACCOUNTID
where ORDERID = :ORDERID
            ";
        #endregion Скрипти SQL
    }

    public class idocCustomer : idocDocument
    {
        protected override void Constructor(string key, FBClient client, string type)
        {
            MainForm = new CustomerForm(this);
            base.Constructor(key, client, type);
        }
        public idocCustomer(string key, FBClient client) : base(key, client, "idocCustomer") { }
        public idocCustomer(int key, FBClient client) : base(key, client, "idocCustomer") { }
        public idocCustomer(FBClient client) : base("", client, "idocCustomer") { }

        private CustomerForm MainForm;

        public override void Load()
        {
            if (Key == "")
            {
                Create();
                MainForm.Text = "Нове замовлення";
                Owner = "Administrator";
            }
            else
            {
                DataTable dt = Client.QueryRecordsList(qryCustomersLoad.ToString().Replace(":customerid", Key));
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
        public override void Show()
        {
            try
            {
                MainForm.Visible = true;
            }
            catch(ObjectDisposedException)
            {
                MainForm = new CustomerForm(this);
                Load();
                MainForm.Visible = true;
            }
        }
        public override void Close()
        {
            MainForm.Close();
        }

        public override void Save()
        {
            if (isCreated)
            {
                
            }
            else
            {
                
            }
            MessageBox.Show("Збереження...");
        }
        public override void Delete()
        {
            MessageBox.Show("Видалення...");
        }

        #region Скрипти SQL
        private string qryCustomersLoad { get; set; } =
            @"
select
  vc.*,
  p.persontitle ownerpersontitle
from vtcustomers vc
  left join (employee e
  join persons p on p.personid = e.personid
  ) on e.empid = vc.ownerid
where vc.customerid=:customerid
            ";
        #endregion

    }

}

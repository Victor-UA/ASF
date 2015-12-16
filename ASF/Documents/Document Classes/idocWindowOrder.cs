using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Victors;

namespace ASF.Documents
{
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
        public override void Load()
        {
            if (Key == "")
            {
                isCreated = false;
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
        public override void Show()
        {
            try
            {
                MainForm.Visible = true;
            }
            catch (ObjectDisposedException)
            {
                MainForm = new WindowOrderForm(this);
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
            Program.OrdersAreChanged = true;
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

}

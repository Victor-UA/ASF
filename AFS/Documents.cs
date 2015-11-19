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
    public interface idocDocument
    {
        string Type { get; }
        string Key { get; }
        bool isChanged { get; }
        bool isCreated { get; }
        void Show();
        void Save();
        void Delete();
    }
    
    public class idocWindowOrder : idocDocument
    {
        private void Constructor(string key, FBClient client)
        {
            Key = key;
            Client = client;
            MainForm = new WindowOrderForm(this);
            Load();
        }
        public idocWindowOrder(string key, FBClient client)
        {
            Constructor(key, client);
        }
        public idocWindowOrder(int key, FBClient client)
        {
            Constructor(key.ToString(), client);
        }
        public idocWindowOrder(FBClient client)
        {
            Constructor("", client);
        }


        private WindowOrderForm MainForm;

        public string Type { get; private set; } = "idocWindowOrder";
        public string Key { get; private set; }

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
        public string Customer
        {
            get
            {
                return MainForm.tB_Customer.Text;
            }
            set
            {
                MainForm.tB_Customer.Text = value;
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
                MainForm.tB_TotalCost.Text = string.Format(CultureInfo.InvariantCulture, "{0:#,0.00}", value);
                MainForm.tB_TotalCost.Text = MainForm.tB_TotalCost.Text.Replace(",", " ");
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
                MainForm.tB_TotalPrice.Text = string.Format(CultureInfo.InvariantCulture, "{0:#,0.00}", value);
                MainForm.tB_TotalPrice.Text = MainForm.tB_TotalPrice.Text.Replace(",", " ");
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

        public bool isCreated
        {
            get
            {
                return MainForm.isCreated;
            }
            private set
            {
                MainForm.isCreated = value;
            }
        }
        public bool isChanged
        {
            get
            {
                return MainForm.isChanged;
            }
            private set
            {
                MainForm.isChanged = value;
            }
        }
        public FBClient Client { get; private set; }

        public void Create()
        {
            long key = Client.QueryValue(@"select gen_id(gen_orders, 1) from rdb$database");
            Key = key.ToString();
            isCreated = false;
            isChanged = true;
        }
        public void Load()
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
                    Customer = dt.Rows[0]["VCUSTOMERNAME"].ToString();
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
        public void Save()
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
        public void Delete()
        {
            MessageBox.Show("Видалення...");
        }

        public void Show()
        {
            MainForm.Visible = true;
        }
        public void Close()
        {
            MainForm.Close();
        }

        //Скрипти SQL
        private string qryOrderLoad { get; set; } =
            @"
select * from vtorders o where o.orderid=:orderid
            ";
        //Скрипти SQL

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
    }
}

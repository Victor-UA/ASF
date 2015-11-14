using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            Key = Client.QueryValue(@"select gen_id(gen_orders, 1) from rdb$database").toString;
            isCreated = false;
            isChanged = true;
        }
        public void Load()
        {
            DataTable dt = Client.QueryRecordsList(qryOrderLoad.ToString().Replace(":orderid", Key));

            if (dt.Rows.Count > 0)
            {
                OrderNo = dt.Rows[0]["orderno"].ToString();
                MainForm.Text = OrderNo;
                DateOrder = dt.Rows[0]["dateorder"].ToString() == "" ? DateTime.MinValue : (DateTime)dt.Rows[0]["dateorder"];
                AgreementNo = dt.Rows[0]["AgreementNo"].ToString();
                AgreementDate = dt.Rows[0]["AgreementDate"].ToString() == "" ? DateTime.MinValue : (DateTime)dt.Rows[0]["AgreementDate"];

                isCreated = true;
                isChanged = false;
            }
            else
            {
                Create();
                OrderNo = "";
                MainForm.Text = "Нове замовлення";
                AgreementNo = "";
                DateOrder = DateTime.Now;
                AgreementDate = DateTime.Now;
            }
            MainForm.OrderStatesLoad();
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

        private WindowOrderForm MainForm;
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
            Create();
            Constructor(Key, client);
        }

        private void Constructor(string key, FBClient client)
        {
            Key = key;
            Client = client;
            MainForm = new WindowOrderForm(this);
            Load();
        }

        //Скрипти SQL
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
    }
}

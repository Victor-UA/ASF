using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Victors;

namespace ASF.Documents
{
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
            if (Key == "")
            {
                isCreated = false;
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
        public override void Save()
        {

            string SQL = qryCustomerSave;
            try
            {
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

                isChanged = false;
                isCreated = true;
                Program.CustomersAreChanged = true;
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
        private string qryCustomerSave { get; set; } =
            @"
execute block
as
  declare variable isCreated bool;
  declare variable guidhi num_int64;
  declare variable guidlo num_int64;
  declare variable contragid id;
  declare variable phoneid id;
  declare variable existing_phoneid id;
  declare variable addressid id;
  declare variable emailid id;
Begin

  select
    ca.contragid,
    ph.phoneid,
    ad.addressid,
    ea.emailid,
    ca.guidhi,
    ca.guidlo
  from customers cu
    join (contragents ca
    left join phones ph on ph.contragid = ca.contragid
    left join addresses ad on ad.contragid = ca.contragid
    left join emailaddresses ea on ea.contragid = ca.contragid
    ) on ca.contragid = cu.contragid
  where cu.customerid = :customerid
  into :contragid, :phoneid, :addressid, :emailid, :guidhi, :guidlo;

  isCreated = iif(:contragid is null, 0, 1);

  if (:contragid is null) then begin
    select
      cast(ng.guidhi as num_int64),
      cast(ng.guidlo as num_int64)
    from new_guid ng
    into :guidhi, :guidlo;

    select
      gen_id(gen_contragents, 1)
    from rdb$database
    into :contragid;
  end

  update or insert into contragents (contragid,name,persontype,website,guidhi,guidlo,rcomment)
  values (
    :contragid,
    :name,
    0,
    :website,
    :guidhi,
    :guidlo,
    :rcomment
  )
  matching(contragid);

  if (:_phone is null) then
    update contragents ca
    set ca.mainphoneid = null
    where ca.contragid=:contragid;
  else begin
    if (:phoneid is null) then
      select
        gen_id(gen_phone, 1)
      from rdb$database
      into :phoneid;
    else begin
      select
        ph.phoneid
      from phones ph
      where ph.phone=:_phone
      into :existing_phoneid;

      if (:existing_phoneid <> :phoneid) then
        phoneid = :existing_phoneid;
    end

    update or insert into phones (phoneid,contragid,phtypeid,phone)
    values (
      :phoneid,
      :contragid,
      1,
      :_phone
    )
    matching(phoneid);

    update contragents ca
    set ca.mainphoneid = :phoneid
    where ca.contragid = :contragid;
  end

  if (:addressid is null) then begin
    select
      cast(ng.guidhi as num_int64),
      cast(ng.guidlo as num_int64)
    from new_guid ng
    into :guidhi, :guidlo;

    select
      gen_id(gen_addresses, 1)
    from rdb$database
    into :addressid;
  end

  update or insert into addresses (addressid,contragid,addresstypeid,city,country,address,guidhi,guidlo,region,district,postalcode)
  values (
    :addressid,
    :contragid,
    2,
    :city,
    :country,
    :_address,
    :guidhi,
    :guidlo,
    :region,
    :district,
    :postalcode
  );

  if (:emailid is null) then begin
    select
      gen_id(gen_emailaddresses, 1)
    from rdb$database
    into :emailid;
  end

  update or insert into emailaddresses (emailid,contragid,email)
  values (
    :emailid,
    :contragid,
    :_email
  )
  matching(emailid);

  if (isCreated = 0) then begin
    select
      cast(ng.guidhi as num_int64),
      cast(ng.guidlo as num_int64)
    from new_guid ng
    into :guidhi, :guidlo;
  end
  update or insert into customers (customerid,contragid,payer,ownerid,guidhi,guidlo,isseller)
  values (
    :customerid,
    :contragid,
    0,
    :ownerid,
    :guidhi,
    :guidlo,
    0
  )
  matching(customerid);

End
            ";
        #endregion

    }

}

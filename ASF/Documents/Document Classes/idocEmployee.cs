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

        public string Title
        {
            get
            {
                return MainForm.tB_Title.Text;
            }
            set
            {
                MainForm.tB_Title.Text = value.ToString();
                MainForm.Text = value.ToString();
            }
        }
        public string Surname
        {
            get
            {
                return MainForm.tB_Surname.Text;
            }
            set
            {
                MainForm.tB_Surname.Text = value.ToString();
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
        public string Middlename
        {
            get
            {
                return MainForm.tB_Middlename.Text;
            }
            set
            {
                MainForm.tB_Middlename.Text = value.ToString();
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

        public string UserName
        {
            get
            {
                return MainForm.tB_UserName.Text;
            }
            set
            {
                MainForm.tB_UserName.Text = value.ToString();
            }
        }
        public string UserPassword
        {
            get
            {
                return MainForm.tB_UserPassword.Text;
            }
            set
            {
                MainForm.tB_UserPassword.Text = value.ToString();
            }
        }
        public bool Locked
        {
            get
            {
                return MainForm.cB_Locked.Checked;
            }
            set
            {
                MainForm.cB_Locked.Checked = value;
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
            long key = Client.QueryValue(@"select gen_id(gen_employee, 1) from rdb$database");
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
                MainForm.Text = "Новий співробітник";
                Owner = "Administrator";
            }
            else
            {
                DataTable dt = Client.QueryRecordsList(qryEmployeeLoad.ToString().Replace(":empid", Key));
                if (dt != null && dt.Rows.Count > 0)
                {
                    Title = dt.Rows[0]["Title"].ToString();
                    Surname = dt.Rows[0]["Surname"].ToString();
                    Name = dt.Rows[0]["Name"].ToString();
                    Middlename = dt.Rows[0]["Middlename"].ToString();

                    Phone = dt.Rows[0]["Phone"].ToString();
                    Email = dt.Rows[0]["Email"].ToString();

                    Address = dt.Rows[0]["Address"].ToString();
                    City = dt.Rows[0]["City"].ToString();
                    Region = dt.Rows[0]["Region"].ToString();
                    District = dt.Rows[0]["District"].ToString();
                    Country = dt.Rows[0]["Country"].ToString();
                    PostalCode = dt.Rows[0]["PostalCode"].ToString();

                    RComment = dt.Rows[0]["RComment"].ToString();

                    UserName = dt.Rows[0]["UserName"].ToString();
                    UserPassword = dt.Rows[0]["UserPassword"].ToString();
                    Locked = (int)dt.Rows[0]["Locked"] == 1 ? true : false;

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
                SQL = SQL.Replace(":empid", Key.ToString());
                SQL = SQL.Replace(":persontitle", "'" + Title.ToString() + "'");
                SQL = SQL.Replace(":personname", "'" + Name.ToString() + "'");
                SQL = SQL.Replace(":personmiddle", "'" + Middlename.ToString() + "'");
                SQL = SQL.Replace(":personlastname", "'" + Surname.ToString() + "'");
                
                SQL = SQL.Replace(":_phone", Phone.ToString() == "" ? "null" : "'" + Phone.ToString() + "'");

                SQL = SQL.Replace(":city", "'" + City.ToString() + "'");
                SQL = SQL.Replace(":country", "'" + Country.ToString() + "'");
                SQL = SQL.Replace(":region", "'" + Region.ToString() + "'");
                SQL = SQL.Replace(":district", "'" + District.ToString() + "'");
                SQL = SQL.Replace(":_address", "'" + Address.ToString() + "'");
                SQL = SQL.Replace(":postalcode", "'" + PostalCode.ToString() + "'");

                SQL = SQL.Replace(":_email", "'" + Email.ToString() + "'");

                SQL = SQL.Replace(":rcomment", "'" + RComment.ToString() + "'");
                SQL = SQL.Replace(":ownerid", "0"); //Тимчасово!

                SQL = SQL.Replace(":locked", Locked ? "1" : "0");
                SQL = SQL.Replace(":username", "'" + UserName.ToString() + "'");
                SQL = SQL.Replace(":userpassword", "'" + UserPassword.ToString() + "'");

                Client.ExecuteSQLCommit(SQL);

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
  veo.title ownerpersontitle,
  veo.empid ownerid,
  ad.*,
  ea.*,
  (
    select
      e.userpwd
    from employee e
    where e.empid=ve.empid
  ) userpassword
from vtemployee ve
  join vtemployee veo on veo.empid = ve.ownerid
  left join addresses ad on ad.addressid=ve.mainaddressid
left join EMAILADDRESSES ea on ea.emailid=ve.mainemailid
where ve.empid=:empid
            ";
        private string qryEmployeeSave { get; set; } =
            @"
execute block
as
  declare variable isCreated bool;
  declare variable guidhi num_int64;
  declare variable guidlo num_int64;
  declare variable personid id;
  declare variable contragid id;
  declare variable phoneid id;
  declare variable existing_phoneid id;
  declare variable addressid id;
  declare variable emailid id;
Begin

  select
    p.personid,
    p.mainphoneid,
    p.mainaddressid,
    p.mainemailid,
    p.guidhi,
    p.guidlo
  from employee e 
    join persons p on p.personid=e.personid
  where e.empid = :empid
  into :personid, :phoneid, :addressid, :emailid, :guidhi, :guidlo;

  isCreated = iif(:personid is null, 0, 1);

  select
    ca.contragid
  from contragents ca
  where ca.name = 'ASF'
  into :contragid;

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
    insert into contragents (contragid,name,persontype,guidhi,guidlo,rcomment)
    values (
      :contragid,
      'ASF',
      1,
      :guidhi,
      :guidlo,
      'Наша компанія'
    );
  end

  if (:personid is null) then begin
    select
      cast(ng.guidhi as num_int64),
      cast(ng.guidlo as num_int64)
    from new_guid ng
    into :guidhi, :guidlo;
    select
      gen_id(gen_person, 1)
    from rdb$database
    into :personid;
  end

  update or insert into persons (personid, contragid, persontitle, personname, personmiddle, personlastname, guidhi, guidlo)
  values (
    :personid,
    :contragid,
    :persontitle,
    :personname,
    :personmiddle,
    :personlastname,
    :guidhi,
    :guidlo
  )
  matching(personid);

  if (:_phone is null) then
    update persons p
    set p.mainphoneid = null
    where p.personid=:personid;
  else begin
    if (:phoneid is null) then
      select
        gen_id(gen_phone, 1)
      from rdb$database
      into :phoneid;
    else begin
      select first 1
        ph.phoneid
      from phones ph
      where ph.phone=:_phone
      order by 1 desc
      into :existing_phoneid;

      if (:existing_phoneid <> :phoneid) then
        phoneid = :existing_phoneid;
    end

    update or insert into phones (phoneid,personid,phtypeid,phone)
    values (
      :phoneid,
      :personid,
      1,
      :_phone
    )
    matching(phoneid);

    update persons p
    set p.mainphoneid = :phoneid
    where p.personid = :personid;
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

  update or insert into addresses (addressid,contragid,personid,addresstypeid,city,country,address,guidhi,guidlo,region,district,postalcode)
  values (
    :addressid,
    :contragid,
    :personid,
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

  update or insert into emailaddresses (emailid,contragid,personid,email)
  values (
    :emailid,
    :contragid,
    :personid,
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
  update or insert into employee (empid,personid,locked,username,userpwd,ownerid,guidhi,guidlo)
  values (
    :empid,
    :personid,
    :locked,
    :username,
    :userpassword,
    :ownerid,
    :guidhi,
    :guidlo
  )
  matching(empid);

End
            ";
        #endregion

    }
}

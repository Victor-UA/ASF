using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Victors;

namespace ASF.Documents
{
    public class idocOrderState : idocDocument
    {
        protected override void Constructor(string key, FBClient client, string type)
        {
            MainForm = new OrderStateForm(this);
            base.Constructor(key, client, type);
        }
        public idocOrderState(string key, FBClient client) : base(key, client, "idocOrderState") { }
        public idocOrderState(int key, FBClient client) : base(key, client, "idocOrderState") { }
        public idocOrderState(FBClient client) : base("", client, "idocOrderState") { }

        private OrderStateForm MainForm;

        public string Name
        {
            get
            {
                return MainForm.tB_Name.Text;
            }
            set
            {
                MainForm.tB_Name.Text = value.ToString();
                MainForm.Text = value.ToString();
            }
        }
        public string Code
        {
            get
            {
                return MainForm.tB_Code.Text.ToString();
            }
            set
            {
                MainForm.tB_Code.Text = value.ToString();
            }
        }
        public int StateType
        {
            get
            {
                try
                {
                    return Convert.ToInt32(MainForm.tB_StateType.Text);
                }
                catch
                {
                    return 0;
                }
            }
            set
            {
                MainForm.tB_StateType.Text = value.ToString();
            }
        }
        public int Level
        {
            get
            {
                try
                {
                    return Convert.ToInt32(MainForm.tB_Level.Text);
                }
                catch
                {
                    return 0;
                }  

            }
            set
            {
                MainForm.tB_Level.Text = value.ToString();
            }
        }
        public int Index
        {
            get
            {
                try
                {
                    return Convert.ToInt32(MainForm.tB_Index.Text);
                }
                catch
                {
                    return 0;
                }
            }
            set
            {
                MainForm.tB_Index.Text = value.ToString();
            }
        }
        private idocOrderState Switchover_ = null;
        public idocOrderState Switchover
        {
            get
            {
                return Switchover_;
            }
            set
            {
                Switchover_ = value;
                MainForm.tB_Switchover.Text = value == null ? "" : value.Name.ToString();
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
            long key = Client.QueryValue(@"select gen_id(gen_orderstates, 1) from rdb$database");
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
                MainForm.Text = "Новий стан";
                Owner = Program.UserContext;
            }
            else
            {
                DataTable dt = new DataTable();
                try
                {
                    dt = Client.QueryRecordsList(qryOrderStatesLoad.ToString().Replace(":orderstateid", Key));
                }
                catch (Exception e)
                {
                    MessageBox.Show
                        (
                            "Помилка завантаження історії зміни станів замовлення\r" + 
                            e.Message
                        );
                }
                if (dt.Rows.Count > 0)
                {
                    Name = dt.Rows[0]["Name"].ToString();
                    Code = dt.Rows[0]["Code"].ToString();
                    try
                    {
                        Level = Convert.ToInt32(dt.Rows[0]["STATELEVEL"].ToString());
                    }
                    catch
                    {
                        Level = 0;
                    }

                    try
                    {
                        StateType = Convert.ToInt32(dt.Rows[0]["STATETYPE"].ToString());
                    }
                    catch
                    {
                        StateType = 0;
                    }
                    
                    try
                    {
                        Index = Convert.ToInt32(dt.Rows[0]["RECINDEX"].ToString());
                    }
                    catch
                    {
                        Index = 0;
                    }

                    Switchover = dt.Rows[0]["ADDORDERSTATEID"].ToString() == "null" ? null : new idocOrderState(dt.Rows[0]["ADDORDERSTATEID"].ToString(), Client);
                    
                    RComment = dt.Rows[0]["RComment"].ToString();

                    Owner = new idocEmployee(dt.Rows[0]["ownerid"].ToString(), Client);
                    MainForm.toolStripStatusOwner.Text = Owner.Title;

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
                MainForm = new OrderStateForm(this);
                Load();
                MainForm.Visible = true;
            }
        }
        public override void Save()
        {

            string SQL = qryOrderStateSave;
            try
            {
                if (!Owner.isCreated)
                {
                    Owner = Program.UserContext;
                }
                SQL = SQL.Replace(":orderstateid_", Key.ToString());
                SQL = SQL.Replace(":name", "'" + Name.ToString() + "'");
                SQL = SQL.Replace(":code", "'" + Code.ToString() + "'");
                SQL = SQL.Replace(":statelevel", Level.ToString());
                SQL = SQL.Replace(":recindex", Index.ToString());
                SQL = SQL.Replace(":addorderstateid", Switchover == null ? "null" : Switchover.Key.ToString());

                SQL = SQL.Replace(":rcomment", "'" + RComment.ToString() + "'");
                SQL = SQL.Replace(":ownerid", isCreated ? Owner.Key : Program.UserContext.Key);
                
                Client.ExecuteSQLCommit(SQL);

                MainForm.toolStripStatusOwner.Text = Owner.Title;

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
        private string qryOrderStatesLoad { get; set; } =
            @"
select
  vs.orderstateid,
  vs.name,
  vs.code,
  vs.statetype,
  vs.statelevel,
  coalesce(vs.addorderstateid, 'null') addorderstateid,
  vs.recindex,
  coalesce(vs.rcomment, '') rcomment,
  vs.guidhi,
  vs.guidlo,
  coalesce(vs.ownerid, 0) ownerid,
  vs.deleted
from VTORDERSTATES vs
where vs.orderstateid=:orderstateid
            ";
        private string qryOrderStateSave { get; set; } =
            @"
execute block
as
  declare variable guidhi num_int64;
  declare variable guidlo num_int64;
  declare variable orderstateid id;
  declare variable addorderstateid id;
Begin

  select
    os.orderstateid,
    os.guidhi,
    os.guidlo,
    os.addorderstateid
  from orderstates os
  where os.orderstateid=:orderstateid_
  into :orderstateid, :guidhi, :guidlo, :addorderstateid;

  if (:orderstateid is null) then begin
    select
      cast(ng.guidhi as num_int64),
      cast(ng.guidlo as num_int64)
    from new_guid ng
    into :guidhi, :guidlo;

    orderstateid = :orderstateid_;
  end

  update or insert into orderstates (orderstateid,recindex,name,code,statetype,statelevel,addorderstateid,ownerid,guidhi,guidlo,rcomment)
  values (
    :orderstateid,
    :recindex,
    :name,
    :code,
    0,
    :statelevel,
    :addorderstateid,
    :ownerid,
    :guidhi,
    :guidlo,
    :rcomment
  )
  matching(orderstateid);

End

            ";
        #endregion

    }

}

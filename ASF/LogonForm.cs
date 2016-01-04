using System;
using System.Data;
using Victors;
using System.Windows.Forms;
using ASF.Documents;

namespace ASF
{
    public partial class LogonForm : Form
    {
        public LogonForm()
        {
            InitializeComponent();
        }

        private void b_Enter_Click(object sender, EventArgs e)
        {
            FBClient Client = new FBClient(Program.BaseConnectionString); 
            string SQL = qryUserPassword;
            SQL = SQL.Replace(":username", "'"+tB_Login.Text+"'");
            DataTable dt = Client.QueryRecordsList(SQL);

            if (dt != null && dt.Rows.Count > 0)
            {
                Program.UserContext = new idocEmployee(dt.Rows[0]["empid"].ToString(), Client);
                Program.LogonisOk = Program.UserContext.UserPassword == tB_Password.Text;
                //Program.LogonisOk = true;
                if (Program.LogonisOk)
                {
                    Close();
                }
                else
                {
                    MessageBox.Show("Неправильний пароль");
                    tB_Password.SelectAll();
                    tB_Password.Focus();
                }
            }
            else
            {
                MessageBox.Show("Неправильний пароль");
                tB_Password.SelectAll();
                tB_Password.Focus();
            }
        }
        private void b_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LogonForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '\x27':
                    Close();
                    break;
            }
            
        }
        private void tB_Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '\r':
                    b_Enter_Click(sender, new EventArgs());
                    break;
            }
        }
        private void tB_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '\r':
                    b_Enter_Click(sender, new EventArgs());
                    break;
            }
        }
        #region Скрипти SQL
        private string qryUserPassword { get; set; } =
            @"
select
  e.empid,
  e.userpwd
from employee e
where lower(e.username)=lower(:username)
            ";
        #endregion

    }
}

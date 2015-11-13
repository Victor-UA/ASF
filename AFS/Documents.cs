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
        public FBClient Client { get; private set; }
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
        private void Create()
        {
            Key = Client.QueryValue(@"select gen_id(gen_orders, 1) from rdb$database").toString;
            isCreated = false;
            isChanged = true;
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
            MainForm = new WindowOrderForm(this);
            if (client.QueryValue(@"select orderid from orders where orderid=" + key) == null)
            {
                Create();
            }
            else
            {
                Key = key;
                isCreated = true;
                isChanged = false;
            }
            Client = client;
        }
        public void Save()
        {
            MainForm.Save();
        }
        public void Show()
        {
            MainForm.Visible = true;
        }
        public void Close()
        {
            MainForm.Close();
        }
        public void Delete()
        {
            MessageBox.Show("Видалення...");
        }
    }
}

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
    }
    
    public class idocWindowOrder : idocDocument
    {
        public string Type { get; private set; } = "idocWindowOrder";
        public string Key { get; private set; }
        private Form MainForm;
        public idocWindowOrder(string key, FBClient client)
        {
            Constructor(key, client);
        }
        public idocWindowOrder(int key, FBClient client)
        {
            Constructor(key.ToString(), client);
        }
        
        private void Constructor(string key, FBClient client)
        {
            Key = key;
            MainForm = new WindowOrderForm(key, client);
        }
        public void Show()
        {
            MainForm.Visible = true;
        }
        public void Close()
        {
            MainForm.Close();
        }
    }
}

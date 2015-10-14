using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public idocWindowOrder(string key)
        {
            Constructor(key);
        }
        public idocWindowOrder(int key)
        {
            Constructor(key.ToString());
        }
        
        private void Constructor(string key)
        {
            Key = key;
            MainForm = new WindowOrderForm(key);
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASF.Dialogs.Dialog_Forms
{
    public partial class InputDialogForm : Form
    {
        public InputDialogForm(string label, string caption)
        {
            InitializeComponent();

        }

        public string Label
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }
        public string Caption
        {
            get
            {
                return Text;
            }
            set
            {
                Text = value;
            }
        }
        public string Result
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

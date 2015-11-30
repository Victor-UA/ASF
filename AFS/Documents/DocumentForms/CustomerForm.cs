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
    public partial class CustomerForm : DocumentForm
    {
        public CustomerForm(idocCustomer document) : base()
        {
            Document = document;
            InitializeComponent();
        }
        private idocCustomer Document { get; set; }
    }
}

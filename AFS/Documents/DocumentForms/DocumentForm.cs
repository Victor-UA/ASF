using System.Windows.Forms;

namespace ASF.Documents
{
    public class DocumentForm : Form
    {
        public DocumentForm() : base() { }

        protected bool _ReadOnly = false;
        protected bool _isChanged;
        protected bool _CanBeSaved = true;

        public virtual bool isCreated { get; set; } = true;
        public virtual bool isChanged { get; set; }
    }
}

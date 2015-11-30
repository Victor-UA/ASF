using System.Windows.Forms;

namespace ASF.Documents
{
    public class DocumentForm : Form
    {
        public DocumentForm() : base() { }

        public virtual bool isCreated { get; set; } = true;
        public virtual bool isChanged { get; set; }
    }
}

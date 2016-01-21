using ASF.Dialogs.Dialog_Forms;
using System.Windows.Forms;

namespace ASF.Dialogs.Dialog_Classes
{
    static class Prompt
    {
        public static string InputDialog(string label, string caption)
        {
            InputDialogForm form = new InputDialogForm(label, caption);
            form.Label = label;
            form.Caption = caption;
            return form.ShowDialog() == DialogResult.OK ? form.Result : "";
        }
    }
}

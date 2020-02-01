using System.Diagnostics;
using System.Windows.Forms;

namespace Example1.Classes
{
    public static class Dialogs
    {
        [DebuggerStepThrough]
        public static bool Question(string Text)
        {
            return (MessageBox.Show(
                        Text,
                        Application.ProductName,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) == DialogResult.Yes);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxDataBinding
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CorrectButton_Click(object sender, EventArgs e)
        {
            var f = new CorrectForm();
            f.ShowDialog();
        }

        private void InCorrectButton_Click(object sender, EventArgs e)
        {
            var f = new IncorrectForm();
            f.ShowDialog();
        }
    }
}

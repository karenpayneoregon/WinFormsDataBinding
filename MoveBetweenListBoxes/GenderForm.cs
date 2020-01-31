using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoveBetweenListBoxes.Classes;

namespace MoveBetweenListBoxes
{
    /// <summary>
    /// When displaying reference table data the primary key
    /// is needed for applying to a new customer or editing
    /// a customer.
    ///
    /// Many coders will opt for a DataTable which works but
    /// is overkill for simply showing a column and access
    /// to the primary key column
    /// </summary>
    public partial class GenderForm : Form
    {
        public GenderForm()
        {
            InitializeComponent();

            Shown += GenderForm_Shown;

        }

        private async void GenderForm_Shown(object sender, EventArgs e)
        {
            var ops = new SqlServerOperations();
            var genderList = await ops.GenderList();

            listBox1.DataSource = genderList;

            IdentifierLabel.DataBindings.Add("Text", genderList, "Id");

        }
    }
}

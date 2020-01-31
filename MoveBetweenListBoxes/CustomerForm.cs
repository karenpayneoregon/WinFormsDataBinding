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
using MoveBetweenListBoxes.Extensions;

namespace MoveBetweenListBoxes
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
            Shown += Form1_Shown;
        }
        private BindingList<Customer> _bindingListOriginalData = new BindingList<Customer>();
        private BindingList<Customer> _bindingListRight = new BindingList<Customer>();

        private async void Form1_Shown(object sender, EventArgs e)
        {

            var ops = new SqlServerOperations();
            _bindingListOriginalData = new BindingList<Customer>(await ops.CustomersList());
            listBox1.DataSource = _bindingListOriginalData;
            
            listBox2.DataSource = _bindingListRight;
            listBox2.DisplayMember = "CompanyName";

            listBox1.DoubleClick += ListBox1_DoubleClick;
            listBox2.DoubleClick += ListBox2_DoubleClick;
        }


        private void ListBox1_DoubleClick(object sender, EventArgs e)
        {
            MoveFromLeftToRight();
        }
        private void ListBox2_DoubleClick(object sender, EventArgs e)
        {
            MoveFromRightToLeft();
        }

        private void MoveItemLeftToRightButton_Click(object sender, EventArgs e)
        {
            MoveFromLeftToRight();
        }

        private void MoveItemRightToLeftButton_Click(object sender, EventArgs e)
        {
            MoveFromRightToLeft();
        }

        private void MoveFromLeftToRight()
        {
            if (_bindingListOriginalData.Count != 0)
            {
                _bindingListRight.Add((Customer)listBox1.SelectedItem);
                _bindingListOriginalData.Remove((Customer)listBox1.SelectedItem);
            }
        }

        private void MoveFromRightToLeft()
        {
            if (_bindingListRight.Count != 0)
            {
                var cust = (Customer)listBox2.SelectedItem;
                _bindingListOriginalData.Add(cust);
                _bindingListRight.Remove(cust);
            }
        }
        /// <summary>
        /// Names are un ordered but can be ordered via OrderBy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetCustomersButton1_Click(object sender, EventArgs e)
        {
            var results = _bindingListOriginalData.Select(customer => customer.CompanyName);
            if (!results.Any())
            {
                MessageBox.Show("List is empty");
            }
            else
            {
                MessageBox.Show(string.Join("\n", results));
            }
        }

        private void GetCustomersButton2_Click(object sender, EventArgs e)
        {
            var results = _bindingListRight.Select(customer => customer.CompanyName);
            if (!results.Any())
            {
                MessageBox.Show("List is empty");
            }
            else
            {
                MessageBox.Show(string.Join("\n", results));
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ListBoxDataBinding.Classes;

namespace ListBoxDataBinding
{
    public partial class IncorrectForm : Form
    {

        public IncorrectForm()
        {
            InitializeComponent();
            CustomerListBox.DataSource = new List<CustomerPlain>();
            CustomerListBox.DisplayMember = "FullName";
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(FirstNameTextBox.Text) && !string.IsNullOrWhiteSpace(LastNameTextBox.Text))
            {
                var customers = ((List<CustomerPlain>)CustomerListBox.DataSource);
                customers.Add(new CustomerPlain() {FirstName = FirstNameTextBox.Text, LastName = LastNameTextBox.Text});

                ListCountLabel.Text = $"ListBox count: {CustomerListBox.Items.Count}  Customer List count: {customers.Count}";
            }
        }
    }
}

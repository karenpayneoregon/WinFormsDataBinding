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
    public partial class CorrectForm : Form
    {

        private readonly BindingList<Customer> _customersBindingList = new BindingList<Customer>();

        public CorrectForm()
        {
            InitializeComponent();

            CustomerListBox.DataSource = _customersBindingList;
            CustomerListBox.DisplayMember = "FullName";

        }
        /// <summary>
        /// Add new customer which will display in the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCustomerButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(AddFirstNameTextBox.Text) || 
                string.IsNullOrWhiteSpace(AddLastNameTextBox.Text)) return;

            var customer = new Customer()
            {
                FirstName = AddFirstNameTextBox.Text,
                LastName = AddLastNameTextBox.Text
            };

            _customersBindingList.Add(customer);

            EditCustomerButton.Enabled = true;

            ListCountLabel.Text = 
                $"ListBox count: {CustomerListBox.Items.Count}  " + $"" +
                $"Customer List count: {_customersBindingList.Count}";

        }

        private void EditCustomerButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EditFirstNameTextBox.Text) || 
                string.IsNullOrWhiteSpace(EditLastNameTextBox.Text)) return;

            if (CustomerListBox.SelectedIndex <= -1) return;

            _customersBindingList[CustomerListBox.SelectedIndex].FirstName = 
                EditFirstNameTextBox.Text;

            _customersBindingList[CustomerListBox.SelectedIndex].LastName = 
                EditLastNameTextBox.Text;
        }

    }
}

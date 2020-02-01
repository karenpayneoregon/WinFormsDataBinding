using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Example1Library.Classes;


namespace Example1
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _bindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataError += DataGridView1_DataError;
            _bindingSource.AddingNew += _bindingSource_AddingNew;
            Shown += Form1_Shown;

        }
        /// <summary>
        /// Assign new identifier, for a real application this would
        /// be handled differently.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _bindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {

            var id = ((List<Customer>) _bindingSource.DataSource)
                     .Select(customer => customer.Id).Max() + 1;

            e.NewObject = new Customer() {Id = id};
        }

        /// <summary>
        /// Quickly get out of trouble, for a production application this
        /// is not the way to go, instead present the user with an easy to
        /// understand message or even better use assertion to prevent this
        /// e.g. for a date column present the cell as a date, not text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show($"Issue: {e.Exception.Message}");
            e.Cancel = true;           
            SendKeys.Send("{ESC}");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            var fileOperations = new FileOperations();
            var fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Import1.txt");

            _bindingSource.DataSource = fileOperations.ReadCustomersPerfectWorld(fileName);

            dataGridView1.DataSource = _bindingSource;

            IdentifierLabel.DataBindings.Add("Text", _bindingSource, "id");
            FirstNameTextBox.DataBindings.Add("Text", _bindingSource, "FirstName");
            LastNameTextBox.DataBindings.Add("Text", _bindingSource, "LastName");
        }
    }
}

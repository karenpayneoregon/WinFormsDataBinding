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
            Shown += Form1_Shown;

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

            FirstNameTextBox.DataBindings.Add("Text", _bindingSource, "FirstName");
            LastNameTextBox.DataBindings.Add("Text", _bindingSource, "LastName");
        }
    }
}

using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace BindingSourceAddingNew
{
    public partial class MainForm : Form
    {
        private readonly BindingSource _bindingSource = new BindingSource();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var mockedData = new DataTable())
            {
                mockedData.Columns.AddRange(new[] {
                    new DataColumn {ColumnName = "Identifier",
                        DataType = typeof(int),
                        AutoIncrement = true},
                    new DataColumn("PartName", typeof(string)),
                    new DataColumn("partqty", typeof(int)),
                    new DataColumn("Cost", typeof(decimal))
                    }
                );

                mockedData.Rows.Add(null, "Part A", 100, 45.99F);
                mockedData.Rows.Add(null, "Part 99", 34, 20.99F);
                mockedData.Rows.Add(null, "Part B", 4, 2.45F);

                _bindingSource.DataSource = mockedData;

                bindingNavigator1.BindingSource = _bindingSource;

                textBox1.DataBindings.Add("Text", _bindingSource, "PartName");
                textBox2.DataBindings.Add("Text", _bindingSource, "partqty");
                textBox3.DataBindings.Add("Text", _bindingSource, "Cost");

                _bindingSource.AddingNew += _bindingSource_AddingNew;

            }
        }

        private void _bindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            DataView dataView = _bindingSource.List as DataView;
            DataRowView dataRowView = dataView.AddNew();

            dataRowView["PartName"] = "Just added";
            dataRowView["partqty"] = 10;

            e.NewObject = dataRowView;

            _bindingSource.MoveLast();
        }

        private void AddNewRecordToolButton_Click(object sender, EventArgs e)
        {
            _bindingSource.AddNew();
        }
    }
}
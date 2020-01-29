using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonPractice.Interfaces;
using Normal = CommonPractice.BaseExampleClasses;
using nf = CommonPractice.BaseNotifyClasses;
using  jet = CommonPractice.BaseJetNotifyClasses;

namespace CommonPractice
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _bindingSource = new BindingSource();
        private readonly StringBuilder _stringBuilder = new StringBuilder();
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Pause for one second to see new results as
        /// the text box results will be the same always while the
        /// ListBox will be different for the common method with no
        /// BindingSource.
        /// </summary>
        /// <returns></returns>
        private async Task PrepareForPopulatingListBox()
        {
            _stringBuilder.Clear();
            ResultsTextBox.Text = "";

            _bindingSource.DataSource = null;
            listBox1.DataSource = null;

            await Task.Delay(1000);
        }

        private async void CommonSolutionNonBindingSourceButton_Click(object sender, EventArgs e)
        {
            await PrepareForPopulatingListBox();

            listBox1.DataSource = new List<Normal.Person>()
            {
                new Normal.Person() { Id = 1, FirstName = "Jane", LastName = "Smith"},
                new Normal.Person() { Id = 2, FirstName = "Amy", LastName = "Jones" }
            };

            ((List<Normal.Person>)listBox1.DataSource).Add(new Normal.Person()
            {
                Id = 3, FirstName = "Pat",
                LastName = "Lebow"
            });

            ((Normal.Person)listBox1.Items[0]).FirstName = "Kane";


            var peopleList = (List<Normal.Person>)listBox1.DataSource;

            foreach (Normal.Person person in peopleList)
            {
                _stringBuilder.AppendLine(person.ToString());
            }

            ResultsTextBox.Text = _stringBuilder.ToString();
        }

        private async void ExampleBaseButton_Click(object sender, EventArgs e)
        {
            await PrepareForPopulatingListBox();

            _bindingSource.DataSource = new List<Normal.Person>()
            {
                new Normal.Person() { Id = 1, FirstName = "Jane", LastName = "Smith"},
                new Normal.Person() { Id = 2, FirstName = "Amy", LastName = "Jones" }
            };

            ((List<Normal.Person>)_bindingSource.DataSource).Add(new Normal.Person()
            {
                Id = 3, FirstName = "Pat",
                LastName = "Lebow"
            });

            listBox1.DataSource = _bindingSource;

            ((Normal.Person)_bindingSource[0]).FirstName = "Kane";


            var peopleList = (List<Normal.Person>)_bindingSource.DataSource;

            foreach (Normal.Person person in peopleList)
            {
                _stringBuilder.AppendLine(person.ToString());
            }

            ResultsTextBox.Text = _stringBuilder.ToString();

        }

        private async void INotifyPropertyChangedButton_Click(object sender, EventArgs e)
        {
            await PrepareForPopulatingListBox();

            _bindingSource.DataSource = new List<nf.Person>()
            {
                new nf.Person() { Id = 1, FirstName = "Jane", LastName = "Smith"},
                new nf.Person() { Id = 2, FirstName = "Amy", LastName = "Jones" }
            };

            ((List<nf.Person>)_bindingSource.DataSource).Add(new nf.Person()
            {
                Id = 3,
                FirstName = "Pat",
                LastName = "Lebow"
            });

            listBox1.DataSource = _bindingSource;

            ((nf.Person)_bindingSource[0]).FirstName = "Kane";


            var peopleList = (List<nf.Person>)_bindingSource.DataSource;

            foreach (nf.Person person in peopleList)
            {
                _stringBuilder.AppendLine(person.ToString());
            }

            ResultsTextBox.Text = _stringBuilder.ToString();
        }

        private async void JetBrainsINotifyPropertyChangedButton_Click(object sender, EventArgs e)
        {
            await PrepareForPopulatingListBox();

            _bindingSource.DataSource = new List<jet.Person>()
            {
                new jet.Person() { Id = 1, FirstName = "Jane", LastName = "Smith"},
                new jet.Person() { Id = 2, FirstName = "Amy", LastName = "Jones" }
            };

            ((List<jet.Person>)_bindingSource.DataSource).Add(new jet.Person()
            {
                Id = 3,
                FirstName = "Pat",
                LastName = "Lebow"
            });

            listBox1.DataSource = _bindingSource;

            ((jet.Person)_bindingSource[0]).FirstName = "Kane";


            var peopleList = (List<jet.Person>)_bindingSource.DataSource;

            foreach (jet.Person person in peopleList)
            {
                _stringBuilder.AppendLine(person.ToString());
            }

            ResultsTextBox.Text = _stringBuilder.ToString();
        }
        private void CurrentPersonButton_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current == null)
            {
                return;
            }

            MessageBox.Show(((IPerson)_bindingSource.Current).LastName);
        }


    }
}

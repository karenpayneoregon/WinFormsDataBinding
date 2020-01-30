using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonPractice.HelperClasses;
using CommonPractice.Interfaces;
using static CommonPractice.HelperClasses.SysColors;
using Normal = CommonPractice.BaseExampleClasses;
using nf = CommonPractice.BaseNotifyClasses;
using jetVersion = CommonPractice.BaseJetNotifyClasses;

namespace CommonPractice
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _personBindingSource = new BindingSource();
        private readonly BindingSource _colorsBindingSource = new BindingSource();

        private readonly StringBuilder _stringBuilder = new StringBuilder();
        public Form1()
        {
            InitializeComponent();

            SetupColorComboBoxes();
        }

        private void SetupColorComboBoxes()
        {
            // add colors starting with the letter A
            ColorsComboBox1.DataSource = ColorsBeginningWithA();
            // add colors starting with B, will not show up
            var bColors = ColorsBeginningWithB();
            ((List<nf.ColorItem>)ColorsComboBox1.DataSource).AddRange(bColors.ToArray());

            /*
             * We need to use a BindingList to allow a ComboBox to recognize new
             * items added.
             */
            var bColorList = new BindingList<nf.ColorItem>(ColorsBeginningWithA());

            ColorsComboBox2.DataSource = bColorList;
            bColorList.AddColors(bColors);

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

            _personBindingSource.DataSource = null;
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
                Id = 3,
                FirstName = "Pat",
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

            _personBindingSource.DataSource = new List<Normal.Person>()
            {
                new Normal.Person() { Id = 1, FirstName = "Jane", LastName = "Smith"},
                new Normal.Person() { Id = 2, FirstName = "Amy", LastName = "Jones" }
            };

            ((List<Normal.Person>)_personBindingSource.DataSource).Add(new Normal.Person()
            {
                Id = 3,
                FirstName = "Pat",
                LastName = "Lebow"
            });

            listBox1.DataSource = _personBindingSource;

            ((Normal.Person)_personBindingSource[0]).FirstName = "Kane";


            var peopleList = (List<Normal.Person>)_personBindingSource.DataSource;

            foreach (Normal.Person person in peopleList)
            {
                _stringBuilder.AppendLine(person.ToString());
            }

            ResultsTextBox.Text = _stringBuilder.ToString();

        }

        private async void INotifyPropertyChangedButton_Click(object sender, EventArgs e)
        {
            await PrepareForPopulatingListBox();

            _personBindingSource.DataSource = new List<nf.Person>()
            {
                new nf.Person() { Id = 1, FirstName = "Jane", LastName = "Smith"},
                new nf.Person() { Id = 2, FirstName = "Amy", LastName = "Jones" }
            };

            ((List<nf.Person>)_personBindingSource.DataSource).Add(new nf.Person()
            {
                Id = 3,
                FirstName = "Pat",
                LastName = "Lebow"
            });

            listBox1.DataSource = _personBindingSource;

            ((nf.Person)_personBindingSource[0]).FirstName = "Kane";


            var peopleList = (List<nf.Person>)_personBindingSource.DataSource;

            foreach (nf.Person person in peopleList)
            {
                _stringBuilder.AppendLine(person.ToString());
            }

            ResultsTextBox.Text = _stringBuilder.ToString();
        }

        private async void JetBrainsINotifyPropertyChangedButton_Click(object sender, EventArgs e)
        {
            await PrepareForPopulatingListBox();

            _personBindingSource.DataSource = new List<jetVersion.Person>()
            {
                new jetVersion.Person() { Id = 1, FirstName = "Jane", LastName = "Smith"},
                new jetVersion.Person() { Id = 2, FirstName = "Amy", LastName = "Jones" }
            };

            ((List<jetVersion.Person>)_personBindingSource.DataSource).Add(new jetVersion.Person()
            {
                Id = 3,
                FirstName = "Pat",
                LastName = "Lebow"
            });

            listBox1.DataSource = _personBindingSource;

            ((jetVersion.Person)_personBindingSource[0]).FirstName = "Kane";


            var peopleList = (List<jetVersion.Person>)_personBindingSource.DataSource;

            foreach (jetVersion.Person person in peopleList)
            {
                _stringBuilder.AppendLine(person.ToString());
            }

            ResultsTextBox.Text = _stringBuilder.ToString();
        }
        /// <summary>
        /// Since there are two different ways the ListBox is loaded
        /// if _bindingSource.DataSource == null means the ListBox.DataSource
        /// was set to a list, otherwise ListBox.DataSource set to the
        /// BindingSource.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CurrentPersonButton_Click(object sender, EventArgs e)
        {
            if (_personBindingSource.DataSource == null)
            {
                MessageBox.Show(((IPerson)listBox1.SelectedItem).LastName);
            }
            else
            {
                MessageBox.Show(((IPerson)_personBindingSource.Current).LastName);
            }


        }


    }
}

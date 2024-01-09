using System.ComponentModel;
using MoveBetweenListBoxesCore.Classes;
using MoveBetweenListBoxesCore.Models;

namespace MoveBetweenListBoxesCore;

/// <summary>
/// Special note
/// Both ListBox controls Sort property is set to true so when moving
/// items they fall into the proper place else if sort is false when
/// moving an item it will be added to the end of the control.
/// </summary>
public partial class CustomerForm : Form
{
    private BindingList<Customer?> _bindingListOriginalData = new();
    private BindingList<Customer?> _bindingListRight = new();

    public CustomerForm()
    {
        InitializeComponent();
        Shown += Form1_Shown;
    }

    private async void Form1_Shown(object? sender, EventArgs e)
    {

        DataOperations operations = new();

        _bindingListOriginalData = new BindingList<Customer?>(await operations.CustomersList());

        listBox1.DataSource = _bindingListOriginalData;

        listBox2.DataSource = _bindingListRight;
        listBox2.DisplayMember = "CompanyName";

    }

    private void MoveItemLeftToRightButton_Click(object sender, EventArgs e)
    {
        if (_bindingListOriginalData.Count == 0) return;

        var customer = (Customer)listBox1.SelectedItem;
        _bindingListRight.Add(customer);
        _bindingListOriginalData.Remove(customer);
    }

    private void MoveItemRightToLeftButton_Click(object sender, EventArgs e)
    {
        if (_bindingListRight.Count == 0) return;

        var customer = (Customer)listBox2.SelectedItem;
        _bindingListOriginalData.Add(customer);
        _bindingListRight.Remove(customer);
    }

    private void GetCustomersButton1_Click(object sender, EventArgs e)
    {
        var results = _bindingListOriginalData.Select(customer => customer!.CompanyName);

        MessageBox.Show(!results.Any() ? 
            "List is empty" : 
            string.Join("\n", results));
    }

    private void GetCustomersButton2_Click(object sender, EventArgs e)
    {
        var results = _bindingListRight.Select(customer => customer!.CompanyName);

        MessageBox.Show(!results.Any() ? 
            "List is empty" : 
            string.Join("\n", results));
    }
}

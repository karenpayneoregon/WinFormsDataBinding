using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoveBetweenListBoxes.Classes;

namespace MoveBetweenListBoxes.Extensions
{
    public static class BindingListExtensions
    {
        public static void Add(this BindingList<Customer> sender, Customer customer)
        {


            var newCustomer = sender.AddNew();
            newCustomer.CompanyName = customer.CompanyName;
        }
    }
}

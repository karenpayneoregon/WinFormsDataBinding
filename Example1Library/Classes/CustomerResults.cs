using System.Collections.Generic;

namespace Example1Library.Classes
{
    public class CustomerResults
    {
        public int TotalLineCount { get; set; } 
        public int EmptyLineCountType { get; set; }
        public int ValidLineCount { get; set; }
        public List<Customer> Customers { get; set; }
        public List<string> IssuesList { get; set; }

        public CustomerResults()
        {
            IssuesList = new List<string>();
            Customers = new List<Customer>();
        }
    }
}

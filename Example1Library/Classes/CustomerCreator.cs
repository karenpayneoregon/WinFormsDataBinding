using System;
using System.Collections.Generic;

namespace Example1Library.Classes
{
    public class CustomerCreator
    {
        public Customer Customer { get; set; }
        public CustomerResults CustomerResults { get; set; }
        public List<string> IssueList { get; set; }
        public bool HasIssues => IssueList.Count > 0;
        public string Issues => string.Join(",", IssueList.ToArray());
        public CustomerCreator(string customerLine, int lineIndex)
        {
            IssueList = new List<string>();
            Customer = new Customer();
            CustomerResults = new CustomerResults();

            Build(customerLine, lineIndex);
        }

        private void Build(string customerLine, int lineIndex)
        {
            var parts = customerLine.Split(',');

            const int fieldCount = 8;

            if (parts.Length != fieldCount)
            {
                IssueList.Add($"Line: {lineIndex} Field count {parts.Length}, expected {fieldCount}.");
                return;                
            }

            if (!string.IsNullOrWhiteSpace(parts[0]))
            {
                Customer.FirstName = parts[0];
            }
            else
            {
                IssueList.Add($"Line: {lineIndex} FirstName required");
            }

            if (!string.IsNullOrWhiteSpace(parts[1]))
            {
                Customer.LastName = parts[1];
            }
            else
            {
                IssueList.Add($"Line: {lineIndex} LastName required");
            }

            Customer.Street = parts[2] ?? "";
            Customer.City = parts[3] ?? "";
            Customer.State = parts[4] ?? "";
            Customer.Country = parts[5] ?? "";

            if (!string.IsNullOrWhiteSpace(parts[6]))
            {
                if (decimal.TryParse(parts[6], out var balanceResult))
                {
                    Customer.Balance = balanceResult;
                }
                else
                {
                    IssueList.Add($"Line: {lineIndex} Balance value '{parts[6]}' is invalid decimal");
                }
            }
            else
            {
                IssueList.Add($"Line: {lineIndex} Balance is required");
            }

            if (!string.IsNullOrWhiteSpace(parts[7]))
            {
                if (DateTime.TryParse(parts[7], out var paidResult))
                {
                    Customer.LastPaid = paidResult;
                }
                else
                {
                    IssueList.Add($"Line: {lineIndex} Last paid '{parts[7]}' is not valid date");
                }
            }
            else
            {
                IssueList.Add($"Line: {lineIndex} Last paid is required");
            }

            CustomerResults.Customers.Add(Customer);
            CustomerResults.IssuesList.AddRange(IssueList);

        }
    }
}

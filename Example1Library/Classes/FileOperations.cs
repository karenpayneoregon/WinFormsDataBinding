using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Example1Library.Classes
{
    public class FileOperations : BaseConnectionLibrary.BaseExceptionProperties
    {
        /// <summary>
        /// Read in a text file were there are no issues like bad data types
        /// or missing elements.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public List<Customer> ReadCustomersPerfectWorld(string fileName)
        {
            int identifier = 0;
            int IncrementIdentifier() => identifier += 1;

            return (
                from line in File.ReadAllLines(fileName)
                where line.Length > 0
                let lineParts = line.Split(',')
                select new Customer()
                {
                    Id = IncrementIdentifier(),
                    FirstName = lineParts[0],
                    LastName = lineParts[1],
                    Street = lineParts[2],
                    City = lineParts[3],
                    State = lineParts[4],
                    Country = lineParts[5],
                    Balance = Convert.ToDecimal(lineParts[6]),
                    LastPaid = Convert.ToDateTime(lineParts[7])
                }).ToList();

        }
    }

}

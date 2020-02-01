using System;

namespace Example1Library.Classes
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public decimal? Balance { get; set; }
        public DateTime? LastPaid { get; set; }
        public override string ToString()
        {
            return $"{FirstName}, {LastName}";
        }
    }
}

using System;

namespace ListBoxDataBinding.Classes
{
    public class CustomerPlain
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public override string ToString()
        {
            return $"{FirstName}, {LastName}";
        }
    }
}

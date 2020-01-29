using CommonPractice.Interfaces;

namespace CommonPractice.BaseExampleClasses
{
    public class Person : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString() => $"{FirstName} {LastName}";
    }
}
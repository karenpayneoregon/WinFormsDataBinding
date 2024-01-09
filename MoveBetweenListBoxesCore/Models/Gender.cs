#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace MoveBetweenListBoxesCore.Models
{
    public class Gender
    {
        public int Id { get; set; }
        public string GenderType { get; set; }
        public override string ToString() => GenderType;
    }
}

namespace MoveBetweenListBoxes.Classes
{
    public class Gender
    {
        public int Id { get; set; }
        public string GenderType { get; set; }
        public override string ToString() => GenderType;
    }
}

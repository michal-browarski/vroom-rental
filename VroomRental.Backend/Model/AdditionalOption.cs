namespace VroomRental.Backend.Model
{
    public class AdditionalOption
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Price} zł";
        }
    }
}

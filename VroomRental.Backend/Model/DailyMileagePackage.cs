namespace VroomRental.Backend.Model
{
    public class DailyMileagePackage
    {
        public int Id { get; set; }
        public string PackageName { get; set; }
        public decimal Price { get; set; }
        public int MaxKilometersPerDay { get; set; }

        public override string ToString()
        {
            return $"{PackageName} ({MaxKilometersPerDay} km) - {Price:C}";
        }
    }
}

namespace VroomRental.Backend.Model
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string ProductionYear { get; set; }
        public string BodyType { get; set; }
        public string Color {  get; set; }
        public int Mileage { get; set; }
        public CarStatus Status { get; set; }
        public decimal PricePerDay { get; set; }
        public DateTime LastInspectionDate { get; set; }
        public List<CarReservation> CarReservations { get; set; }
        public List<Repair> Repairs { get; set; }
    }
}

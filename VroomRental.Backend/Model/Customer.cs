namespace VroomRental.Backend.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string DriverLicenceNumber { get; set; }
        public Address Address { get; set; }
        public List<CarReservation> CarReservations { get; set; }
    }
}

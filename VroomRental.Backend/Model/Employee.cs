namespace VroomRental.Backend.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public int RoleId { get; set; }
        public string Login {  get; set; }
        public byte[] Password { get; set; }
        public List<CarReservation> CarReservations { get; set; }
    }
}

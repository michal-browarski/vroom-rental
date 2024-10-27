namespace VroomRental.Backend.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        public string Login {  get; set; }
        public string Password { get; set; }
        public List<CarReservation> CarReservations { get; set; }
    }
}

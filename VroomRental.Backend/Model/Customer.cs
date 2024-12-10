using VroomRental.Backend.Model;

public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string DriverLicenceNumber { get; set; }
    public DateTime RegistrationDate { get; set; }
    public Address Address { get; set; }
    public string FullAddress
    {
        get
        {
            if (Address != null)
            {
                return $"{Address.Street}, {Address.HomeNumber}, {Address.City}, {Address.ZipCode}";
            }
            return string.Empty;
        }
    }
}

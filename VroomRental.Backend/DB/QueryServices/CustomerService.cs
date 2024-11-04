using System.Data;
using VroomRental.Backend.Model;

namespace VroomRental.Backend.DB.QueryServices
{
    public class CustomerService
    {
        private readonly DatabaseService _databaseService;

        public CustomerService(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public List<Customer> GetAllCustomersWithAddress()
        {
            string query = @"
        SELECT c.Customer_Id, c.First_Name, c.Last_Name, c.Phone, c.Email, c.Driver_Licence_Number,
               a.Street, a.Home_Number, a.City, a.Zip_Code
        FROM tbl_Customers c
        LEFT JOIN tbl_Addresses a ON c.Customer_Id = a.Customer_Id";

            DataTable customerTable = _databaseService.ExecuteQuery(query);
            List<Customer> customers = new List<Customer>();

            foreach (DataRow row in customerTable.Rows)
            {
                customers.Add(new Customer
                {
                    Id = Convert.ToInt32(row["Customer_Id"]),
                    FirstName = row["First_Name"].ToString(),
                    LastName = row["Last_Name"].ToString(),
                    Phone = row["Phone"].ToString(),
                    Email = row["Email"].ToString(),
                    DriverLicenceNumber = row["Driver_Licence_Number"].ToString(),
                    Address = new Address
                    {
                        Street = row["Street"].ToString(),
                        HomeNumber = row["Home_Number"].ToString(),
                        City = row["City"].ToString(),
                        ZipCode = row["Zip_Code"].ToString()
                    }
                });
            }
            return customers;
        }

    }
}

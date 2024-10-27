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

        public List<Customer> GetAllCustomers()
        {
            string query = "SELECT * FROM tbl_Customers";
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
                    DriverLicenceNumber = row["Driver_Licence_Number"].ToString()
                });
            }
            return customers;
        }
    }
}

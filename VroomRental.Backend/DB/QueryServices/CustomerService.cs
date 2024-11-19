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

        // Pobieranie klientów z ich adresami
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

        // Dodawanie klienta i jego adresu
        public void AddCustomerWithAddress(Customer customer)
        {
            // Dodaj klienta
            string customerQuery = @"
            INSERT INTO tbl_Customers (First_Name, Last_Name, Phone, Email, Driver_Licence_Number)
            VALUES (@FirstName, @LastName, @Phone, @Email, @DriverLicenceNumber);
            SELECT SCOPE_IDENTITY();";

            var customerParameters = new Dictionary<string, object>
            {
                {"@FirstName", customer.FirstName },
                {"@LastName", customer.LastName },
                {"@Phone", customer.Phone },
                {"@Email", customer.Email },
                {"@DriverLicenceNumber", customer.DriverLicenceNumber }
            };

            int customerId = Convert.ToInt32(_databaseService.ExecuteScalar(customerQuery, customerParameters));

            // Dodaj adres
            string addressQuery = @"
            INSERT INTO tbl_Addresses (Customer_Id, Street, Home_Number, City, Zip_Code)
            VALUES (@CustomerId, @Street, @HomeNumber, @City, @ZipCode)";

            var addressParameters = new Dictionary<string, object>
            {
                {"@CustomerId", customerId },
                {"@Street", customer.Address.Street },
                {"@HomeNumber", customer.Address.HomeNumber },
                {"@City", customer.Address.City },
                {"@ZipCode", customer.Address.ZipCode }
            };

            _databaseService.ExecuteNonQuery(addressQuery, addressParameters);
        }

        // Aktualizacja klienta i jego adresu
        public void EditCustomerWithAddress(Customer customer)
        {
            // Aktualizuj dane klienta
            string customerQuery = @"
            UPDATE tbl_Customers
            SET First_Name = @FirstName,
                Last_Name = @LastName,
                Phone = @Phone,
                Email = @Email,
                Driver_Licence_Number = @DriverLicenceNumber
            WHERE Customer_Id = @CustomerId";

            var customerParameters = new Dictionary<string, object>
            {
                {"@CustomerId", customer.Id },
                {"@FirstName", customer.FirstName },
                {"@LastName", customer.LastName },
                {"@Phone", customer.Phone },
                {"@Email", customer.Email },
                {"@DriverLicenceNumber", customer.DriverLicenceNumber }
            };

            _databaseService.ExecuteNonQuery(customerQuery, customerParameters);

            // Aktualizuj adres
            string addressQuery = @"
            UPDATE tbl_Addresses
            SET Street = @Street,
                Home_Number = @HomeNumber,
                City = @City,
                Zip_Code = @ZipCode
            WHERE Customer_Id = @CustomerId";

            var addressParameters = new Dictionary<string, object>
            {
                {"@CustomerId", customer.Id },
                {"@Street", customer.Address.Street },
                {"@HomeNumber", customer.Address.HomeNumber },
                {"@City", customer.Address.City },
                {"@ZipCode", customer.Address.ZipCode }
            };

            _databaseService.ExecuteNonQuery(addressQuery, addressParameters);
        }

        // Usuwanie klienta i jego adresu
        public void RemoveCustomerWithAddress(int customerId)
        {
            // Usuń adres
            string addressQuery = "DELETE FROM tbl_Addresses WHERE Customer_Id = @CustomerId";

            var addressParameters = new Dictionary<string, object>
            {
                {"@CustomerId", customerId }
            };

            _databaseService.ExecuteNonQuery(addressQuery, addressParameters);

            // Usuń klienta
            string customerQuery = "DELETE FROM tbl_Customers WHERE Customer_Id = @CustomerId";

            var customerParameters = new Dictionary<string, object>
            {
                {"@CustomerId", customerId }
            };

            _databaseService.ExecuteNonQuery(customerQuery, customerParameters);
        }
    }
}

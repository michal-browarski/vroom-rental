using System.Data;
using VroomRental.Backend.Model;

namespace VroomRental.Backend.DB.QueryServices
{
    public class EmployeeService
    {
        private readonly DatabaseService _databaseService;

        public EmployeeService(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public List<Employee> GetAllEmployees()
        {
            string query = "SELECT * FROM tbl_Employees";
            DataTable employeeTable = _databaseService.ExecuteQuery(query);
            List<Employee> employees = new List<Employee>();

            foreach (DataRow row in employeeTable.Rows)
            {
                employees.Add(new Employee
                {
                    Id = Convert.ToInt32(row["Employee_Id"]),
                    FirstName = row["First_Name"].ToString(),
                    LastName = row["Last_Name"].ToString(),
                    Role = (Role)Convert.ToInt32(row["Role"]),
                    Login = row["Login"].ToString(),
                    Password = row["Password"].ToString()
                });
            }
            return employees;
        }
    }
}

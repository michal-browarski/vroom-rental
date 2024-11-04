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

        public List<Employee> GetAllEmployeesWithRole()
        {
            string query = @"
        SELECT e.Employee_Id, e.First_Name, e.Last_Name, e.Login, r.Name AS RoleName
        FROM tbl_Employees e
        LEFT JOIN tbl_Roles r ON e.Role = r.Position_Id";

            DataTable employeeTable = _databaseService.ExecuteQuery(query);
            List<Employee> employees = new List<Employee>();

            foreach (DataRow row in employeeTable.Rows)
            {
                employees.Add(new Employee
                {
                    Id = Convert.ToInt32(row["Employee_Id"]),
                    FirstName = row["First_Name"].ToString(),
                    LastName = row["Last_Name"].ToString(),
                    Login = row["Login"].ToString(),
                    Role = row["RoleName"].ToString()
                });
            }
            return employees;
        }

    }
}

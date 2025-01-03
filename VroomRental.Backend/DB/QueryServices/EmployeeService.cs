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

        // Pobranie wszystkich pracowników (już istniejąca funkcja)
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

        // Dodawanie nowego pracownika
        public void AddEmployee(Employee employee)
        {
            string query = @"
            INSERT INTO tbl_Employees (First_Name, Last_Name, Role, Login, Password)
            VALUES (@FirstName, @LastName, @Role, @Login, @Password)";

                        var parameters = new Dictionary<string, object>
                {
                    { "@FirstName", employee.FirstName },
                    { "@LastName", employee.LastName },
                    { "@Role", employee.RoleId },
                    { "@Login", employee.Login },
                    { "@Password", ConvertPasswordToBinary(employee.Password) }
                };

            _databaseService.ExecuteNonQuery(query, parameters);
        }

        private byte[] ConvertPasswordToBinary(string password)
        {
            // Konwertujemy hasło na byte[] za pomocą UTF-8
            return System.Text.Encoding.UTF8.GetBytes(password);
        }


        // Edytowanie istniejącego pracownika
        public void EditEmployee(Employee employee)
        {
            string query = @"
            UPDATE tbl_Employees
            SET First_Name = @FirstName,
                Last_Name = @LastName,
                Role = @Role,
                Login = @Login,
                Password = @Password
            WHERE Employee_Id = @EmployeeId";

            var parameters = new Dictionary<string, object>
        {
            { "@FirstName", employee.FirstName },
            { "@LastName", employee.LastName },
            { "@Role", employee.RoleId },
            { "@Login", employee.Login },
            { "@Password", ConvertPasswordToBinary(employee.Password)  },
            { "@EmployeeId", employee.Id }
        };

            _databaseService.ExecuteNonQuery(query, parameters);
        }

        // Usuwanie pracownika
        public void RemoveEmployee(int employeeId)
        {
            string query = "DELETE FROM tbl_Employees WHERE Employee_Id = @EmployeeId";

            var parameters = new Dictionary<string, object>
        {
            { "@EmployeeId", employeeId }
        };

            _databaseService.ExecuteNonQuery(query, parameters);
        }

        // Wyszukiwanie pracowników według roli
        public List<Employee> SearchEmployeesByRole(string roleName)
        {
            string query = @"
            SELECT e.Employee_Id, e.First_Name, e.Last_Name, e.Login, r.Name AS RoleName
            FROM tbl_Employees e
            LEFT JOIN tbl_Roles r ON e.Role = r.Position_Id
            WHERE r.Name LIKE @RoleName";

            var parameters = new Dictionary<string, object>
        {
            { "@RoleName", $"%{roleName}%" }
        };

            DataTable employeeTable = _databaseService.ExecuteQuery(query, parameters);
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

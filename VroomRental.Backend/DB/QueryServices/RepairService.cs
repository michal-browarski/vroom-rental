using System.Data;
using VroomRental.Backend.Model;

namespace VroomRental.Backend.DB.QueryServices
{
    public class RepairService
    {
        private readonly DatabaseService _databaseService;
        public RepairService(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public List<Repair> GetAllRepairs()
        {
            string query = @"
                SELECT 
                    r.Repair_Id, r.Report_Date, r.Description, r.Status, r.End_Date, 
                    e.Employee_Id, e.First_Name, e.Last_Name,
                    c.Car_Id, c.Brand, c.Model
                FROM 
                    tbl_Repairs r
                JOIN 
                    tbl_Employees e ON r.Employee_Id = e.Employee_Id
                JOIN 
                    tbl_Cars c ON r.Car_Id = c.Car_Id";

            DataTable repairTable = _databaseService.ExecuteQuery(query);
            List<Repair> repairs = new List<Repair>();

            foreach (DataRow row in repairTable.Rows)
            {
                repairs.Add(new Repair
                {
                    Id = Convert.ToInt32(row["Repair_Id"]),
                    ReportDate = Convert.ToDateTime(row["Report_Date"]),
                    Description = row["Description"].ToString(),
                    Status = (RepairStatus)Enum.Parse(typeof(RepairStatus), row["Status"].ToString()),
                    EndDate = row.IsNull("End_Date") ? null : Convert.ToDateTime(row["End_Date"]),

                    Employee = new Employee
                    {
                        Id = Convert.ToInt32(row["Employee_Id"]),
                        FirstName = row["First_Name"].ToString(),
                        LastName = row["Last_Name"].ToString()
                    },

                    Car = new Car
                    {
                        Id = Convert.ToInt32(row["Car_Id"]),
                        Brand = row["Brand"].ToString(),
                        Model = row["Model"].ToString()
                    }
                });
            }

            return repairs;
        }
    }
}

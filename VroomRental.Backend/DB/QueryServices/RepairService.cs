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
                    r.Repair_Id, r.Report_Date, r.Description, r.Status, r.End_Date, r.Cost,
                    e.Employee_Id, e.First_Name AS Employee_FirstName, e.Last_Name AS Employee_LastName,
                    c.Car_Id, c.Brand, c.Model
                FROM 
                    tbl_Repairs r
                LEFT JOIN 
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
                    Cost = row.IsNull("Cost") ? 0 : Convert.ToDecimal(row["Cost"]),

                    Employee = row.IsNull("Employee_Id") ? null : new Employee
                    {
                        Id = Convert.ToInt32(row["Employee_Id"]),
                        FirstName = row["Employee_FirstName"].ToString(),
                        LastName = row["Employee_LastName"].ToString()
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

        public void UpdateRepair(Repair repair)
        {
            string query = @"
                UPDATE tbl_Repairs
                SET 
                    Report_Date = @ReportDate,
                    Description = @Description,
                    Status = @Status,
                    End_Date = @EndDate,
                    Cost = @Cost,
                    Employee_Id = @EmployeeId
                WHERE Repair_Id = @RepairId";

            var parameters = new Dictionary<string, object>
            {
                { "@ReportDate", repair.ReportDate },
                { "@Description", repair.Description },
                { "@Status", (int)repair.Status }, 
                { "@EndDate", repair.EndDate ?? (object)DBNull.Value },
                { "@Cost", repair.Cost },
                { "@EmployeeId", repair.Employee?.Id ?? (object)DBNull.Value },
                { "@RepairId", repair.Id }
            };

            _databaseService.ExecuteNonQuery(query, parameters);
        }

        public void RemoveRepair(int repairId)
        {
            string query = @"
                DELETE FROM tbl_Repairs
                WHERE Repair_Id = @RepairId";

            var parameters = new Dictionary<string, object>
            {
                { "@RepairId", repairId }
            };

            _databaseService.ExecuteNonQuery(query, parameters);
        }

    }
}

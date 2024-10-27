using System.Data;
using VroomRental.Backend.Model;

namespace VroomRental.Backend.DB.QueryServices
{
    public class CarReservationService
    {
        private readonly DatabaseService _databaseService;

        public CarReservationService(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public List<CarReservation> GetAllCarReservations()
        {
            string query = @"
                SELECT 
                    r.Reservation_Id, r.Start_Date, r.Planned_End_Date, r.Actual_End_Date, r.Status, 
                    c.Customer_Id, c.First_Name, c.Last_Name, 
                    car.Car_Id, car.Brand, car.Model, 
                    e.Employee_Id, e.First_Name, e.Last_Name,
                    p.Amount, p.Payment_Date
                FROM 
                    tbl_Car_Reservations r
                JOIN 
                    tbl_Customers c ON r.Customer_Id = c.Customer_Id
                JOIN 
                    tbl_Cars car ON r.Car_Id = car.Car_Id
                LEFT JOIN 
                    tbl_Employees e ON r.Employee_Id = e.Employee_Id
                LEFT JOIN 
                    tbl_Payments p ON r.Reservation_Id = p.Reservation_Id";

            DataTable reservationTable = _databaseService.ExecuteQuery(query);
            List<CarReservation> reservations = new List<CarReservation>();

            foreach (DataRow row in reservationTable.Rows)
            {
                reservations.Add(new CarReservation
                {
                    Id = Convert.ToInt32(row["Reservation_Id"]),
                    StartDate = Convert.ToDateTime(row["Start_Date"]),
                    PlannedEndDate = Convert.ToDateTime(row["Planned_End_Date"]),
                    ActualEndDate = row.IsNull("Actual_End_Date") ? (DateTime?)null : Convert.ToDateTime(row["Actual_End_Date"]),
                    Status = (ReservationStatus)Enum.Parse(typeof(ReservationStatus), row["Status"].ToString()),

                    Customer = new Customer
                    {
                        Id = Convert.ToInt32(row["Customer_Id"]),
                        FirstName = row["First_Name"].ToString(),
                        LastName = row["Last_Name"].ToString()
                    },

                    Car = new Car
                    {
                        Id = Convert.ToInt32(row["Car_Id"]),
                        Brand = row["Brand"].ToString(),
                        Model = row["Model"].ToString()
                    },

                    Employee = row.IsNull("Employee_Id") ? null : new Employee
                    {
                        Id = Convert.ToInt32(row["Employee_Id"]),
                        FirstName = row["First_Name"].ToString(),
                        LastName = row["Last_Name"].ToString()
                    },

                    Payment = row.IsNull("Reservation_Id") ? null : new Payment
                    {
                        CarReservationId = Convert.ToInt32(row["Reservation_Id"]),
                        Amount = Convert.ToDecimal(row["Amount"]),
                        PaymentDate = Convert.ToDateTime(row["Payment_Date"])
                    }
                });
            }

            return reservations;
        }
    }
}

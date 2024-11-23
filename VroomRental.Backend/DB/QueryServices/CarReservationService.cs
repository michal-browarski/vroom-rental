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
            c.Customer_Id, c.First_Name AS Customer_First_Name, c.Last_Name AS Customer_Last_Name, 
            car.Car_Id, car.Brand, car.Model, 
            e.Employee_Id, e.First_Name AS Employee_First_Name, e.Last_Name AS Employee_Last_Name,
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
                        FirstName = row["Customer_First_Name"].ToString(),
                        LastName = row["Customer_Last_Name"].ToString()
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
                        FirstName = row.IsNull("Employee_First_Name") ? null : row["Employee_First_Name"].ToString(),
                        LastName = row.IsNull("Employee_Last_Name") ? null : row["Employee_Last_Name"].ToString()
                    },

                    Payment = row.IsNull("Amount") ? null : new Payment
                    {
                        CarReservationId = Convert.ToInt32(row["Reservation_Id"]),
                        Amount = row.IsNull("Amount") ? 0 : Convert.ToDecimal(row["Amount"]),
                        PaymentDate = row.IsNull("Payment_Date") ? (DateTime?)null : Convert.ToDateTime(row["Payment_Date"])
                    }
                });
            }

            return reservations;
        }



        public void AddReservation(CarReservation reservation)
        {
            string query = @"
                INSERT INTO tbl_Car_Reservations 
                (Customer_Id, Car_Id, Start_Date, Planned_End_Date, Actual_End_Date, Status, Employee_Id)
                VALUES 
                (@CustomerId, @CarId, @StartDate, @PlannedEndDate, @ActualEndDate, @Status, @EmployeeId)";

            var parameters = new Dictionary<string, object>
            {
                { "@CustomerId", reservation.Customer.Id },
                { "@CarId", reservation.Car.Id },
                { "@StartDate", reservation.StartDate },
                { "@PlannedEndDate", reservation.PlannedEndDate },
                { "@ActualEndDate", reservation.ActualEndDate ?? (object)DBNull.Value },
                { "@Status", reservation.Status },
                { "@EmployeeId", reservation.Employee?.Id ?? (object)DBNull.Value }
            };

            _databaseService.ExecuteNonQuery(query, parameters);
        }

        public List<AdditionalOption> GetOptionsFromReservation(int reservationId)
        {
            string query = @"
        SELECT o.Option_Id, o.Option_Name, o.Price
        FROM tbl_Reservation_Options ro
        JOIN tbl_Additional_Options o ON ro.Option_Id = o.Option_Id
        WHERE ro.Reservation_Id = @ReservationId";

            var parameters = new Dictionary<string, object>
            {
                { "@ReservationId", reservationId }
            };

            DataTable optionsTable = _databaseService.ExecuteQuery(query, parameters);
            var options = new List<AdditionalOption>();

            foreach (DataRow row in optionsTable.Rows)
            {
                options.Add(new AdditionalOption
                {
                    Id = Convert.ToInt32(row["Option_Id"]),
                    Name = row["Option_Name"].ToString(),
                    Price = Convert.ToDecimal(row["Price"])
                });
            }

            return options;
        }


        public void AddOptionsToReservation(int reservationId, List<AdditionalOption> options)
        {
            foreach (var option in options)
            {
                string query = @"
                    INSERT INTO tbl_Reservation_Options (Reservation_Id, Option_Id)
                    VALUES (@ReservationId, @OptionId)";

                var parameters = new Dictionary<string, object>
                {
                    { "@ReservationId", reservationId },
                    { "@OptionId", option.Id }
                };

                _databaseService.ExecuteNonQuery(query, parameters);
            }
        }

        public List<AdditionalOption> GetAllAdditionalOptions()
        {
            string query = @"
        SELECT Option_Id, Option_Name, Price
        FROM tbl_Additional_Options";

            DataTable optionsTable = _databaseService.ExecuteQuery(query);
            var options = new List<AdditionalOption>();

            foreach (DataRow row in optionsTable.Rows)
            {
                options.Add(new AdditionalOption
                {
                    Id = Convert.ToInt32(row["Option_Id"]),
                    Name = row["Option_Name"].ToString(),
                    Price = Convert.ToDecimal(row["Price"])
                });
            }

            return options;
        }

        public void UpdateReservation(CarReservation reservation)
        {
            string query = @"
                UPDATE tbl_Car_Reservations
                SET 
                    Actual_End_Date = @ActualEndDate,
                    Status = @Status
                WHERE Reservation_Id = @ReservationId";

                    var parameters = new Dictionary<string, object>
            {
                { "@ActualEndDate", reservation.ActualEndDate ?? (object)DBNull.Value },
                { "@Status", reservation.Status },
                { "@ReservationId", reservation.Id }
            };

            _databaseService.ExecuteNonQuery(query, parameters);
        }

        public void UpdateCarStatus(int carId, CarStatus status)
        {
            string query = @"
                UPDATE tbl_Cars
                SET Status = @Status
                WHERE Car_Id = @CarId";

                    var parameters = new Dictionary<string, object>
            {
                { "@Status", status },
                { "@CarId", carId }
            };

            _databaseService.ExecuteNonQuery(query, parameters);
        }

    }
}

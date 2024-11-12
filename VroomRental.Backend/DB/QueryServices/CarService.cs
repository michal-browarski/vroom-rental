using System.Data;
using VroomRental.Backend.Model;

namespace VroomRental.Backend.DB.QueryServices
{
    public class CarService
    {
        private readonly DatabaseService _databaseService;

        public CarService(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public List<Car> GetAllCars()
        {
            string query = "SELECT * FROM tbl_Cars";
            DataTable carTable = _databaseService.ExecuteQuery(query);
            List<Car> cars = new List<Car>();

            foreach (DataRow row in carTable.Rows)
            {
                cars.Add(new Car
                {
                    Id = Convert.ToInt32(row["Car_Id"]),
                    Brand = row["Brand"].ToString(),
                    Model = row["Model"].ToString(),
                    ProductionYear = row["Production_Year"].ToString(),
                    BodyType = row["Body_Type"].ToString(),
                    Color = row["Color"].ToString(),
                    Mileage = Convert.ToInt32(row["Mileage"]),
                    Status = (CarStatus)Convert.ToInt32(row["Status"]),
                    FuelType = row["Fuel_Type"].ToString(),
                    PricePerDay = Convert.ToDecimal(row["Price_Per_Day"]),
                    LastInspectionDate = Convert.ToDateTime(row["Last_Inspection_Date"])
                });
            }
            return cars;
        }

        public void AddCar(Car car)
        {
            string query = "INSERT INTO tbl_Cars (Brand, Model, Production_Year, Body_Type, Color, Mileage, Status, Fuel_Type, Price_Per_Day, Last_Inspection_Date) " +
                           "VALUES (@Brand, @Model, @ProductionYear, @BodyType, @Color, @Mileage, @Status, @FuelType, @PricePerDay, @LastInspectionDate)";

            var parameters = new Dictionary<string, object>
            {
                {"@Brand", car.Brand },
                {"@Model", car.Model },
                {"@ProductionYear", car.ProductionYear },
                {"@BodyType", car.BodyType },
                {"@Color", car.Color },
                {"@Mileage", car.Mileage },
                {"@Status", (int)car.Status },
                {"@FuelType", car.FuelType },
                {"@PricePerDay", car.PricePerDay },
                {"@LastInspectionDate", car.LastInspectionDate }
            };

            _databaseService.ExecuteNonQuery(query, parameters);
        }

        public void RemoveCar(int carId)
        {
            string query = "DELETE FROM tbl_Cars WHERE Car_Id = @CarId";
            var parameters = new Dictionary<string, object> { { "@CarId", carId } };
            _databaseService.ExecuteNonQuery(query, parameters);
        }

        public void EditCar(Car car)
        {
            string query = "UPDATE tbl_Cars SET Brand = @Brand, Model = @Model, Production_Year = @ProductionYear, Body_Type = @BodyType, " +
                           "Color = @Color, Mileage = @Mileage, Status = @Status, Fuel_Type = @FuelType, Price_Per_Day = @PricePerDay, " +
                           "Last_Inspection_Date = @LastInspectionDate WHERE Car_Id = @CarId";

            var parameters = new Dictionary<string, object>
            {
                {"@CarId", car.Id },
                {"@Brand", car.Brand },
                {"@Model", car.Model },
                {"@ProductionYear", car.ProductionYear },
                {"@BodyType", car.BodyType },
                {"@Color", car.Color },
                {"@Mileage", car.Mileage },
                {"@Status", (int)car.Status },
                {"@FuelType", car.FuelType },
                {"@PricePerDay", car.PricePerDay },
                {"@LastInspectionDate", car.LastInspectionDate }
            };

            _databaseService.ExecuteNonQuery(query, parameters);
        }
    }
}

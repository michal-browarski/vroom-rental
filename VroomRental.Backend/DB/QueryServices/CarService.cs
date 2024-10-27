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
                    PricePerDay = Convert.ToDecimal(row["Price_Per_Day"]),
                    LastInspectionDate = Convert.ToDateTime(row["Last_Inspection_Date"])
                });
            }
            return cars;
        }
    }
}

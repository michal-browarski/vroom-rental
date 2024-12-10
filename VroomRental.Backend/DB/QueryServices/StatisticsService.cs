using System.Data;
using VroomRental.Backend.Model;

namespace VroomRental.Backend.DB.QueryServices
{
    public class StatisticsService
    {
        private readonly DatabaseService _databaseService;

        public StatisticsService(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        /// <summary>
        /// Returns number of cars divided by status
        /// </summary>
        /// <returns>Number of: 1. active cars, 2. rented cars, 3. cars in repair, 4. total cars</returns>
        public Tuple<int, int, int, int> GetCarsNumberByStatus()
        {
            string queryActiveCars = "SELECT COUNT(*) FROM tbl_Cars WHERE status = 1";

            string queryRentedCars = "SELECT COUNT(*) FROM tbl_Cars WHERE status = 2";

            string queryCarsInRepair = "SELECT COUNT(*) FROM tbl_Cars WHERE status = 3";

            int activeCars = Convert.ToInt32(_databaseService.ExecuteScalar(queryActiveCars));
            int rentedCars = Convert.ToInt32(_databaseService.ExecuteScalar(queryRentedCars));
            int carsInRepair = Convert.ToInt32(_databaseService.ExecuteScalar(queryCarsInRepair));
            int totalCars = activeCars + rentedCars + carsInRepair;

            return new Tuple<int, int, int, int>(activeCars, rentedCars, carsInRepair, totalCars);
        }

        public int GetDelaysNumber()
        {
            string delays = @"
                            SELECT COUNT(*)
                            FROM tbl_Car_Reservations
                            WHERE Actual_End_Date IS NULL
                            AND Planned_End_Date < GETDATE()";

            int delaysNumber = Convert.ToInt32(_databaseService.ExecuteScalar(delays));
            return delaysNumber;
        }
    }
}

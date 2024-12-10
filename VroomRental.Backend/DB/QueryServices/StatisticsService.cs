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
        /// <returns>Number of: 1. active cars, 2. cars in repair, 3. total cars</returns>
        public Tuple<int, int, int> GetCarsNumberByStatus()
        {
            string queryActiveCars = "SELECT COUNT(*) FROM tbl_Cars WHERE status = 1";

            string queryCarsInRepair = "SELECT COUNT(*) FROM tbl_Cars WHERE status = 3";

            string queryTotalCars = "SELECT COUNT(*) FROM tbl_Cars";

            int activeCars = Convert.ToInt32(_databaseService.ExecuteScalar(queryActiveCars));
            int carsInRepair = Convert.ToInt32(_databaseService.ExecuteScalar(queryCarsInRepair));
            int totalCars = Convert.ToInt32(_databaseService.ExecuteScalar(queryTotalCars));

            return new Tuple<int, int, int>(activeCars, carsInRepair, totalCars);
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

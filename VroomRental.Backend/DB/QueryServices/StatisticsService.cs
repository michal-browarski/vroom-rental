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

        public Tuple<int, int> GetHowManyCarsAvailable()
        {
            string queryActiveCars = "SELECT COUNT(*) FROM tbl_Cars WHERE status = 1";

            string queryTotalCars = "SELECT COUNT(*) FROM tbl_Cars";

            int activeCars = Convert.ToInt32(_databaseService.ExecuteScalar(queryActiveCars));
            int totalCars = Convert.ToInt32(_databaseService.ExecuteScalar(queryTotalCars));

            return new Tuple<int, int>(activeCars, totalCars);
        }
    }
}

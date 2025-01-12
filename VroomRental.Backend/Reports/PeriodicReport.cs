using VroomRental.Backend.DB.QueryServices;

namespace VroomRental.Backend.Reports
{
    public class PeriodicReport
    {
        public PeriodicReport(decimal profit, decimal averageProfit, int rentalsNumber, double averageRentalTime, int newCustomers, string topBrand)
        {
            Profit = profit;
            AverageProfitPerDay = averageProfit;
            RentalsNumber = rentalsNumber;
            AverageRentalTime = averageRentalTime;
            NewCustomers = newCustomers;
            TopBrandInPeriod = topBrand;
        }

        public decimal Profit { get; init; }
        public decimal AverageProfitPerDay { get; init; }
        public int RentalsNumber { get; init; }
        public double AverageRentalTime { get; init; }
        public int NewCustomers {  get; init; }
        public string TopBrandInPeriod { get; init; }
    }
}
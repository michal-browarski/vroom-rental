using VroomRental.Backend.DB.QueryServices;
using VroomRental.Backend.Model;

namespace VroomRental.Backend.Reports
{
    public class PeriodicReport
    {
        public PeriodicReport(decimal profit, decimal averageProfit, int rentalsNumber, double averageRentalTime, int newCustomers, string topBrand, 
            Dictionary<string, int> fuelTypeCounts, Dictionary<string, int> bodyTypeCounts, Dictionary<string, int> topBrands, Dictionary<string, int> topCars, 
            List<Payment> periodPayments)
        {
            Profit = profit;
            AverageProfitPerDay = averageProfit;
            RentalsNumber = rentalsNumber;
            AverageRentalTime = averageRentalTime;
            NewCustomers = newCustomers;
            TopBrandInPeriod = topBrand;
            FuelTypeCounts = fuelTypeCounts;
            BodyTypeCounts = bodyTypeCounts;
            TopBrands = topBrands;
            TopCars = topCars;
            PeriodPayments = periodPayments;
        }

        public decimal Profit { get; init; }
        public decimal AverageProfitPerDay { get; init; }
        public int RentalsNumber { get; init; }
        public double AverageRentalTime { get; init; }
        public int NewCustomers {  get; init; }
        public string TopBrandInPeriod { get; init; }
        public Dictionary<string, int> FuelTypeCounts { get; init; }
        public Dictionary<string, int> BodyTypeCounts { get; init; }
        public Dictionary<string, int> TopBrands { get; init; }
        public Dictionary<string, int> TopCars { get; init; }
        public List<Payment> PeriodPayments { get; init; }
    }
}
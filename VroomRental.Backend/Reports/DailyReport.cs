namespace VroomRental.Backend.Reports
{
    public class DailyReport
    {
        public DailyReport(int rentedCars, decimal payments, string topBrand, int totalCars, int availableCars, int carsInRepair, int delays)
        {
            RentedCarsNumber = rentedCars;
            PaymentAmount = payments;
            TopBrand = topBrand;
            TotalCarsNumber = totalCars;
            AvailableCarsNumber = availableCars;
            CarsInRepairNumber = carsInRepair;
            DelaysNumber = delays;
        }

        public int RentedCarsNumber { get; init; }
        public decimal PaymentAmount { get; init; }
        public string TopBrand { get; init; }
        public int TotalCarsNumber { get; init; }
        public int AvailableCarsNumber { get; init; }
        public int CarsInRepairNumber { get; init; }
        public int DelaysNumber { get; init; }
    }
}

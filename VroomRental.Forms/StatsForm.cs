using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System.Configuration;
using VroomRental.Backend.DB;
using VroomRental.Backend.DB.QueryServices;

namespace VroomRental.Forms
{
    public partial class StatsForm : Form
    {
        private readonly StatisticsService _statsService;
        private readonly CarReservationService _carReservationService;
        private readonly PaymentService _paymentService;
        private readonly CustomerService _customerService;
        private Dictionary<string, int> _brands;
        private DateTime startDate = DateTime.Now;
        private DateTime endDate = DateTime.Now.AddDays(-7);
        public StatsForm()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            DatabaseService databaseService = new DatabaseService(connectionString);
            _statsService = new StatisticsService(databaseService);
            _carReservationService = new CarReservationService(databaseService);
            _paymentService = new PaymentService(databaseService);
            _customerService = new CustomerService(databaseService);

            EndDateMaskedTextBox.Text = startDate.ToString("dd.MM.yyyy");
            StartDateMaskedTextBox.Text = endDate.ToString("dd.MM.yyyy");

            InitializeDailyStats();
            InitializePeriodStats();
        }

        private void DateResetButton_Click(object sender, EventArgs e)
        {
            EndDateMaskedTextBox.Text = DateTime.Now.ToString("dd.MM.yyyy");
            StartDateMaskedTextBox.Text = DateTime.Now.AddDays(-7).ToString("dd.MM.yyyy");
            InitializePeriodStats();
        }

        private void InitializeDailyStats()
        {
            var progress = _statsService.GetCarsNumberByStatus();
            int delays = _statsService.GetDelaysNumber();
            int todayRentals;
            decimal todayPayments;
            string? topBrandToday;


            // Dzisiejsze wypożyczenia
            var allRented = _carReservationService.GetAllCarReservations();
            todayRentals = allRented
                .Count(r => r.StartDate.Date == DateTime.Today);
            TodayRentalsLabel.Text = $"Dzisiejsze wypożyczenia {todayRentals}";


            // Dzisiejsze płatności
            var allPayments = _paymentService.GetAllPayments();
            todayPayments = allPayments
                .Where(p => p.PaymentDate.HasValue && p.PaymentDate.Value.Date == DateTime.Today)
                .Sum(p => p.Amount);
            TodayPaymentsLabel.Text = $"Zapłacono dzisiaj {todayPayments} zł";


            // Najpopularniejsza marka dzisiaj
            topBrandToday = allRented
                .Where(r => r.StartDate.Date == DateTime.Today)
                .GroupBy(r => r.Car.Brand)
                .OrderByDescending(g => g.Count())
                .FirstOrDefault()?.Key;
            TodayPopularBrand.Text = $"Top brand: {topBrandToday}";

            // Dostępne samochody - progress bar
            CarsAvaiableProgressBar.Maximum = progress.Item4;
            CarsAvaiableProgressBar.Value = progress.Item1;
            AvailableCarsLabel.Text = $"Dostępne samochody {CarsAvaiableProgressBar.Value}/{CarsAvaiableProgressBar.Maximum}";

            // Samochody w naprawie - progress bar
            RepairCarsProgressBar.Maximum = progress.Item4;
            RepairCarsProgressBar.Value = progress.Item3;
            RepairCarLabel.Text = $"Samochody w naprawie {RepairCarsProgressBar.Value}/{RepairCarsProgressBar.Maximum}";

            // Zalegające zwroty
            LateReturnLabel.Text = $"Zalegające zwroty {delays}";

            // Status samochodów - wykres kołowy
            PlotModel dailyModel = new();
            PieSeries dailyPlot = new() { InsideLabelPosition = 0.5, AngleSpan = 360, StartAngle = 0, FontSize = 25 };
            dailyPlot.Slices.Add(new PieSlice("Dostępne", progress.Item1) { Fill = OxyColor.FromRgb(0, 255, 0) }); // Zielony
            dailyPlot.Slices.Add(new PieSlice("Wypożyczone", progress.Item2) { Fill = OxyColor.FromRgb(255, 255, 0) }); // Żółty
            dailyPlot.Slices.Add(new PieSlice("W naprawie", progress.Item3) { Fill = OxyColor.FromRgb(255, 0, 0) }); // Czerwony
            dailyModel.Series.Add(dailyPlot);
            DailyPlotView.Model = dailyModel;
        }

        private void InitializePeriodStats()
        {
            var reservations = _carReservationService.GetAllCarReservations();
            var payments = _paymentService.GetAllPayments();
            var customers = _customerService.GetAllCustomersWithAddress();

            // Pobranie daty początkowej i końcowej
            startDate = DateTime.ParseExact(StartDateMaskedTextBox.Text, "dd.MM.yyyy",
                System.Globalization.CultureInfo.InvariantCulture);

            endDate = DateTime.ParseExact(EndDateMaskedTextBox.Text, "dd.MM.yyyy",
                System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None);

            // Zysk
            decimal sumPayment = payments
                .Where(p => p.PaymentDate.HasValue && p.PaymentDate.Value.Date >= startDate && p.PaymentDate.Value.Date <= endDate)
                .Sum(p => p.Amount);
            TotalPaymentLabel.Text = $"Zyski: {sumPayment} zł";

            // Średni zysk na dzień
            decimal meanPayment = Math.Round(sumPayment / (endDate - startDate).Days + 1, 2);
            MeanLabel.Text = $"Średnia: {meanPayment} zł";

            // Liczba wypożyczeń
            int rentCount = reservations
                .Where(r => r.StartDate.Date >= startDate && r.ActualEndDate.HasValue && r.ActualEndDate.Value.Date <= endDate)
                .Count();
            PeriodRentalLabel.Text = $"Wypożyczenia: {rentCount}";

            // Średni czas wypożyczenia
            var filteredReservations = reservations
                .Where(r => r.StartDate.Date >= startDate &&
                            r.ActualEndDate.HasValue &&
                            r.ActualEndDate.Value.Date <= endDate)
                .ToList();

            double averageRentalDuration = filteredReservations
                .Select(r => (r.ActualEndDate.Value - r.StartDate).TotalDays)
                .DefaultIfEmpty(0)
                .Average();

            MeanRentalTimeLabel.Text = $"Średni czas wypożyczenia: {averageRentalDuration} dni";

            // Nowi klienci
            int newCustomers = customers
                .Where(c => c.RegistrationDate >= startDate && c.RegistrationDate <= endDate)
                .Count();
            NewCustomersLabel.Text = $"Nowi klienci: {newCustomers}"; ;

            // Najpopularniejsza marka w okresie
            string? topBrand = reservations
                .Where(r => r.StartDate.Date >= startDate &&
                            r.ActualEndDate.HasValue &&
                            r.ActualEndDate.Value.Date <= endDate)
                .GroupBy(r => r.Car.Brand)
                .OrderByDescending(g => g.Count())
                .FirstOrDefault()?.Key;
            PeriodPopularBrand.Text = $"Top brand: {topBrand}";

            InitializePeriodPlot();
        }

        private void InitializePeriodPlot()
        {
            // Domyslny wykres - wykres z markami
        }

        private void BrandsPlotButton_Click(object sender, EventArgs e)
        {            
            // Ile wypożyczeń danej marki
            //_brands = _carReservationService.GetAllCarReservations()
            //    .Where(r => r.StartDate.Date >= startDate &&
            //                r.ActualEndDate.HasValue &&
            //                r.ActualEndDate.Value.Date <= endDate)
            //    .GroupBy(r => r.Car.Brand)
            //    .ToDictionary(g => g.Key, g => g.Count());

            InitializePeriodPlot();
        }

        private void PaymentMethodPlotButton_Click(object sender, EventArgs e)
        {

        }

        private void OptionsPlotButton_Click(object sender, EventArgs e)
        {

        }
    }
}

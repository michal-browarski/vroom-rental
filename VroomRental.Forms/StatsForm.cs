using OxyPlot;
using OxyPlot.Series;
using System.Configuration;
using System.Diagnostics.Tracing;
using VroomRental.Backend.DB;
using VroomRental.Backend.DB.QueryServices;

namespace VroomRental.Forms
{
    public partial class StatsForm : Form
    {
        private readonly StatisticsService _statsService;
        private readonly CarReservationService _carReservationService;
        private readonly PaymentService _paymentService;
        public StatsForm()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            DatabaseService databaseService = new DatabaseService(connectionString);
            _statsService = new StatisticsService(databaseService);
            _carReservationService = new CarReservationService(databaseService);
            _paymentService = new PaymentService(databaseService);

            EndDateMaskedTextBox.Text = DateTime.Now.ToString("dd.MM.yyyy");
            StartDateMaskedTextBox.Text = DateTime.Now.AddDays(-7).ToString("dd.MM.yyyy");

            InitializeDailyStats();
        }

        private void DateResetButton_Click(object sender, EventArgs e)
        {
            EndDateMaskedTextBox.Text = DateTime.Now.ToString("dd.MM.yyyy");
            StartDateMaskedTextBox.Text = DateTime.Now.AddDays(-7).ToString("dd.MM.yyyy");
        }

        private void InitializeDailyStats()
        {
            var progress = _statsService.GetCarsNumberByStatus();
            int delays = _statsService.GetDelaysNumber();
            int todayRentals;
            decimal todayPayments;
            string? topBrandToday;
            List<string> topThreeBrandsToday;

            // Dzisiejsze wypożyczenia
            var allRented = _carReservationService.GetAllCarReservations();
            todayRentals = allRented
                .Count(r => r.StartDate.Date == DateTime.Today);

            // Dzisiejsze płatności
            var allPayments = _paymentService.GetAllPayments();
            todayPayments = allPayments
                .Where(p => p.PaymentDate.HasValue && p.PaymentDate.Value.Date == DateTime.Today)
                .Sum(p => p.Amount);

            // Najpopularniejsza marka dzisiaj
            topBrandToday = allRented
                .Where(r => r.StartDate.Date == DateTime.Today)
                .GroupBy(r => r.Car.Brand)
                .OrderByDescending(g => g.Count())
                .FirstOrDefault()?.Key;

            // Dostępne samochody - progress bar
            CarsAvaiableProgressBar.Maximum = progress.Item4;
            CarsAvaiableProgressBar.Value = progress.Item1;
            AvailableCarsLabel.Text = $"Dostępne samochody {CarsAvaiableProgressBar.Value}/{CarsAvaiableProgressBar.Maximum}";

            // Samochody w naprawie - progress bar
            RepairCarsProgressBar.Maximum = progress.Item4;
            RepairCarsProgressBar.Value = progress.Item3;
            RepairCarLabel.Text = $"Samochody w naprawie {RepairCarsProgressBar.Value}/{RepairCarsProgressBar.Maximum}";

            // Wykres kołowy
            PlotModel dailyModel = new();
            PieSeries dailyPlot = new() { InsideLabelPosition = 0.5, AngleSpan = 360, StartAngle = 0, FontSize = 25 };
            dailyPlot.Slices.Add(new PieSlice("Dostępne", progress.Item1) { Fill = OxyColor.FromRgb(0, 255, 0) }); // Zielony
            dailyPlot.Slices.Add(new PieSlice("Wypożyczone", progress.Item2) { Fill = OxyColor.FromRgb(255, 255, 0) }); // Żółty
            dailyPlot.Slices.Add(new PieSlice("W naprawie", progress.Item3) { Fill = OxyColor.FromRgb(255, 0, 0) }); // Czerwony
            dailyModel.Series.Add(dailyPlot);
            DailyPlotView.Model = dailyModel;

            TodayPopularBrand.Text = $"Top brand: {topBrandToday}";
            TodayPaymentsLabel.Text = $"Zapłacono dzisiaj {todayPayments} zł";
            TodayRentalsLabel.Text = $"Dzisiejsze wypożyczenia {todayRentals}";
            LateReturnLabel.Text = $"Zalegające zwroty {delays}";
        }
    }
}

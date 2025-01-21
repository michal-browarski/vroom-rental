using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System.Configuration;
using VroomRental.Backend.DB;
using VroomRental.Backend.DB.QueryServices;
using VroomRental.Backend.Model;
using VroomRental.Backend.Reports;

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
        private Button selectedButton;
        private PDFReportGenerator _reportGenerator;
        private DailyReport _dailyReport;
        private PeriodicReport _periodicReport;
        public StatsForm()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            DatabaseService databaseService = new DatabaseService(connectionString);
            _statsService = new StatisticsService(databaseService);
            _carReservationService = new CarReservationService(databaseService);
            _paymentService = new PaymentService(databaseService);
            _customerService = new CustomerService(databaseService);
            selectedButton = OptionsPlotButton;
            _reportGenerator = new PDFReportGenerator();

            EndDatePicker.MaxDate = DateTime.Now;
            EndDatePicker.Value = startDate;
            StartDatePicker.Value = endDate;
        }

        private void InitializeDateRangeComboBox()
        {
            DateRangeComboBox.Items.Add("1 week");
            DateRangeComboBox.Items.Add("1 month");
            DateRangeComboBox.Items.Add("Current month");
            DateRangeComboBox.Items.Add("Previous month");
            DateRangeComboBox.Items.Add("Current quarter");
            DateRangeComboBox.Items.Add("Previous quarter");
            DateRangeComboBox.SelectedIndex = 0;

            DateRangeComboBox.SelectedIndexChanged += DateRangeComboBox_SelectedIndexChanged;

            // Ustaw początkowe wartości dla zakresu dat
            SetDateRangeForSelection("1 week");
        }

        private void DateRangeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRange = DateRangeComboBox.SelectedItem.ToString();
            SetDateRangeForSelection(selectedRange);

            InitializePeriodStats();
        }

        private void SetDateRangeForSelection(string range)
        {
            DateTime now = DateTime.Now.Date;

            switch (range)
            {
                case "1 week":
                    StartDatePicker.Value = now.AddDays(-7);
                    EndDatePicker.Value = now;
                    break;

                case "1 month":
                    StartDatePicker.Value = now.AddMonths(-1);
                    EndDatePicker.Value = now;
                    break;

                case "Current month":
                    StartDatePicker.Value = new DateTime(now.Year, now.Month, 1);
                    EndDatePicker.Value = now;
                    break;

                case "Previous month":
                    DateTime firstDayOfPreviousMonth = new DateTime(now.Year, now.Month, 1).AddMonths(-1);
                    StartDatePicker.Value = firstDayOfPreviousMonth;
                    EndDatePicker.Value = firstDayOfPreviousMonth.AddMonths(1).AddDays(-1) > now
                                          ? now
                                          : firstDayOfPreviousMonth.AddMonths(1).AddDays(-1);
                    break;

                case "Current quarter":
                    int currentQuarter = (now.Month - 1) / 3 + 1;
                    int firstMonthOfQuarter = (currentQuarter - 1) * 3 + 1;
                    DateTime firstDayOfQuarter = new DateTime(now.Year, firstMonthOfQuarter, 1);
                    DateTime lastDayOfQuarter = firstDayOfQuarter.AddMonths(3).AddDays(-1);
                    StartDatePicker.Value = firstDayOfQuarter;
                    EndDatePicker.Value = lastDayOfQuarter > now ? now : lastDayOfQuarter;
                    break;

                case "Previous quarter":
                    int previousQuarter = ((now.Month - 1) / 3);
                    if (previousQuarter == 0)
                    {
                        previousQuarter = 4;
                        DateTime firstDayOfPreviousQuarter = new DateTime(now.Year - 1, (previousQuarter - 1) * 3 + 1, 1);
                        StartDatePicker.Value = firstDayOfPreviousQuarter;
                        EndDatePicker.Value = firstDayOfPreviousQuarter.AddMonths(3).AddDays(-1);
                    }
                    else
                    {
                        DateTime firstDayOfPreviousQuarter = new DateTime(now.Year, (previousQuarter - 1) * 3 + 1, 1);
                        StartDatePicker.Value = firstDayOfPreviousQuarter;
                        EndDatePicker.Value = firstDayOfPreviousQuarter.AddMonths(3).AddDays(-1);
                    }
                    break;

                default:
                    StartDatePicker.Value = now.AddDays(-7);
                    EndDatePicker.Value = now;
                    break;
            }
        }

        private void DateResetButton_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now.Date;

            EndDatePicker.Value = now;
            StartDatePicker.Value = DateTime.Now.AddDays(-7);
            DateRangeComboBox.SelectedIndex = 0;
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
            TodayRentalsLabel.Text = $"Today rentals {todayRentals}";

            // Dzisiejsze płatności
            var allPayments = _paymentService.GetAllPayments();
            todayPayments = allPayments
                .Where(p => p.PaymentDate.HasValue && p.PaymentDate.Value.Date == DateTime.Today)
                .Sum(p => p.Amount);
            TodayPaymentsLabel.Text = $"Paid today {todayPayments} zł";

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
            AvailableCarsLabel.Text = $"Available cars {CarsAvaiableProgressBar.Value}/{CarsAvaiableProgressBar.Maximum}";

            // Samochody w naprawie - progress bar
            RepairCarsProgressBar.Maximum = progress.Item4;
            RepairCarsProgressBar.Value = progress.Item3;
            RepairCarLabel.Text = $"Cars in repair {RepairCarsProgressBar.Value}/{RepairCarsProgressBar.Maximum}";

            // Zalegające zwroty
            LateReturnLabel.Text = $"Delays {delays}";

            // Status samochodów - wykres kołowy
            PlotModel dailyModel = new();
            PieSeries dailyPlot = new() { InsideLabelPosition = 0.5, AngleSpan = 360, StartAngle = 0, FontSize = 25 };
            dailyPlot.Slices.Add(new PieSlice("Available", progress.Item1) { Fill = OxyColor.FromRgb(0, 255, 0) }); // Zielony
            dailyPlot.Slices.Add(new PieSlice("Rented", progress.Item2) { Fill = OxyColor.FromRgb(255, 255, 0) }); // Żółty
            dailyPlot.Slices.Add(new PieSlice("In repair", progress.Item3) { Fill = OxyColor.FromRgb(255, 0, 0) }); // Czerwony
            dailyModel.Series.Add(dailyPlot);
            DailyPlotView.Model = dailyModel;

            _dailyReport = 
                new(rentedCars: todayRentals, payments: todayPayments, topBrand: topBrandToday, 
                totalCars: progress.Item4, availableCars: progress.Item1, carsInRepair: progress.Item3,
                delays: delays);
        }

        private void InitializePeriodStats()
        {
            var reservations = _carReservationService.GetAllCarReservations();
            var payments = _paymentService.GetAllPayments();
            var customers = _customerService.GetAllCustomersWithAddress();

            // Pobranie daty początkowej i końcowej
            startDate = StartDatePicker.Value.Date;
            endDate = EndDatePicker.Value.Date;

            // Zysk
            decimal sumPayment = payments
                .Where(p => p.PaymentDate.HasValue && p.PaymentDate.Value.Date >= startDate && p.PaymentDate.Value.Date <= endDate)
                .Sum(p => p.Amount);
            TotalPaymentLabel.Text = $"Profit: {sumPayment} zł";

            // Średni zysk na dzień
            decimal meanPayment = Math.Round(sumPayment / (endDate - startDate).Days + 1, 2);
            MeanLabel.Text = $"Average: {meanPayment} zł";

            // Liczba wypożyczeń
            int rentCount = reservations
                .Where(r => r.StartDate.Date >= startDate && r.ActualEndDate.HasValue && r.ActualEndDate.Value.Date <= endDate)
                .Count();
            PeriodRentalLabel.Text = $"Rentals: {rentCount}";

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

            averageRentalDuration = Math.Round(averageRentalDuration, 1);

            MeanRentalTimeLabel.Text = $"Average rental time: {averageRentalDuration}";

            // Nowi klienci
            int newCustomers = customers
                .Where(c => c.RegistrationDate >= startDate && c.RegistrationDate <= endDate)
                .Count();
            NewCustomersLabel.Text = $"New customers: {newCustomers}"; ;

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

            reservations = reservations
                .Where(r => r.StartDate.Date >= startDate &&
                    r.ActualEndDate.HasValue &&
                    r.ActualEndDate.Value.Date <= endDate)
                .ToList();

            var fuelTypeCounts = reservations
                .GroupBy(r => r.Car.FuelType)
                .ToDictionary(g => g.Key, g => g.Count());

            var bodyTypeCounts = reservations
                .GroupBy(r => r.Car.BodyType)
                .ToDictionary(g => g.Key, g => g.Count());

            var topBrands = reservations
                .GroupBy(r => r.Car.Brand)
                .ToDictionary(g => g.Key, g => g.Count());

            var topCars = reservations
                .GroupBy(r => $"{r.Car.Brand} {r.Car.Model} {r.Car.FuelType} #{r.Car.Id}")
                .ToDictionary(g => g.Key, g => g.Count());

            var periodPayments = _paymentService.GetAllPayments()
                .Where(p => p.PaymentDate.HasValue && p.PaymentDate.Value.Date >= startDate && p.PaymentDate.Value.Date <= endDate)
                .ToList();

            _periodicReport = 
                new(profit: sumPayment, averageProfit: meanPayment, rentalsNumber: rentCount, 
                averageRentalTime: averageRentalDuration, newCustomers: newCustomers, 
                topBrand: topBrand, fuelTypeCounts: fuelTypeCounts, bodyTypeCounts: bodyTypeCounts, topBrands: topBrands, topCars: topCars, periodPayments: periodPayments);
        }

        private void InitializePeriodPlot()
        {
            selectedButton.PerformClick();
        }

        private void OptionsPlotButton_Click(object sender, EventArgs e)
        {
            List<CarReservation> reservations = _carReservationService.GetAllCarReservations()
                .Where(r => r.StartDate.Date >= startDate &&
                    r.ActualEndDate.HasValue &&
                    r.ActualEndDate.Value.Date <= endDate)
                .ToList();

            var additionalOptions = reservations
                .SelectMany(r => _carReservationService.GetOptionsFromReservation(r.Id))
                .GroupBy(o => o.Name)
                .Select(g => new { Name = g.Key, Count = g.Count() })
                .OrderBy(g => g.Count)
                .ToList();

            var plotModel = new PlotModel() { Title = "Additional Options" };
            var categoryAxis = new CategoryAxis { Position = AxisPosition.Left };
            categoryAxis.Labels.AddRange(additionalOptions.Select(g => g.Name));
            plotModel.Axes.Add(categoryAxis);

            var valueAxis = new LinearAxis { Position = AxisPosition.Bottom, Title = "Number", Minimum = 0, MajorStep = 1 };
            plotModel.Axes.Add(valueAxis);

            var columnSeries = new BarSeries { Title = "Additional Options" };
            foreach (var option in additionalOptions)
            {
                columnSeries.Items.Add(new BarItem(option.Count));
            }
            plotModel.Series.Add(columnSeries);

            PeriodPlotView.Model = plotModel;
            selectedButton = OptionsPlotButton;
        }

        private void FuelTypePlotButton_Click(object sender, EventArgs e)
        {
            List<CarReservation> reservations = _carReservationService.GetAllCarReservations()
                .Where(r => r.StartDate.Date >= startDate &&
                    r.ActualEndDate.HasValue &&
                    r.ActualEndDate.Value.Date <= endDate)
                .ToList();

            var fuelTypeCounts = reservations
                .GroupBy(r => r.Car.FuelType)
                .Select(g => new { FuelType = g.Key, Count = g.Count() })
                .OrderBy(g => g.Count)
                .ToList();

            var plotModel = new PlotModel() { Title = "Fuel type" };
            var categoryAxis = new CategoryAxis { Position = AxisPosition.Left };
            categoryAxis.Labels.AddRange(fuelTypeCounts.Select(g => g.FuelType));
            plotModel.Axes.Add(categoryAxis);

            var valueAxis = new LinearAxis { Position = AxisPosition.Bottom, Title = "Number", Minimum = 0, MajorStep = 1 };
            plotModel.Axes.Add(valueAxis);

            var columnSeries = new BarSeries { Title = "Fuel type" };
            foreach (var fuelType in fuelTypeCounts)
            {
                columnSeries.Items.Add(new BarItem(fuelType.Count));
            }
            plotModel.Series.Add(columnSeries);

            PeriodPlotView.Model = plotModel;
            selectedButton = FuelTypePlotButton;
        }

        private void CarTypePlotButton_Click(object sender, EventArgs e)
        {
            List<CarReservation> reservations = _carReservationService.GetAllCarReservations()
                .Where(r => r.StartDate.Date >= startDate &&
                    r.ActualEndDate.HasValue &&
                    r.ActualEndDate.Value.Date <= endDate)
                .ToList();

            var bodyTypeCounts = reservations
                .GroupBy(r => r.Car.BodyType)
                .Select(g => new { BodyType = g.Key, Count = g.Count() })
                .OrderBy(g => g.Count)
                .ToList();

            var plotModel = new PlotModel() { Title = "Body type" };
            var categoryAxis = new CategoryAxis { Position = AxisPosition.Left };
            categoryAxis.Labels.AddRange(bodyTypeCounts.Select(g => g.BodyType));
            plotModel.Axes.Add(categoryAxis);

            var valueAxis = new LinearAxis { Position = AxisPosition.Bottom, Title = "Number", Minimum = 0, MajorStep = 1 };
            plotModel.Axes.Add(valueAxis);

            var columnSeries = new BarSeries { Title = "Body type" };
            foreach (var bodyType in bodyTypeCounts)
            {
                columnSeries.Items.Add(new BarItem(bodyType.Count));
            }
            plotModel.Series.Add(columnSeries);

            PeriodPlotView.Model = plotModel;
            selectedButton = CarTypePlotButton;
        }

        private void PopularBrandsPlotButton_Click(object sender, EventArgs e)
        {
            List<CarReservation> reservations = _carReservationService.GetAllCarReservations()
                .Where(r => r.StartDate.Date >= startDate &&
                    r.ActualEndDate.HasValue &&
                    r.ActualEndDate.Value.Date <= endDate)
                .ToList();

            var topBrands = reservations
                .GroupBy(r => r.Car.Brand)
                .Select(g => new { Brand = g.Key, Count = g.Count() })
                .OrderBy(g => g.Count)
                .ToList();

            var plotModel = new PlotModel() { Title = "Top brands" };
            var categoryAxis = new CategoryAxis { Position = AxisPosition.Left };
            categoryAxis.Labels.AddRange(topBrands.Select(g => g.Brand));
            plotModel.Axes.Add(categoryAxis);

            var valueAxis = new LinearAxis { Position = AxisPosition.Bottom, Title = "Number", Minimum = 0, MajorStep = 1 };
            plotModel.Axes.Add(valueAxis);

            var columnSeries = new BarSeries { Title = "Top brands" };
            foreach (var brand in topBrands)
            {
                columnSeries.Items.Add(new BarItem(brand.Count));
            }
            plotModel.Series.Add(columnSeries);

            PeriodPlotView.Model = plotModel;
            selectedButton = PopularBrandsPlotButton;
        }

        private void PopularCarsPlotButton_Click(object sender, EventArgs e)
        {
            List<CarReservation> reservations = _carReservationService.GetAllCarReservations()
                .Where(r => r.StartDate.Date >= startDate &&
                    r.ActualEndDate.HasValue &&
                    r.ActualEndDate.Value.Date <= endDate)
                .ToList();

            var topCars = reservations
                .GroupBy(r => $"{r.Car.Brand} {r.Car.Model} {r.Car.FuelType} #{r.Car.Id}")
                .Select(g => new { CarName = g.Key, Count = g.Count() })
                .OrderBy(g => g.Count)
                .ToList();

            var plotModel = new PlotModel() { Title = "Top cars" };
            var categoryAxis = new CategoryAxis { Position = AxisPosition.Left };
            categoryAxis.Labels.AddRange(topCars.Select(g => g.CarName));
            plotModel.Axes.Add(categoryAxis);

            var valueAxis = new LinearAxis { Position = AxisPosition.Bottom, Title = "Number", Minimum = 0, MajorStep = 1 };
            plotModel.Axes.Add(valueAxis);

            var columnSeries = new BarSeries { Title = "Top cars" };
            foreach (var car in topCars)
            {
                columnSeries.Items.Add(new BarItem(car.Count));
            }
            plotModel.Series.Add(columnSeries);

            PeriodPlotView.Model = plotModel;
            selectedButton = PopularCarsPlotButton;
        }

        private void PaymentTypePlotButton_Click(object sender, EventArgs e)
        {
            var payments = _paymentService.GetAllPayments()
                .Where(p => p.PaymentDate.HasValue && p.PaymentDate.Value.Date >= startDate && p.PaymentDate.Value.Date <= endDate)
                .ToList();

            var plotModel = new PlotModel() { Title = "Payment methods" };
            PieSeries paymentPlot = new() { InsideLabelPosition = 0.5, AngleSpan = 360, StartAngle = 0, FontSize = 25 };
            paymentPlot.Slices.Add(new PieSlice("Blik", payments.Where(p => p.PaymentMethod == PaymentMethod.Card).Count()) { Fill = OxyColor.FromRgb(0, 255, 0) }); // Zielony
            paymentPlot.Slices.Add(new PieSlice("Gotówka", payments.Where(p => p.PaymentMethod == PaymentMethod.Cash).Count()) { Fill = OxyColor.FromRgb(255, 255, 0) }); // Żółty
            plotModel.Series.Add(paymentPlot);
            PeriodPlotView.Model = plotModel;
            selectedButton = PaymentTypePlotButton;
        }

        private void StatsForm_Load(object sender, EventArgs e)
        {
            InitializeDateRangeComboBox();

            InitializeDailyStats();
            InitializePeriodStats();

            StartDatePicker.ValueChanged += (s, e) => InitializePeriodStats();
            EndDatePicker.ValueChanged += (s, e) => InitializePeriodStats();
            DateRangeComboBox.SelectedValueChanged += (s, e) => InitializePeriodStats();
        }

        private void DailyReportButton_Click(object sender, EventArgs e)
        {
            _reportGenerator.GenerateDailyReport(_dailyReport);
        }

        private void PeriodReportButton_Click(object sender, EventArgs e)
        {
            _reportGenerator.GeneratePeriodicReport(startDate, endDate, _periodicReport);
        }
    }
}

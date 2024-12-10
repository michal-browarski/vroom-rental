using System.Configuration;
using VroomRental.Backend.DB;
using VroomRental.Backend.DB.QueryServices;

namespace VroomRental.Forms
{
    public partial class StatsForm : Form
    {
        private readonly StatisticsService _statsService;
        public StatsForm()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            DatabaseService databaseService = new DatabaseService(connectionString);
            _statsService = new StatisticsService(databaseService);

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

            CarsAvaiableProgressBar.Maximum = progress.Item3;
            CarsAvaiableProgressBar.Value = progress.Item1;
            AvailableCarsLabel.Text = $"Dostępne samochody {CarsAvaiableProgressBar.Value}/{CarsAvaiableProgressBar.Maximum}";

            RepairCarsProgressBar.Maximum = progress.Item3;
            RepairCarsProgressBar.Value = progress.Item2;
            RepairCarLabel.Text = $"Samochody w naprawie {RepairCarsProgressBar.Value}/{RepairCarsProgressBar.Maximum}";

            LateReturnLabel.Text = $"Zalegające zwroty {delays}";
        }
    }
}

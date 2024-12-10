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

            var progress = _statsService.GetHowManyCarsAvailable(); 
            CarsAvaiableProgressBar.Minimum = 0;
            CarsAvaiableProgressBar.Maximum = progress.Item2;
            CarsAvaiableProgressBar.Value = progress.Item1;
            ProgressLabel.Text = $"Dostępne samochody {CarsAvaiableProgressBar.Value}/{CarsAvaiableProgressBar.Maximum}";
        }

        private void DateResetButton_Click(object sender, EventArgs e)
        {
            EndDateMaskedTextBox.Text = DateTime.Now.ToString("dd.MM.yyyy");
            StartDateMaskedTextBox.Text = DateTime.Now.AddDays(-7).ToString("dd.MM.yyyy");
        }
    }
}

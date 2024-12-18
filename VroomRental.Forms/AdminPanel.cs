namespace VroomRental.Forms
{
    public partial class AdminPanel : Form
    {
        private Form? activeFormInstance;
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void ReservationsButton_Click(object sender, EventArgs e)
        {
            if (activeFormInstance == null || activeFormInstance!.IsDisposed)
            {
                activeFormInstance = new CarReservationsForm();
                activeFormInstance.Show();
            }
            else
            {
                activeFormInstance.Focus();
            }
        }

        private void CarsButton_Click(object sender, EventArgs e)
        {
            if (activeFormInstance == null || activeFormInstance!.IsDisposed)
            {
                activeFormInstance = new CarsForm();
                activeFormInstance.Show();
            }
            else
            {
                activeFormInstance.Focus();
            }
        }

        private void StatsButton_Click(object sender, EventArgs e)
        {
            if (activeFormInstance == null || activeFormInstance!.IsDisposed)
            {
                activeFormInstance = new StatsForm();
                activeFormInstance.Show();
            }
            else
            {
                activeFormInstance.Focus();
            }
        }
    }
}

using QuestPDF.Infrastructure;

namespace VroomRental.Forms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            QuestPDF.Settings.License = LicenseType.Community;
            Application.Run(new LoginForm());
        }
    }
}
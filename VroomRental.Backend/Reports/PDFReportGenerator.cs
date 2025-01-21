using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace VroomRental.Backend.Reports
{
    public class PDFReportGenerator
    {
        public void GenerateDailyReport(DailyReport dailyData)
        {
            string formattedDate = DateTime.Now.ToString("dd-MM-yyyy");
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"VroomRental Report {formattedDate}.pdf");

            var document = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(50);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(12));

                    page.Header()
                        .Text($"Vroom Rental Report for {formattedDate}")
                        .SemiBold().FontSize(20).FontColor(Colors.Blue.Medium);

                    page.Content()
                        .Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn();
                                columns.RelativeColumn();
                            });

                            table.Header(header =>
                            {
                                header.Cell().Element(CellStyle).Text("Stats");
                                header.Cell().Element(CellStyle).Text("Liczba");
                            });

                            table.Cell().Row(1).Column(1).Element(Block).Text("Wypożyczenia");
                            table.Cell().Row(1).Column(2).Element(Block).Text($"{dailyData.RentedCarsNumber}");

                            table.Cell().Row(2).Column(1).Element(Block).Text("Płatności");
                            table.Cell().Row(2).Column(2).Element(Block).Text($"{dailyData.PaymentAmount}");

                            table.Cell().Row(3).Column(1).Element(Block).Text("Najpopularniejsza marka");
                            table.Cell().Row(3).Column(2).Element(Block).Text($"{dailyData.TopBrand}");

                            table.Cell().Row(4).Column(1).Element(Block).Text("Dostępne samochody");
                            table.Cell().Row(4).Column(2).Element(Block).Text($"{dailyData.AvailableCarsNumber}");

                            table.Cell().Row(5).Column(1).Element(Block).Text("Samochody w naprawie");
                            table.Cell().Row(5).Column(2).Element(Block).Text($"{dailyData.CarsInRepairNumber}");

                            table.Cell().Row(6).Column(1).Element(Block).Text("Zalegające zwroty");
                            table.Cell().Row(6).Column(2).Element(Block).Text($"{dailyData.DelaysNumber}");

                            page.Footer()
                                .AlignRight()
                                .Text(text =>
                                {
                                    text.Span("Generated on: ");
                                    text.Span(DateTime.Now.ToString("yyyy-MM-dd")).SemiBold();
                                });
                        });
                });
            });

            document.GeneratePdf(filePath);
        }

        public void GeneratePeriodicReport(DateTime start, DateTime end, PeriodicReport periodicData)
        {
            string formattedDateStart = start.ToString("dd-MM-yyyy");
            string formattedDateEnd= end.ToString("dd-MM-yyyy");
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"VroomRental Report {formattedDateStart} - {formattedDateEnd}.pdf");

            var document = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(50);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(12));

                    page.Header()
                        .Text(CreateReportTitle(start, end))
                        .SemiBold().FontSize(20).FontColor(Colors.Blue.Medium);

                    page.Content()
                        .Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn();
                                columns.RelativeColumn();
                            });

                            table.Header(header =>
                            {
                                header.Cell().Element(CellStyle).Text("Stats");
                                header.Cell().Element(CellStyle).Text("Liczba");
                            });

                            table.Cell().Row(1).Column(1).Element(Block).Text("Zysk");
                            table.Cell().Row(1).Column(2).Element(Block).Text($"{periodicData.Profit}");

                            table.Cell().Row(2).Column(1).Element(Block).Text("Średni zysk/dzień");
                            table.Cell().Row(2).Column(2).Element(Block).Text($"{periodicData.AverageProfitPerDay}");

                            table.Cell().Row(3).Column(1).Element(Block).Text("Wypożyczenia");
                            table.Cell().Row(3).Column(2).Element(Block).Text($"{periodicData.RentalsNumber}");

                            table.Cell().Row(4).Column(1).Element(Block).Text("Średni czas wypożyczenia");
                            table.Cell().Row(4).Column(2).Element(Block).Text($"{periodicData.AverageRentalTime}");

                            table.Cell().Row(5).Column(1).Element(Block).Text("Nowi klienci");
                            table.Cell().Row(5).Column(2).Element(Block).Text($"{periodicData.NewCustomers}");

                            int totalFuelTypes = periodicData.FuelTypeCounts.Sum(kvp => kvp.Value);
                            int totalBodyTypes = periodicData.BodyTypeCounts.Sum(kvp => kvp.Value);

                            // Typ paliwa: Petrol
                            int petrolCount = periodicData.FuelTypeCounts.TryGetValue("Petrol", out int petrolValue) ? petrolValue : 0;
                            double petrolPercentage = totalFuelTypes > 0 ? (petrolCount / (double)totalFuelTypes * 100) : 0;
                            table.Cell().Row(7).Column(1).Element(Block).Text("Typ paliwa: Petrol");
                            table.Cell().Row(7).Column(2).Element(Block).Text($"{petrolCount} - {petrolPercentage:0.00}%");

                            // Typ paliwa: Diesel
                            int dieselCount = periodicData.FuelTypeCounts.TryGetValue("Diesel", out int dieselValue) ? dieselValue : 0;
                            double dieselPercentage = totalFuelTypes > 0 ? (dieselCount / (double)totalFuelTypes * 100) : 0;
                            table.Cell().Row(8).Column(1).Element(Block).Text("Typ paliwa: Diesel");
                            table.Cell().Row(8).Column(2).Element(Block).Text($"{dieselCount} - {dieselPercentage:0.00}%");

                            // Typ paliwa: Electric
                            int electricCount = periodicData.FuelTypeCounts.TryGetValue("Electric", out int electricValue) ? electricValue : 0;
                            double electricPercentage = totalFuelTypes > 0 ? (electricCount / (double)totalFuelTypes * 100) : 0;
                            table.Cell().Row(9).Column(1).Element(Block).Text("Typ paliwa: Electric");
                            table.Cell().Row(9).Column(2).Element(Block).Text($"{electricCount} - {electricPercentage:0.00}%");

                            // Typ paliwa: Hybrid
                            int hybridCount = periodicData.FuelTypeCounts.TryGetValue("Hybrid", out int hybridValue) ? hybridValue : 0;
                            double hybridPercentage = totalFuelTypes > 0 ? (hybridCount / (double)totalFuelTypes * 100) : 0;
                            table.Cell().Row(10).Column(1).Element(Block).Text("Typ paliwa: Hybrid");
                            table.Cell().Row(10).Column(2).Element(Block).Text($"{hybridCount} - {hybridPercentage:0.00}%");

                            // Rodzaj nadwozia: Coupe
                            int coupeCount = periodicData.BodyTypeCounts.TryGetValue("Coupe", out int coupeValue) ? coupeValue : 0;
                            double coupePercentage = totalBodyTypes > 0 ? (coupeCount / (double)totalBodyTypes * 100) : 0;
                            table.Cell().Row(11).Column(1).Element(Block).Text("Rodzaj nadwozia: Coupe");
                            table.Cell().Row(11).Column(2).Element(Block).Text($"{coupeCount} - {coupePercentage:0.00}%");

                            // Rodzaj nadwozia: Hatchback
                            int hatchbackCount = periodicData.BodyTypeCounts.TryGetValue("Hatchback", out int hatchbackValue) ? hatchbackValue : 0;
                            double hatchbackPercentage = totalBodyTypes > 0 ? (hatchbackCount / (double)totalBodyTypes * 100) : 0;
                            table.Cell().Row(12).Column(1).Element(Block).Text("Rodzaj nadwozia: Hatchback");
                            table.Cell().Row(12).Column(2).Element(Block).Text($"{hatchbackCount} - {hatchbackPercentage:0.00}%");

                            // Rodzaj nadwozia: Sedan
                            int sedanCount = periodicData.BodyTypeCounts.TryGetValue("Sedan", out int sedanValue) ? sedanValue : 0;
                            double sedanPercentage = totalBodyTypes > 0 ? (sedanCount / (double)totalBodyTypes * 100) : 0;
                            table.Cell().Row(13).Column(1).Element(Block).Text("Rodzaj nadwozia: Sedan");
                            table.Cell().Row(13).Column(2).Element(Block).Text($"{sedanCount} - {sedanPercentage:0.00}%");

                            // Rodzaj nadwozia: SUV
                            int suvCount = periodicData.BodyTypeCounts.TryGetValue("SUV", out int suvValue) ? suvValue : 0;
                            double suvPercentage = totalBodyTypes > 0 ? (suvCount / (double)totalBodyTypes * 100) : 0;
                            table.Cell().Row(14).Column(1).Element(Block).Text("Rodzaj nadwozia: SUV");
                            table.Cell().Row(14).Column(2).Element(Block).Text($"{suvCount} - {suvPercentage:0.00}%");

                            // Top Brand
                            table.Cell().Row(15).Column(1).Element(Block).Text("Top Brand: ");
                            table.Cell().Row(15).Column(2).Element(Block).Text($"{periodicData.TopBrandInPeriod}");

                            // Top Car
                            var topCar = periodicData.TopCars
                                .OrderByDescending(kvp => kvp.Value)
                                .FirstOrDefault();

                            table.Cell().Row(16).Column(1).Element(Block).Text("Top Car: ");
                            table.Cell().Row(16).Column(2).Element(Block).Text($"{topCar.Key}");

                            // Płatności
                            int blikPaymentsCount = periodicData.PeriodPayments.Count(p => p.PaymentMethod == Model.PaymentMethod.Card);
                            int cashPaymentsCount = periodicData.PeriodPayments.Count(p => p.PaymentMethod == Model.PaymentMethod.Cash);
                            int totalPaymentsCount = periodicData.PeriodPayments.Count();

                            double blikPercentage = totalPaymentsCount > 0 ? (blikPaymentsCount / (double)totalPaymentsCount) * 100 : 0;
                            double cashPercentage = totalPaymentsCount > 0 ? (cashPaymentsCount / (double)totalPaymentsCount) * 100 : 0;

                            table.Cell().Row(17).Column(1).Element(Block).Text("Płatności BLIK: ");
                            table.Cell().Row(17).Column(2).Element(Block).Text($"{blikPaymentsCount} ({blikPercentage:0.00}%)");

                            table.Cell().Row(18).Column(1).Element(Block).Text("Płatności gotówką");
                            table.Cell().Row(18).Column(2).Element(Block).Text($"{cashPaymentsCount} ({cashPercentage:0.00}%)");

                            page.Footer()
                                .AlignRight()
                                .Text(text =>
                                {
                                    text.Span("Generated on: ");
                                    text.Span(DateTime.Now.ToString("yyyy-MM-dd")).SemiBold();
                                });
                        });
                });
            });

            document.GeneratePdf(filePath);
        }

        private string CreateReportTitle(DateTime start, DateTime end)
        {
            if (start.Month == end.Month && start.Year == end.Year)
            {
                // Full Month
                if (start.Day == 1 && end.Day == DateTime.DaysInMonth(start.Year, start.Month))
                {
                    return $"Vroom Rental Report: {start:MMMM yyyy}";
                }
                else
                {
                    return $"{start:dd} - {end:dd MMMM yyyy}";
                }
            }

            // Same year
            if (start.Year == end.Year)
            {
                return $"Vroom Rental Report {start:dd MMMM} - {end:dd MMMM yyyy}";
            }

            // Different year
            return $"{start:dd MMMM yyyy} - {end:dd MMMM yyyy}";
        }

        private IContainer CellStyle(IContainer container)
        {
            return container.Padding(5).BorderBottom(1).BorderColor(Colors.Grey.Lighten2);
        }
        
        private IContainer Block(IContainer container)
        {
            return container
                    .Border(1)
                    .Background(Colors.Grey.Lighten3)
                    .ShowOnce()
                    .MinWidth(50)
                    .MinHeight(50)
                    .AlignCenter()
                    .AlignMiddle();
        }
    }
}

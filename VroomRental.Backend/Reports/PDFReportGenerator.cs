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

                            table.Cell().Row(6).Column(1).Element(Block).Text("Najpopularniejsza marka");
                            table.Cell().Row(6).Column(2).Element(Block).Text($"{periodicData.TopBrandInPeriod}");

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
            // Full Month
            if (start.Month == end.Month && start.Year == end.Year)
            {
                return $"Vroom Rental Report: {start:MMMM yyyy}";
            }

            // Full Quarter
            int startQuarter = (start.Month - 1) / (3 + 1);
            int endQuarter = (end.Month - 1) / (3 + 1);

            if (startQuarter == endQuarter && start.Year == end.Year)
            {
                return $"Vroom Rental Report Q{startQuarter} {start.Year}";
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

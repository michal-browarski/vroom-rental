using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace VroomRental.Backend.Reports
{
    public class PDFReportGenerator
    {
        public void GenerateDailyReport(DateTime date)
        {
            string formattedDate = date.ToString("yyyy-MM-dd");
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
                            table.Cell().Row(1).Column(2).Element(Block).Text("1000");

                            table.Cell().Row(2).Column(1).Element(Block).Text("Płatności");
                            table.Cell().Row(2).Column(2).Element(Block).Text("1000");

                            table.Cell().Row(3).Column(1).Element(Block).Text("Najpopularniejsza marka");
                            table.Cell().Row(3).Column(2).Element(Block).Text("Toyota");

                            table.Cell().Row(4).Column(1).Element(Block).Text("Dostępne samochody");
                            table.Cell().Row(4).Column(2).Element(Block).Text("Liczba - Procent");

                            table.Cell().Row(5).Column(1).Element(Block).Text("Samochody w naprawie");
                            table.Cell().Row(5).Column(2).Element(Block).Text("Liczba - Procent");

                            table.Cell().Row(6).Column(1).Element(Block).Text("Zalegające zwroty");
                            table.Cell().Row(6).Column(2).Element(Block).Text("1000");

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

        public void GeneratePeriodicReport(DateTime start, DateTime end)
        {
            string formattedDateStart = start.ToString("yyyy-MM-dd");
            string formattedDateEnd= end.ToString("yyyy-MM-dd");
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
                        .Text($"Vroom Rental Report for {formattedDateStart} - {formattedDateEnd}")
                        .SemiBold().FontSize(20).FontColor(Colors.Blue.Medium);

                    page.Content()
                        .Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn(3); // Tabela 1
                                columns.RelativeColumn(1); // Tabela 2
                                columns.RelativeColumn(2); // Tabela 3
                            });

                            table.Header(header =>
                            {
                                header.Cell().Element(CellStyle).Text("Tabela 1");
                                header.Cell().Element(CellStyle).Text("Tabela 2");
                                header.Cell().Element(CellStyle).Text("Tabela 3");
                            });

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

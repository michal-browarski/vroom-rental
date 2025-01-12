using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

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
                        .Text($"Vroom Rental Report for {date}")
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

        public void GeneratePeriodicReport(DateTime start, DateTime end)
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"VroomRental Report {start} - {end}");
        }

        private IContainer CellStyle(IContainer container)
        {
            return container.Padding(5).BorderBottom(1).BorderColor(Colors.Grey.Lighten2);
        } 
    }
}

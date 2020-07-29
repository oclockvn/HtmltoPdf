using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;

namespace HtmlToPdf.Web.Pages
{
    public class ReportModel : PageModel
    {
        public List<Technology> Technologies { get; set; } = new List<Technology>();
        public List<OverviewMetric> Metrics { get; set; } = new List<OverviewMetric>();

        public void OnGet()
        {
            Technologies = new List<Technology>
            {
                new Technology
                {
                    Name = "LED LIGHTING",
                    Sell = 0,
                    Rebate = 0,
                    OutOfPocket = 0,
                    UsageReduction = 0,
                    DemandReduction = 0
                },
                new Technology
                {
                    Name = "VOLAGE OPTIMISATION",
                    Sell = 159_430,
                    Rebate = 65_445,
                    OutOfPocket = 93_985,
                    UsageReduction = 29,
                    DemandReduction = 8
                },
                new Technology
                {
                    Name = "MONITORING",
                    Rebate = 0,
                    OutOfPocket = 0,
                    UsageReduction = 0,
                    DemandReduction = 0
                },
                new Technology
                {
                    Name = "POWER FACTOR CORRECTION",
                    Rebate = 0,
                    OutOfPocket = 0,
                    UsageReduction = 0,
                    DemandReduction = 0
                },
                new Technology
                {
                    Name = "SOLAR POWER",
                    Sell = 0,
                    Rebate = 0,
                    OutOfPocket = 0,
                    UsageReduction = 0,
                    DemandReduction = 0
                },
                new Technology
                {
                    Name = "BATTERY ENERGY STORAGE",
                    Sell = 0,
                    Rebate = 0,
                    OutOfPocket = 0,
                    UsageReduction = 0,
                    DemandReduction = 0
                },
                new Technology
                {
                    Name = "--",
                    Sell = 0,
                    Rebate = 0,
                    OutOfPocket = 0,
                    UsageReduction = 0,
                    DemandReduction = 0
                },
                new Technology
                {
                    Name = "--",
                    Sell = 0,
                    Rebate = 0,
                    OutOfPocket = 0,
                    UsageReduction = 0,
                    DemandReduction = 0
                },
                new Technology
                {
                    Name = "--",
                    Sell = 0,
                    Rebate = 0,
                    OutOfPocket = 0,
                    UsageReduction = 0,
                    DemandReduction = 0
                },
                new Technology
                {
                    Name = "--",
                    Sell = 0,
                    Rebate = 0,
                    OutOfPocket = 0,
                    UsageReduction = 0,
                    DemandReduction = 0
                },
                new Technology
                {
                    Name = "--",
                    Sell = 0,
                    Rebate = 0,
                    OutOfPocket = 0,
                    UsageReduction = 0,
                    DemandReduction = 0
                },
                new Technology
                {
                    Name = "--",
                    Sell = 0,
                    Rebate = 0,
                    OutOfPocket = 0,
                    UsageReduction = 0,
                    DemandReduction = 0
                },
                new Technology
                {
                    Name = "--",
                    Sell = 0,
                    Rebate = 0,
                    OutOfPocket = 0,
                    UsageReduction = 0,
                    DemandReduction = 0
                },
                new Technology
                {
                    Name = "--",
                    Sell = 0,
                    Rebate = 0,
                    OutOfPocket = 0,
                    UsageReduction = 0,
                    DemandReduction = 0
                },
                new Technology
                {
                    Name = "--",
                    Sell = 0,
                    Rebate = 0,
                    OutOfPocket = 0,
                    UsageReduction = 0,
                    DemandReduction = 0
                },
                new Technology
                {
                    Name = "--",
                    Sell = 0,
                    Rebate = 0,
                    OutOfPocket = 0,
                    UsageReduction = 0,
                    DemandReduction = 0
                },
            };

            Metrics = new List<OverviewMetric>
            {
                new OverviewMetric("Value", "$2.8M"),
                new OverviewMetric("Rebate", "$9.7k"),
                new OverviewMetric("Out of pocket", "$2.8M"),
                new OverviewMetric("ROI", "5 years")
            };
        }

        public IActionResult OnPost()
        {
            // Create a PDF from any existing web page
            var renderer = new IronPdf.HtmlToPdf(new IronPdf.PdfPrintOptions
            {
                Title = "Proposal",
                CssMediaType = IronPdf.PdfPrintOptions.PdfCssMediaType.Print,
                PaperSize = IronPdf.PdfPrintOptions.PdfPaperSize.A4,
                PrintHtmlBackgrounds = true,
                MarginBottom = 0,
                MarginLeft = 0,
                MarginRight = 0,
                MarginTop = 0
            });
            var PDF = renderer.RenderUrlAsPdf("https://localhost:44345/Report");
            PDF.SaveAs($"dist/report_{DateTime.Now.ToString("ddMMyyyyhhmmss")}.pdf");

            //var pdf = renderer.RenderHTMLFileAsPdf("template.html");
            //pdf.SaveAs($"report_{DateTime.Now.ToString("ddMMyyyyhhmmss")}.pdf");

            return Redirect("/Report");
        }
    }

    public class Technology
    {
        public string Name { get; set; }
        public double Sell { get; set; }
        public double Rebate { get; set; }
        public double OutOfPocket { get; set; }
        public double UsageReduction { get; set; }
        public double DemandReduction { get; set; }
    }

    public class OverviewMetric
    {
        public string Title { get; set; }
        public string Value { get; set; }

        public OverviewMetric(string title, string value)
        {
            Title = title;
            Value = value;
        }
    }
}

﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;

namespace HtmlToPdf.Web.Pages
{
    public class ReportModel : PageModel
    {
        public List<Technology> Technologies { get; set; } = new List<Technology>();

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

        }

        public IActionResult OnPost()
        {
            // Create a PDF from any existing web page
            var renderer = new IronPdf.HtmlToPdf(new IronPdf.PdfPrintOptions
            {
                CustomCssUrl = "https://localhost:44345/css/proposal.css",
                Title = "Proposal",
                CssMediaType = IronPdf.PdfPrintOptions.PdfCssMediaType.Print,
                PaperSize = IronPdf.PdfPrintOptions.PdfPaperSize.A4,
            });
            var PDF = renderer.RenderUrlAsPdf("https://localhost:44345/Report");
            PDF.SaveAs($"report_{DateTime.Now.ToString("ddMMyyyyhhmmss")}.pdf");

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
}

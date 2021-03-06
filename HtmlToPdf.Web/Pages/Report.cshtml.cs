﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;

namespace HtmlToPdf.Web.Pages
{
    public class ReportModel : PageModel
    {
        public List<Technology> Technologies { get; set; } = new List<Technology>();
        public List<OverviewMetric> Metrics { get; set; } = new List<OverviewMetric>();

        public List<BillSaving> UsageNow { get; set; } = new List<BillSaving>();
        public List<BillSaving> UsageAfter { get; set; } = new List<BillSaving>();

        public List<BillSaving> DemandNow { get; set; } = new List<BillSaving>();
        public List<BillSaving> DemandAfter { get; set; } = new List<BillSaving>();

        public List<BillSaving> FixNow { get; set; } = new List<BillSaving>();
        public List<BillSaving> FixAfter { get; set; } = new List<BillSaving>();

        public List<BillSaving> ExportNow { get; set; } = new List<BillSaving>();
        public List<BillSaving> ExportAfter { get; set; } = new List<BillSaving>();

        public List<Assumption> Assumptions { get; set; }
        public List<Quotation> Quotations { get; set; }
        public List<WarrantyList> Warranties { get; set; }

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

            UsageNow = new List<BillSaving>
            {
                new BillSaving("Description", "$/kwh", "Quantity", "Cost"),
                new BillSaving("Peak rate", "$0.1", "4,349", "$434.92"),
                new BillSaving("Off-peak rate", "$0.29", "206,823", "$59,565.1"),
                new BillSaving("Total Consumption", "", "", "$2111.72"),
            };

            UsageAfter = new List<BillSaving>
            {
                new BillSaving("Description", "$/kwh", "Quantity", "Cost"),
                new BillSaving("Peak rate", "-", "-", "-"),
                new BillSaving("Off-peak rate", "$0.29", "206,333", "$60,000"),
                new BillSaving("Total Consumption", "", "", "$2082.33"),
            };

            DemandNow = new List<BillSaving>
            {
                new BillSaving("Description", "$/kwh", "Quantity", "Cost"),
                new BillSaving("All Demand Cost", "-", "-", "-"),
                new BillSaving("Total Demand Cost", "", "", "-"),
            };

            DemandAfter = new List<BillSaving>
            {
                new BillSaving("Description", "$/kwh", "Quantity", "Cost"),
                new BillSaving("All Demand Cost", "-", "-", "-"),
                new BillSaving("Total Demand Cost", "", "", "-"),
            };

            FixNow = new List<BillSaving>
            {
                new BillSaving("Description", "$/kwh", "Quantity", "Cost"),
                new BillSaving("All Fixed Cost", "-", "-", "-"),
                new BillSaving("Total Fixed Cost", "", "", "-"),
            };

            FixAfter = new List<BillSaving>
            {
                new BillSaving("Description", "$/kwh", "Quantity", "Cost"),
                new BillSaving("All Demand Cost", "-", "-", "-"),
                new BillSaving("Total Demand Cost", "", "", "-"),
            };

            ExportNow = new List<BillSaving>
            {
                new BillSaving("Description", "$/kwh", "Quantity", "Cost"),
                new BillSaving("All Export Power", "-", "-", "-"),
                new BillSaving("Total Export", "", "", "-"),
            };

            ExportAfter = new List<BillSaving>
            {
                new BillSaving("Description", "$/kwh", "Quantity", "Cost"),
                new BillSaving("All Export Power", "-", "-", "-"),
                new BillSaving("Total Export", "", "", "-"),
            };

            Assumptions = new List<Assumption>
            {
                new Assumption("OPPORTUNITY INFO", string.Empty, true),
                new Assumption("Supply Address", "1205 Numurkan Rd, Katunga, VIX 3640"),
                new Assumption("Meter ID", "6203928552"),
                new Assumption("Average Monthly Electricity Bill (Ex GST)","$1000"),
                new Assumption("TAX", string.Empty, true),
                new Assumption("Registered for GST", "Yes"),
                new Assumption("GRID", string.Empty, true),
                new Assumption("Voltage & Arrangement", "230v"),
                new Assumption("Frequency", "50hz"),
                new Assumption("METER DATA", string.Empty, true),
                new Assumption("File", "<filename>")
            };

            Quotations = Quotation.Gen();
            Warranties = WarrantyList.Gen();
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
                MarginTop = 0,
                EnableJavaScript = true,
                RenderDelay = 3000
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

    public class BillSaving
    {
        public string Description { get; set; }
        public string Kwh { get; set; }
        public string Qty { get; set; }
        public string Cost { get; set; }

        public BillSaving(string desc, string kwh, string qty, string cost)
        {
            Description = desc;
            Kwh = kwh;
            Qty = qty;
            Cost = cost;
        }
    }

    public class Assumption
    {
        public string Label { get; set; }
        public string Value { get; set; }
        public bool IsTitle { get; set; }

        public Assumption(string label, string value, bool isTitle = false)
        {
            Label = label;
            Value = value;
            IsTitle = isTitle;
        }
    }

    public class Quotation
    {
        public string Header { get; set; }
        public string HelpText { get; set; }
        public List<QuotationPrimary> Primaries { get; set; } = new List<QuotationPrimary>();
        public List<QuotationSecondary> Secondaries { get; set; } = new List<QuotationSecondary>();

        public static List<Quotation> Gen()
        {
            return new List<Quotation>
            {
                new Quotation
                {
                    Header = "LED LIGHTING",
                    HelpText = "All figures exclude GST unless specified",
                    Primaries = new List<QuotationPrimary>
                    {
                        new QuotationPrimary("$111.11", "0", "$113.00", "$224.11")
                    },
                    Secondaries = new List<QuotationSecondary>
                    {
                        new QuotationSecondary
                        {
                            Category = "Price",
                            Products = new List<QuotationProduct>
                            {
                                new QuotationProduct("Lorem ipsum dolor sit amet", 1, "$100", "$100"),
                                new QuotationProduct("Sed ut perspiciatis unde omnis", 2, "$50", "$100"),
                            }
                        },
                        new QuotationSecondary
                        {
                            Category = "Rebate",
                            Products = new List<QuotationProduct>
                            {
                                new QuotationProduct("Ut enim ad minima veniam", 1, "$20", "$20")
                            }
                        }
                    }
                },
                new Quotation
                {
                    Header = "POWER FACTOR CORRECTION",
                    HelpText = "All figures exclude GST unless specified",
                    Primaries = new List<QuotationPrimary>
                    {
                        new QuotationPrimary("$111.11", "0", "$113.00", "$224.11")
                    },
                    Secondaries = new List<QuotationSecondary>
                    {
                        new QuotationSecondary
                        {
                            Category = "Price",
                            Products = new List<QuotationProduct>
                            {
                                new QuotationProduct("Quis autem vel", 1, "$100", "$100"),
                                new QuotationProduct("Nam libero tempore", 2, "$50", "$100"),
                            }
                        },
                        new QuotationSecondary
                        {
                            Category = "Rebate",
                            Products = new List<QuotationProduct>
                            {
                                new QuotationProduct("sed quia non numquam eius", 1, "$20", "$20"),
                                new QuotationProduct("Nemo enim ipsam voluptatem", 1, "$20", "$20")
                            }
                        }
                    }
                },
                new Quotation
                {
                    Header = "SOLAR POWER",
                    HelpText = "All figures exclude GST unless specified",
                    Primaries = new List<QuotationPrimary>
                    {
                        new QuotationPrimary("$111.11", "0", "$113.00", "$224.11")
                    },
                    Secondaries = new List<QuotationSecondary>
                    {
                        new QuotationSecondary
                        {
                            Category = "Price",
                            Products = new List<QuotationProduct>
                            {
                                new QuotationProduct("Quis autem vel", 1, "$100", "$100"),
                                new QuotationProduct("consectetur adipiscing elit", 1, "$100", "$100"),
                                new QuotationProduct("sed do eiusmod tempor incididunt", 1, "$100", "$100"),
                                new QuotationProduct("ut labore et dolore magna aliqua", 1, "$100", "$100"),
                                new QuotationProduct("Ut enim ad minim veniam", 1, "$100", "$100"),
                                new QuotationProduct("quis nostrud exercitation", 1, "$100", "$100"),
                                new QuotationProduct("ullamco laboris nisi", 1, "$100", "$100"),
                                new QuotationProduct("ut aliquip ex ea", 1, "$100", "$100"),
                                new QuotationProduct("commodo consequat", 1, "$100", "$100"),
                                new QuotationProduct("Duis aute irure dolor", 1, "$100", "$100"),
                                new QuotationProduct("Quis autem vel", 1, "$100", "$100"),
                                new QuotationProduct("in reprehenderit", 1, "$100", "$100"),
                                new QuotationProduct("sed do eiusmod tempor incididunt", 1, "$100", "$100"),
                                new QuotationProduct("ut labore et dolore magna aliqua", 1, "$100", "$100"),
                                new QuotationProduct("Ut enim ad minim veniam", 1, "$100", "$100"),
                                new QuotationProduct("quis nostrud exercitation", 1, "$100", "$100"),
                                new QuotationProduct("Nam libero tempore", 2, "$50", "$100"),
                            }
                        },
                        new QuotationSecondary
                        {
                            Category = "Rebate",
                            Products = new List<QuotationProduct>
                            {
                                new QuotationProduct("sed quia non numquam eius", 1, "$20", "$20"),
                                new QuotationProduct("Nemo enim ipsam voluptatem", 1, "$20", "$20")
                            }
                        }
                    }
                },
                new Quotation
                {
                    Header = "TOTAL",
                    HelpText = "All figures exclude GST unless specified",
                    Primaries = new List<QuotationPrimary>
                    {
                        new QuotationPrimary("$111.11", "0", "$113.00", "$224.11"){ Highlight = true }
                    }
                }
            };
        }
    }

    public class QuotationPrimary
    {
        public string Price { get; set; }
        public string Rebate { get; set; }
        public string OutOfPocket { get; set; }
        public string OutOfPocketGst { get; set; }
        public bool Highlight { get; set; }

        public QuotationPrimary(string price, string rebate, string oop, string gst)
        {
            Price = price;
            Rebate = rebate;
            OutOfPocket = oop;
            OutOfPocketGst = gst;
        }
    }

    public class QuotationSecondary
    {
        public string Category { get; set; }
        public List<QuotationProduct> Products { get; set; }
    }

    public class QuotationProduct
    {
        public string Description { get; set; }
        public int Qty { get; set; }
        public string UnitPrice { get; set; }
        public string Price { get; set; }

        public QuotationProduct(string desc, int qty, string unit, string price)
        {
            Description = desc;
            Qty = qty;
            UnitPrice = unit;
            Price = price;
        }
    }

    public class Warranty
    {
        public string Item { get; set; }
        public string Part { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }

        public Warranty(string item, string part, string desc, int year)
        {
            Item = item;
            Part = part;
            Description = desc;
            Year = year;
        }
    }

    public class WarrantyList
    {
        public string Category { get; set; }
        public List<Warranty> Items { get; set; }

        public static List<WarrantyList> Gen()
        {
            return new List<WarrantyList>
            {
                new WarrantyList
                {
                    Category = "LED LIGHTING",
                    Items = new List<Warranty>
                    {
                        new Warranty("WORKMANSHIP", "JKM330M-60", "JINKO PANEL 330W-BLK FRAME ", 10),
                        new Warranty("SOLAR PANEL MANUFACTURERS", "JKM330M-60", "JINKO PANEL 330W-BLK FRAME ", 10),
                        new Warranty("INVERTER MANUFACTURERS", "FRONIUS SYMO15.0-3-M", "JINKO PANEL 330W-BLK FRAME ", 10),
                    }
                },
                new WarrantyList
                {
                    Category = "POWER FACTOR CORRECTION",
                    Items = new List<Warranty>
                    {
                        new Warranty("WORKMANSHIP", "JKM330M-60", "JINKO PANEL 330W-BLK FRAME ", 10),
                        new Warranty("SOLAR PANEL MANUFACTURERS", "JKM330M-60", "JINKO PANEL 330W-BLK FRAME ", 10),
                        new Warranty("INVERTER MANUFACTURERS", "FRONIUS SYMO15.0-3-M", "JINKO PANEL 330W-BLK FRAME ", 10),
                    }
                },
                new WarrantyList
                {
                    Category = "SOLAR POWER",
                    Items = new List<Warranty>
                    {
                        new Warranty("WORKMANSHIP", "JKM330M-60", "JINKO PANEL 330W-BLK FRAME ", 10),
                        new Warranty("SOLAR PANEL MANUFACTURERS", "JKM330M-60", "JINKO PANEL 330W-BLK FRAME ", 10),
                        new Warranty("INVERTER MANUFACTURERS", "FRONIUS SYMO15.0-3-M", "JINKO PANEL 330W-BLK FRAME ", 10),
                    }
                },
                new WarrantyList
                {
                    Category = "TECHONOLOGY NAME",
                    Items = new List<Warranty>
                    {
                        new Warranty("WORKMANSHIP", "JKM330M-60", "JINKO PANEL 330W-BLK FRAME ", 10),
                        new Warranty("SOLAR PANEL MANUFACTURERS", "JKM330M-60", "JINKO PANEL 330W-BLK FRAME ", 10),
                        new Warranty("INVERTER MANUFACTURERS", "FRONIUS SYMO15.0-3-M", "JINKO PANEL 330W-BLK FRAME ", 10),
                    }
                },
            };
        }
    }
}

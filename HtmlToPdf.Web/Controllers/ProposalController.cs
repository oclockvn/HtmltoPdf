using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using PuppeteerSharp;
using PuppeteerSharp.Media;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace HtmlToPdf.Web.Controllers
{
    [Route("export")]
    [ApiController]
    public class ProposalController : ControllerBase
    {
        private readonly IWebHostEnvironment environment;

        public ProposalController(IWebHostEnvironment environment)
        {
            this.environment = environment;
        }

        [HttpGet, Route("pdf")]
        public async Task<IActionResult> Pdf()
        {
            await new BrowserFetcher().DownloadAsync(BrowserFetcher.DefaultRevision);
            var browser = await Puppeteer.LaunchAsync(new LaunchOptions
            {
                Headless = true,
            });
            var page = await browser.NewPageAsync();
            await page.GoToAsync("https://localhost:44345/report");
            await page.EmulateMediaTypeAsync(MediaType.Screen);

            var filename = Guid.NewGuid().ToString("N") + ".pdf";
            var outputDir = Path.Combine(environment.ContentRootPath, "proposal");
            //var rotativaLocation = Path.Combine(environment.WebRootPath, "wkhtml", "wkhtmltopdf.exe");
            if (!Directory.Exists(outputDir))
            {
                Directory.CreateDirectory(outputDir);
            }

            var outputFile = Path.Combine(outputDir, filename);
            var footerPath = Path.Combine(environment.WebRootPath, "wkhtml", "footer.html");
            var headerPath = Path.Combine(environment.WebRootPath, "wkhtml", "header.html");

            await page.PdfAsync(outputFile, new PdfOptions
            {
                DisplayHeaderFooter = true,
                HeaderTemplate = "<style>#header, #footer { padding: 0 !important; }</style><div style='width: 210mm; border-top: 10px solid #4d80b0;'></div>",
                //FooterTemplate = "<div style='height: 50px; background-color: green; font-size: 12px;'></div>",
                Format = PaperFormat.A4,
                PrintBackground = true,
                PreferCSSPageSize = true,
            });

            return Ok(new { msg = "Ok" });
        }

        [HttpPost, Route("export")]
        public async Task<IActionResult> Export()
        {
            var footerPath = Path.Combine(environment.WebRootPath, "wkhtml", "footer.html");
            var headerPath = Path.Combine(environment.WebRootPath, "wkhtml", "header.html");
            //var url = Request.GetDisplayUrl();
            var pdfUrl = $"{Request.Scheme}://{Request.Host.Value}/report";
            var filename = Guid.NewGuid().ToString("N") + ".pdf";
            var outputDir = Path.Combine(environment.ContentRootPath, "proposal");
            var rotativaLocation = Path.Combine(environment.WebRootPath, "wkhtml", "wkhtmltopdf.exe");
            if (!Directory.Exists(outputDir))
            {
                Directory.CreateDirectory(outputDir);
            }

            var output = Path.Combine(outputDir, filename);

            var cmd = $"{rotativaLocation} --background --enable-javascript --javascript-delay 2000 --margin-bottom 20mm --margin-top 2mm --margin-left 0 --margin-right 0 --footer-html \"{footerPath}\" --header-html \"{headerPath}\" {pdfUrl} {output}";
            Debug.WriteLine("> " + cmd);
            //var process = Process.Start(new ProcessStartInfo
            //{
            //    Arguments = $"/C {cmd}",
            //    CreateNoWindow = false,
            //    WindowStyle = ProcessWindowStyle.Hidden,
            //    UseShellExecute = false,
            //    FileName = "cmd.exe",
            //    RedirectStandardOutput = true
            //});

            ////process.EnableRaisingEvents = true;
            ////process.Exited += (sender, e) =>
            ////{
            ////    Debug.WriteLine("Export pdf completed");
            ////};
            ////await process.StandardOutput.ReadToEndAsync();
            //process.StandardOutput.ReadToEnd();
            //process.WaitForExit();

            //byte[] arr = null;
            using (var proc = new Process())
            {
                try
                {
                    proc.StartInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/C {cmd}",
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        RedirectStandardInput = true,
                        CreateNoWindow = true
                    };

                    proc.Start();
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                var _output = proc.StandardOutput.ReadToEnd();

                proc.WaitForExit();

                // generate PDF from given HTML string, not from URL
                //if (!string.IsNullOrEmpty(html))
                //{
                //using (var sIn = proc.StandardInput)
                //{
                //    sIn.WriteLine(html);
                //}
                //}

                //using (var ms = new MemoryStream())
                //{
                //    using (var sOut = proc.StandardOutput.BaseStream)
                //    {
                //        byte[] buffer = new byte[4096];
                //        int read;

                //        while ((read = sOut.Read(buffer, 0, buffer.Length)) > 0)
                //        {
                //            ms.Write(buffer, 0, read);
                //        }
                //    }

                //    string error = proc.StandardError.ReadToEnd();

                //    if (ms.Length == 0)
                //    {
                //        throw new Exception(error);
                //    }

                //    proc.WaitForExit();

                //    arr = ms.ToArray();
                //}
            }

            //System.IO.File.WriteAllBytes(output, arr);
            return Ok(new { filename });
        }
    }
}

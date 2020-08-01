namespace HtmlToPdf.Web.Extensions
{
    public static class ValueFormatter
    {
        public static string FormatMoney(this double value, string currency = "$")
        {
            return string.Format("{0}{1:#,##}", currency, value);
        }
    }
}

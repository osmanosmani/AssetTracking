namespace AssetTracking.Models
{
    public class CurrencyObj
    {
        public string CurrencyCode { get; set; }
        public double ExchangeRateFromEUR { get; set; }

        public CurrencyObj(string currencyCode, double rate)
        {
            CurrencyCode = currencyCode;
            ExchangeRateFromEUR = rate;
        }
    }
}
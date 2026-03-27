using AssetTracking.Enums;

namespace AssetTracking.Models
{
    public class Office
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public CurrencyType Currency { get; set; }

        public Office(string name, string country, CurrencyType currency)
        {
            Name = name;
            Country = country;
            Currency = currency;
        }
    }
}
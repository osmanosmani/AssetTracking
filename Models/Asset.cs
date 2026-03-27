using System;
using AssetTracking.Enums;

namespace AssetTracking.Models
{
    public abstract class Asset
    {
        public string Brand { get; set; }
        public string ModelName { get; set; }
        public decimal Price { get; set; }
        public CurrencyType Currency { get; set; }
        public DateTime PurchaseDate { get; set; }
        public Office Office { get; set; }

        public abstract AssetType Type { get; }

        protected Asset(
            string brand,
            string modelName,
            decimal price,
            CurrencyType currency,
            DateTime purchaseDate,
            Office office)
        {
            Brand = brand;
            ModelName = modelName;
            Price = price;
            Currency = currency;
            PurchaseDate = purchaseDate;
            Office = office;
        }
    }
}
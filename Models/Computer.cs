using System;
using AssetTracking.Enums;

namespace AssetTracking.Models
{
    public class Computer : Asset
    {
        public override AssetType Type => AssetType.Computer;

        public Computer(
            string brand,
            string modelName,
            decimal price,
            CurrencyType currency,
            DateTime purchaseDate,
            Office office)
            : base(brand, modelName, price, currency, purchaseDate, office)
        {
        }
    }
}
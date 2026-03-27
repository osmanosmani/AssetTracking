using System;
using AssetTracking.Enums;

namespace AssetTracking.Models
{
    public class Phone : Asset
    {
        public override AssetType Type => AssetType.Phone;

        public Phone(
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
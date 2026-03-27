using AssetTracking.Enums;
using AssetTracking.Models;
using System;
using System.Numerics;

namespace AssetTracking.Services
{
    public static class SampleDataLoader
    {
        public static void Load(AssetService service)
        {
            var usa = new Office("USA Office", "USA", CurrencyType.USD);
            var sweden = new Office("Sweden Office", "Sweden", CurrencyType.SEK);
            var germany = new Office("Germany Office", "Germany", CurrencyType.EUR);

            // Germany
            service.AddAsset(new Computer("Asus", "ROG 600", 1600, CurrencyType.EUR, new DateTime(2021, 12, 07), germany));
            service.AddAsset(new Computer("Asus", "ROG 500", 1500, CurrencyType.EUR, new DateTime(2022, 02, 07), germany));
            service.AddAsset(new Computer("Asus", "ROG 300", 1200, CurrencyType.EUR, new DateTime(2022, 02, 07), germany));
            service.AddAsset(new Phone("Siemens", "Brick", 200, CurrencyType.EUR, new DateTime(2022, 08, 07), germany));

            // Sweden
            service.AddAsset(new Computer("Dell", "Optiplex 100", 15000, CurrencyType.SEK, new DateTime(2022, 08, 07), sweden));
            service.AddAsset(new Computer("Dell", "Optiplex 200", 14000, CurrencyType.SEK, new DateTime(2022, 09, 07), sweden));
            service.AddAsset(new Computer("Dell", "Optiplex 300", 13000, CurrencyType.SEK, new DateTime(2022, 10, 07), sweden));
            service.AddAsset(new Phone("Samsung", "Galaxy 10", 4500, CurrencyType.SEK, new DateTime(2022, 04, 07), sweden));
            service.AddAsset(new Phone("Sony", "Xperia 7", 3000, CurrencyType.SEK, new DateTime(2022, 03, 07), sweden));

            // USA
            service.AddAsset(new Computer("Dell", "Desktop 900", 100, CurrencyType.USD, new DateTime(2021, 08, 07), usa));
            service.AddAsset(new Computer("Dell", "Desktop 800", 150, CurrencyType.USD, new DateTime(2021, 09, 07), usa));
            service.AddAsset(new Computer("Lenovo", "X100", 300, CurrencyType.USD, new DateTime(2022, 01, 07), usa));
            service.AddAsset(new Phone("Motorola", "X3", 200, CurrencyType.USD, new DateTime(2022, 03, 07), usa));
            service.AddAsset(new Phone("Motorola", "X4", 400, CurrencyType.USD, new DateTime(2022, 02, 07), usa));
        }
    }
}
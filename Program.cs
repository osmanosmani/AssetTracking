using System;
using System.Collections.Generic;
using AssetTracking.Enums;
using AssetTracking.Helpers;
using AssetTracking.Models;
using AssetTracking.Services;

namespace AssetTracking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LiveCurrency.FetchRates();

            AssetService assetService = new();
            SampleDataLoader.Load(assetService);

            List<Asset> assets = assetService.GetFullySortedAssets();

            ConsoleTableHelper.PrintHeader();

            foreach (Asset asset in assets)
            {
                decimal priceUsd = assetService.GetPriceInUsd(asset);
                decimal priceLocal = assetService.GetPriceInOfficeCurrency(asset);

                string color = AssetColorService.GetColorStatus(asset);

                ConsoleColor originalColor = Console.ForegroundColor;

                if (color == "RED")
                    Console.ForegroundColor = ConsoleColor.Red;
                else if (color == "YELLOW")
                    Console.ForegroundColor = ConsoleColor.Yellow;
                else
                    Console.ForegroundColor = ConsoleColor.Gray;

                string assetLabel = asset.Type == AssetType.Phone ? "Smartphone" : "Computer";

                Console.WriteLine(
                    $"{asset.Office.Country,-12} " +
                    $"{assetLabel,-12} " +
                    $"{asset.Brand,-12} " +
                    $"{asset.ModelName,-20} " +
                    $"{priceUsd,-15:0.00} " +
                    $"{asset.Office.Currency} {priceLocal,-12:0.00} " +
                    $"{asset.PurchaseDate,-15:yyyy-MM-dd}");

                Console.ForegroundColor = originalColor;
            }

            ConsoleTableHelper.PrintFooter();
        }
    }
}
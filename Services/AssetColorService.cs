using System;
using AssetTracking.Models;

namespace AssetTracking.Services
{
    public static class AssetColorService
    {
        public static string GetColorStatus(Asset asset)
        {
            DateTime referenceDate = new DateTime(2025, 03, 01);
            DateTime endOfLife = asset.PurchaseDate.AddYears(3);
            TimeSpan remaining = endOfLife - referenceDate;

            if (remaining.TotalDays < 90)
                return "RED";

            if (remaining.TotalDays < 180)
                return "YELLOW";

            return "NORMAL";
        }
    }
}
using System;
using System.Collections.Generic;

namespace AssetTracking.Services
{
    public static class LiveCurrency
    {
        private static readonly Dictionary<string, decimal> RatesToUsd = new()
        {
            { "USD", 1.00m },
            { "EUR", 1.08m },
            { "SEK", 0.095m }
        };

        public static void FetchRates()
        {
            // Placeholder for live API call if needed later
        }

        public static double Convert(double amount, string from, string to)
        {
            if (!RatesToUsd.ContainsKey(from) || !RatesToUsd.ContainsKey(to))
                throw new ArgumentException("Unsupported currency.");

            decimal amountDecimal = (decimal)amount;

            decimal amountInUsd = amountDecimal * RatesToUsd[from];

            decimal result = to == "USD"
                ? amountInUsd
                : amountInUsd / RatesToUsd[to];

            return (double)result;
        }
    }
}
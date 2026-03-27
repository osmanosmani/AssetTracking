using System;
using System.Collections.Generic;
using System.Linq;
using AssetTracking.Models;

namespace AssetTracking.Services
{
    public class AssetService
    {
        private readonly List<Asset> _assets = new();

        public void AddAsset(Asset asset)
        {
            if (asset == null)
                throw new ArgumentNullException(nameof(asset));

            _assets.Add(asset);
        }

        public List<Asset> GetFullySortedAssets()
        {
            return _assets
                .OrderBy(a => a.Office.Country)
                .ThenBy(a => a.PurchaseDate)
                .ToList();
        }

        public decimal GetPriceInUsd(Asset asset)
        {
            if (asset == null)
                throw new ArgumentNullException(nameof(asset));

            string from = asset.Currency.ToString();
            string to = "USD";

            return (decimal)LiveCurrency.Convert((double)asset.Price, from, to);
        }

        public decimal GetPriceInOfficeCurrency(Asset asset)
        {
            if (asset == null)
                throw new ArgumentNullException(nameof(asset));

            string from = asset.Currency.ToString();
            string to = asset.Office.Currency.ToString();

            return (decimal)LiveCurrency.Convert((double)asset.Price, from, to);
        }
    }
}
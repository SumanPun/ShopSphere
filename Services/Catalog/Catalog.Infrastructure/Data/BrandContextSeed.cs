﻿using Catalog.Core.Entities;
using MongoDB.Driver;
using System.Text.Json;

namespace Catalog.Infrastructure.Data
{
    public static class BrandContextSeed
    {
        public static void SeedData(IMongoCollection<ProductBrand> brandsCollection)
        {
            bool checkBrands = brandsCollection.Find(b => true).Any();
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "SeedData", "brands.json");
            if (!checkBrands)
            {
                var brandsData = File.ReadAllText(path);
                //var brandsData = File.ReadAllText("../Catalog.Infrastructure/Data/SeedData/brands.json");
                var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandsData);
                if (brands != null)
                {
                    foreach (var brand in brands) {
                        brandsCollection.InsertOneAsync(brand);
                    }
                }
            }
        }
    }
}

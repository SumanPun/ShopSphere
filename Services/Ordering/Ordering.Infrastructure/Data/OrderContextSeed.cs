﻿using Microsoft.Extensions.Logging;
using Ordering.Core.Entities;

namespace Ordering.Infrastructure.Data
{
    public class OrderContextSeed
    {
        public static async Task SeedAsync(OrderContext orderContext, ILogger<OrderContextSeed> logger)
        {
            if (!orderContext.Orders.Any())
            {
                orderContext.Orders.AddRange(GetOrders());
                await orderContext.SaveChangesAsync();
                logger.LogInformation($"Ordering Database: {typeof(OrderContext).Name} seeded!!!");
            }
        }

        private static IEnumerable<Order> GetOrders()
        {
            return new List<Order>
            {
                new()
                {
                    UserName = "john",
                    FirstName = "John",
                    LastName = "Doe",
                    EmailAddress = "johdoe@eCommerce.net",
                    AddressLine = "Kathmandu",
                    Country = "Nepal",
                    TotalPrice = 750,
                    State = "BA",
                    ZipCode = "560001",

                    CardName = "Visa",
                    CardNumber = "1234567890123456",
                    CreatedBy = "John",
                    Expiration = "12/25",
                    Cvv = "123",
                    PaymentMethod = 1,
                    LastModifiedBy = "John",
                    LastModifiedDate = new DateTime(),
                }
            };
        }
    }
}

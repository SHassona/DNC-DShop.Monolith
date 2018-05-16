﻿using System;

namespace DShop.Monolith.Core.Events.Products
{
    public class ProductUpdated : IEvent
    {
        public Guid Id { get; }
        public string Name { get; }
        public string Description { get; }
        public string Vendor { get; }
        public decimal Price { get; }

        public ProductUpdated(Guid id, string name, string description, 
            string vendor, decimal price)
        {
            Id = id;
            Name = name;
            Description = description;
            Vendor = vendor;
            Price = price;
        }
    }
}

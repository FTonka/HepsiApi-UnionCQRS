﻿using Bogus;
using HepsiApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiApi.Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            Faker faker = new("tr");
            Product product1 = new()
            {
                Id = 1,
                Title=faker.Commerce.ProductName(),
                Description=faker.Commerce.ProductDescription(),
                BrandId=1,
                Discount=faker.Random.Decimal(0,10),
                Price=faker.Finance.Amount(10,1000),
                CreateDate=DateTime.Now,
                IsDeleted=true,
            };
            Product product2 = new()
            {
                Id = 2,
                Title = faker.Commerce.ProductName(),
                Description = faker.Commerce.ProductDescription(),
                BrandId = 1,
                Discount = faker.Random.Decimal(0, 10),
                Price = faker.Finance.Amount(10, 1000),
                CreateDate = DateTime.Now,
                IsDeleted = true,
            };
            Product product3 = new()
            {
                Id = 3,
                Title = faker.Commerce.ProductName(),
                Description = faker.Commerce.ProductDescription(),
                BrandId = 1,
                Discount = faker.Random.Decimal(0, 10),
                Price = faker.Finance.Amount(10, 1000),
                CreateDate = DateTime.Now,
                IsDeleted = true,
            };
            builder.HasData(product1, product2, product3); 
        }
    }
}

using ProductStore.Data.Presistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductStore.Data
{
    public static class SeedData
    {
        public static void InitializeData(this ProductStoreDbContext context)
        {
            if(!context.Products.Any())
            {
                context.Products.Add(
                    new Product
                    {
                        Name = "Product 1",
                        Price = 10.1m,
                        Reviews = new List<Review>
                        {
                            new Review
                            {
                                Description = "Very good product"
                            },
                            new Review
                            {
                                Description = "Product is good, delivery is bad"
                            }
                        }
                    });

                context.Products.Add(
                    new Product
                    {
                        Name = "Product 2",
                        Price = 12.1m,
                        Reviews = new List<Review>
                        {
                            new Review
                            {
                                Description = "Product is good, delivery is bad"
                            }
                        }
                    });

                context.Products.Add(
                    new Product
                    {
                        Name = "Product 3",
                        Price = 20.1m,
                        Reviews = new List<Review>
                        {
                            new Review
                            {
                                Description = "Very good product"
                            },
                            new Review
                            {
                                Description = "Product is good, delivery is bad"
                            },
                            new Review
                            {
                                Description = "Price is high"
                            }
                        }
                    });

                context.Products.Add(
                    new Product
                    {
                        Name = "Product 4",
                        Price = 30.1m
                    });

                context.SaveChanges();
            }
        }
    }
}

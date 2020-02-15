using System;
using System.Collections.Generic;

namespace ProductStore.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<Review> Reviews { get; set; }
    }
}

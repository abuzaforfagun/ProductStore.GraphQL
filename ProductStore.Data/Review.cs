using System;
using System.Collections.Generic;
using System.Text;

namespace ProductStore.Data
{
    public class Review
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public string Description { get; set; }
    }
}

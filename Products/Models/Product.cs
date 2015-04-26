using System;

namespace CleanArchitectureAspNetMvc5.Products.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
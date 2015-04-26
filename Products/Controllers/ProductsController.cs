using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using CleanArchitectureAspNetMvc5.Products.Models;

namespace CleanArchitectureAspNetMvc5.Products.Controllers
{
    public class ProductsController : Controller
    {
        private readonly List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Name = "Ice Cream", Price = 1.23m },
            new Product { Id = 2, Name = "Cake", Price = 2.34m }
        };

        public ActionResult Index()
        {
            return View(_products);
        }

        public ActionResult Details(int id)
        {
            var product = _products
                .First(p => p.Id == id);

            return View(product);
        }
    }
}
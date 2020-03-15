using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DataBaseProject.Models;
using DataBaseProject.Repositories;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProduct _ProductRepo;

        public HomeController(IProduct ProductRepo)
        {
            _ProductRepo = ProductRepo;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Product()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Product(ProductViewModel product)
        {
            var model = new Product {
               Colour =  product.Colour,
               Price = product.Price,
               Sku = product.Sku,
               Stock = product.Stock,
               Style = product.Style,
                Title = product.Title
 

            };

            _ProductRepo.AddNewProduct(model);
           
            return RedirectToAction(nameof(Product));
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

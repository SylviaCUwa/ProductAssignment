using Microsoft.AspNetCore.Mvc;
using ProductAssignment.Data.Repositories;
using ProductAssignment.Models;

namespace ProductAssignment.Controllers
{
    public class ProductsController : Controller
    {
        private readonly Repository _productRepository;

        public ProductsController(Repository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            IEnumerable<Product> products = _productRepository.GetAllAsync();
            return View(products);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}

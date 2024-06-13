using AjaxProject.WebUl.Dal.Context;
using AjaxProject.WebUl.Dal.Entity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AjaxProject.WebUl.Controllers
{
    public class DefaultController : Controller
    {
        private readonly AjaxDbContext _context;

        public DefaultController(AjaxDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductList()
        {
            var values = _context.Products.ToList();
            var jsonValues = JsonConvert.SerializeObject(values);
            return Json(jsonValues);
        }
        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            var jsonValues = JsonConvert.SerializeObject(product);
            return Json(jsonValues);
        }

        public IActionResult DeleteProduct(int id)
        {
           var values = _context.Products.Find(id);
            _context.Products.Remove(values);
            _context.SaveChanges();
            return NoContent();
        }

        public IActionResult GetProduct(int id)
        {
            var values = _context.Products.Find(id);
            var jsonValues = JsonConvert.SerializeObject(values);
            return Json(jsonValues);
        }

        public IActionResult UpdateProduct(Product product)
        {
            var values = _context.Products.Find(product.ProductId);
            values.Name = product.Name;
            values.Price = product.Price;
            values.Stock = product.Stock;
            _context.SaveChanges();
            return NoContent();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using WebApplication1.Controllers.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers{
    public class ItemsController : Controller
    {
        private ApplicationContext context;
        public ItemsController(ApplicationContext _context)
        {
            context = _context;
        }

        public IActionResult Overview()
        {
            Item item = new Item { Name = "Keyboard" };

            return View(item);
        }

        public IActionResult Index()
        {
            var items = context.Items.ToList();

            return View(items);
        }
        
        public IActionResult Edit(int id)
        {
            return Content("id = " + id);
        }
    }
}



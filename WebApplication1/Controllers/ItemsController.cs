using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers{
    public class ItemsController : Controller
    {
        public IActionResult Overview()
        {
            Item item = new Item{Name = "Keyboard"};

            return View(item);
        }
    }
}



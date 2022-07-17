using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Menu()
        {
            ViewData["Title"] = "Menu";
            return View();
        }
    }
}

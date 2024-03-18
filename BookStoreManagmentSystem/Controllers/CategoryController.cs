using Microsoft.AspNetCore.Mvc;

namespace BookStoreManagmentSystem.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace DaCart
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
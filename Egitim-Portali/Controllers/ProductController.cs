using Microsoft.AspNetCore.Mvc;

namespace Egitim_Portali.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

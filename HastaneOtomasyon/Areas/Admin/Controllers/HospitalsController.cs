using Microsoft.AspNetCore.Mvc;

namespace HastaneOtomasyon.Areas.Admin.Controllers
{
    public class HospitalsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

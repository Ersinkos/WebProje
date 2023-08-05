using Microsoft.AspNetCore.Mvc;
using Hastane.Services;

namespace HastaneOtomasyon.Areas.Admin.Controllers
{
    [Area("admin")]
    public class UsersController : Controller
    {
        
        private IApplicationUserService _userService;
        public UsersController(IApplicationUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index(int PageNumber = 1, int PageSize = 10)
        {
            return View(_userService.GetAll(PageNumber, PageSize));
        }
    }
}

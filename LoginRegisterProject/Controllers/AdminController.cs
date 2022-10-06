using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace LoginRegisterProject.Controllers
{
    public class AdminController : Controller
    {
        //[Authorize(Roles = "admin,manager")]
		[Authorize(Roles = "admin")]
		public IActionResult Index()
        {
            return View();
        }
    }
}

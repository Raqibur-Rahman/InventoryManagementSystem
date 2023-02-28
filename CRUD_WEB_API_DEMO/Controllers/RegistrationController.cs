using Microsoft.AspNetCore.Mvc;

namespace CRUD_WEB_API_DEMO.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

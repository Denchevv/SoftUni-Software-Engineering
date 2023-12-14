namespace MyAspNetApp.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class OwnersController : Controller
    {
        // Creates shortcut in my APP Owners/Details
        public IActionResult Details()
        {
            return View();
        }
    }
}

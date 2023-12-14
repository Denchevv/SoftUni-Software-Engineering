using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class QuestionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace MyAspNetApp.Controllers;
public class CatsController : Controller
{
    public IActionResult All(int total)
    {

        var list = new List<int>();

        for (int i = 0; i < total; i++)
        {
            list.Add(i + 1);
        }

        return View(list);
    }
}


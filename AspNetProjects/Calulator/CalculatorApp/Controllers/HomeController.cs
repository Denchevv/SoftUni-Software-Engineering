using CalculatorApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index(decimal leftOperand, decimal rightOperand, string @operator, decimal result)
        {
            Calculator calculator = new Calculator()
            {
                RightOperand = rightOperand,
                LeftOperand = leftOperand,
                Operator = @operator,
                Result = result
            };
            return View(calculator);
        }

        public IActionResult Calculate (Calculator calculator)
        {
            calculator.CalculateResult();

            if(calculator.RightOperand == 0 && calculator.Operator == "/")
            {
                TempData["Error"] = "Cannot divide by zero";
            }
            else
            {
                Data.CalculatorHistory.Add(calculator);

            }

            return RedirectToAction("Index", calculator);
        }

        public IActionResult History()
        {
            return View(Data.CalculatorHistory);
        }
    }
}

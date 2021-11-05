using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace asp_less3_ex1_calc.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index(double x=0, double y=0, string sub=null)
        {
            switch (sub)
            {
                case " + ":
                    ViewBag.Result = x + y;
                    break;
                case " - ":
                    ViewBag.Result = x - y;
                    break;
                case " * ":
                    ViewBag.Result = x * y;
                    break;
                case " / ":
                    {
                        if (y == 0)
                        {
                            ViewBag.Result = "На ноль делить нельзя!";
                            break;
                        }
                        ViewBag.Result = x / y;
                        break;
                    }
                default:
                    ViewBag.Result = 0;
                    break;
            }
            return View();
        }
    }
}

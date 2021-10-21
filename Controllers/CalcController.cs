using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp_less3_ex1_calc.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index(int x=0, int y=0, string sub=null)
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
                            ViewBag.Result = null;
                            ViewBag.Commit = "На ноль делить нельзя!";
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

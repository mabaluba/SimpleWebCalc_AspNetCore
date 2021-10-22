using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public IActionResult UserInfo()
        {
            var userIP = HttpContext.Connection.LocalIpAddress;
            var userIP1 = HttpContext.Connection.RemoteIpAddress;
            var userAgent = Request.Headers.Where((i,k)=>i.Key=="User-Agent").Select(i=>i.Value).FirstOrDefault();
            //Console.WriteLine(userAgent);
            ViewBag.UserAgent = userAgent;
            ViewBag.U1 = userIP;
            ViewBag.U2 = userIP1;
            return View();
        }
    }
}

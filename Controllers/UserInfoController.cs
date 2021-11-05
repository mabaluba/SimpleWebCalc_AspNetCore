using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp_less3_ex1_calc.Controllers
{
    public class UserInfoController : Controller
    {
        public IActionResult UserInfo()
        {
            var userIP = HttpContext.Connection.LocalIpAddress;
            var userIP1 = HttpContext.Connection.RemoteIpAddress;
            var userAgent = Request.Headers.Where((i, k) => i.Key == "User-Agent").Select(i => i.Value).FirstOrDefault();
            ViewBag.UserAgent = userAgent;
            ViewBag.U1 = userIP.AddressFamily;
            ViewBag.U2 = userIP1.MapToIPv4();
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using asp_less3_ex1_calc.Model;

namespace asp_less3_ex1_calc.Controllers
{
    public class BindingController : Controller
    {
        public IActionResult Bind()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Bind(TreeProducts model)
        {
            Debug.WriteLine(model);

            return View(model);
        }
    }
}

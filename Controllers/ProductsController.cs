using asp_less3_ex1_calc.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace asp_less3_ex1_calc.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Show()
        {
            List<TreeProducts> products = new()
            {
                new ( 1, 127, "Oak" ),
                new ( 2, 127, "Cedar" ),
                new ( 3, 127, "Walnut" )
            };
           
            return View(products);
        }
    }
}

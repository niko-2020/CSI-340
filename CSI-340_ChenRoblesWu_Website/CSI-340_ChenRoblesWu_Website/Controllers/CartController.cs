using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSI_340_ChenRoblesWu_Website.Controllers
{
    public class CartController : Controller
    {
        public IActionResult ShoppingCart()
        {
            return View();
        }
    }
}

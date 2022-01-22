using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSI_340_ChenRoblesWu_Website.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult ContactInfo()
        {
            return View();
        }
    }
}

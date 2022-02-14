using CSI_340_ChenRoblesWu_Website.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSI_340_ChenRoblesWu_Website.Controllers
{
    public class CartController : Controller
    {
        private readonly DataContext _db;
        public CartController(DataContext db)
        {
            _db = db;
        }
        /*public async Task<IActionResult> addToCart(int customer_id,int book_id,int count)
        {
            customer_id.
        }*/
    }
}

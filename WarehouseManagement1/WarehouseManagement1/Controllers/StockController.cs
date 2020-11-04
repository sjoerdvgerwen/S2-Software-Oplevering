using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WarehouseManagement1.Models;

namespace WarehouseManagement1.Controllers
{
    public class StockController : Controller
    {
        public IActionResult StockList()
        {
            var stock = new Stock() { Name = "Moersleutel", Id = 1 };

            return View(stock); 
        }
    }
}

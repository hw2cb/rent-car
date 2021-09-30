using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RentCar.Models;
using RentCar.Models.Data;

namespace RentCar.Controllers
{
    public class HomeController : Controller
    {
        ICarRepository repo;
        public HomeController(ICarRepository r)
        {
            repo = r;
        }
        public IActionResult Index()
        {
            
            return View(repo.GetCars());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

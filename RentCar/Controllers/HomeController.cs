using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RentCar.Models;

namespace RentCar.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration Configuration;
        public HomeController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IActionResult Index()
        {
            List<Car> cars = new List<Car>();
            using (SqlConnection connection = new SqlConnection(Configuration.GetConnectionString("DBConnection")))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Автомобили", connection);
                SqlDataReader reader = command.ExecuteReader();

               
               while(reader.Read())
               {
                    Car car = new Car()
                    {
                        Name = reader["Марка автомобиля"].ToString(),
                        Color = reader["Цвет"].ToString()
                    };
                    cars.Add(car);
               }
            }
            return View(cars);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

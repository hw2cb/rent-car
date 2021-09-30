using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using Dapper;
namespace RentCar.Models.Data
{
    public class CarRepository : ICarRepository
    {
        string connectionString = null;
        public CarRepository(string conn)
        {
            connectionString = conn;
        }
        public List<Car> GetCars()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Car>("SELECT * FROM Автомобили").ToList();
            }
        }
    }
}

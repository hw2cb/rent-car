using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Models.Data
{
    public interface ICarRepository
    {
        List<Car> GetCars();
    }
}

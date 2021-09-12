using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Models
{
    public class Deliveries
    {
        public int Id { get; set; }
        [DisplayName("Дата начала поставки")]
        [DataType(DataType.Date)]
        public DateTime DateStart { get; set; }
        [DisplayName("Срок выполнения в днях")]
        [DataType(DataType.Text)]
        [Range(1, 10, ErrorMessage = "От 1 до 10000")]
        public int Days { get; set; }
        [DisplayName("Срок доставки")]
        [DataType(DataType.Date)]
        public DateTime DateEnd { get; set; }
    }
}

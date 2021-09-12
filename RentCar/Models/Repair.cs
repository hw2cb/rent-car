using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Models
{
    public class Repair
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [DisplayName("Дата ремонта")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [DisplayName("Срок ремонта")]
        [DataType(DataType.Text)]
        [Range(1, 10, ErrorMessage = "От 1 до 10000")]
        public int Days { get; set; }
        [DisplayName("Цена ремонта")]
        [DataType(DataType.Text)]
        [Range(typeof(decimal), "1.00", "1000000.00", ErrorMessage = "От 1 до 1.000.000")]
        public decimal Cost { get; set; }
    }
}

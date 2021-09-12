using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Models
{
    public class Issue
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [DisplayName("Время")]
        public TimeSpan Time { get; set; }
        [DisplayName("Оплата")]
        [DataType(DataType.Text)]
        [Range(typeof(decimal), "1.00", "1000000.00", ErrorMessage = "От 1 до 1.000.000")]
        public decimal Payment { get; set; }
        [DisplayName("Дата аренды")]
        [DataType(DataType.Date)]
        public DateTime DateOfRentStart { get; set; }
        [DisplayName("Срок (дни)")]
        [DataType(DataType.Text)]
        [Range(1, 1000000, ErrorMessage = "От 1 до 1.000.000")]
        public int Days { get; set; }
        [DisplayName("Дата возврата")]
        [DataType(DataType.Date)]
        public DateTime DateOfRentEnd { get; set; }
        [MaxLength(400, ErrorMessage = "Максимальная длина поля не должна привышать 400 символов")]
        [DisplayName("Особые отметки")]
        [DataType(DataType.Text)]
        public string Description { get; set; }
    }
}

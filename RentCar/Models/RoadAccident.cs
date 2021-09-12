using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Models
{
    public class RoadAccident
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [DisplayName("Дата")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [MaxLength(400, ErrorMessage = "Максимальная длина поля не должна привышать 400 символов")]
        [DisplayName("Повреждения")]
        [DataType(DataType.Text)]
        public string Damage { get; set; }
        [MaxLength(400, ErrorMessage = "Максимальная длина поля не должна привышать 400 символов")]
        [DisplayName("Особые отметки")]
        [DataType(DataType.Text)]
        public string Description { get; set; }
    }
}

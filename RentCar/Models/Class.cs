using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Models
{
    public class Class
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [MaxLength(50, ErrorMessage = "Максимальная длина поля не должна привышать 50 символов")]
        [Required(ErrorMessage = "Поле не заполнено")]
        [DataType(DataType.Text)]
        [DisplayName("Класс")]
        public string Name { get; set; }
    }
}

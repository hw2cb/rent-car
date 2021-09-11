using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Models
{
    public class DriversLic
    {
        [DisplayName("Дата выдачи")]
        [DataType(DataType.Date)]
        public DateTime DateStart { get; set; }
        [MaxLength(100, ErrorMessage = "Максимальная длина поля не должна привышать 100 символов")]
        [Required(ErrorMessage = "Поле не заполнено")]
        [DataType(DataType.Text)]
        [DisplayName("Кем выдано")]
        public string Who { get; set; }
        [DisplayName("Действительно до")]
        [DataType(DataType.Date)]
        public DateTime DateEnd { get; set; }
        [MaxLength(4, ErrorMessage = "Максимальная длина поля не должна привышать 4 символов")]
        [Required(ErrorMessage = "Поле не заполнено")]
        [DataType(DataType.Text)]
        [DisplayName("Серия")]
        public string Series { get; set; }
        [MaxLength(6, ErrorMessage = "Максимальная длина поля не должна привышать 6 символов")]
        [Required(ErrorMessage = "Поле не заполнено")]
        [DataType(DataType.Text)]
        [DisplayName("Номер")]
        public string Number { get; set; }
    }
}

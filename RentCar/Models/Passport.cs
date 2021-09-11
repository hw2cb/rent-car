using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Models
{
    public class Passport
    {
        [MaxLength(4, ErrorMessage = "Максимальная длина поля не должна привышать 4 символов")]
        [Required(ErrorMessage = "Поле не заполнено")]
        [DataType(DataType.Text)]
        [DisplayName("Серия")]
        public int Series { get; set; }
        [MaxLength(6, ErrorMessage = "Максимальная длина поля не должна привышать 6 символов")]
        [Required(ErrorMessage = "Поле не заполнено")]
        [DataType(DataType.Text)]
        [DisplayName("Номер")]
        public int Number { get; set; }
    }
}

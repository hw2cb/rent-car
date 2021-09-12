using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Models
{
    public class Provider
    {
        public int Id { get; set; }
        public string ContactPerson { get; set; }
        [MaxLength(200, ErrorMessage = "Максимальная длина поля не должна привышать 200 символов")]
        [Required(ErrorMessage = "Поле не заполнено")]
        [DataType(DataType.Text)]
        [DisplayName("Адрес")]
        public string Address { get; set; }
        [Range(12, 12, ErrorMessage = "Номер телефона должен содержать 11 символов, вначале +")]
        [DisplayName("Номер телефона")]
        [DataType(DataType.Text)]
        public string Phone { get; set; }
        [MaxLength(200, ErrorMessage = "Максимальная длина поля не должна привышать 200 символов")]
        [DisplayName("Название")]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        [MaxLength(450, ErrorMessage = "Максимальная длина поля не должна привышать 450 символов")]
        [DisplayName("Банковские реквизиты")]
        [DataType(DataType.Text)]
        public string Bank { get; set; }
    }
}

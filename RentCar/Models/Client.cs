using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace RentCar.Models
{
    public class Client
    {
        [HiddenInput(DisplayValue =false)]
        public int Id { get; set; }
        [Range(12,12, ErrorMessage ="Номер телефона должен содержать 11 символов, вначале +")]
        [DisplayName("Номер телефона")]
        [DataType(DataType.Text)]
        public string Phone { get; set; }
        [MaxLength(100, ErrorMessage ="Максимальная длина поля не должна привышать 100 символов")]
        [Required(ErrorMessage ="Поле не заполнено")]
        [DataType(DataType.Text)]
        [DisplayName("Фамилия")]
        public string Surname { get; set; }
        [MaxLength(100, ErrorMessage = "Максимальная длина поля не должна привышать 100 символов")]
        [Required(ErrorMessage = "Поле не заполнено")]
        [DataType(DataType.Text)]
        [DisplayName("Имя")]
        public string Name { get; set; }
        [MaxLength(100, ErrorMessage = "Максимальная длина поля не должна привышать 100 символов")]
        [Required(ErrorMessage = "Поле не заполнено")]
        [DataType(DataType.Text)]
        [DisplayName("Отчество")]
        public string Patronymic { get; set; }
        [Required(ErrorMessage = "Поле не заполнено")]
        [DataType(DataType.Text)]
        [DisplayName("Пол")]
        public string Sex { get; set; }
        [DisplayName("Дата рождения")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [MaxLength(200, ErrorMessage = "Максимальная длина поля не должна привышать 200 символов")]
        [Required(ErrorMessage = "Поле не заполнено")]
        [DataType(DataType.Text)]
        [DisplayName("Адрес")]
        public string Address { get; set; }
        public DriversLic DriversLic { get; set; }
        public Passport Passport { get; set; }
    }
}

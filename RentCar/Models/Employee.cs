using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [MaxLength(100, ErrorMessage = "Максимальная длина поля не должна привышать 100 символов")]
        [Required(ErrorMessage = "Поле не заполнено")]
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
        [MaxLength(50, ErrorMessage = "Максимальная длина поля не должна привышать 50 символов")]
        [Required(ErrorMessage = "Поле не заполнено")]
        [DataType(DataType.Text)]
        [DisplayName("Должность")]
        public string Position { get; set; }
        [Required(ErrorMessage = "Поле не заполнено")]
        [DataType(DataType.Text)]
        [DisplayName("Пол")]
        public string Sex { get; set; }
        [DisplayName("Дата рождения")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [DisplayName("Дата приема на работу")]
        [DataType(DataType.Date)]
        public DateTime EmploymentDate { get; set; }
        [DisplayName("Дата увольнения")]
        [DataType(DataType.Date)]
        public DateTime DateOfDismissal { get; set; }
        [DisplayName("Зарплата")]
        [DataType(DataType.Text)]
        [Range(typeof(decimal), "1.00", "1000000.00", ErrorMessage = "От 1 до 1.000.000")]
        public decimal Salary { get; set; }
        [MaxLength(200, ErrorMessage = "Максимальная длина поля не должна привышать 200 символов")]
        [Required(ErrorMessage = "Поле не заполнено")]
        [DataType(DataType.Text)]
        [DisplayName("Адрес")]
        public string Address { get; set; }
        [Range(12, 12, ErrorMessage = "Номер телефона должен содержать 11 символов, вначале +")]
        [DisplayName("Номер телефона")]
        [DataType(DataType.Text)]
        public string Phone { get; set; }
        [MaxLength(150, ErrorMessage = "Максимальная длина поля не должна привышать 150 символов")]
        [Required(ErrorMessage = "Поле не заполнено")]
        [DisplayName("Образование")]
        [DataType(DataType.Text)]
        public string Education { get; set; }

    }
}

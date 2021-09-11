using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Models
{
    public class Car
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [MaxLength(50, ErrorMessage ="Максимальная длина поля не должна привышать 50 символов")]
        [DisplayName("Марка автомобиля")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage ="Поле не заполнено")]
        public string Name { get; set; }
        [MaxLength(8, ErrorMessage = "Максимальная длина поля не должна привышать 8 символов")]
        [DisplayName("Номер автомобиля")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Поле не заполнено")]
        public string GovNumber { get; set; }
        [DisplayName("Расход бензина на 100 км")]
        [DataType(DataType.Text)]
        [Range(typeof(float), "1", "50", ErrorMessage ="От 1 до 50")]
        public float Fuel { get; set; }
        [MaxLength(50, ErrorMessage = "Максимальная длина поля не должна привышать 50 символов")]
        [DisplayName("Цвет")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Поле не заполнено")]
        public string Color { get; set; }
        [DisplayName("Цена аренды")]
        [DataType(DataType.Text)]
        [Range(typeof(decimal), "1.00", "10000.00", ErrorMessage ="От 1 до 10000")]
        public decimal Price { get; set; }
        [DisplayName("Посадочные места")]
        [DataType(DataType.Text)]
        [Range(1, 10, ErrorMessage = "От 1 до 10")]
        public int Seats { get; set; }
        [MaxLength(50, ErrorMessage = "Максимальная длина поля не должна привышать 20 символов")]
        [DisplayName("Номер двигателя")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Поле не заполнено")]
        public string EngineNumber { get; set; }
        [DisplayName("Год выпуска")]
        [DataType(DataType.Date)]
        public DateTime YearOfProduction { get; set; }
        [MaxLength(200, ErrorMessage = "Максимальная длина поля не должна привышать 200 символов")]
        [DisplayName("Место расположения автомобиля")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Поле не заполнено")]
        public string Place { get; set; }
        [DisplayName("Закупочная цена")]
        [DataType(DataType.Text)]
        [Range(typeof(decimal), "1.00", "100000000.00", ErrorMessage = "От 1 до 100.000.000")]
        public decimal Cost { get; set; } //закупочная цена
        [DisplayName("Пробег в км")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Поле не заполнено")]
        public int Mileage { get; set; }
        [MaxLength(10, ErrorMessage = "Максимальная длина поля не должна привышать 10 символов")]
        [DisplayName("Была ли в ремонте")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Поле не заполнено")]
        public string Repair { get; set; }
        [MaxLength(200, ErrorMessage = "Максимальная длина поля не должна привышать 200 символов")]
        [DisplayName("Состояние в данный момент")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Поле не заполнено")]
        public string Status { get; set; }
        [DisplayName("Арендована в данный момент")]
        public bool CarIsStock { get; set; }
    }
}

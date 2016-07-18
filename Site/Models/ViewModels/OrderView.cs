using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Models.ViewModels
{
    public class OrderView
    {
        [HiddenInput(DisplayValue = false)]
        public int ID { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int UserID { get; set; }

        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Пожалуйста, укажите имя")]
        public string Name { get; set; }

        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Пожалуйста, укажите категорию для игры")]
        public string Fam { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int TypeOrderID { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Дата заказа")]
        [Required(ErrorMessage = "Пожалуйста, введите описание для игры")]
        public string DateOrder { get; set; }
        
        [Display(Name = "Цена (руб)")]
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Пожалуйста, введите положительное значение для цены")]
        public decimal Price { get; set; }

        [Display(Name = "Состояние")]
        [Required(ErrorMessage = "Пожалуйста, укажите категорию для игры")]
        public string State { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Описание")]
        [Required(ErrorMessage = "Пожалуйста, введите описание")]
        public string Comment { get; set; }
    }
}
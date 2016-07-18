using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Site.Models.ViewModels
{
    public class ShippingView
    {
        [Required(ErrorMessage = "Укажите как вас зовут")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Вставьте адрес доставки")]
        [Display(Name = "Адрес")]
        public string Line1 { get; set; }

        [Display(Name = "Телефон")]
        [RegularExpression("(8|\\+7?-?)\\(?\\d{3}\\)?-? *\\d{3}-? *-?\\d{4}", ErrorMessage = "Некорректный номер телефона")]
        public string Line2 { get; set; }

        /*[Display(Name = "Третий адрес")]
        public string Line3 { get; set; }*/

        [Required(ErrorMessage = "Укажите город")]
        [Display(Name = "Город")]
        public string City { get; set; }

        [Required(ErrorMessage = "Укажите страну")]
        [Display(Name = "Страна")]
        public string Country { get; set; }
    }
}
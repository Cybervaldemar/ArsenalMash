using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Models
{
    public class NewsModel
    {
        [HiddenInput(DisplayValue = false)]
        public int ID { get; set; }

        [Required(ErrorMessage = "Укажите заголовок")]
        [Display(Name = "Заголовок")]
        public string TitleNew { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Укажите текст превью ")]
        [Display(Name = "Превью")]
        public string PreviewText { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Текст")]
        public string TextNew { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Дата")]
        public string DateNew { get; set; }

        [DataType(DataType.ImageUrl)]
        [Required(ErrorMessage = "Укажите изображение")]
        [Display(Name = "Изображение")]
        public string PictureNew { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Другая информация")]
        public string OtherInfo { get; set; }
    }
}
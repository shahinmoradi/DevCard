using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_Mvc.Models
{
    public class Contact
    {
        [Display(Name ="نام ")]
        [Required(ErrorMessage ="مقدار نام اجباری است ")]
        [MaxLength(100,ErrorMessage ="مقدار وارد شده نمیتواند بیشتر از 100کاراکتر باشد")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage ="مقدار وارد شده معتبر نیست")]
        [Display(Name = "ایمیل ")]
        [Required(ErrorMessage = "مقدار ایمیل اجباری است ")]
        public string Email { get; set; }


        public string Service { get; set; }
        public string Message { get; set; }
    }
}

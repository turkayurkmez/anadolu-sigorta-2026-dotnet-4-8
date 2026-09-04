using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerceSample.Models
{
    public class UserLoginModel
    {
        [Required(ErrorMessage ="kullanıcı adı boş olamaz")]
        [MinLength(3,ErrorMessage ="Kullanıcı adı en az 3 harf olmalı")]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "şifre boş olamaz")]

        public string Password { get; set; }
    }
}
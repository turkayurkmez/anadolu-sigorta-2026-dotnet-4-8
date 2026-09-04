using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerceSample.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public string Role { get; set; } = "customer";


    }
}
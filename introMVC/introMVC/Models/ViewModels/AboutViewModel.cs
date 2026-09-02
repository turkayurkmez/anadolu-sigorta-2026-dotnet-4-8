using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace introMVC.Models.ViewModels
{
    public class AboutViewModel
    {
        public string Title { get; set; }
        public DateTime ServerDate { get; set; } = DateTime.UtcNow;
    }
}
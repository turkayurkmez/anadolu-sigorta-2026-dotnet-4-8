using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerceSample.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Ürün adı boş olamaz")]
        [MaxLength(200,ErrorMessage ="Ürün adı en fazla 200 karakter olmalı!")]
        public string Name { get; set; }
        [DataType(DataType.Currency, ErrorMessage ="Hata mesajı...")]
        [Range(1,double.MaxValue,ErrorMessage ="Fiyat aralığı doğru olmalı")]
       
        public decimal? Price { get; set; }
        public int StockCount { get; set; }
        public string ImageUrl { get; set; } = "https://media.istockphoto.com/id/1980276924/tr/vekt%C3%B6r/no-photo-thumbnail-graphic-element-no-found-or-available-image-in-the-gallery-or-album-flat.jpg?s=612x612&w=0&k=20&c=9QmBeeN4wCDLMHkAfkT5VY9xCEu89uRlMz3bE6pG1aQ=";

        public int? CategoryId { get; set; }

        //Navigation Property:
        public virtual Category Category { get; set; }
    }
}
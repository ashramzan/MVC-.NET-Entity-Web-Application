using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductsApp.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("product name")]
        [StringLength(30)]
        public string ProductName { get; set; }
        [Required(ErrorMessage ="Price Required")]
        [Range(0,100000, ErrorMessage ="Price must be between 0 and 100000")]
        public decimal Price { get; set; }
        [DisplayName("description")]
        [StringLength(50)]
        public string Description { get; set; }
    }
}
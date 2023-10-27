using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Entity_Framework.Models
{
    public class ProductModel
    {
        public int ProductID { get; internal set; }
        [DisplayName("Product Name")]
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        
    }
}
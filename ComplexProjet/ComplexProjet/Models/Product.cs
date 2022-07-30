using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ComplexProjet.Models
{
    public class Product
    {
        [Key]

        public int productId { get; set; }
        [StringLength(20), Required]
        public string productName { get; set; }
        [StringLength(int.MaxValue), Required]
        public string productDetails { get; set; }
    }
}

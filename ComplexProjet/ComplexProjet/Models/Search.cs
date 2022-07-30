using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ComplexProjet.Models
{
    public class Search
    {
        [Key]
        public int searchId { get; set; }
        [StringLength(10), Required]
        public string searchByName { get; set; }
        [StringLength(10), Required]
        public string searchByItem { get; set; }
        [StringLength(10), Required]
        public string searchByPrice { get; set; }
        [Display(Name = "Product")]
        public virtual int productId { get; set; }
        [ForeignKey("productId")]
        public virtual Product product { get; set; }
    }
}

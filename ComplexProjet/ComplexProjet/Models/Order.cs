using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ComplexProjet.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int orderId { get; set; }
        [StringLength(int.MaxValue), Required]

        public string address { get; set; }

        public int pincode { get; set; }
        [Display(Name = "Product")]
        public virtual int productId { get; set; }
        [ForeignKey("productId")]
        public virtual Product product { get; set; }
    }
}

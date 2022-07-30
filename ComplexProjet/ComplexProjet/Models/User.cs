using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ComplexProjet.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int userId { get; set; }
        [StringLength(10), Required]
        public string firstName { get; set; }
        [StringLength(10), Required]
        public string lastName { get; set; }
        public long phoneNumber { get; set; }
        [StringLength(30), Required]
        public string email { get; set; }
        [StringLength(10), Required]
        public string password { get; set; }
        [Display(Name = "Product")]
        public virtual int productId { get; set; }
        [ForeignKey("productId")]
        public virtual Product product { get; set; }
    }
}

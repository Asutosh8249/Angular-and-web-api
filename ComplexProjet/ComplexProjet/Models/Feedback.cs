using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ComplexProjet.Models
{
    public class Feedback
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int feedbackId { get; set; }
        public int rating { get; set; }
        [StringLength(10), Required]
        public string feedback { get; set; }
        [Display(Name = "Product")]
        public virtual int productId { get; set; }
        [ForeignKey("productId")]
        
        public virtual Product product { get; set; }
    }
}

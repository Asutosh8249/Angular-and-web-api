using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ComplexProjet.Models
{
    public class Login
    {

        [Key]
        public int loginId { get; set; }
        [StringLength(30)]
        public string emailId { get; set; }
        [StringLength(10)]
        public string password { get; set; }
        [Display(Name = "User")]
        public virtual int userId { get; set; }
        [ForeignKey("userId")]
        public virtual User user{get;set;}
      
    }
}

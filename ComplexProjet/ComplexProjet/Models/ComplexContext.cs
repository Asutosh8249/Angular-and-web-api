using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComplexProjet.Models
{
    public class ComplexContext: DbContext
    {

            public ComplexContext(DbContextOptions<ComplexContext> options) : base(options)
            {

            }
            public DbSet<Product> products { get; set; }
            public DbSet<Order> orders { get; set; }
            public DbSet<User> users { get; set; }
            public DbSet<Search> search { get; set; }
            public DbSet<Feedback> feedbacks { get; set; }
            public DbSet<Login> log { get; set; }
        }
}

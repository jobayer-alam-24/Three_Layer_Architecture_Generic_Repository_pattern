using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AToZDataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace AToZBusinessLogicLayer.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Customer> Customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-MJB7RA8;Database=ThreeLayerDb;Trusted_Connection=true;Encrypt=false;MultipleActiveResultSets=true");
        }
    }
}

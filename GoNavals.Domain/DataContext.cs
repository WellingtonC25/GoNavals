using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoNavals.Domain
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }
        public DataContext(DbContextOptions<DataContext> options ) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-VL26VQS;Database=GoNavals;Trusted_Connection=true;TrustServerCertificate=true");
        }

        public DbSet<Ciudad> Ciudad { get; set; }
        public DbSet<Color> Color { get; set; }
        public DbSet<Comandancia> Comandancia { get; set; }

    }
}

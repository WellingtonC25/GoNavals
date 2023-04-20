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
        public DbSet<Comandante> Comandante { get; set; }
        public DbSet<ComandanteComandancia> ComandanteComandancia { get; set; }
        public DbSet<Constructora> Constructora { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Embarcacion> Embarcacion { get; set; }
        public DbSet<Ocupacion> Ocupacion { get; set; }
        public DbSet<Pais> Pais { get; set; }
        public DbSet<Propietario> Propietario { get; set; }
        public DbSet<Puerto> Puerto { get; set; }
        public DbSet<Rango> Rango { get; set; }
        public DbSet<TipoUso> TipoUso { get; set; }
        public DbSet<Zona> Zona { get; set; }

    }
}

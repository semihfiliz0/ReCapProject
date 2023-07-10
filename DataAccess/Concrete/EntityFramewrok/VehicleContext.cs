using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class VehicleContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-CM9EINI\mssqlserver01;Database=Vehicle;Trusted_Connection=true;TrustServerCertificate=True ");

        }

        //Hangi class'ım hangi tabloya denk gelicek

        public DbSet<Car> Cars { get; set; }

        public DbSet<Brand> brands { get; set; }

        public DbSet<Color> Colors { get; set; }
    }
}

using Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //local
            optionsBuilder.UseSqlServer("Server=DESKTOP-N6K9MD1;Database=dapperGeneric;Trusted_Connection=true;TrustServerCertificate=True");
        }

        public DbSet<Products> Products { get; set; }
    }
}

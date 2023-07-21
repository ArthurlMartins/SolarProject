using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace SolarProject.Models
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {                   
            optionsBuilder.UseMySql("Server=localhost;DataBase=Solar;Uid=root;");
        }

        public DbSet<Interesse> Interesses { get; set; }

    }
}

namespace Lab_Demo.Data
{
    using Lab_Demo.Models;
    using Microsoft.EntityFrameworkCore;

    public class MinionsDbContext : DbContext
    {
        private const string ConnectionString = @"Server=localhost\SQLEXPRESS01;Database=Despicable;Trusted_Connection=True;Encrypt=false";
        public virtual DbSet<Minion> Minions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}

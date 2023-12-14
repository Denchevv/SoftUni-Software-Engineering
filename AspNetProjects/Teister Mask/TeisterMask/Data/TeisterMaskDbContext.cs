
namespace TeisterMask.Data
{
    using Microsoft.EntityFrameworkCore;
    using TeisterMask.Models;

    public class TeisterMaskDbContext : DbContext
    {
        public virtual DbSet<Task> Tasks { get; set; }

        private const string ConnectionString = @"Server=localhost\SQLEXPRESS01;Database=MeisterTask;Trusted_Connection=True;Encrypt=false;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}

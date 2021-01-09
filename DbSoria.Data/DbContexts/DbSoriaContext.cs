using Microsoft.EntityFrameworkCore;

namespace DbSoria.Data.DbContexts
{
    public class DbSoriaContext : DbContext
    {
        public DbSoriaContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSoriaContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=DbSoriaData;Trusted_Connection=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
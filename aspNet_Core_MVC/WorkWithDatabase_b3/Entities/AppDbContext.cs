using Microsoft.EntityFrameworkCore;

namespace WorkWithDatabase_b3.Entities
{
    public class AppDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=ACERASPIRE-KHAI\\SQLEXPRESS;Database=ProductManager;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<ProductEntity> ProductEntities { get; set; }
        public DbSet<CategoryEntity> CategoryEntities { get; set; }
    } 
}

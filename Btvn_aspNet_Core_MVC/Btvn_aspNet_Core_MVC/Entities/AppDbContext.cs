using Microsoft.EntityFrameworkCore;

namespace Btvn_aspNet_Core_MVC.Entities
{
    public class AppDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=ACERASPIRE-KHAI\\SQLEXPRESS;Database=StudentManagement_dev;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<StudentEntity> StudentEntities { get; set; }   
        public DbSet<ResultEntity> ResultEntities{ get; set; }
        public DbSet<SubjectEntity> SubjectEntities{ get; set; }
    }
}

using Microsoft.EntityFrameworkCore;

namespace DataBase
{
    public class TeachersContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=./TeachersDataBase.db");
        }
    }
}

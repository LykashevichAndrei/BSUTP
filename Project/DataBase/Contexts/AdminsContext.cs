using Microsoft.EntityFrameworkCore;

namespace DataBase
{
    public class AdminsContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=./AdminsDataBase.db");
        }
    }
}
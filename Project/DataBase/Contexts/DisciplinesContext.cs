using Microsoft.EntityFrameworkCore;

namespace DataBase
{
    public class DisciplinesContext : DbContext
    {
        public DbSet<Discipline> Disciplines { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=./DisciplinesDataBase.db");
        }
    }
}

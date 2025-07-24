using Microsoft.EntityFrameworkCore;

namespace PharmaDataBase
{
    public class DrugDbContext : DbContext
    {
        string _connectionString = "";
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<DrugResponse> DrugResponses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}

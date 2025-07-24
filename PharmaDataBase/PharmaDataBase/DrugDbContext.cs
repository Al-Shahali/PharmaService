using Microsoft.EntityFrameworkCore;

namespace PharmaDataBase
{
    public class DrugDbContext : DbContext
    {
        string _connectionString = "Server=db24045.public.databaseasp.net; Database=db24045; User Id=db24045; Password=D@a6qE9_L+c7; Encrypt=True; TrustServerCertificate=True;";
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<DrugResponse> DrugResponses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}

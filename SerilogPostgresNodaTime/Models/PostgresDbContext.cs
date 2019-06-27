using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SerilogPostgresNodaTime.Models
{
    public class PostgresDbContext : DbContext
    {
        public PostgresDbContext(DbContextOptions<PostgresDbContext> options) : base(options) { }

        public DbSet<Table1> Table1 { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Model.GetEntityTypes().Select(e => e.Relational()).ToList().ForEach(t => t.TableName = t.TableName.ToLower());
            modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetProperties()).ToList().ForEach(p => p.Relational().ColumnName = p.Name.ToLower());

            base.OnModelCreating(modelBuilder);
        }
    }
}
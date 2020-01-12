using Microsoft.EntityFrameworkCore;

namespace GoVote.Data
{
    public class PartyDatabaseContext : DbContext
    {
        public PartyDatabaseContext(DbContextOptions<PartyDatabaseContext> options) : base(options)
        {

        }

        public DbSet<Party> Parties { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Party>(e =>
            {
                e.Property(t => t.PartyName).IsRequired();
            });

            // Seed Method
            modelBuilder.Entity<Party>().HasData(
                Party.Create("Partidul Național Liberal"),
                Party.Create("Partidul Social Democrat"),
                Party.Create("Uniunea Salvați România"),
                Party.Create("Alianța Liberalilor și Democraților"),
                Party.Create("Partidul România Unită"),
                Party.Create("Partidul Noua Revoluție"),
                Party.Create("Alianța Noastră România"),
                Party.Create("Partidul România Mare"),
                Party.Create("Pro România"),
                Party.Create("Uniunea Democrată Maghiară din România"));
        }
    }
}

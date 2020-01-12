using Microsoft.EntityFrameworkCore;
using System;

namespace GoVote.Data
{
    public class CandidateDatabaseContext : DbContext
    {
        public CandidateDatabaseContext(DbContextOptions<CandidateDatabaseContext> options) : base(options)
        {

        }

        public DbSet<Candidate> Candidates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candidate>(e =>
            {
                e.Property(t => t.LastName).IsRequired();
                e.Property(t => t.FirstName).IsRequired();
                e.Property(t => t.PartyID).IsRequired();
                e.Property(t => t.VotingTypeId).IsRequired();
            });

            //Seed Method
            modelBuilder.Entity<Candidate>().HasData(
                Candidate.Create("Iohannis", "Klaus", new Guid("EB14B17C-23EE-42D6-8B8F-8C1569C71900"), new Guid("8254D087-4AD7-4069-816F-5ED97D119716")),
                Candidate.Create("Barna", "Dan", new Guid("37545B86-03BE-41C0-B99C-64642B028073"), new Guid("8254D087-4AD7-4069-816F-5ED97D119716")),
                Candidate.Create("Dancila", "Viorica", new Guid("87956373-A20E-4C9A-B6DB-E62ED99308EB"), new Guid("8254D087-4AD7-4069-816F-5ED97D119716")),
                Candidate.Create("Diaconu", "Mircea", new Guid("A6D6C337-D870-4FD7-829D-C5BB240C68B5"), new Guid("8254D087-4AD7-4069-816F-5ED97D119716")),
                Candidate.Create("Paleologul", "Theodor", new Guid("E5A072D9-06F5-4FAB-88C9-7A1F6C8CB062"), new Guid("8254D087-4AD7-4069-816F-5ED97D119716")),
                Candidate.Create("Hunor", "Kelemen", new Guid("A7DD53E5-0ED5-443D-A8F6-C3CEDAB4FEB0"), new Guid("8254D087-4AD7-4069-816F-5ED97D119716")),
                Candidate.Create("Ioana", "Ramona", new Guid("EB14B17C-23EE-42D6-8B8F-8C1569C71900"), new Guid("AE040CC6-C820-4F54-8173-0510907C04EE")),
                Candidate.Create("Ivan", "Catalin", new Guid("CDF668B2-911D-49F6-998D-E212F1B054F8"), new Guid("AE040CC6-C820-4F54-8173-0510907C04EE")),
                Candidate.Create("Cumpanasu", "Alexandru", new Guid("B0D619D7-F409-4FDC-9E7C-E8FC780E2E31"), new Guid("AE040CC6-C820-4F54-8173-0510907C04EE")),
                Candidate.Create("Catarama", "Viorel", new Guid("10B098A5-CBBF-4D7A-9E9C-4B50639E5CA4"), new Guid("AE040CC6-C820-4F54-8173-0510907C04EE"))
            );
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace GoVote.Data
{
    public class CitizenDatabaseContext : DbContext
    {
        public CitizenDatabaseContext(DbContextOptions<CitizenDatabaseContext> options) : base(options)
        {

        }

        public DbSet<Citizen> Citizens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Citizen>(e =>
            {
                e.Property(t => t.CNP).IsRequired();
                e.Property(t => t.LastName).IsRequired();
                e.Property(t => t.FirstName).IsRequired();
                e.Property(t => t.Sex).IsRequired();
                e.Property(t => t.Address).IsRequired();
                e.Property(t => t.County).IsRequired();
                e.Property(t => t.City).IsRequired();
                e.Property(t => t.VotedFor);
            });

            // Seed Method
            modelBuilder.Entity<Citizen>().HasData(
               Citizen.Create("6000611068050", "Rindasu", "Andreea", "Female", "Prelungirea Salciei nr 11", "Bacau", "Bacau"),
               Citizen.Create("2940306114529", "Arsene", "Andreea", "Female", "Trandafirilor nr 19", "Iasi", "Iasi"),
               Citizen.Create("1880904084673", "Lipan", "Matei", "Male", "Mihai Eminesu nr 1", "Roman", "Roman"),
               Citizen.Create("2861123273951", "Tiganescu", "Ana", "Female", "Republicii nr 14", "Suceava", "Suceava"),
               Citizen.Create("2850429512165", "Ciuraru", "Bianca", "Female", "Tudor Vladimirescu nr 12", "Vaslui", "Vaslui"),
               Citizen.Create("6000428269851", "Andries", "Stefania", "Female", "Mihai Balcesu nr 3", "Neamt", "Neamt"),
               Citizen.Create("2960325371467", "Cercel", "Irina", "Female", "Trandafirilor nr 2", "Roman", "Roman"),
               Citizen.Create("1901109433987", "Rezmerita", "Mihnea", "Male", "Primaverii nr 3", "Roman", "Roman"),
               Citizen.Create("2920729465763", "Turcu", "Ana-Maria", "Female", "Libertatii nr 3", "Neamt", "Neamt"),
               Citizen.Create("1910311156287", "Vararu", "Cristian", "Male", "Libertatii nr 3", "Neamt", "Neamt"),
               Citizen.Create("2981127050438", "Vatamanelu", "Andreea", "Female", "Garii nr 134", "Roman", "Roman"),
               Citizen.Create("5000421196666", "Cioata", "Matei", "Male", "Florilor nr 21", "Harghita", "Harghita"),
               Citizen.Create("2960309425462", "Nechita", "Ramona", "Female", "1 Mai nr 45", "Suceava", "Suceava"),
               Citizen.Create("6000811408722", "Bejan", "Irina", "Female", "Unirii nr 654", "Iasi", "Iasi"),
               Citizen.Create("2941219407433", "Hlusneac", "Maria", "Female", "Liliacului nr 44", "Cluj", "Cluj"),
               Citizen.Create("1880328521060", "Listar", "Constantin", "Male", "George Cosbuc nr 233", "Botosani", "Botosani"),
               Citizen.Create("2960807266344", "Spinu", "Simona", "Female", "Zorilor nr 77", "Cluj", "Cluj"),
               Citizen.Create("1910604085307", "Dragomir", "Cristian", "Male", "Viilor nr 455", "Bacau", "Bacau"),
               Citizen.Create("2880406141584", "Turcu", "Ramona", "Female", "Vasile Alecsandri nr 23", "Bucuresti", "Bucuresti"),
               Citizen.Create("2890724113425", "Aruxandei", "Dumitrina", "Female", "Pacii nr 45", "Iasi", "Iasi"),
               Citizen.Create("6020719379362", "Atomei", "Denisa", "Female", "Tineretului nr 2", "Bucuresti", "Bucuresti"),
               Citizen.Create("1850821461879", "Popescu", "Daniel", "Male", "Plopilor nr 3", "Cluj", "Cluj"),
               Citizen.Create("2860814180133", "Andriescu", "Amalia", "Female", "Pacii nr 46", "Oradea", "Oradea"),
               Citizen.Create("1931127108323", "Stefanoaia", "Nicu", "Male", "Aurel Vlaicu nr 345", "Brasov", "Brasov"),
               Citizen.Create("2990119284775", "Gusa", "Ana", "Female", "Crinului nr 66", "Botosani", "Botosani"),
               Citizen.Create("1890901434640", "Ionescu", "Adrian", "Male", "Oituz nr 28", "Vaslui", "Vaslui"),
               Citizen.Create("1860217392218", "Ursaciuc", "Ion", "Male", "Plopilor nr 754", "Brasov", "Brasov"),
               Citizen.Create("1870531383849", "Vulpe", "Alex", "Male", "Tatarasi nr 898", "Iasi", "Iasi"),
               Citizen.Create("6020721248923", "Ciobanu", "Alina", "Female", "Nicu Gane nr 4", "Suceava", "Suceava"),
               Citizen.Create("1920212194589", "Ciulei", "Lucian", "Male", "George Balcescu nr 7", "Bacau", "Bacau")
               );
                
        }

    }
}

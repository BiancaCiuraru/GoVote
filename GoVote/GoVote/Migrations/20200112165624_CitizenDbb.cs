using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GoVote.Migrations
{
    public partial class CitizenDbb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Citizens",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    CNP = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    Sex = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    County = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    VotedFor = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citizens", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Citizens",
                columns: new[] { "ID", "Address", "CNP", "City", "County", "FirstName", "LastName", "Sex", "VotedFor" },
                values: new object[,]
                {
                    { new Guid("8a114780-173b-4ca9-915a-bd26bad53fa0"), "Prelungirea Salciei nr 11", "6000611068050", "Bacau", "Bacau", "Andreea", "Rindasu", "Female", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("801ae241-3f27-4d1c-a99b-33c7c9984f1f"), "Tatarasi nr 898", "1870531383849", "Iasi", "Iasi", "Alex", "Vulpe", "Male", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("fb574366-bf4b-419a-a1b5-9831d6375fcb"), "Plopilor nr 754", "1860217392218", "Brasov", "Brasov", "Ion", "Ursaciuc", "Male", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("31f1ca3d-9b98-47f6-824a-b0d9a29f73d7"), "Oituz nr 28", "1890901434640", "Vaslui", "Vaslui", "Adrian", "Ionescu", "Male", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8dc919d2-5538-46ad-a1bd-b3783180ebab"), "Crinului nr 66", "2990119284775", "Botosani", "Botosani", "Ana", "Gusa", "Female", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("229a3cc0-3723-429c-b4b8-068ae8d7902a"), "Aurel Vlaicu nr 345", "1931127108323", "Brasov", "Brasov", "Nicu", "Stefanoaia", "Male", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a01b5096-b60a-4ae5-9bb9-24e13cd3a396"), "Pacii nr 46", "2860814180133", "Oradea", "Oradea", "Amalia", "Andriescu", "Female", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("529c30bf-029f-40b8-ae87-42003c9ee081"), "Plopilor nr 3", "1850821461879", "Cluj", "Cluj", "Daniel", "Popescu", "Male", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("bf8450ae-bc9c-4f05-83b1-494e68b58c26"), "Tineretului nr 2", "6020719379362", "Bucuresti", "Bucuresti", "Denisa", "Atomei", "Female", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("39a92bac-5413-455a-82db-4aba628bb238"), "Pacii nr 45", "2890724113425", "Iasi", "Iasi", "Dumitrina", "Aruxandei", "Female", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("37108fc2-60a0-4b24-886c-d40bc365757b"), "Vasile Alecsandri nr 23", "2880406141584", "Bucuresti", "Bucuresti", "Ramona", "Turcu", "Female", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("791daf04-0a6d-4174-9169-3f8a72a6895d"), "Viilor nr 455", "1910604085307", "Bacau", "Bacau", "Cristian", "Dragomir", "Male", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("50bae3ad-8255-4592-aa79-e2ca19da0b2f"), "Zorilor nr 77", "2960807266344", "Cluj", "Cluj", "Simona", "Spinu", "Female", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("bd119af8-21e6-4ceb-bb7d-40fb787d3e63"), "George Cosbuc nr 233", "1880328521060", "Botosani", "Botosani", "Constantin", "Listar", "Male", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("04caa65c-3f6b-4b0b-b7e1-a4afb85359a9"), "Liliacului nr 44", "2941219407433", "Cluj", "Cluj", "Maria", "Hlusneac", "Female", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f1b9bfb0-9458-4e48-87b2-a85e1dd94e6f"), "Unirii nr 654", "6000811408722", "Iasi", "Iasi", "Irina", "Bejan", "Female", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7de21f2d-f92b-427e-9134-76d794c0ad6f"), "1 Mai nr 45", "2960309425462", "Suceava", "Suceava", "Ramona", "Nechita", "Female", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2f97490c-498f-4643-85e9-28b83ce459da"), "Florilor nr 21", "5000421196666", "Harghita", "Harghita", "Matei", "Cioata", "Male", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("bf0f0dee-6628-400f-8d86-07a79d87c717"), "Garii nr 134", "2981127050438", "Roman", "Roman", "Andreea", "Vatamanelu", "Female", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c47a3c32-bd72-42d2-b97a-f51e4267603f"), "Libertatii nr 3", "1910311156287", "Neamt", "Neamt", "Cristian", "Vararu", "Male", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("cf558522-425d-4185-9084-ecdd21382fde"), "Libertatii nr 3", "2920729465763", "Neamt", "Neamt", "Ana-Maria", "Turcu", "Female", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b6cdbb7d-0b9f-4a2c-ba99-9a2aef2b76b0"), "Primaverii nr 3", "1901109433987", "Roman", "Roman", "Mihnea", "Rezmerita", "Male", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("afc01f73-569a-4db2-9472-b510102b77d8"), "Trandafirilor nr 2", "2960325371467", "Roman", "Roman", "Irina", "Cercel", "Female", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("04d6341e-8a3a-4273-afd2-8de18e65c14e"), "Mihai Balcesu nr 3", "6000428269851", "Neamt", "Neamt", "Stefania", "Andries", "Female", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("3c527fd5-1efd-4ff6-8c62-57c5aff428bd"), "Tudor Vladimirescu nr 12", "2850429512165", "Vaslui", "Vaslui", "Bianca", "Ciuraru", "Female", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("86779329-1dbe-4eb5-8d9d-82e647fbfb6a"), "Republicii nr 14", "2861123273951", "Suceava", "Suceava", "Ana", "Tiganescu", "Female", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("038bc0be-604f-43d2-961c-69908d926bfa"), "Mihai Eminesu nr 1", "1880904084673", "Roman", "Roman", "Matei", "Lipan", "Male", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f819dce8-54c6-42c8-a2aa-ca0876b1fe6e"), "Trandafirilor nr 19", "2940306114529", "Iasi", "Iasi", "Andreea", "Arsene", "Female", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2ed7bf41-226c-40ed-941c-067184a6ed27"), "Nicu Gane nr 4", "6020721248923", "Suceava", "Suceava", "Alina", "Ciobanu", "Female", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b4cd4a0e-e171-4fef-99a7-352bae76331b"), "George Balcescu nr 7", "1920212194589", "Bacau", "Bacau", "Lucian", "Ciulei", "Male", new Guid("00000000-0000-0000-0000-000000000000") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Citizens");
        }
    }
}

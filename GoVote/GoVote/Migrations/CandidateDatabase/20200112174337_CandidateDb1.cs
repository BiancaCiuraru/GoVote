using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GoVote.Migrations.CandidateDatabase
{
    public partial class CandidateDb1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Candidates",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    PartyID = table.Column<Guid>(nullable: false),
                    VotingTypeId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidates", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "ID", "FirstName", "LastName", "PartyID", "VotingTypeId" },
                values: new object[,]
                {
                    { new Guid("a756d18e-ce73-49bf-bfde-f7cb7c118ab8"), "Klaus", "Iohannis", new Guid("eb14b17c-23ee-42d6-8b8f-8c1569c71900"), new Guid("8254d087-4ad7-4069-816f-5ed97d119716") },
                    { new Guid("fc8fdef0-2f59-42d2-8427-6e0f8e1824ca"), "Dan", "Barna", new Guid("37545b86-03be-41c0-b99c-64642b028073"), new Guid("8254d087-4ad7-4069-816f-5ed97d119716") },
                    { new Guid("194ce01d-c4d5-4874-b10c-b70180e86a51"), "Viorica", "Dancila", new Guid("87956373-a20e-4c9a-b6db-e62ed99308eb"), new Guid("8254d087-4ad7-4069-816f-5ed97d119716") },
                    { new Guid("0c83870a-b849-44b7-87a8-ffba02643bc2"), "Mircea", "Diaconu", new Guid("a6d6c337-d870-4fd7-829d-c5bb240c68b5"), new Guid("8254d087-4ad7-4069-816f-5ed97d119716") },
                    { new Guid("c8d81a12-ed50-4144-b0c8-222f2bf26fa5"), "Theodor", "Paleologul", new Guid("e5a072d9-06f5-4fab-88c9-7a1f6c8cb062"), new Guid("8254d087-4ad7-4069-816f-5ed97d119716") },
                    { new Guid("4574f5f7-2ad4-4a36-ac7d-88b29f09b6db"), "Kelemen", "Hunor", new Guid("a7dd53e5-0ed5-443d-a8f6-c3cedab4feb0"), new Guid("8254d087-4ad7-4069-816f-5ed97d119716") },
                    { new Guid("7c6b51db-10ea-4d90-a3cf-57a8638f8c94"), "Ramona", "Ioana", new Guid("eb14b17c-23ee-42d6-8b8f-8c1569c71900"), new Guid("ae040cc6-c820-4f54-8173-0510907c04ee") },
                    { new Guid("98345799-73c4-4514-96b6-cd76e8b6cbc6"), "Catalin", "Ivan", new Guid("cdf668b2-911d-49f6-998d-e212f1b054f8"), new Guid("ae040cc6-c820-4f54-8173-0510907c04ee") },
                    { new Guid("9a98bede-04d3-4a50-80e2-6fb6c6c3bcc1"), "Alexandru", "Cumpanasu", new Guid("b0d619d7-f409-4fdc-9e7c-e8fc780e2e31"), new Guid("ae040cc6-c820-4f54-8173-0510907c04ee") },
                    { new Guid("4cd5e71a-957f-4a69-9a7a-17205bbb037f"), "Viorel", "Catarama", new Guid("10b098a5-cbbf-4d7a-9e9c-4b50639e5ca4"), new Guid("ae040cc6-c820-4f54-8173-0510907c04ee") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Candidates");
        }
    }
}

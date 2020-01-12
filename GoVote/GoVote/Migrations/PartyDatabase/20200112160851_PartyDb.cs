using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GoVote.Migrations.PartyDatabase
{
    public partial class PartyDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parties",
                columns: table => new
                {
                    PartyID = table.Column<Guid>(nullable: false),
                    PartyName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parties", x => x.PartyID);
                });

            migrationBuilder.InsertData(
                table: "Parties",
                columns: new[] { "PartyID", "PartyName" },
                values: new object[,]
                {
                    { new Guid("eb14b17c-23ee-42d6-8b8f-8c1569c71900"), "Partidul Național Liberal" },
                    { new Guid("87956373-a20e-4c9a-b6db-e62ed99308eb"), "Partidul Social Democrat" },
                    { new Guid("a7dd53e5-0ed5-443d-a8f6-c3cedab4feb0"), "Uniunea Salvați România" },
                    { new Guid("b0d619d7-f409-4fdc-9e7c-e8fc780e2e31"), "Alianța Liberalilor și Democraților" },
                    { new Guid("e5a072d9-06f5-4fab-88c9-7a1f6c8cb062"), "Partidul România Unită" },
                    { new Guid("cdf668b2-911d-49f6-998d-e212f1b054f8"), "Partidul Noua Revoluție" },
                    { new Guid("10b098a5-cbbf-4d7a-9e9c-4b50639e5ca4"), "Alianța Noastră România" },
                    { new Guid("8157a0b7-2b67-41b8-a764-4b80a628b696"), "Partidul România Mare" },
                    { new Guid("a6d6c337-d870-4fd7-829d-c5bb240c68b5"), "Pro România" },
                    { new Guid("37545b86-03be-41c0-b99c-64642b028073"), "Uniunea Democrată Maghiară din România" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parties");
        }
    }
}

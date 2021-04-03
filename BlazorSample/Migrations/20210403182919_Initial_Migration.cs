using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorSample.Migrations
{
    public partial class Initial_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseYear = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Name", "ReleaseYear" },
                values: new object[] { new Guid("2ffd74af-0a34-448e-a211-d6398a6b03c8"), "Wild Dog", 2021 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Name", "ReleaseYear" },
                values: new object[] { new Guid("e560574d-f130-4ddb-a852-4567bc8d7365"), "Vakeel Saab", 2021 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}

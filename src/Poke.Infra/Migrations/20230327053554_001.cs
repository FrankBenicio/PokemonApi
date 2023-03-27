using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Poke.Infra.Migrations
{
    /// <inheritdoc />
    public partial class _001 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PokemonMaster",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "varchar(1000)", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    Cpf = table.Column<string>(type: "varchar(1000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonMaster", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PokemonCaught",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Pokemon = table.Column<string>(type: "varchar(1000)", nullable: false),
                    PokemonMasterId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonCaught", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonCaught_PokemonMaster_PokemonMasterId",
                        column: x => x.PokemonMasterId,
                        principalTable: "PokemonMaster",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PokemonCaught_PokemonMasterId",
                table: "PokemonCaught",
                column: "PokemonMasterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PokemonCaught");

            migrationBuilder.DropTable(
                name: "PokemonMaster");
        }
    }
}

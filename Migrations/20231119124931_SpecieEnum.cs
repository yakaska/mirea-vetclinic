using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace mirea_vetclinic.Migrations
{
    /// <inheritdoc />
    public partial class SpecieEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_pets_species_specie_id",
                table: "pets");

            migrationBuilder.DropTable(
                name: "species");

            migrationBuilder.DropIndex(
                name: "ix_pets_specie_id",
                table: "pets");

            migrationBuilder.RenameColumn(
                name: "specie_id",
                table: "pets",
                newName: "specie");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "specie",
                table: "pets",
                newName: "specie_id");

            migrationBuilder.CreateTable(
                name: "species",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    specie_name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_species", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "ix_pets_specie_id",
                table: "pets",
                column: "specie_id");

            migrationBuilder.AddForeignKey(
                name: "fk_pets_species_specie_id",
                table: "pets",
                column: "specie_id",
                principalTable: "species",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

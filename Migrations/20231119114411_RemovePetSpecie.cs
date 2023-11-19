using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mirea_vetclinic.Migrations
{
    /// <inheritdoc />
    public partial class RemovePetSpecie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pet_specie");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pet_specie",
                columns: table => new
                {
                    pet_id = table.Column<int>(type: "integer", nullable: false),
                    specie_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pet_specie", x => new { x.pet_id, x.specie_id });
                    table.ForeignKey(
                        name: "fk_pet_specie_pets_pet_id",
                        column: x => x.pet_id,
                        principalTable: "pets",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_pet_specie_species_specie_id",
                        column: x => x.specie_id,
                        principalTable: "species",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_pet_specie_specie_id",
                table: "pet_specie",
                column: "specie_id");
        }
    }
}

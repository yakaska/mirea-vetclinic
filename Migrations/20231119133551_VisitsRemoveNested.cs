using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mirea_vetclinic.Migrations
{
    /// <inheritdoc />
    public partial class VisitsRemoveNested : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_visits_hostesses_hostess_id",
                table: "visits");

            migrationBuilder.DropForeignKey(
                name: "fk_visits_pets_pet_id",
                table: "visits");

            migrationBuilder.DropForeignKey(
                name: "fk_visits_vets_vet_id",
                table: "visits");

            migrationBuilder.AlterColumn<int>(
                name: "vet_id",
                table: "visits",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "pet_id",
                table: "visits",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "hostess_id",
                table: "visits",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "fk_visits_hostesses_hostess_id",
                table: "visits",
                column: "hostess_id",
                principalTable: "hostesses",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_visits_pets_pet_id",
                table: "visits",
                column: "pet_id",
                principalTable: "pets",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_visits_vets_vet_id",
                table: "visits",
                column: "vet_id",
                principalTable: "vets",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_visits_hostesses_hostess_id",
                table: "visits");

            migrationBuilder.DropForeignKey(
                name: "fk_visits_pets_pet_id",
                table: "visits");

            migrationBuilder.DropForeignKey(
                name: "fk_visits_vets_vet_id",
                table: "visits");

            migrationBuilder.AlterColumn<int>(
                name: "vet_id",
                table: "visits",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "pet_id",
                table: "visits",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "hostess_id",
                table: "visits",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "fk_visits_hostesses_hostess_id",
                table: "visits",
                column: "hostess_id",
                principalTable: "hostesses",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_visits_pets_pet_id",
                table: "visits",
                column: "pet_id",
                principalTable: "pets",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_visits_vets_vet_id",
                table: "visits",
                column: "vet_id",
                principalTable: "vets",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

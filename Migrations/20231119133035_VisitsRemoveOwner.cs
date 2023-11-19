using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mirea_vetclinic.Migrations
{
    /// <inheritdoc />
    public partial class VisitsRemoveOwner : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_visits_owners_owner_id",
                table: "visits");

            migrationBuilder.DropIndex(
                name: "ix_visits_owner_id",
                table: "visits");

            migrationBuilder.DropColumn(
                name: "owner_id",
                table: "visits");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "owner_id",
                table: "visits",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "ix_visits_owner_id",
                table: "visits",
                column: "owner_id");

            migrationBuilder.AddForeignKey(
                name: "fk_visits_owners_owner_id",
                table: "visits",
                column: "owner_id",
                principalTable: "owners",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

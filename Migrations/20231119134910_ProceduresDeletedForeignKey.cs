using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mirea_vetclinic.Migrations
{
    /// <inheritdoc />
    public partial class ProceduresDeletedForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "visit_id",
                table: "procedures",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "ix_procedures_visit_id",
                table: "procedures",
                column: "visit_id");

            migrationBuilder.AddForeignKey(
                name: "fk_procedures_visits_visit_id",
                table: "procedures",
                column: "visit_id",
                principalTable: "visits",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_procedures_visits_visit_id",
                table: "procedures");

            migrationBuilder.DropIndex(
                name: "ix_procedures_visit_id",
                table: "procedures");

            migrationBuilder.DropColumn(
                name: "visit_id",
                table: "procedures");
        }
    }
}

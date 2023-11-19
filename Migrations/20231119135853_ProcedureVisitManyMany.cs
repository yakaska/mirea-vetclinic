using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mirea_vetclinic.Migrations
{
    /// <inheritdoc />
    public partial class ProcedureVisitManyMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "procedure_visit",
                columns: table => new
                {
                    procedures_id = table.Column<int>(type: "integer", nullable: false),
                    visits_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_procedure_visit", x => new { x.procedures_id, x.visits_id });
                    table.ForeignKey(
                        name: "fk_procedure_visit_procedures_procedures_id",
                        column: x => x.procedures_id,
                        principalTable: "procedures",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_procedure_visit_visits_visits_id",
                        column: x => x.visits_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_procedure_visit_visits_id",
                table: "procedure_visit",
                column: "visits_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "procedure_visit");

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
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mirea_vetclinic.Migrations
{
    /// <inheritdoc />
    public partial class ProcedureVisitOneMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "vet_specialties");

            migrationBuilder.DropTable(
                name: "visit_procedures");

            migrationBuilder.CreateTable(
                name: "specialty_vet",
                columns: table => new
                {
                    specialties_id = table.Column<int>(type: "integer", nullable: false),
                    vets_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_specialty_vet", x => new { x.specialties_id, x.vets_id });
                    table.ForeignKey(
                        name: "fk_specialty_vet_specialties_specialties_id",
                        column: x => x.specialties_id,
                        principalTable: "specialties",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_specialty_vet_vets_vets_id",
                        column: x => x.vets_id,
                        principalTable: "vets",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_specialty_vet_vets_id",
                table: "specialty_vet",
                column: "vets_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "specialty_vet");

            migrationBuilder.CreateTable(
                name: "vet_specialties",
                columns: table => new
                {
                    vet_id = table.Column<int>(type: "integer", nullable: false),
                    specialty_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_vet_specialties", x => new { x.vet_id, x.specialty_id });
                    table.ForeignKey(
                        name: "fk_vet_specialties_specialties_specialty_id",
                        column: x => x.specialty_id,
                        principalTable: "specialties",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_vet_specialties_vets_vet_id",
                        column: x => x.vet_id,
                        principalTable: "vets",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "visit_procedures",
                columns: table => new
                {
                    visit_id = table.Column<int>(type: "integer", nullable: false),
                    procedure_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_visit_procedures", x => new { x.visit_id, x.procedure_id });
                    table.ForeignKey(
                        name: "fk_visit_procedures_procedures_procedure_id",
                        column: x => x.procedure_id,
                        principalTable: "procedures",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_visit_procedures_visits_visit_id",
                        column: x => x.visit_id,
                        principalTable: "visits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_vet_specialties_specialty_id",
                table: "vet_specialties",
                column: "specialty_id");

            migrationBuilder.CreateIndex(
                name: "ix_visit_procedures_procedure_id",
                table: "visit_procedures",
                column: "procedure_id");
        }
    }
}

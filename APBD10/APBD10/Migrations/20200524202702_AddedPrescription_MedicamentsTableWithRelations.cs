using Microsoft.EntityFrameworkCore.Migrations;

namespace APBD10.Migrations
{
    public partial class AddedPrescription_MedicamentsTableWithRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Presciption_Medicaments",
                columns: table => new
                {
                    IdPresciption_Medicament = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMedicament = table.Column<int>(nullable: false),
                    IdPrescription = table.Column<int>(nullable: false),
                    Dose = table.Column<int>(nullable: false),
                    Details = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presciption_Medicaments", x => x.IdPresciption_Medicament);
                    table.ForeignKey(
                        name: "FK_Presciption_Medicaments_Medicaments_IdMedicament",
                        column: x => x.IdMedicament,
                        principalTable: "Medicaments",
                        principalColumn: "IdMedicament",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Presciption_Medicaments_Prescriptions_IdPrescription",
                        column: x => x.IdPrescription,
                        principalTable: "Prescriptions",
                        principalColumn: "IdPrescription",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Presciption_Medicaments_IdMedicament",
                table: "Presciption_Medicaments",
                column: "IdMedicament");

            migrationBuilder.CreateIndex(
                name: "IX_Presciption_Medicaments_IdPrescription",
                table: "Presciption_Medicaments",
                column: "IdPrescription");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Presciption_Medicaments");
        }
    }
}

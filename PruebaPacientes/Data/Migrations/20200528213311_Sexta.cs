using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Sexta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ListaPaciente_NroDeDocumento",
                table: "ListaPaciente");

            migrationBuilder.AlterColumn<string>(
                name: "NroDeDocumento",
                table: "ListaPaciente",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NroDeDocumento",
                table: "ListaPaciente",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ListaPaciente_NroDeDocumento",
                table: "ListaPaciente",
                column: "NroDeDocumento",
                unique: true,
                filter: "[NroDeDocumento] IS NOT NULL");
        }
    }
}

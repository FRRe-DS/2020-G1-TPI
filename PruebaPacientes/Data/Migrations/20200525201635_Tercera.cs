using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Tercera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Localidad");

            migrationBuilder.DropTable(
                name: "Provincia");

            migrationBuilder.DropColumn(
                name: "CodigoPostal",
                table: "Domicilio");

            migrationBuilder.DropColumn(
                name: "Localidad",
                table: "Domicilio");

            migrationBuilder.DropColumn(
                name: "Provincia",
                table: "Domicilio");

            migrationBuilder.AddColumn<int>(
                name: "LocalidadId",
                table: "Domicilio",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ListaProvincias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListaProvincias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ListaLocalidades",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    ProvinciaId = table.Column<int>(nullable: false),
                    CodigoPostal = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListaLocalidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListaLocalidades_ListaProvincias_ProvinciaId",
                        column: x => x.ProvinciaId,
                        principalTable: "ListaProvincias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Domicilio_LocalidadId",
                table: "Domicilio",
                column: "LocalidadId");

            migrationBuilder.CreateIndex(
                name: "IX_ListaLocalidades_ProvinciaId",
                table: "ListaLocalidades",
                column: "ProvinciaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Domicilio_ListaLocalidades_LocalidadId",
                table: "Domicilio",
                column: "LocalidadId",
                principalTable: "ListaLocalidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Domicilio_ListaLocalidades_LocalidadId",
                table: "Domicilio");

            migrationBuilder.DropTable(
                name: "ListaLocalidades");

            migrationBuilder.DropTable(
                name: "ListaProvincias");

            migrationBuilder.DropIndex(
                name: "IX_Domicilio_LocalidadId",
                table: "Domicilio");

            migrationBuilder.DropColumn(
                name: "LocalidadId",
                table: "Domicilio");

            migrationBuilder.AddColumn<string>(
                name: "CodigoPostal",
                table: "Domicilio",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Localidad",
                table: "Domicilio",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Provincia",
                table: "Domicilio",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Provincia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Localidad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProvinciaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localidad", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Localidad_Provincia_ProvinciaId",
                        column: x => x.ProvinciaId,
                        principalTable: "Provincia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Localidad_ProvinciaId",
                table: "Localidad",
                column: "ProvinciaId");
        }
    }
}

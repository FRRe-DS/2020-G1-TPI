using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Cuarta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Domicilio_ListaLocalidades_LocalidadId",
                table: "Domicilio");

            migrationBuilder.DropForeignKey(
                name: "FK_ListaAntecedenteEpidemiologicos1_Domicilio_DomicilioAlejoEnElQueResidioDomicioId",
                table: "ListaAntecedenteEpidemiologicos1");

            migrationBuilder.DropForeignKey(
                name: "FK_ListaPaciente_Domicilio_DomicilioDomicioId",
                table: "ListaPaciente");

            migrationBuilder.DropIndex(
                name: "IX_ListaPaciente_DomicilioDomicioId",
                table: "ListaPaciente");

            migrationBuilder.DropIndex(
                name: "IX_ListaAntecedenteEpidemiologicos1_DomicilioAlejoEnElQueResidioDomicioId",
                table: "ListaAntecedenteEpidemiologicos1");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Domicilio",
                table: "Domicilio");

            migrationBuilder.DropColumn(
                name: "DomicilioDomicioId",
                table: "ListaPaciente");

            migrationBuilder.DropColumn(
                name: "DomicilioAlejoEnElQueResidioDomicioId",
                table: "ListaAntecedenteEpidemiologicos1");

            migrationBuilder.DropColumn(
                name: "DomicioId",
                table: "Domicilio");

            migrationBuilder.DropColumn(
                name: "Departamento",
                table: "Domicilio");

            migrationBuilder.AddColumn<string>(
                name: "APIUserId",
                table: "ListaPaciente",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DomicilioId",
                table: "ListaPaciente",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RespuestaMedica",
                table: "ListaFormularioParaAnalisis",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DomicilioAlejoEnElQueResidioDomicilioId",
                table: "ListaAntecedenteEpidemiologicos1",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LocalidadId",
                table: "Domicilio",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DomicilioId",
                table: "Domicilio",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Domicilio",
                table: "Domicilio",
                column: "DomicilioId");

            migrationBuilder.CreateIndex(
                name: "IX_ListaPaciente_DomicilioId",
                table: "ListaPaciente",
                column: "DomicilioId");

            migrationBuilder.CreateIndex(
                name: "IX_ListaAntecedenteEpidemiologicos1_DomicilioAlejoEnElQueResidioDomicilioId",
                table: "ListaAntecedenteEpidemiologicos1",
                column: "DomicilioAlejoEnElQueResidioDomicilioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Domicilio_ListaLocalidades_LocalidadId",
                table: "Domicilio",
                column: "LocalidadId",
                principalTable: "ListaLocalidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ListaAntecedenteEpidemiologicos1_Domicilio_DomicilioAlejoEnElQueResidioDomicilioId",
                table: "ListaAntecedenteEpidemiologicos1",
                column: "DomicilioAlejoEnElQueResidioDomicilioId",
                principalTable: "Domicilio",
                principalColumn: "DomicilioId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ListaPaciente_Domicilio_DomicilioId",
                table: "ListaPaciente",
                column: "DomicilioId",
                principalTable: "Domicilio",
                principalColumn: "DomicilioId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Domicilio_ListaLocalidades_LocalidadId",
                table: "Domicilio");

            migrationBuilder.DropForeignKey(
                name: "FK_ListaAntecedenteEpidemiologicos1_Domicilio_DomicilioAlejoEnElQueResidioDomicilioId",
                table: "ListaAntecedenteEpidemiologicos1");

            migrationBuilder.DropForeignKey(
                name: "FK_ListaPaciente_Domicilio_DomicilioId",
                table: "ListaPaciente");

            migrationBuilder.DropIndex(
                name: "IX_ListaPaciente_DomicilioId",
                table: "ListaPaciente");

            migrationBuilder.DropIndex(
                name: "IX_ListaAntecedenteEpidemiologicos1_DomicilioAlejoEnElQueResidioDomicilioId",
                table: "ListaAntecedenteEpidemiologicos1");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Domicilio",
                table: "Domicilio");

            migrationBuilder.DropColumn(
                name: "APIUserId",
                table: "ListaPaciente");

            migrationBuilder.DropColumn(
                name: "DomicilioId",
                table: "ListaPaciente");

            migrationBuilder.DropColumn(
                name: "RespuestaMedica",
                table: "ListaFormularioParaAnalisis");

            migrationBuilder.DropColumn(
                name: "DomicilioAlejoEnElQueResidioDomicilioId",
                table: "ListaAntecedenteEpidemiologicos1");

            migrationBuilder.DropColumn(
                name: "DomicilioId",
                table: "Domicilio");

            migrationBuilder.AddColumn<int>(
                name: "DomicilioDomicioId",
                table: "ListaPaciente",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DomicilioAlejoEnElQueResidioDomicioId",
                table: "ListaAntecedenteEpidemiologicos1",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LocalidadId",
                table: "Domicilio",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "DomicioId",
                table: "Domicilio",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Departamento",
                table: "Domicilio",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Domicilio",
                table: "Domicilio",
                column: "DomicioId");

            migrationBuilder.CreateIndex(
                name: "IX_ListaPaciente_DomicilioDomicioId",
                table: "ListaPaciente",
                column: "DomicilioDomicioId");

            migrationBuilder.CreateIndex(
                name: "IX_ListaAntecedenteEpidemiologicos1_DomicilioAlejoEnElQueResidioDomicioId",
                table: "ListaAntecedenteEpidemiologicos1",
                column: "DomicilioAlejoEnElQueResidioDomicioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Domicilio_ListaLocalidades_LocalidadId",
                table: "Domicilio",
                column: "LocalidadId",
                principalTable: "ListaLocalidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ListaAntecedenteEpidemiologicos1_Domicilio_DomicilioAlejoEnElQueResidioDomicioId",
                table: "ListaAntecedenteEpidemiologicos1",
                column: "DomicilioAlejoEnElQueResidioDomicioId",
                principalTable: "Domicilio",
                principalColumn: "DomicioId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ListaPaciente_Domicilio_DomicilioDomicioId",
                table: "ListaPaciente",
                column: "DomicilioDomicioId",
                principalTable: "Domicilio",
                principalColumn: "DomicioId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

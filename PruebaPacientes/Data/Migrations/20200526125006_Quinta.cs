using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Quinta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ListaAntecedenteEpidemiologicos1_ListaFormularioParaAnalisis_FormularioParaAnalisisId",
                table: "ListaAntecedenteEpidemiologicos1");

            migrationBuilder.DropForeignKey(
                name: "FK_ListaAntecedenteEpidemiologicos2_ListaFormularioParaAnalisis_FormularioParaAnalisisId",
                table: "ListaAntecedenteEpidemiologicos2");

            migrationBuilder.DropForeignKey(
                name: "FK_ListaEnfermedadesPreviasComorbilidades_ListaFormularioParaAnalisis_FormularioParaAnalisisId",
                table: "ListaEnfermedadesPreviasComorbilidades");

            migrationBuilder.DropForeignKey(
                name: "FK_ListaSignosYSintomas_ListaFormularioParaAnalisis_FormularioParaAnalisisId",
                table: "ListaSignosYSintomas");

            migrationBuilder.DropIndex(
                name: "IX_ListaSignosYSintomas_FormularioParaAnalisisId",
                table: "ListaSignosYSintomas");

            migrationBuilder.DropIndex(
                name: "IX_ListaEnfermedadesPreviasComorbilidades_FormularioParaAnalisisId",
                table: "ListaEnfermedadesPreviasComorbilidades");

            migrationBuilder.DropIndex(
                name: "IX_ListaAntecedenteEpidemiologicos2_FormularioParaAnalisisId",
                table: "ListaAntecedenteEpidemiologicos2");

            migrationBuilder.DropIndex(
                name: "IX_ListaAntecedenteEpidemiologicos1_FormularioParaAnalisisId",
                table: "ListaAntecedenteEpidemiologicos1");

            migrationBuilder.DropColumn(
                name: "FormularioParaAnalisisId",
                table: "ListaSignosYSintomas");

            migrationBuilder.DropColumn(
                name: "FormularioParaAnalisisId",
                table: "ListaEnfermedadesPreviasComorbilidades");

            migrationBuilder.DropColumn(
                name: "FormularioParaAnalisisId",
                table: "ListaAntecedenteEpidemiologicos2");

            migrationBuilder.DropColumn(
                name: "FormularioParaAnalisisId",
                table: "ListaAntecedenteEpidemiologicos1");

            migrationBuilder.CreateIndex(
                name: "IX_ListaFormularioParaAnalisis_AntecedenteEpidemiologicos1Id",
                table: "ListaFormularioParaAnalisis",
                column: "AntecedenteEpidemiologicos1Id");

            migrationBuilder.CreateIndex(
                name: "IX_ListaFormularioParaAnalisis_AntecedenteEpidemiologicos2Id",
                table: "ListaFormularioParaAnalisis",
                column: "AntecedenteEpidemiologicos2Id");

            migrationBuilder.CreateIndex(
                name: "IX_ListaFormularioParaAnalisis_EnfermedadesPreviasComorbilidadesId",
                table: "ListaFormularioParaAnalisis",
                column: "EnfermedadesPreviasComorbilidadesId");

            migrationBuilder.CreateIndex(
                name: "IX_ListaFormularioParaAnalisis_SignosYSintomasId",
                table: "ListaFormularioParaAnalisis",
                column: "SignosYSintomasId");

            migrationBuilder.AddForeignKey(
                name: "FK_ListaFormularioParaAnalisis_ListaAntecedenteEpidemiologicos1_AntecedenteEpidemiologicos1Id",
                table: "ListaFormularioParaAnalisis",
                column: "AntecedenteEpidemiologicos1Id",
                principalTable: "ListaAntecedenteEpidemiologicos1",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ListaFormularioParaAnalisis_ListaAntecedenteEpidemiologicos2_AntecedenteEpidemiologicos2Id",
                table: "ListaFormularioParaAnalisis",
                column: "AntecedenteEpidemiologicos2Id",
                principalTable: "ListaAntecedenteEpidemiologicos2",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ListaFormularioParaAnalisis_ListaEnfermedadesPreviasComorbilidades_EnfermedadesPreviasComorbilidadesId",
                table: "ListaFormularioParaAnalisis",
                column: "EnfermedadesPreviasComorbilidadesId",
                principalTable: "ListaEnfermedadesPreviasComorbilidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ListaFormularioParaAnalisis_ListaSignosYSintomas_SignosYSintomasId",
                table: "ListaFormularioParaAnalisis",
                column: "SignosYSintomasId",
                principalTable: "ListaSignosYSintomas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ListaFormularioParaAnalisis_ListaAntecedenteEpidemiologicos1_AntecedenteEpidemiologicos1Id",
                table: "ListaFormularioParaAnalisis");

            migrationBuilder.DropForeignKey(
                name: "FK_ListaFormularioParaAnalisis_ListaAntecedenteEpidemiologicos2_AntecedenteEpidemiologicos2Id",
                table: "ListaFormularioParaAnalisis");

            migrationBuilder.DropForeignKey(
                name: "FK_ListaFormularioParaAnalisis_ListaEnfermedadesPreviasComorbilidades_EnfermedadesPreviasComorbilidadesId",
                table: "ListaFormularioParaAnalisis");

            migrationBuilder.DropForeignKey(
                name: "FK_ListaFormularioParaAnalisis_ListaSignosYSintomas_SignosYSintomasId",
                table: "ListaFormularioParaAnalisis");

            migrationBuilder.DropIndex(
                name: "IX_ListaFormularioParaAnalisis_AntecedenteEpidemiologicos1Id",
                table: "ListaFormularioParaAnalisis");

            migrationBuilder.DropIndex(
                name: "IX_ListaFormularioParaAnalisis_AntecedenteEpidemiologicos2Id",
                table: "ListaFormularioParaAnalisis");

            migrationBuilder.DropIndex(
                name: "IX_ListaFormularioParaAnalisis_EnfermedadesPreviasComorbilidadesId",
                table: "ListaFormularioParaAnalisis");

            migrationBuilder.DropIndex(
                name: "IX_ListaFormularioParaAnalisis_SignosYSintomasId",
                table: "ListaFormularioParaAnalisis");

            migrationBuilder.AddColumn<int>(
                name: "FormularioParaAnalisisId",
                table: "ListaSignosYSintomas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FormularioParaAnalisisId",
                table: "ListaEnfermedadesPreviasComorbilidades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FormularioParaAnalisisId",
                table: "ListaAntecedenteEpidemiologicos2",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FormularioParaAnalisisId",
                table: "ListaAntecedenteEpidemiologicos1",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ListaSignosYSintomas_FormularioParaAnalisisId",
                table: "ListaSignosYSintomas",
                column: "FormularioParaAnalisisId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ListaEnfermedadesPreviasComorbilidades_FormularioParaAnalisisId",
                table: "ListaEnfermedadesPreviasComorbilidades",
                column: "FormularioParaAnalisisId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ListaAntecedenteEpidemiologicos2_FormularioParaAnalisisId",
                table: "ListaAntecedenteEpidemiologicos2",
                column: "FormularioParaAnalisisId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ListaAntecedenteEpidemiologicos1_FormularioParaAnalisisId",
                table: "ListaAntecedenteEpidemiologicos1",
                column: "FormularioParaAnalisisId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ListaAntecedenteEpidemiologicos1_ListaFormularioParaAnalisis_FormularioParaAnalisisId",
                table: "ListaAntecedenteEpidemiologicos1",
                column: "FormularioParaAnalisisId",
                principalTable: "ListaFormularioParaAnalisis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ListaAntecedenteEpidemiologicos2_ListaFormularioParaAnalisis_FormularioParaAnalisisId",
                table: "ListaAntecedenteEpidemiologicos2",
                column: "FormularioParaAnalisisId",
                principalTable: "ListaFormularioParaAnalisis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ListaEnfermedadesPreviasComorbilidades_ListaFormularioParaAnalisis_FormularioParaAnalisisId",
                table: "ListaEnfermedadesPreviasComorbilidades",
                column: "FormularioParaAnalisisId",
                principalTable: "ListaFormularioParaAnalisis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ListaSignosYSintomas_ListaFormularioParaAnalisis_FormularioParaAnalisisId",
                table: "ListaSignosYSintomas",
                column: "FormularioParaAnalisisId",
                principalTable: "ListaFormularioParaAnalisis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

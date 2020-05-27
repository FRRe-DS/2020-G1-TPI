using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Primera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Domicilio",
                columns: table => new
                {
                    DomicioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Provincia = table.Column<string>(nullable: true),
                    Departamento = table.Column<string>(nullable: true),
                    Localidad = table.Column<string>(nullable: true),
                    CodigoPostal = table.Column<string>(nullable: true),
                    Calle = table.Column<string>(nullable: true),
                    NroDeCalle = table.Column<string>(nullable: true),
                    Dpto = table.Column<string>(nullable: true),
                    NroDeDpto = table.Column<string>(nullable: true),
                    Piso = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domicilio", x => x.DomicioId);
                });

            migrationBuilder.CreateTable(
                name: "ListaPaciente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Apellido = table.Column<string>(nullable: true),
                    TipoDeDocumento = table.Column<string>(nullable: false),
                    NroDeDocumento = table.Column<string>(nullable: true),
                    FechaDeNacimiento = table.Column<DateTime>(nullable: false),
                    DomicilioDomicioId = table.Column<int>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    Sexo = table.Column<string>(nullable: true),
                    Correo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListaPaciente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListaPaciente_Domicilio_DomicilioDomicioId",
                        column: x => x.DomicilioDomicioId,
                        principalTable: "Domicilio",
                        principalColumn: "DomicioId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ListaFormularioParaAnalisis",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstadoDelFormulario = table.Column<string>(nullable: false),
                    FechaDeCreacion = table.Column<DateTime>(nullable: false),
                    PacienteId = table.Column<int>(nullable: false),
                    AntecedenteEpidemiologicos1Id = table.Column<int>(nullable: false),
                    AntecedenteEpidemiologicos2Id = table.Column<int>(nullable: false),
                    EnfermedadesPreviasComorbilidadesId = table.Column<int>(nullable: false),
                    SignosYSintomasId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListaFormularioParaAnalisis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListaFormularioParaAnalisis_ListaPaciente_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "ListaPaciente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ListaAntecedenteEpidemiologicos1",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoDeOcupacionDelPaciente = table.Column<string>(nullable: false),
                    OtroTipoDeOcupacion = table.Column<string>(nullable: true),
                    TieneVacunaAntiGripal = table.Column<bool>(nullable: false),
                    FechaDeVacunacion = table.Column<DateTime>(nullable: false),
                    FechaDeVencimientoDeLaVacuna = table.Column<DateTime>(nullable: false),
                    EstuvoEnUnLugarDeContagioFueraDelPaisPrevioASintomas = table.Column<bool>(nullable: false),
                    PaisEnQueEstuvo = table.Column<string>(nullable: true),
                    CiudadDelPaisEnQueEstuvo = table.Column<string>(nullable: true),
                    FechaDeLlegadaAlPaisEnQueEstuvo = table.Column<DateTime>(nullable: false),
                    FechaDeSalidaDelPaisEnQueEstuvo = table.Column<DateTime>(nullable: false),
                    TipoDeTransporteUtilizado = table.Column<string>(nullable: false),
                    FechaDeIngresoAlPais = table.Column<DateTime>(nullable: false),
                    CompañiaDeTransporte = table.Column<string>(nullable: true),
                    ResidioEnLugarAjenoASuDomicilioDentroDelPaisPrevioASintomas = table.Column<bool>(nullable: false),
                    DomicilioAlejoEnElQueResidioDomicioId = table.Column<int>(nullable: true),
                    FechaDeLlegadaADomicilioAjeno = table.Column<DateTime>(nullable: false),
                    FechaDeSalidaDelDomicilioAjeno = table.Column<DateTime>(nullable: false),
                    FormularioParaAnalisisId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListaAntecedenteEpidemiologicos1", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListaAntecedenteEpidemiologicos1_Domicilio_DomicilioAlejoEnElQueResidioDomicioId",
                        column: x => x.DomicilioAlejoEnElQueResidioDomicioId,
                        principalTable: "Domicilio",
                        principalColumn: "DomicioId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ListaAntecedenteEpidemiologicos1_ListaFormularioParaAnalisis_FormularioParaAnalisisId",
                        column: x => x.FormularioParaAnalisisId,
                        principalTable: "ListaFormularioParaAnalisis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ListaAntecedenteEpidemiologicos2",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitoCentroConCasosPositivosPrevioASintomas = table.Column<bool>(nullable: false),
                    NombreDelCentroVisitado = table.Column<string>(nullable: true),
                    CiudadDelCentroVisitado = table.Column<string>(nullable: true),
                    FechaDeLaVisitaAlCentro = table.Column<DateTime>(nullable: false),
                    ContactoConAnimalesPrevioASintomas = table.Column<bool>(nullable: false),
                    TipoDeAnimalesConContacto = table.Column<string>(nullable: false),
                    OtroTipoDeContactoConAnimales = table.Column<string>(nullable: true),
                    ContactoConPersonasConIRPrevioASintomas = table.Column<bool>(nullable: false),
                    TipoDeEntornoDeContacto = table.Column<string>(nullable: false),
                    OtroTipoDeEntornoDeContacto = table.Column<string>(nullable: true),
                    ContactoConCasosProbablesOConfirmadosPrevioASintomas = table.Column<bool>(nullable: false),
                    ApellidoDelCaso = table.Column<string>(nullable: true),
                    NombreDelCaso = table.Column<string>(nullable: true),
                    DNIDelCaso = table.Column<string>(nullable: true),
                    PaisDelCaso = table.Column<string>(nullable: true),
                    AreaDelCaso = table.Column<string>(nullable: true),
                    FormularioParaAnalisisId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListaAntecedenteEpidemiologicos2", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListaAntecedenteEpidemiologicos2_ListaFormularioParaAnalisis_FormularioParaAnalisisId",
                        column: x => x.FormularioParaAnalisisId,
                        principalTable: "ListaFormularioParaAnalisis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ListaEnfermedadesPreviasComorbilidades",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PresentaEnfermedadesComorbilidades = table.Column<bool>(nullable: false),
                    InmunoSupresionCongenitaOAdquirida = table.Column<bool>(nullable: false),
                    Diabetes = table.Column<bool>(nullable: false),
                    Obesidad = table.Column<bool>(nullable: false),
                    Embarzo = table.Column<bool>(nullable: false),
                    Puerperio = table.Column<bool>(nullable: false),
                    Prematuridad = table.Column<bool>(nullable: false),
                    SemanasDePrematuridad = table.Column<string>(nullable: true),
                    BajoPesoAlNacer = table.Column<bool>(nullable: false),
                    CantidadDePesoAlNacer = table.Column<string>(nullable: true),
                    EnfermedadNeurologica = table.Column<bool>(nullable: false),
                    EnfermedadHepatica = table.Column<bool>(nullable: false),
                    EnfermedadRenalCronica = table.Column<bool>(nullable: false),
                    HipertensionArterial = table.Column<bool>(nullable: false),
                    EnfermedadOncologica = table.Column<bool>(nullable: false),
                    BronquitisPrevia = table.Column<bool>(nullable: false),
                    NAC_Previa = table.Column<bool>(nullable: false),
                    EPOC = table.Column<bool>(nullable: false),
                    Asma = table.Column<bool>(nullable: false),
                    Tubercolosis = table.Column<bool>(nullable: false),
                    Fumador = table.Column<bool>(nullable: false),
                    NingunaDelasAnteriores = table.Column<bool>(nullable: false),
                    Otras = table.Column<bool>(nullable: false),
                    OtrasDetalle = table.Column<string>(nullable: true),
                    FormularioParaAnalisisId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListaEnfermedadesPreviasComorbilidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListaEnfermedadesPreviasComorbilidades_ListaFormularioParaAnalisis_FormularioParaAnalisisId",
                        column: x => x.FormularioParaAnalisisId,
                        principalTable: "ListaFormularioParaAnalisis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ListaSignosYSintomas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FiebreMayorA38 = table.Column<bool>(nullable: false),
                    Taquipnea_Disnea = table.Column<bool>(nullable: false),
                    Diarrea = table.Column<bool>(nullable: false),
                    Artralgias = table.Column<bool>(nullable: false),
                    MalestarEnGenerl = table.Column<bool>(nullable: false),
                    Tos = table.Column<bool>(nullable: false),
                    Vomitos = table.Column<bool>(nullable: false),
                    DolorDeGarganta = table.Column<bool>(nullable: false),
                    InsuficienciaRespiratoria = table.Column<bool>(nullable: false),
                    DolorAbdominal = table.Column<bool>(nullable: false),
                    DolorToracico = table.Column<bool>(nullable: false),
                    RechazoAlAlimento = table.Column<bool>(nullable: false),
                    IrritabilidadConfusion = table.Column<bool>(nullable: false),
                    Convulsiones = table.Column<bool>(nullable: false),
                    Otros = table.Column<bool>(nullable: false),
                    OtrosDetalle = table.Column<string>(nullable: true),
                    FormularioParaAnalisisId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListaSignosYSintomas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListaSignosYSintomas_ListaFormularioParaAnalisis_FormularioParaAnalisisId",
                        column: x => x.FormularioParaAnalisisId,
                        principalTable: "ListaFormularioParaAnalisis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ListaAntecedenteEpidemiologicos1_DomicilioAlejoEnElQueResidioDomicioId",
                table: "ListaAntecedenteEpidemiologicos1",
                column: "DomicilioAlejoEnElQueResidioDomicioId");

            migrationBuilder.CreateIndex(
                name: "IX_ListaAntecedenteEpidemiologicos1_FormularioParaAnalisisId",
                table: "ListaAntecedenteEpidemiologicos1",
                column: "FormularioParaAnalisisId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ListaAntecedenteEpidemiologicos2_FormularioParaAnalisisId",
                table: "ListaAntecedenteEpidemiologicos2",
                column: "FormularioParaAnalisisId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ListaEnfermedadesPreviasComorbilidades_FormularioParaAnalisisId",
                table: "ListaEnfermedadesPreviasComorbilidades",
                column: "FormularioParaAnalisisId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ListaFormularioParaAnalisis_PacienteId",
                table: "ListaFormularioParaAnalisis",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_ListaPaciente_DomicilioDomicioId",
                table: "ListaPaciente",
                column: "DomicilioDomicioId");

            migrationBuilder.CreateIndex(
                name: "IX_ListaPaciente_NroDeDocumento",
                table: "ListaPaciente",
                column: "NroDeDocumento",
                unique: true,
                filter: "[NroDeDocumento] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ListaSignosYSintomas_FormularioParaAnalisisId",
                table: "ListaSignosYSintomas",
                column: "FormularioParaAnalisisId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ListaAntecedenteEpidemiologicos1");

            migrationBuilder.DropTable(
                name: "ListaAntecedenteEpidemiologicos2");

            migrationBuilder.DropTable(
                name: "ListaEnfermedadesPreviasComorbilidades");

            migrationBuilder.DropTable(
                name: "ListaSignosYSintomas");

            migrationBuilder.DropTable(
                name: "ListaFormularioParaAnalisis");

            migrationBuilder.DropTable(
                name: "ListaPaciente");

            migrationBuilder.DropTable(
                name: "Domicilio");
        }
    }
}

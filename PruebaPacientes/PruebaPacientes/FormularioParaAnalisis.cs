using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class FormularioParaAnalisis
    {
        public int Id                                                              { get; set; }
        public EstadoDelFormulario EstadoDelFormulario                             { get; set; }
        public DateTime FechaDeCreacion                                            { get; set; }
        public Paciente Paciente { get; set; }
        public int PacienteId { get; set; }
        public AntecedenteEpidemiologicos1 AntecedenteEpidemiologicos1             { get; set; }
        public int AntecedenteEpidemiologicos1Id                                   { get; set; }
        public AntecedenteEpidemiologicos2 AntecedenteEpidemiologicos2             { get; set; }
        public int AntecedenteEpidemiologicos2Id                                   { get; set; }
        public EnfermedadesPreviasComorbilidades EnfermedadesPreviasComorbilidades { get; set; }
        public int EnfermedadesPreviasComorbilidadesId                             { get; set; }
        public SignosYSintomas SignosYSintomas                                     { get; set; }
        public int SignosYSintomasId                                               { get; set; }
        public string RespuestaMedica                                              { get; set; }
    }
}

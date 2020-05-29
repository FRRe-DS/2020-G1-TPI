using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class SignosYSintomas
    {
        public int Id                           { get; set; }

        public bool FiebreMayorA38              { get; set; }
        public bool Taquipnea_Disnea            { get; set; }
        public bool Diarrea                     { get; set; }
        public bool Artralgias                  { get; set; }
        public bool MalestarEnGenerl            { get; set; }
        public bool Tos                         { get; set; }
        public bool Vomitos                     { get; set; }
        public bool DolorDeGarganta             { get; set; }
        public bool InsuficienciaRespiratoria   { get; set; }
        public bool DolorAbdominal              { get; set; }
        public bool DolorToracico               { get; set; }
        public bool RechazoAlAlimento           { get; set; }
        public bool IrritabilidadConfusion      { get; set; }
        public bool Convulsiones                { get; set; }
        public bool Otros                       { get; set; }
        public string OtrosDetalle              { get; set; }
        //public int FormularioParaAnalisisId { get; set; }

        //public FormularioParaAnalisis FormularioParaAnalisis { get; set; }

    }
}

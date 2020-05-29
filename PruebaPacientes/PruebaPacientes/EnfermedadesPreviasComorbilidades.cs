using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class EnfermedadesPreviasComorbilidades
    {
        public int Id                                   { get; set; }

        public bool PresentaEnfermedadesComorbilidades  { get; set; }

        public bool InmunoSupresionCongenitaOAdquirida  { get; set; }
        public bool Diabetes                            { get; set; }
        public bool Obesidad                            { get; set; }
        public bool Embarzo                             { get; set; }
        public bool Puerperio                           { get; set; }
        public bool Prematuridad                        { get; set; }
        public string SemanasDePrematuridad             { get; set; }
        public bool BajoPesoAlNacer                     { get; set; }
        public string CantidadDePesoAlNacer             { get; set; }
        public bool EnfermedadNeurologica               { get; set; }
        public bool EnfermedadHepatica                  { get; set; }
        public bool EnfermedadRenalCronica              { get; set; }
        public bool HipertensionArterial                { get; set; }
        public bool EnfermedadOncologica                { get; set; }
        public bool BronquitisPrevia                    { get; set; }
        public bool NAC_Previa                          { get; set; }
        public bool EPOC                                { get; set; }
        public bool Asma                                { get; set; }
        public bool Tubercolosis                        { get; set; }
        public bool Fumador                             { get; set; }
        public bool NingunaDelasAnteriores              { get; set; }
        public bool Otras                               { get; set; }
        public string OtrasDetalle                      { get; set; }
        //public int FormularioParaAnalisisId { get; set; }
        //public FormularioParaAnalisis FormularioParaAnalisis { get; set; }


    }
}

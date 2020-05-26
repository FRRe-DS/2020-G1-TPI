using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class AntecedenteEpidemiologicos1
    {
        public int Id                                                           { get; set; }
       
        public TipoDeOcupacionDelPaciente TipoDeOcupacionDelPaciente            { get; set; }
        public string OtroTipoDeOcupacion                                       { get; set; }

        public bool TieneVacunaAntiGripal                                       { get; set; }
        public DateTime FechaDeVacunacion                                       { get; set; }
        public DateTime FechaDeVencimientoDeLaVacuna                            { get; set; }

        public bool EstuvoEnUnLugarDeContagioFueraDelPaisPrevioASintomas        { get; set; }
        public string PaisEnQueEstuvo                                           { get; set; }
        public string CiudadDelPaisEnQueEstuvo                                  { get; set; }
        public DateTime FechaDeLlegadaAlPaisEnQueEstuvo                         { get; set; }
        public DateTime FechaDeSalidaDelPaisEnQueEstuvo                         { get; set; }
        public TipoDeTransporteUtilizado TipoDeTransporteUtilizado              { get; set; }
        public DateTime FechaDeIngresoAlPais                                    { get; set; }
        public string CompañiaDeTransporte                                      { get; set; }

        public bool ResidioEnLugarAjenoASuDomicilioDentroDelPaisPrevioASintomas { get; set; }
        public Domicilio DomicilioAlejoEnElQueResidio                           { get; set; }
        public DateTime FechaDeLlegadaADomicilioAjeno                           { get; set; }
        public DateTime FechaDeSalidaDelDomicilioAjeno                          { get; set; }
        
        //public int FormularioParaAnalisisId {get; set; }
        //public FormularioParaAnalisis FormularioParaAnalisis { get; set; }


    }
}

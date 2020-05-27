using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class AntecedenteEpidemiologicos2
    {
       public int Id                                                    { get; set; }

       public bool VisitoCentroConCasosPositivosPrevioASintomas         { get; set; }
       public string NombreDelCentroVisitado                            { get; set; }
       public string CiudadDelCentroVisitado                            { get; set; }
       public DateTime FechaDeLaVisitaAlCentro                          { get; set; }
       
       public bool ContactoConAnimalesPrevioASintomas                   { get; set; }
       public TipoDeAnimalesConContacto TipoDeAnimalesConContacto       { get; set; }
       public string OtroTipoDeContactoConAnimales                      { get; set; }

      public bool ContactoConPersonasConIRPrevioASintomas               { get; set; }  //IR = Infeccion Respiratoria
      public TipoDeEntornoDeContacto TipoDeEntornoDeContacto            { get; set; }
      public string OtroTipoDeEntornoDeContacto                         { get; set; }

      public bool ContactoConCasosProbablesOConfirmadosPrevioASintomas  { get; set; } 
      public string ApellidoDelCaso                                     { get; set; }
      public string NombreDelCaso                                       { get; set; }
      public string DNIDelCaso                                          { get; set; }
      public string PaisDelCaso                                         { get; set; }
      public string AreaDelCaso                                         { get; set; }
      //public int FormularioParaAnalisisId { get; set; }
      //public FormularioParaAnalisis FormularioParaAnalisis { get; set; }


    }
}

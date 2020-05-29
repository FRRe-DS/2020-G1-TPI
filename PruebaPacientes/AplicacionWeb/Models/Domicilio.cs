using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Domicilio
    {
        public int DomicilioId { get; set; }
        //public Provincia Provincia         { get; set; }
        //public string Departamento      { get; set; }
        //public string Localidad         { get; set; }
        //public string CodigoPostal      { get; set; }
        public string Calle             { get; set; }
        public string NroDeCalle        { get; set; }
        public string Dpto              { get; set; }
        public string NroDeDpto         { get; set; }
        public string Piso              { get; set; }
        public int LocalidadId          { get; set; }
        public Localidad Localidad      { get; set; }
    }
}

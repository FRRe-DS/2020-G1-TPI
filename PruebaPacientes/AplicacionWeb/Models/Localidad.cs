using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Localidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int ProvinciaId { get; set; }
        public Provincia Provincia{ get; set; }
        public string CodigoPostal { get; set; }
    }
}

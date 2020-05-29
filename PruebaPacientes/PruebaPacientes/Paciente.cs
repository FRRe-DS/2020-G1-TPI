using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Paciente
    {
        public string APIUserId                { get; set; }
        public int Id                          { get; set; }
        public string Nombre                   { get; set; }
        public string Apellido                 { get; set; }
        public TipoDeDocumento TipoDeDocumento { get; set; }
        public string NroDeDocumento           { get; set; }
        public DateTime FechaDeNacimiento      { get; set; }
        public Domicilio Domicilio             { get; set; }
        public string Telefono                 { get; set; }
        public string Sexo                     { get; set; }
        public string Correo                   { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;
using Modelo;

namespace CovidWebAPI.Model
{
    public class ApplicationUser : IdentityUser
    {
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public TipoDeDocumento TipoDeDocumento { get; set; }
        public string NumeroDeDocumento { get; set; }
    }
}

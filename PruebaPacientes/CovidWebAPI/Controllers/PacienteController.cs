using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelo;
using Service;
using Service.Tools;

namespace CovidWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        // GET: api/FormularioParaAnalisis
        [HttpGet]
        [Route("[action]")]
        public ActionResult<Paciente> GetPacienteByDNI( string DNI)
        {
            try
            {
                DataContext dataContext = new DataContext();
                PacienteService pacienteService = new PacienteService(dataContext);
                var paciente = pacienteService.GetByDNI(DNI);
                if (paciente == null)
                {
                    return NotFound();
                }
                return paciente;

            }
            catch (Exception e)
            {

                return BadRequest(Tools.ExceptionMessage(e));
            }
        }
    }
}

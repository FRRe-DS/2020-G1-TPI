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
    public class LocalidadController : ControllerBase
    {

        [HttpGet]
        [Route("[action]")]
        public ActionResult<List<Localidad>> GetAll()
        {
            try
            {
                DataContext dataContext = new DataContext();
                LocalidadService localidadService = new LocalidadService(dataContext);
                var lista = localidadService.GetAll();
                if (lista == null)
                {
                    return NotFound();
                }
                return lista;

            }
            catch (Exception e)
            {

                return BadRequest(Tools.ExceptionMessage(e));
            }
        }

        [HttpPost]
        [Route("[action]")]
        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin, App")]
        public ActionResult Add([FromBody] Localidad localidad)
        {
            try
            {
                DataContext dataContext = new DataContext();
                LocalidadService localidadService = new LocalidadService(dataContext);
                localidadService.Add(localidad);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest(Tools.ExceptionMessage(e));
            }
        }        
    }
}

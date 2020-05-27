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
    public class FormularioParaAnalisisController : ControllerBase
    {
        // GET: api/FormularioParaAnalisis
        [HttpGet]
        [Route("[action]")]
        public ActionResult<List<FormularioParaAnalisis>> GetAll()
        {
            try
            {
                DataContext dataContext = new DataContext();
                FormuarioParaAnalisisService formuarioParaAnalisisService = new FormuarioParaAnalisisService(dataContext);
                var lista = formuarioParaAnalisisService.GetAll();
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
        public ActionResult Add([FromBody] FormularioParaAnalisis FPA)
        {
            try
            {
                DataContext dataContext = new DataContext();
                FormuarioParaAnalisisService formuarioParaAnalisisService = new FormuarioParaAnalisisService(dataContext);
                formuarioParaAnalisisService.Add(FPA);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest(Tools.ExceptionMessage(e));
            }
        }

        // GET: api/FormularioParaAnalisis/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/FormularioParaAnalisis
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/FormularioParaAnalisis/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

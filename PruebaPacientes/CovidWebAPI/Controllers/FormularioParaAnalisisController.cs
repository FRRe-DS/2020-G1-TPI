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

        [HttpGet]
        [Route("[action]")]
        public ActionResult<List<FormularioParaAnalisis>> GetNuevosFormularios()
        {
            try
            {
                DataContext dataContext = new DataContext();
                FormuarioParaAnalisisService formuarioParaAnalisisService = new FormuarioParaAnalisisService(dataContext);

                var lista = formuarioParaAnalisisService.GetFormulariosGenerados();
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


        [HttpGet("[action]/{fomularioId}")]
        public ActionResult SetRecibido(int fomularioId)
        {
            try
            {
                DataContext dataContext = new DataContext();
                FormuarioParaAnalisisService formuarioParaAnalisisService = new FormuarioParaAnalisisService(dataContext);
                formuarioParaAnalisisService.SetEnviado(fomularioId);
                return Ok();
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

     
    }
}

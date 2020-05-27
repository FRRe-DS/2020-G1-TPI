using Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Modelo;
using Service;
using Service.Tools;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LS.eCommerce.WebApi.Controllers
{
    [Route("api/[controller]")]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin, App, AppUser")]
    [ApiController]
    public class ProvinciaController : ControllerBase
    {
        [HttpGet]
        [Route("[action]")]
        public ActionResult<List<Provincia>> GetAll()
        {
            try
            {
                DataContext dataContext = new DataContext();
                ProvinciaService provinciaService = new ProvinciaService(dataContext);
                var lista = provinciaService.GetAll();
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

        //[HttpGet("[action]/{rubroCodigo}")]
        //public async Task<ActionResult<Provincia>> GetAsync(int Id)
        //{
        //    try
        //    {
        //        DataContext dataContext = new DataContext();
        //        ProvinciaService provinciaService = new ProvinciaService(dataContext);
        //        Provincia item = await provinciaService.get(ID);
        //        if (item == null)
        //        {
        //            return NotFound();
        //        }
        //        return item;

        //    }
        //    catch (Exception e)
        //    {

        //        return BadRequest(Tools.ExceptionMessage(e));
        //    }
        //}


       

       

        [HttpPost]
        [Route("[action]")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin, App")]
        public ActionResult Add([FromBody] Provincia provincia)
        {
            try
            {
                DataContext dataContext = new DataContext();
                ProvinciaService provinciaService = new ProvinciaService(dataContext);
                provinciaService.Add(provincia);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest(Tools.ExceptionMessage(e));
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin, App")]
        public ActionResult Update([FromBody] Provincia provincia)
        {
            try
            {
                DataContext dataContext = new DataContext();
                ProvinciaService provinciaService = new ProvinciaService(dataContext);
                provinciaService.Update(provincia);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest(Tools.ExceptionMessage(e));
            }
        }






        [HttpPost]
        [Route("[action]")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin, App")]
        public ActionResult Delete([FromBody] Provincia provincia)
        {
            try
            {
                DataContext dataContext = new DataContext();
                ProvinciaService provinciaService = new ProvinciaService(dataContext);
                provinciaService.Delete(provincia);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest(Tools.ExceptionMessage(e));
            }
        }






    }
}

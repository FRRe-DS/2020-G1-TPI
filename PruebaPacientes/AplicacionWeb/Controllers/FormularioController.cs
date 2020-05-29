using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AplicacionWeb.Controllers
{
    public class FormularioController : Controller
    {
        // GET: Formulario
        public ActionResult ReportarSintomas()
        {
            return View();
        }

        // GET: Formulario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Formulario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Formulario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ReportarSintomas(FormCollection formCollection)
        {
                string _nombre = formCollection["nombre"];
                string _apellidos = formCollection["apellidos"];
                string _dni = formCollection["dni"];
            // Aquí cualquier uso de las variables '_nombre', 
            // '_apellidos' y '_email'

            Console.WriteLine(_nombre, _apellidos, _dni);
          
            return View("ReportarSintomas");
        }
        /*public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }*/

        // GET: Formulario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Formulario/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Formulario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Formulario/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
using Ejemplo1Asp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejemplo1Asp.Controllers
{
    public class PracticasController : Controller
    {
        // GET: Practicas
        public ActionResult Index()
        {
            var persona = new Persona()
            {
                Nombre = "Iza",
                Edad = 20,
                Empleado = false,
                Nacimiento = new DateTime(2001, 5, 4)
            };
            ViewBag.Propiedad = persona;

            return View();
        }

        public ActionResult Index2(Persona persona)
        {
            ViewBag.Nom = persona.Nombre;
            ViewBag.Edad = persona.Edad;
            return View(persona);
        }

        public ActionResult Index3(Persona persona)
        {
            ViewBag.Nom = persona.Nombre;
            ViewBag.Edad = persona.Edad;
            return View(persona);
        }
    }
}
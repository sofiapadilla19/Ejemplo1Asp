using Ejemplo1Asp.Models;
using Ejemplo1Asp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejemplo1Asp.Controllers
{
    public class OperasBasController : Controller
    {
        // GET: OperasBas
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MuestraPeliculas()
        {
            var PeliculasService = new PeliculasService(); //Aqui se almacenan la lista de peliculas
            var model = PeliculasService.ObtenerPelicula();
            return View(model); //aqui se manda a la vista a través de model
        }

        //public ActionResult Sumar(Calculos calculos)
            //el segundo calculo es la creacion del objeto de esa clase
        //{
            //var tem = new Calculos();
            //tem = calculos;
            //tem.Elegir();
            //ViewBag.res = tem.Resultado; //ViewBag es crear una variable que se puede usar en la vista
            //return View();
        //}


        public ActionResult Sumar()
        {
            var tem = new Calculos();
            return View();
        }
        [HttpPost]

        public ActionResult Sumar(Calculos calculos, string r1)
        {
            var tem = new Calculos();
            tem = calculos;
            //tem.escoger();
            if (r1.Equals("suma"))
            {
                tem.Suma();
            }
            if (r1.Equals("resta"))
            {
                tem.Resta();
            }

            ViewBag.res = tem.Resultado;
            return View();
        }


        //public JsonResult Temporal()
        //{
        //var alumno1 = new Alumno() { Nombre = "Iza", Edad = 15 };
        //var alumno2 = new Alumno() { Nombre = "Sofia", Edad = 16 };
        //return Json(new List<Alumno>() { alumno1,alumno2}, JsonRequestBehavior.AllowGet);
        //    //return View();
        //}

        //public RedirectResult Temporal()
        //{
        //    return Redirect("https://www.google.com.mx");
        //}

        public RedirectToRouteResult Temporal()
        {
            return RedirectToAction("About","Home");
            //en este caso el primero es la accion y el segundo es el controlador
        }

        public ActionResult vista()
        {
            ViewBag.Nombre = "Sofia"; //variable
            ViewData["Nom"]="Iza"; //variable de otra forma
            return View();
        }

    }
}
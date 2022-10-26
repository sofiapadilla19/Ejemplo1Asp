using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejemplo1Asp.Controllers
{
    public class HomeController : Controller

        //La clase se llama Home pero se le antepone el Controller
    {

        //Esti es una "funcion" o un "método" pero dentro de un controlador se conocen como Acciones

        //el index es el nombre de la lista en este caso
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //a través de la viewbag se pueden mandar mensajes o variables de mensaje a la vista
            //se regresa la variable a la vista
            ViewBag.Message = "IEVN 1001";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
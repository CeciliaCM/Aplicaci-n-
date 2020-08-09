using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Web.UI.WebControls;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult MediasMoviles()
        {
            ViewBag.Message = "Modelo de medias móviles.";

            return View();
        }
        [HttpGet]
        public ActionResult OtrosModelos()
        {
            ViewBag.Message = "Modelos de análisis técnico y cuantitativo";

            return View();
        }
        [HttpGet]
        public ActionResult Informacion()
        {
            ViewBag.Message = "Esta aplicación tiene como fin incluir modelos cuantitativos y técnicos de " +
                "análisis del preccio de instrumentos financieros ";

            return View();
        }


        [HttpGet]
        public ActionResult Registro()
        {
            ViewBag.Message = "Crea una cuenta ";



            return View();
        }

        [HttpGet]
        public ActionResult hasregistrado()
        {
            ViewBag.Message = "Te has registrado ";



            return View();
        }
        [HttpGet]
        public ActionResult Gráfica()
        {
            ViewBag.Message = "Gráfica Medias Móviles ";




            return View();
        }

        [HttpGet]
        public ActionResult KIMBERA()
        {
            ViewBag.Message = "Gráfica Medias Móviles ";




            return View();
        }

        [HttpGet]
        public ActionResult ALPEKA()
        {
            ViewBag.Message = "Gráfica Medias Móviles ";




            return View();
        }
        [HttpGet]
        public ActionResult TLEVISACPO()
        {
            ViewBag.Message = "Gráfica Medias Móviles ";




            return View();
        }

        [HttpGet]
        public ActionResult CUERVO()
        {
            ViewBag.Message = "Gráfica Medias Móviles ";




            return View();
        }
        [HttpGet]
        public ActionResult PINFRA()
        {
            ViewBag.Message = "Gráfica Medias Móviles ";




            return View();
        }

        [HttpGet]
        public ActionResult AccesoGráficas()
        {
            ViewBag.Message = "Gráfica Medias Móviles ";



            return View();
        }
    }
}


        
       





 
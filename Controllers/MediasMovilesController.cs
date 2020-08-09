using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class MediasMovilesController : Controller
    {
        // GET: MediasMoviles
        public ActionResult Index()
        {
            ViewBag.Message = "Modelo de Medias Móviles ";

            return View();

             void Main(string[] args)
            {
                using (var reader = new System.IO.StreamReader(@"C:\Users\cecil\Desktop\Aplicación web\Medias Moviles"))
                {
                    List<string> listA = new List<string>();
                    List<string> listB = new List<string>();
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');

                        listA.Add(values[0]);
                        listB.Add(values[1]);
                    }
                }
            }

        }
        
    }
}
using Microsoft.AspNetCore.Mvc;
/*Agregar el using para el manejo de las listas*/
using System.Collections.Generic;
/*Agregamos el using para modelos*/
using G6IV13.Models;

namespace G6IV13.Controllers
{
    public class ActividadController : Controller
    {
        //Se genera una lista de tipo estatica donde se
        //almacenará los items que el usuario ingresa
        private static List<Actividad> _actividades = new List<Actividad>();

        public IActionResult Index()
        {
            //Con el ViewBag pasamos la lista _actividades a la vista index y que pueda utilizar
            ViewBag.Actividades = _actividades;
            return View();
        }

        public IActionResult Agregar()
        {
            return View();
        }
    }
}

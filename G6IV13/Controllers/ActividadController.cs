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
            ViewBag.Actividades = _actividades;
            return View();
        }
    }
}

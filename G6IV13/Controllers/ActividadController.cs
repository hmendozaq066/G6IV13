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
        //Cuando no se indica el método a usar, de forma predeterminada es GET
        public IActionResult Agregar()
        {
            return View();
        }

        //Se puede definir el método con el cual se recibirán los datos, en este
        //caso es POST
        //Los parámetros deben llamarse igual que en el formulario
        [HttpPost]
        public IActionResult Agregar(int ID, string Descripcion, int Estado)
        {//Aquí hay una sobrecarga de los métodos
            var _ID = ID;//Este ID es igual al partámetro
            var _Descripcion = Descripcion; //Es igual a la descripción
            var _Estado = Estado; //Es igual al Estado

            /*_actividades.Add(
                new Actividad { ID = _ID, Descripcion = _Descripcion,
                    Estado = _Estado 
                });*/
            var act = new Actividad();
            act.ID = _ID;
            act.Descripcion = _Descripcion;
            act.Estado = _Estado;   
            _actividades.Add(act);

            return RedirectToAction("Index");
        }
    }
}

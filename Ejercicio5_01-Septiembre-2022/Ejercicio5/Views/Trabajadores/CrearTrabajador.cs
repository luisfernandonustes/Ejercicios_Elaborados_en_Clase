using Ejercicio5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Views.Trabajadores
{
    internal class CrearTrabajador :IView<Trabajador>
    {
        public void Render(Trabajador obj)
        {
            Console.WriteLine($"Se a Creado el Trabajador con el Nombre :{obj.Name}");
        }
    }
}

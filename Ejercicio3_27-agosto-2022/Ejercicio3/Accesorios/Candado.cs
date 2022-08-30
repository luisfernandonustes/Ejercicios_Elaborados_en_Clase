using Ejercicio3.accesorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Accesorios
{
    internal class Candado : IAccesorio
    {
        public void Emsamblar()
        {
            Console.WriteLine("Se instalo un candado");
        }
    }
}

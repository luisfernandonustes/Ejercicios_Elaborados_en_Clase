using Ejercicio4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Obras
{
    internal class Factory : IFactory
    {
        public Entity BuildTrabajador(int id)
        {
            return new Trabajador(id); 
        }
        public Entity BuildJefe(int id, string salario)
        {
            return new Jefe(id, salario);
        }
    }
}

using Ejercicio4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Obras
{
    internal interface IFactory
    {
        public Entity BuildTrabajador(int id);
        public Entity BuildJefe(int id, string salario);   
    }
}

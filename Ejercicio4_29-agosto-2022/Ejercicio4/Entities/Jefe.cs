using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Entities
{
    internal class Jefe : Entity
    {
        public string Salario { get; private set; }

        public Jefe(int id, string salario) : base(id)
        {
            Salario = salario; 
        }
    }
}

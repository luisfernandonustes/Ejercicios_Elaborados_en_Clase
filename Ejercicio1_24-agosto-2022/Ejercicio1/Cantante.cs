using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Cantante: Entity
    {
        public string FirstName { set; private get; }
        public Cantante (string name, string firstName) :base(name)
        {
            FirstName = firstName;
        }
    }
}

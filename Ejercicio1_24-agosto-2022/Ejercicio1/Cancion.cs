using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Cancion: Entity
    {
        public string Reproducion { get; private set; }

        public Cancion(string name, string reproducion):base(name)
        {
            Reproducion = reproducion;
        }
    }
}

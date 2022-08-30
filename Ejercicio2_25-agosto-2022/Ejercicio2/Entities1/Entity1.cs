using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Entities1
{
    internal abstract class Entity1
    {
        public int Id { get; protected set; }
        public string Placa { get; protected set; }

        public abstract void Arrancar();

    }
}

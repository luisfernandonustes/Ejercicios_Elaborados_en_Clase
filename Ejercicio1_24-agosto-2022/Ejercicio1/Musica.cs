using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Musica: Entity
    {
        public string Genero { get; private set; }

        public Musica (string name, string genero):base(name)
        {
            Genero = genero;
        }
    }
}

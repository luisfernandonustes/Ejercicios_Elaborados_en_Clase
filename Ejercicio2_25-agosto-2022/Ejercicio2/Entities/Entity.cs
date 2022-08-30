using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Entities
{
    internal class Entity
    {
        public string Id { get; protected set; }
        public string Placa { get; protected set; }

        public Entity(string id, string placa)
        {
            Id = id;
            Placa = placa;
        }
    }
}

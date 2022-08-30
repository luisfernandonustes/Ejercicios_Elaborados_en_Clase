using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Entity
    {
        public string Name { get; protected set; }

        protected Entity(string Name)
        {
           this.Name = Name;
        }
    }
}

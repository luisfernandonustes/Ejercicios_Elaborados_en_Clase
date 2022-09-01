using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Models
{
    internal class Ingeniero : Entity
    {
        public string TarjetaProfesional { get; private set; }
        public List<TrabajadorIngeniero> TrabajadorIngenieros { get; private set; }
        public Ingeniero(string id, string tarjetaProfesional) : base(id)
        {
            TarjetaProfesional = tarjetaProfesional;
            TrabajadorIngenieros = new();
        }
        public void addIngeniero(string ingenieroId)
        {
            this.TrabajadorIngenieros.Add(
                new TrabajadorIngeniero(
                    Guid.NewGuid().ToString(),
                    ingenieroId, this.Id));
        }
    }
}

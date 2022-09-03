using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Models
{
    public class Ingeniero : Entity
    {
        public string TarjetaProfesional { get; private set; }
        public List<TrabajadorIngeniero> TrabajadorIngenieros { get; private set; }
        private Ingeniero(string id, string tarjetaProfesional) : base(id)
        {
            TarjetaProfesional = tarjetaProfesional;
            TrabajadorIngenieros = new();
        }
        public static Ingeniero Build(string id,string tarjetaProfesional)
        {
            return new Ingeniero(id, tarjetaProfesional);
        }
        public void addTrabajador(string trabajadorId)
        {
            this.TrabajadorIngenieros.Add(
                new TrabajadorIngeniero(
                    Guid.NewGuid().ToString(),
                    trabajadorId, this.Id));
        }
    }
}

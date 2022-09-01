using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Models
{
    internal class ConstruccionObra : Entity
    {
        public string Lugar { get; private set; }
        public List<Trabajador> Trabajadores{ get; set; }
        public ConstruccionObra(string id, string lugar) : base (id)
        {
            Lugar = lugar;
            Trabajadores = new List<Trabajador>();
        }
        public void AddTrabajadores(Trabajador trabajador)
        {
            this.Trabajadores.Add(trabajador);
        }
    }
}

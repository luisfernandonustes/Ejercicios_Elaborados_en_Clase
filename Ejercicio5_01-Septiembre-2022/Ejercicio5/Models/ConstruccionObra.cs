using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Models
{
    public class ConstruccionObra : Entity
    {
        public string Lugar { get; private set; }
        public List<Trabajador> Trabajadores{ get; set; }
        private ConstruccionObra(string id, string lugar) : base (id)
        {
            Lugar = lugar;
            Trabajadores = new List<Trabajador>();
        }
        public static ConstruccionObra Build(string id, string lugar)
        {
            return new ConstruccionObra(id, lugar);
        }
        public void AddTrabajadores(Trabajador trabajador)
        {
            this.Trabajadores.Add(trabajador);
        }
    }
}

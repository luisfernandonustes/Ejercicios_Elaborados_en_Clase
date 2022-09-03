using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Models
{
    public class Trabajador : Entity
    {
        public string Name { get; private set; }
        public ConstruccionObra ConstruccionObra { get; private set; }
        public List<TrabajadorIngeniero> TrabajadorIngenieros { get; private set; }
        public Trabajador(string id, string name, ConstruccionObra construccionObra) : base(id)
        {
            Name = name;
            ConstruccionObra = construccionObra;
            TrabajadorIngenieros = new();
        }
        public static Trabajador Build(string id, string name, ConstruccionObra construccionObra)
        {
            return new Trabajador(id, name, construccionObra);
        }
        public void addIngeniero(string ingenierioId)
        {
            this.TrabajadorIngenieros.Add(
                new TrabajadorIngeniero(
                    id:Guid.NewGuid().ToString(),
                    trabajadorId: this.Id,
                    ingenierioId: ingenierioId));
        }
    }
}

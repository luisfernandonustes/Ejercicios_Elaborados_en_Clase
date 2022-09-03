using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Models
{
    public class TrabajadorIngeniero : Entity
    {
        public string TrabajadorId { get; private set; }
        public string IngenierioId { get; private set; }
        public TrabajadorIngeniero(string id, string trabajadorId, string ingenierioId) : base(id)
        {
            this.TrabajadorId = trabajadorId;
            this.IngenierioId = ingenierioId;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Entities
{
    internal class VehiculoGasolina:Entity
    {
        public VehiculoGasolina(string id, string placa) :base(id,placa)
        {

        }

        public void ImprimirValores()
        {
            if (string.IsNullOrEmpty(Placa))
                throw new Exception("");
            else if (String.IsNullOrEmpty(Id))
                throw new Exception("");  

            Console.WriteLine($"{this.Id} {this.Placa}");
        }
    }
}

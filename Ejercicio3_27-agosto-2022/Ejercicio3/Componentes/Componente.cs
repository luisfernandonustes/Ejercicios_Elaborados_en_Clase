using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Componentes
{
    internal abstract class Componente
    {
        public void Ensamblar()
        {
            Console.WriteLine("ensamblar a el cuadro");
        }
        public abstract void AjustarCorrectamente();
    }
}

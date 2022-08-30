using Ejercicio3.accesorios;
using Ejercicio3.Componentes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.bicicletas
{
    internal class Bicicleta
    {
        private IAccesorio Accesorio;
        private Componente Asiento;
        private Componente Cadena;
        private Componente Cuadro;
        private Componente Frenos;
        private Componente Manubrios;
        private Componente Pedal;
        private Componente Plato;
        private Componente RuedaDelantera;
        private Componente RuedaTrasera;
        private IAccesorio accesorio1;
        public Bicicleta(IAccesorio accesorio, IAccesorio accesorio1)
        {
            Accesorio = accesorio;
            //composicion
            this.Asiento = new Asiento();
            this.Cadena = new Cadena();
            this.Cuadro = new Cuadro();
            this.Frenos = new Frenos();
            this.Manubrios = new Manubrios();
            this.Pedal = new Pedal();
            this.Plato = new Plato();
            this.RuedaDelantera = new RuedaDelantera();
            this.RuedaTrasera = new RuedaTrasera();

        }
    }
}

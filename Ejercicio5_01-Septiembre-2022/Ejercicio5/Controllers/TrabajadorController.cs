using Ejercicio5.Models;
using Ejercicio5.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Controllers
{
    internal class TrabajadorController
    {
        private IView<Trabajador> view;
        public TrabajadorController(IView<Trabajador> view)
        {
            this.view = view;
        }

        public void Crear(string id, string name, ConstruccionObra ConstruccionObra)
        {
            Trabajador trabajador;
            //Se Crea el Objeto Trabajador
            trabajador = Trabajador.Build(id, name, ConstruccionObra);
            this.view.Render(trabajador);
        }
    }
}

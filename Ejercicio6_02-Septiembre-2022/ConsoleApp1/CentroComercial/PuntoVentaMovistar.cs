using ConsoleApp1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CentroComercial
{
    internal class PuntoVentaMovistar<T> where T : Entity
    {
        private List<T> Ventas { get; set;}
        public void Venta(T obj)
        {
            obj.Id = "7854";
            Ventas.Add(obj);
        }
    }
}


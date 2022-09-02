using ConsoleApp1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CentroComercial
{
    internal interface IVentas <T> where T : Entity
    {
        public void Ventas(T obj);
    }
}

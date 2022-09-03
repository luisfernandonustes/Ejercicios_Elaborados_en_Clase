using Ejercicio5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Views
{
    public interface IView<T> where T : Entity
    {
        public void Render(T obj);
    }
}

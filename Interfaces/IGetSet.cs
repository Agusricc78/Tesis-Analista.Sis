using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IGetSet<T>
    {
        T ObtenerPorId(int id);
        List<T> ObtenerTodos();
        void Agregar(T entidad);
    }


}


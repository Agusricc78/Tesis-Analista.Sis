using BE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIOS
{
    public interface IUsuarios
    {
        Usuario TraerUsuario(string nombre);

    }
}

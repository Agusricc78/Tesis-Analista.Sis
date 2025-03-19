using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL.Mappers
{
    public class MP_Idioma
    {
        Conexion cn = new Conexion();

       public DataTable ListarIdiomas()
        {
            return cn.Leer("ObtenerIdiomas");
        }




    }
}

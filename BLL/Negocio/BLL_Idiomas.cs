using DALL.Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Negocio
{
    public class BLL_Idiomas
    {
        MP_Idioma mp = new MP_Idioma();

        public DataTable Idiomas()
        {
            return mp.ListarIdiomas();
        }


    }
}

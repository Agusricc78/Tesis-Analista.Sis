using BE.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DALL.Mappers
{
    public class MP_FormaPago
    {
        private readonly Conexion cn = new Conexion();

        public DataTable TraerPagos()
        {
            return cn.Leer("TraerFormaPagos");
        }





    }
}

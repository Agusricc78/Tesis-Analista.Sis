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
    public class MP_Permisos
    {
        private readonly Conexion cn = new Conexion();
        
        public int CrearPermiso(BE_Permisos per)
        {
            PropertyInfo[] Propsentity = per.GetType().GetProperties();
            List<SqlParameter> ListPara = new List<SqlParameter>();

            foreach (PropertyInfo pi in Propsentity)
            {
                string name = pi.Name;
                object valor = pi.GetValue(per);

                SqlParameter parametros = new SqlParameter($"@{name}", valor);

                ListPara.Add(parametros);
            }

            return cn.Escribir("CrearPermiso", ListPara.ToArray());


        }

        public DataTable ListarPermisos()
        {
            return cn.Leer("ListarPermisos");
        }




    }
}

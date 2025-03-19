using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL.Mappers
{
    public class MP_Proveedor
    {
        private readonly Conexion cn = new Conexion();

        public int AgregarProveedor(string nombre, string apellido, string direc,int tel, int dni, int cuil)
        {

            SqlParameter[] parametros = new SqlParameter[]
            {
                   new SqlParameter("@Nombre",nombre),
                   new SqlParameter("@Apellido",apellido),
                   new SqlParameter("@Direccion",direc),
                    new SqlParameter("@Telefono",tel),
                   new SqlParameter("@DNI",dni),
                   new SqlParameter("@Cuil",cuil)
            };

            return cn.Escribir("AgregarProveedor", parametros);

        }


        public int EliminarProveedor(int dni)
        {
            SqlParameter[] parametros = new SqlParameter[]
           {
                   
                   new SqlParameter("@DNI",dni),
                   
           };
            return cn.Escribir("EliminarProveedor", parametros);
        }




        public DataTable ListarProveedores()
        {
            return cn.Leer("ListarProveedores");
        }




    }
}

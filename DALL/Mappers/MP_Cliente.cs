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
    public class MP_Cliente
    {
        private readonly Conexion cn = new Conexion();

        public int AgregarCliente(BE_Cliente cl)
        {
            SqlParameter[] parametro = new SqlParameter[]
           {
                new SqlParameter("@Nombre",cl.Nombre),
                new SqlParameter("@Apellido",cl.Apellido),
                new SqlParameter("@DNI",cl.DNI),
                new SqlParameter("@Telefono",cl.Telefono)
           };

            return cn.Escribir("RegistrarCliente",parametro);
        }

        public DataTable Cliente(int id)
        {
            SqlParameter[] parametro = new SqlParameter[]
           {
                new SqlParameter("@Id_Cliente",id)
           };

            

            return cn.Leer("ObtenerCliente", parametro);
        }
        
        public DataTable TraerClientes()
        {
            return cn.Leer("ObtenerClientes");
        }




    }
}

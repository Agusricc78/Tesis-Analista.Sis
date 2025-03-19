using BE.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DALL.Mappers
{
    public class MP_Producto
    {
        private readonly Conexion cn = new Conexion();
        public int AgregarProducto(BE_Producto pro)
        {
            PropertyInfo[] Propsentity = pro.GetType().GetProperties();
            List<SqlParameter> ListPara = new List<SqlParameter>();

            foreach (PropertyInfo pi in Propsentity)
            {
                string name = pi.Name;
                object valor = pi.GetValue(pro);

                SqlParameter parametros = new SqlParameter($"@{name}", valor);

                ListPara.Add(parametros);
            }

            return cn.Escribir("AgregarProducto", ListPara.ToArray());
        }

        public int EliminarProducto(int id)
        {
            string storeProc = "EliminarProductoxId";


            SqlParameter[] parametros = new SqlParameter[]
            {
            new SqlParameter("@Id_Producto",id)
            };


            return cn.Escribir(storeProc, parametros);
        }

        public DataTable ListarProductosxId()
        {
            return cn.Leer("ListarProductosXId");
        }

        public DataTable ListarProductos()
        {
            return cn.Leer("ListarProductos");
        }

        public DataTable ListarProductosxcat(string cat)
        {
            
            SqlParameter[] parametros = new SqlParameter[]
            {
            new SqlParameter("@Categoria",cat)
            };

            return cn.Leer("ListarxCat");
        }

        public DataTable ListarFragancias()
        {
            return cn.Leer("ListarxFragancias");
        }

        public DataTable ListarCat()
        {
            return cn.Leer("listarCat");
        }


        public DataTable ListarXMarca(string nombre)
        {
            SqlParameter[] parametros = new SqlParameter[]
           {
            new SqlParameter("@Id_Marca",nombre)
           };

            return cn.Leer("TraerProductosXMarca", parametros);
        }



    }
}

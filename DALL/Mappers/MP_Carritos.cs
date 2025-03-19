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
    public class MP_Carritos
    {
        private readonly Conexion cn = new Conexion();

        public int CrearCarrito( string fecha,string nombre, int sub, int id_usu, int impuestos,int Total,int idcliente )
        {
            SqlParameter[] parametros = new SqlParameter[]
                {
                   new SqlParameter("@FechaCierre",fecha),
                   new SqlParameter("@EstadoCierre",nombre ),
                   new SqlParameter("@Subtotal",sub),
                   new SqlParameter("@Id_Usuario",id_usu),
                   new SqlParameter("@Impuestos",impuestos),
                   new SqlParameter("@Total",Total),
                   new SqlParameter("@Id_Cliente",idcliente)
                   
                };
            return cn.Escribir("CrearCarrito",parametros);
        }

        public DataTable ListarCarritos()
        {
            return cn.Leer("ListarCarritos");
        }

        public DataTable ListarCarritosCerrados()
        {
            return cn.Leer("ListarCarritosCerrados");
        }

        public DataTable GenerarFactura(int id)
        {
            SqlParameter[] parametros = new SqlParameter[]
         {
                   new SqlParameter("@Id_Carrito",id)
         };
            return cn.Leer("GenerarFactura", parametros);
        }


        public int AgregarProductoAlCarrito(int carrito,int cant,int prod)
        {

            SqlParameter[] parametros = new SqlParameter[]
            {
                   new SqlParameter("@Id_Carrito",carrito),
                   new SqlParameter("@Cantidad",cant),
                   new SqlParameter("@Id_Producto",prod)
            };

            return cn.Escribir("AgregarProductoAlCarrito", parametros);

        }

        public DataTable ListarCarritoxId(int carrito)
        {
            SqlParameter[] parametros = new SqlParameter[]
          {
                   new SqlParameter("@Id_Carrito",carrito)
          };
            return cn.Leer("ListarProductosDelCarrito", parametros);
      }


     


        public int ObtenerSubtotalCarrito(int idCarrito)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
            new SqlParameter("@Id_Carrito", idCarrito)
            };

            object resultado = cn.ObetenerDatos("TotalXCarrito", parametros);

            if (resultado != null && int.TryParse(resultado.ToString(), out int subtotal))
            {
                return subtotal;
            }

            throw new Exception("Error al obtener el subtotal del carrito.");
        }


        public int FinalizarCarrito(int idcarrito)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
            new SqlParameter("@Id_Carrito", idcarrito)
            };

            return cn.Escribir("CerrarCarrito", parametros);
        }


        public BE_Carrito ObtenerCarrito(int idCarrito)
        {


            SqlParameter[] parametros = new SqlParameter[]
              {
            new SqlParameter("@Id_Carrito", idCarrito)
              };

            DataTable tabla = cn.Leer("TraerCarrito", parametros);

            if (tabla.Rows.Count > 0)
            {
                DataRow fila = tabla.Rows[0];

                BE_Carrito carr = new BE_Carrito
                {
                    Id_Carrito = Convert.ToInt32(fila["Id"]),
                    FechaCierre = Convert.ToString(fila["FechaCierre"]),
                    Estado = Convert.ToString(fila["EstadoCierre"]),
                    Subtotal = Convert.ToInt32(fila["Subtotal"]),
                    Impuestos = Convert.ToInt32(fila["Impuestos"]),
                    Id_Usuario = Convert.ToInt32(fila["Id_Usuario"]),
                    Total = Convert.ToInt32(fila["Total"]),
                    Id_Cliente = Convert.ToInt32(fila["Id_Negocio"])


                };

                carr.cliente = ObtenerCliente(carr.Id_Cliente);
                return carr;
            }
            else
            {
                return null;
            }

        }


        public BE_Negocio ObtenerNegocio(int id)
        {
            SqlParameter[] parametros = new SqlParameter[]
             {
            new SqlParameter("@Id_Negocio", id)
             };

            DataTable tabla = cn.Leer("ObtenerNegocio", parametros);

            if (tabla.Rows.Count > 0)
            {
                DataRow fila = tabla.Rows[0];


                BE_Negocio neg = new BE_Negocio
                {
                    Id_Negocio = Convert.ToInt32(fila["Id"]),
                    Direccion = Convert.ToString(fila["Direccion"]),
                    CUIT = Convert.ToInt32(fila["CUIT"]),
                    Logo = Convert.ToByte(fila["Logo"]),
                    Nombre = Convert.ToString(fila["Fila"])

                };
                return neg;
            }
            else
            {
                return null;
            }


        }


        public DataTable ObtenerCliente(int id)
        {
            return cn.Leer("ObtenerCliente");
        }


    }
}

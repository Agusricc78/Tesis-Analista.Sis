using BE.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL.Mappers
{
    public class MP_Cotizacion
    {
        private readonly Conexion cn = new Conexion();

        public int AgregarCotizacion(string estado,bool pago, bool verif, bool aprob)
        {
            SqlParameter[] parametro = new SqlParameter[]
          {
                new SqlParameter("@Estado",estado),
               new SqlParameter("@Aprobacion",aprob),
                new SqlParameter("@Verificacion",verif),
                 new SqlParameter("@Pago",pago)
          };

            return cn.Escribir("CrearCotizaciones", parametro);
        }

        public DataTable ListarCotizaciones()
        {
            return cn.Leer("ListarCotizaciones");
        }

        public int InsertarRelacion(int id_producto,int id_cotizacion,int cant)
        {
            SqlParameter[] parametro = new SqlParameter[]
        {
                new SqlParameter("@Id_Producto",id_producto)  ,
                new SqlParameter("@id_cotizacion",id_cotizacion),
                new SqlParameter("@Cantidad",cant),
                
        };

            return cn.Escribir("InsertarCotizacionProducto", parametro);
        }

        public DataTable TraerProductosCotizaciones(int id_cot)
        {
            SqlParameter[] parametro = new SqlParameter[]
        {
                new SqlParameter("@Id_Cotizacion",id_cot)
        };
            return cn.Leer("TraerProductosCotizacion",parametro);
        }

        public int ModificarCotizacion(int id_cot, DateTime fecha_Solicitud,string forma_pago,bool estado)
        {
            SqlParameter[] parametro = new SqlParameter[]
       {
                new SqlParameter("@Id_Cotizacion",id_cot)  ,
                new SqlParameter("@Fecha_Solicitud",fecha_Solicitud),
                new SqlParameter("@Forma_Pago",forma_pago),
                new SqlParameter("@Estado",estado)

       };

            return cn.Escribir("ModificarCotizaciones", parametro);

        }


        public DataTable ListarOrdenes()
        {
            return cn.Leer("ListarOrdenes");
        }



    }
}

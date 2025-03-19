using DALL.Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Negocio
{
    public class BLL_Cotizacion
    {
       MP_Cotizacion mp = new MP_Cotizacion();


        public int InsertarCotizacion(string estado, bool pago, bool verif, bool aprob)
        {
            return mp.AgregarCotizacion(estado,pago,verif,aprob);
        }

        public int InsertarRelacion(int id_prod, int id_cot,int cant)
        {
            return mp.InsertarRelacion(id_prod,id_cot,cant);
        }

        public DataTable ListarCotizaciones()
        {
            return mp.ListarCotizaciones();
        }


        public DataTable ListarProductosCotizaciones(int cot)
        {
            return mp.TraerProductosCotizaciones(cot);
        }

        public int ModificarCot(int id_cot, DateTime fecha_Solicitud, string forma_pago, bool estado)
        {
            return mp.ModificarCotizacion(id_cot,fecha_Solicitud,forma_pago,estado);
        }

        public DataTable ListarOrdenes()
        {
            return mp.ListarOrdenes();
        }



    }
}

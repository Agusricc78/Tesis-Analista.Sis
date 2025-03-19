using BE.Entity;
using DALL.Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Negocio
{
    public class BLL_Carrito_
    {
        MP_Carritos obj = new MP_Carritos();

        public int CrearCarrito(string fecha, int impuestos, int subtotal, string estado,int id, int tot,int idcliente)
        {
            return obj.CrearCarrito(fecha,estado,subtotal,id,impuestos, tot,idcliente);
        }

        public DataTable ListarCarritos()
        {
            return obj.ListarCarritos();
        }

        public DataTable GenerarFactura(int id)
        {
            return obj.GenerarFactura(id);
        }

        public DataTable MostrarCarritosFinalizados()
        {
            return obj.ListarCarritosCerrados();
        }

        public DataTable ListarProductosCarrito(int id)
        {
            return obj.ListarCarritoxId(id);
        }

        public int AgregarProducto(int carrito, int cant,int prod)
        {
            return obj.AgregarProductoAlCarrito(carrito,cant,prod);
        }

        public int TotalCarrito(int id)
        {
            return obj.ObtenerSubtotalCarrito(id);
        }


        public int Cerrar(int id)
        {
            return obj.FinalizarCarrito(id);
        }



        public BE_Carrito ObtenerCarrito(int id)
        {
            return obj.ObtenerCarrito(id);
        }




    }
}

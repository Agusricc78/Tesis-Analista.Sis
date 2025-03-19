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
    public class BLL_Producto
    {
        MP_Producto obj = new MP_Producto();
        public int AgregarProducto(BE_Producto pro)
        {
            return obj.AgregarProducto(pro);
        }

        public DataTable ListarProductos()
        {
            return obj.ListarProductos();
        }
        public DataTable ListarProductosXId()
        {
            return obj.ListarProductosxId();
        }

        public int EliminarProducto(int id)
        {
            return obj.EliminarProducto(id);
        }

        public DataTable ListarxCat(string cat)
        {
            return obj.ListarProductosxcat(cat);
        }

        public DataTable Listarfragancias()
        {
            return obj.ListarFragancias();
        }


        public DataTable ListarCat()
        {
            return obj.ListarCat();
        }


        public DataTable ListarXMarca(string nom)
        {
            return obj.ListarXMarca(nom);
        }



    }
}

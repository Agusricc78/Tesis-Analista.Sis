using DALL.Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Negocio
{
    public class BLL_Proveedor
    {
        MP_Proveedor mp = new MP_Proveedor();

        public int AgregarProveedor(string nom, string apell, string direc,int tel,int cuil, int dni)
        {
            return mp.AgregarProveedor(nom, apell, direc,tel,cuil,dni);
        }

        public DataTable ListarProveedores()
        {
            return mp.ListarProveedores();
        }


        public int EliminarProv(int dni)
        {
            return mp.EliminarProveedor(dni);
        }



    }
}

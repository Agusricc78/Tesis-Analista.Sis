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
    public class BLL_Cliente
    {
        MP_Cliente obj = new MP_Cliente();

        public int AgregarCliente(BE_Cliente cl)
        {
            return obj.AgregarCliente(cl);
        }

        public DataTable ListarClientes()
        {
            return obj.TraerClientes();
        }

        public DataTable ObtenerClienteXId(int id)
        {
            return obj.Cliente(id);
        }
         

    }
}

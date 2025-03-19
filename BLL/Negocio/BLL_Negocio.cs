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
    public class BLL_Negocio
    {

        MP_Negocio Obj = new MP_Negocio();

        public int GuardarDato(BE_Negocio ng)
        {
            if (string.IsNullOrWhiteSpace(ng.Nombre))
            {
                throw new ArgumentException("El Nombre del Negocio es requerido");
            }
            if (string.IsNullOrWhiteSpace(ng.Direccion))
            {
                throw new ArgumentException("El Direccion del negocio es requerida");
            }
            return Obj.GuardarDatos(ng);
        }

        public List<BE_Negocio> ListarNegocio()
        {
            List<BE_Negocio> ListNegocio = new List<BE_Negocio>();

            DataTable dt = Obj.ListarNegocio();

            foreach (DataRow row in dt.Rows)
            {
                BE_Negocio ng = new BE_Negocio()
                {
                    Id_Negocio = Convert.ToInt32(row["Id_Negocio"].ToString()),
                    Nombre = row["Nombre"].ToString(),
                    CUIT =Convert.ToInt32( row["CUIT"].ToString()),
                    Direccion = row["Direccion"].ToString(),
                    Logo = Convert.ToByte(row["Logo"].ToString()),
                };
                ListNegocio.Add(ng);
            }

            return ListNegocio;
        }

        public DataTable Listar()
        {
            return Obj.ListarNegocio();
        }

        public bool ModificarLogo(byte[] imagen)
        {
            return Obj.ModificarLogo(imagen);
        }

        public byte[] ObtenerLogo(out bool obtenido)
        {
            return Obj.ObtenerLogo(out obtenido);
        }

        public DataTable Negocio(string dir)
        {
            return Obj.ObtenerNegocio(dir);
        }



    }
}

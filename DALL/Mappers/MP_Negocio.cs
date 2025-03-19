using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Entity;

namespace DALL.Mappers
{
    public class MP_Negocio
    {
        private readonly Conexion cn = new Conexion();

        public DataTable ListarNegocio()
        {
            return cn.Leer("ListarNegocio");
        }

        public int GuardarDatos(BE_Negocio ng)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Nombre",ng.Nombre),
                new SqlParameter("@CUIT",ng.CUIT),
                new SqlParameter("@Direccion",ng.Direccion)
            };

            return cn.Escribir("GuardarDatos", parametros);
        }

        public byte[] ObtenerLogo(out bool obtenido)
        {
            obtenido = true;
            byte[] LogoBytes = null;

            try
            {
                DataTable dt = cn.Leer("MostrarLogo");

                if (dt.Rows.Count > 0)
                {
                    // Verificar si la columna Logo no es DBNull.Value
                    if (dt.Rows[0]["Logo"] != DBNull.Value)
                    {
                        LogoBytes = (byte[])dt.Rows[0]["Logo"];
                    }
                }
            }
            catch (Exception ex)
            {
                obtenido = false;
                throw new Exception("Error al obtener el logo: " + ex.Message);
            }

            return LogoBytes;
        }

        public bool ModificarLogo(byte[] image)
        {
            bool respuesta = true;
            SqlParameter[] parametro = new SqlParameter[]
            {
                new SqlParameter("@Logo",image)
            };

            cn.Escribir("ModificarLogo", parametro);

            return respuesta;
        }

        public DataTable ObtenerNegocio(string dir)
        {
            SqlParameter[] parametro = new SqlParameter[]
           {
                new SqlParameter("@Direccion",dir)
           };

            cn.Escribir("TrearNegocio", parametro);

            return cn.Leer("TrearNegocio", parametro);
        }

        

    }
}

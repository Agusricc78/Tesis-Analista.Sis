using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DALL
{
    public class ConexionSingleton
    {
       
        private static SqlConnection instancia;

        private ConexionSingleton() { }

        public static SqlConnection ObtenerInstancia()
        {
            if (instancia == null)
            {

                string cadenaConexion = "Server=PcAgus; Database=ProductoOSC; Integrated Security=True;";

                instancia = new SqlConnection(cadenaConexion);
            }

            return instancia;
        }



    }
}

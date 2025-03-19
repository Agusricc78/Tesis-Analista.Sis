using BE.Entity;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL.Mappers
{
    public class MP_BitacoraEvento
    {
        private readonly Conexion cn = new Conexion();

        public int InsertarEvento(string nombre, DateTime fecha, TimeSpan hora, string evento, string modulo, int crit,string username,string apellido)
        {
            SqlParameter[] parametros = new SqlParameter[]
                {
                   new SqlParameter("@fecha",fecha),
                   new SqlParameter("@time",hora),
                   new SqlParameter("@Evento",evento),
                   new SqlParameter("@UserName",username),
                   new SqlParameter("@Modulo",modulo),
                   new SqlParameter("@Criticidad",crit),
                   new SqlParameter("@Nombre",nombre),
                   new SqlParameter("@Apellido",apellido)
                };
            return cn.Escribir("InsertarEvento", parametros);
        }

        public DataTable MostrarEventos()
        {
            return cn.Leer("ListarEventos");
        }

     


    }
}

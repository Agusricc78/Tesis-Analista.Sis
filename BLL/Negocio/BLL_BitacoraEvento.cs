using BE.Entity;
using DALL.Mappers;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Negocio
{
    public class BLL_BitacoraEvento
    {
        MP_BitacoraEvento mp = new MP_BitacoraEvento();


        public int InsertarEvento(string nombre,DateTime fecha,TimeSpan hora,string evento, string modulo, int crit,string apellido, string username)
        {
            return mp.InsertarEvento(nombre,fecha,hora,evento,modulo,crit,apellido,username);

        }

        public DataTable ListarEventos()
        {
            return mp.MostrarEventos();
        }




    }
}

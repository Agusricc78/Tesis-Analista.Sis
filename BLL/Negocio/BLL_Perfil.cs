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
    public class BLL_Perfil
    {
        MP_Perfil obj = new MP_Perfil();

        public void GuardarPerfil(DataTable permisos, int per)
        {
            obj.GuardarPerfil(permisos, per);
        }

        public DataTable ListarPerfiles()
        {
            return obj.ListarPerfiles();
        }
        public DataTable ListarPerfilesXNombre()
        {
            return obj.ListarPerfilesNombre();
        }

        public int AgregarPerfil(string descr, string nom)
        {
            return obj.AgregarPerfil(descr, nom);
        }

        public object TraerDescripcion(int id)
        {
            return obj.TraerDescripcionXId(id);
        }

        public int EliminarPerfil(int id)
        {
            return obj.EliminarPerfil(id);
        }

        public bool ValidarPerfil(int id)
        {
            return obj.ValidarPerfil(id);
        }

        public bool ValidarFamilia(int id)
        {
            return obj.ValidarFamilia(id);
        }

        public bool VerificarFamilia(string nombre)
        {
            return obj.VerificarFamilia(nombre);
        }

        public int InsertarRelacion(int idfam, int idper)
        {
            return obj.InsertarRelacionPerfilFamilia(idfam, idper);
        }

        public bool VerificarRelacionFamPer(int idfam, int idper)
        {
            return obj.VerificarRelacionPerfilFamilia(idfam, idper);
        }

        public int EliminarRelacionPerfilFamilia(int idper)
        {
            return obj.EliminarRelacionFamiliaPerfil(idper);
        }

       
        public void GuardarFamilia(DataTable dt, int idper)
        {
            obj.InsertarRelacionPermisoFamilia(dt, idper);
        }

        public bool guardarPermisosPerfil(DataTable table, int perfil, int familia)
        {
            return obj.GuardarPerfil(table, perfil, familia);
        }

       
    }
}

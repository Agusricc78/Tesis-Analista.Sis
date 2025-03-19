using BE.Entity;
using DALL.Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SERVICIOS.Permisos
{
    public class ManagerPermisos
    {
        MP_Permisos perm = new MP_Permisos();
        private static void AgregarNodosHijo(TreeNode node, PermisoCompuesto permisoCompuesto)
        {
            foreach (Component permisoHijo in permisoCompuesto.ListarPermisos())
            {
                if (permisoHijo is PermisoCompuesto)
                {
                    PermisoCompuesto permisoCompuestoHijo = (PermisoCompuesto)permisoHijo;

                    TreeNode nodoHijo = new TreeNode(permisoCompuestoHijo.Codigo);
                    nodoHijo.Tag = permisoCompuestoHijo;

                    AgregarNodosHijo(nodoHijo, permisoCompuestoHijo);

                    node.Nodes.Add(nodoHijo);
                }
                else if (permisoHijo is PermisoSimple)
                {
                    PermisoSimple permisoSimpleHijo = (PermisoSimple)permisoHijo;

                    TreeNode nodoHijo = new TreeNode(permisoSimpleHijo.Codigo);
                    nodoHijo.Tag = permisoSimpleHijo;

                    node.Nodes.Add(nodoHijo);
                }
            }
        }

        public void guardarPermisosPerfil(DataTable table,int per)
        {
            MP_Perfil perfilDAL = new MP_Perfil();
            perfilDAL.GuardarPerfil(table,per);
        }

        public DataTable obtenerPermisos()
        {
            MP_Perfil perfil = new MP_Perfil();

            return perfil.ListarPerfiles();
        }

    
        public int AgregarFamilia(string descr, string nombre)
        {
            MP_Perfil perfil = new MP_Perfil();
            return  perfil.AgregarFamilia(descr, nombre);
        }

        public int EliminarFamilia(int idfam)
        {
            MP_Perfil perfil = new MP_Perfil();
            return perfil.EliminarFamilia(idfam);
        }

        public int InsertarRelacionFamilia(int idperm, int idfamilia)
        {
            MP_Perfil perfil = new MP_Perfil();
            return perfil.InsertarRelacionFamiliaPermiso(idperm, idfamilia);
        }

        
        public int AgregarPermiso(string nombre,string descripcion) 
        {
            MP_Perfil perfil = new MP_Perfil();
            return perfil.AgregarPermiso(nombre, descripcion);
        }


        public DataTable TraerPermisos()
        {
            MP_Perfil perfil = new MP_Perfil();
            return perfil.TraerPermisosSimples();
        }

        public DataTable TraerPermisosFamilia(int id)
        {
            MP_Perfil perfil = new MP_Perfil();
            return perfil.TraerPermisosFamilia(id);
        }

        public DataTable ListarFamilias()
        {
            MP_Perfil perfil = new MP_Perfil();
            return perfil.TraerFamilias();
        }

        public bool ExistsFamilia(string nombre)
        {
            MP_Perfil per = new MP_Perfil();
            return per.ExistsFamilia(nombre);
        }


       

    }
}

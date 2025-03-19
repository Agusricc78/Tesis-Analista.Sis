using BE.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALL.Mappers;
using System.Web.SessionState;
using SERVICIOS;

namespace BLL.Negocio
{
    public class BLL_Usuario
    {
        MP_Registrar obj = new MP_Registrar();
        public int insertar(Usuario usu)
        {
            return obj.RegistrarUsuario(usu);
        }

        public DataTable autenticar(string username, string passw)
        {
            var usr = obj.autenticar(username, passw);
            return usr;
        }

        public DataTable ListarUsr()
        {
            return obj.ListarUsuarios();
        }

        public int EliminarUsuario(int Dni)
        {
            return obj.EliminarUsuario(Dni);
        }

       public int Desactivar(int Dni) 
        {
            return obj.DesactivarEstado(Dni);
        }

        public int Activar(int Dni)
        {
            return obj.ActivarEstado(Dni);
        }

        public DataTable ObtenerUsuarioPorNombre(string nombre)
        {
            return obj.ObtenerUsuarioporNombre(nombre);
        }

        public DataTable MostrarActivos()
        {
            return obj.MostrarActivos();    
        }

        public int CambiarClave(int dni, string nombre, string contra)
        {
            return obj.CambiarClave(dni, nombre, contra);
        }

        public int Bloquear(string username)
        {
            return obj.BloquearUsuario(username);
        }

        public int Desbloquear(string nombre)
        {
            return obj.DesbloquearUsuario(nombre);
        }

        public bool VerificarEstadoBloqueo(string username)
        {
            return obj.VerificarEstadoBloqueado(username); 
        }


        public bool ValidarUser(string nombre)
        {
            return obj.ValidarUsuario(nombre);
        }


        public int ModificarUsuario(int dni, string username, string nombre, string apellido,string mail)
        {
            return obj.ModificarUsuario(dni,username, nombre, apellido,mail);
        }


        public DataTable ListarClientes()
        {
            return obj.ListarClientes();
        }


        public int UpdateUserPerfil(int idper,int iduser)
        {
            return obj.UpdateUserPerfil(idper,iduser);
        }

        public DataTable ListarPerfiles()
        {
            return obj.ListarPerf();
        }

        public int ActualizarIdioma(string lang)
        {
            return obj.ActualizarIdioma(SessionManager.getProfile().Id_Usuario,lang);
        }

        public bool VerificarPerfil(int idper, int iduser)
        {
            return obj.VerificarPerfil(idper,iduser);
        }


        public bool VerificarPerfilExiste(string nombre)
        {
            return obj.VerificarPerfilExiste(nombre);
        }

        

    }
}

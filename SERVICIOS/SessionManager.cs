using BE.Entity;
using DALL.Mappers;
using Interfaces;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SERVICIOS
{
    public class SessionManager 
    {

        MP_Registrar mp = new MP_Registrar();
        public static IUsuarios _userservice;
        private static object _lock = new Object();
        private static SessionManager _session;
       
        public bool SesionIniciada { get; private set; }

        public Usuario Usuario { get; set; }
        public DateTime FechaInicio { get; set; }

        public static SessionManager GetInstance
        {
            get
            {
                if (_session == null) throw new Exception("Sesión no iniciada");
                return _session;
            }
        }
        
        public static void SetUsuario(IUsuarios user)
        {

        
            _userservice = user;
        }


        public static Usuario getProfile()
        {
            return _session.Usuario;
        }
        
        public void Login(string Nombre)
        {

            var user = mp.ObtenerUsuarioXNom(Nombre);

            lock (_lock)
            {
                if (_session == null)
                {
                   
                    _session = new SessionManager();
                    _session.Usuario = user;
                    _session.FechaInicio = DateTime.Now;
                    _session.SesionIniciada = true;

                   // ObervableLanguage.CurrentLanguage = Usuario.idioma;
                }
                else
                {
                    throw new Exception("Sesión ya iniciada");
                }
            }
        }

        public static void Logout()
        {
            lock (_lock)
            {
                if (_session != null)
                {
                    _session = null;
                }
                else
                {
                    throw new Exception("Sesión no iniciada");
                }
            }
        }

      
    }

}


using BE.Entity;
using DALL.Encriptacion;

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace DALL.Mappers
{
    public class MP_Registrar
    {
        private readonly Conexion cn = new Conexion();
        public int RegistrarUsuario(Usuario us)
        {

            us.Contraseña = PasswordEncript.EncriptarContraseña(us.Contraseña, us.Nombre);
            SqlParameter[] sp = new SqlParameter[]
            {
             new SqlParameter("@UserName",us.UserName),
             new SqlParameter("@Contraseña",us.Contraseña),
             new SqlParameter("@Estado",us.Estado),
             new SqlParameter("@Bloqueo",us.Bloqueo),
             new SqlParameter("@Nombre",us.Nombre),
             new SqlParameter("@Mail",us.Mail),
             new SqlParameter("@Dni",us.Dni),
             new SqlParameter("@Apellido",us.Apellido),

             };

            return cn.Escribir("RegistrarUser", sp);
        }

        public bool ValidarUsuario(string nombre)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                   new SqlParameter("@Nombre", nombre),
                   new SqlParameter
                   {
                 ParameterName = "@Exists",
                 SqlDbType = SqlDbType.Bit,
                 Direction = ParameterDirection.Output
                   }
            };
            cn.Verificar("ValidarUsuario", parametros);

            bool exists = (bool)parametros[1].Value;
            return exists;
        }

        public int CambiarClave(int Dni, string nombre, string contraseña)
        {
            contraseña = PasswordEncript.EncriptarContraseña(contraseña, nombre);

            SqlParameter[] parametros = new SqlParameter[]
                {
                   new SqlParameter("@Nombre", nombre),
                   new SqlParameter("@Contraseña", contraseña),
                   new SqlParameter("@Dni", Dni),
                };
            return cn.Escribir("CambiarClave", parametros);
        }


        public DataTable autenticar(string username, string passw)
        {


            SqlParameter[] parametros = new SqlParameter[]
                {
                   new SqlParameter("@UserName", username),
                   new SqlParameter("@Contraseña", passw)
                };

            return cn.Leer("Autenticar", parametros);
        }

        public DataTable ListarUsuarios()
        {
            return cn.Leer("ObtenerIdUsuario");
        }

        public DataTable MostrarActivos()
        {
            return cn.Leer("MostrarActivos");
        }

        public int EliminarUsuario(int DNI)
        {

            string storeProc = "EliminarUsuario";


            SqlParameter[] parametros = new SqlParameter[]
            {
            new SqlParameter("@Dni",DNI)
            };


            return cn.Escribir(storeProc, parametros);
        }

        public int BloquearUsuario(string username)
        {

            string storeProc = "bloquearUser";


            SqlParameter[] parametros = new SqlParameter[]
            {
            new SqlParameter("@UserName",username)
            };

            return cn.Escribir(storeProc, parametros);
        }

        public bool VerificarEstadoBloqueado(string username)
        {
            return cn.ObtenerEstadoBloqueo(username);
        }

        public int DesbloquearUsuario(string username)
        {

            string storeProc = "DesbloquearUsuario";


            SqlParameter[] parametros = new SqlParameter[]
            {
            new SqlParameter("@UserName",username)
            };


            return cn.Escribir(storeProc, parametros);
        }





        public int DesactivarEstado(int DNI)
        {

            string storeProc = "ModificarEstadoDesactivo";


            SqlParameter[] parametros = new SqlParameter[]
            {
            new SqlParameter("@Dni",DNI)
            };


            return cn.Escribir(storeProc, parametros);
        }

        public int ActivarEstado(int DNI)
        {

            string storeProc = "ModificarEstadoActivado";


            SqlParameter[] parametros = new SqlParameter[]
            {
            new SqlParameter("@Dni",DNI)
            };


            return cn.Escribir(storeProc, parametros);
        }

        public DataTable ObtenerUsuarioporNombre(string Nombre)
        {
            SqlParameter[] parametros = new SqlParameter[]
               {
                   new SqlParameter("@Nombre", Nombre)

               };

            return cn.Leer("ObtenerUsuarioPorNombre", parametros);
        }


        public int ModificarUsuario(int dni, string username, string nombre, string apellido, string mail)
        {
            SqlParameter[] parametros = new SqlParameter[]
               {
                   new SqlParameter("@UserName", username),
                   new SqlParameter("@Nombre", nombre),
                   new SqlParameter("@Apellido",apellido),
                   new SqlParameter("@Dni", dni),
                   new SqlParameter("@Mail",mail)
               };
            return cn.Escribir("ModificarUsuario", parametros);
        }


        public DataTable ListarClientes()
        {
            return cn.Leer("ListarXNombres");
        }

        public int UpdateUserPerfil(int idperfil, int iduser)
        {
            SqlParameter[] parametros = new SqlParameter[]
               {
                   new SqlParameter("@ID_Perfil", idperfil),
                   new SqlParameter("@Id_Usuario", iduser),

               };
            return cn.Escribir("UpdateUserPerfil", parametros);

        }

        public DataTable ListarPerf()
        {
            return cn.Leer("TraerUsersConPerfil");
        }

        public int ActualizarIdioma(int iduser, string lang)
        {
            SqlParameter[] parametros = new SqlParameter[]
               {
                   new SqlParameter("@Id_Usuario", iduser),
                   new SqlParameter("@Lang", lang),

               };

            return cn.Escribir("ActualizarIdioma", parametros);
        }


        public Usuario ObtenerUsuarioXNom(string Nombre)
        {
            Usuario user = new Usuario();
            SqlParameter[] parametros = new SqlParameter[]
               {
                   new SqlParameter("@Nombre", Nombre)

               };
            DataTable dt = cn.Leer("ObtenerUsuarioPorNombre", parametros);
            if (dt.Rows.Count > 0)
            {
                DataRow fila = dt.Rows[0];

                // Mapea los datos del DataRow a un objeto Usuario
                Usuario usuario = new Usuario
                {
                    Id_Usuario = Convert.ToInt32(fila["Id_Usuario"]),
                    Nombre = Convert.ToString(fila["Nombre"]),
                    Contraseña = Convert.ToString(fila["Contraseña"]),
                    Estado = Convert.ToBoolean(fila["Estado"]),
                    Mail = Convert.ToString(fila["Mail"]),
                    Dni = Convert.ToInt32(fila["Dni"]),
                    Bloqueo = Convert.ToBoolean(fila["Bloqueo"]),
                    Apellido = Convert.ToString(fila["Apellido"]),
                    UserName = Convert.ToString(fila["UserName"]),
                    idioma = fila["Idioma"] != DBNull.Value ? fila["Idioma"].ToString() : null,
                    Id_Perfil = fila["Id_Perfil"] != DBNull.Value ? Convert.ToInt32(fila["Id_Perfil"]) : 0,

                }; 
                if (usuario.Id_Perfil != 0)
                {
                    usuario.PerfilCompleto = ObtenerPerfil(usuario.Id_Perfil);
                }
                return usuario;
            }
           else
            {
                return null;
            }

        }


        public BE_Perfil ObtenerPerfil(int idperfil)
        {
           

            SqlParameter[] parametros = new SqlParameter[]
              {
            new SqlParameter("@Id_Perfil", idperfil)
              };

            DataTable tabla = cn.Leer("ObtenerPerfil", parametros);

            if (tabla.Rows.Count > 0)
            {
                DataRow fila = tabla.Rows[0];

                // Mapea los datos del DataRow a un objeto BE_Perfil
                BE_Perfil perf = new BE_Perfil
                {
                    ID = Convert.ToInt32(fila["Id_Rol"]),
                    Descripcion = Convert.ToString(fila["Descripcion"]),
                    Nombre = Convert.ToString(fila["Nombre"]),
                   
                };
                perf.permisos = ObtenerPermisos(perf.ID);
              

                return perf;
            }
            else
            {
                return null;
            }

        }

        public List<int> ObtenerPermisos(int idPerfil)
        {
            
            string storedProcedure = "ObtenerPermisosSimplesPorPerfil";
            SqlParameter[] parametros = new SqlParameter[]
            {
            new SqlParameter("@Id_Perfil", idPerfil)
            };

            DataTable tabla = cn.Leer(storedProcedure, parametros);

            List<int> permisos = new List<int>();

            foreach (DataRow fila in tabla.Rows)
            {
                permisos.Add(Convert.ToInt32(fila["ID"]));
            }

            return permisos;
        }


       
        public bool VerificarPerfil(int idperf, int iduser)
        {
            SqlParameter[] param = new SqlParameter[]
            {
            new SqlParameter("@ID_Perfil", idperf),
            new SqlParameter("@Id_Usuario", iduser),
            new SqlParameter
         {
             ParameterName = "@Exists",
             SqlDbType = SqlDbType.Bit,
             Direction = ParameterDirection.Output
         }
         };

            cn.Leer("VerificarPerfil", param);

            bool exists = (bool)param[2].Value;
            return exists;
        }


        public bool VerificarPerfilExiste(string nombre)
        {
            SqlParameter[] param = new SqlParameter[]
            {
            new SqlParameter("@Nombre", nombre),
            new SqlParameter
         {
             ParameterName = "@Exists",
             SqlDbType = SqlDbType.Bit,
             Direction = ParameterDirection.Output
         }
         };
              cn.Leer("VerificarPerfilCreado", param);

            bool exists = (bool)param[1].Value;
            return exists;

        }
        




    }
}

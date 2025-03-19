using BE.Entity;
using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DALL.Mappers
{
    public class MP_Perfil
    {
        private readonly Conexion cn = new Conexion();
        public DataTable ListarPerfiles()
        {
            return cn.Leer("ListarPerfiles");
        }

        public DataTable ListarPerfilesNombre()
        {
            return cn.Leer("ListarPerfilesXNombre");
        }

        public object TraerDescripcionXId(int id)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
        new SqlParameter("@Id_Rol", id)
            };
            return cn.ObetenerDatos("TraerDescripcionXId", parametros);
        }

        /* public int AgregarPerfil(BE_Perfil per)
         {
             PropertyInfo[] Propsentity = per.GetType().GetProperties();
             List<SqlParameter> ListPara = new List<SqlParameter>();

             foreach (PropertyInfo pi in Propsentity)
             {
                 string name = pi.Name;
                 object valor = pi.GetValue(per);

                 SqlParameter parametros = new SqlParameter($"@{name}", valor);

                 ListPara.Add(parametros);
             }

             return cn.Escribir("InsertarPerf", ListPara.ToArray());
         }
        */

        public int AgregarPerfil(string descripcion, string nombre)
        {
            SqlParameter[] parametros = new SqlParameter[]
             {
         new SqlParameter("@Nombre", nombre),
         new SqlParameter("@Descripcion", descripcion)
             };
            return cn.Escribir("InsertarPerf", parametros);

        }



        /* public void GuardarPerfil(BE_Perfil per, DataTable permisos)
         {
             // Crear parámetros para el procedimiento almacenado
             SqlParameter[] parametros = new SqlParameter[]
             {
         new SqlParameter("@Nombre", per.Nombre),
         new SqlParameter("@Descripcion", per.Descripcion),

         // Parámetro de salida para el ID del perfil
         new SqlParameter
         {
             ParameterName = "@Id_Perfil",
             SqlDbType = SqlDbType.Int,
             Direction = ParameterDirection.Output
         },

         // Parámetro para la lista de permisos
         new SqlParameter
         {
             ParameterName = "@Permisos",
             SqlDbType = SqlDbType.Structured,
             TypeName = "TVP_Permisos", // Tipo de tabla en SQL Server
             Value = permisos
         }
             };

             // Llamar al método Escribir para ejecutar el procedimiento almacenado
             int resultado = cn.Escribir("GuardarPerfil", parametros);

             // Verificar el resultado y obtener el ID del perfil si la operación fue exitosa
             if (resultado > 0)
             {
                 per.ID = (int)parametros[2].Value; // Obtener el ID del perfil generado
             }
         }
        */

        public void GuardarPerfil(DataTable permisos, int per)
        {

            foreach (DataRow permissionRow in permisos.Rows)
            {
                InsertarRelacionPerfilPermisos(per, (int)permissionRow["ID"]);
            }
        }


        public int InsertarPerfil(BE_Perfil perfil)
        {

            SqlParameter[] parametros = new SqlParameter[]
           {
        new SqlParameter("@Nombre",perfil.Nombre),
        new SqlParameter("@Descripcion",perfil.Descripcion)
           };

            return cn.Escribir("InsertarPerf", parametros);
        }

        public void InsertarRelacionPerfilPermisos(int profileId, int idperm)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
        new SqlParameter("@Id_Permiso",idperm),
        new SqlParameter("@Id_Rol",profileId)
            };
            cn.Escribir("InsertarRelacionPermiso", parametros);
        }





        public int AgregarFamilia(string descr, string nombre)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Descripcion",descr),
                new SqlParameter("@Nombre",nombre)
            };

            return cn.Escribir("AgregarFamilia", parametros);
        }

        public int InsertarRelacionFamiliaPermiso(int idfam, int idperm)
        {
            SqlParameter[] parametros = new SqlParameter[]
          {
                new SqlParameter("@IdFamilia",idfam),
                new SqlParameter("@IdPermiso",idperm)
          };

            return cn.Escribir("InsertarPermisoFamilia", parametros);

        }


        public int EliminarFamilia(int idPermCom)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Id_PermisoCompuesto",idPermCom)

            };

            return cn.Escribir("EliminarFamilia", parametros);
        }

        public DataTable TraerPermisosFamilia(int idFamilia)
        {
            SqlParameter[] parametros = new SqlParameter[]
           {
                new SqlParameter("@Id_PermisoCompuesto",idFamilia)

           };

            return cn.Leer("TraerPermisosFamilia", parametros);
        }

        public DataTable TraerPermisosSimples()
        {
            return cn.Leer("TraerPermisos");
        }

        public int AgregarPermiso(string nombre, string descr)
        {
            SqlParameter[] parametros = new SqlParameter[]
          {
                new SqlParameter("@Nombre",nombre),
                new SqlParameter("@Descripcion",descr)
          };

            return cn.Escribir("AgregarPermisos", parametros);
        }


        public DataTable TraerFamilias()
        {
            return cn.Leer("ListarFamilias");
        }

        public bool ExistsFamilia(string nombre)
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
            cn.Leer("VerificarFamilia", param);

            bool exists = (bool)param[1].Value;
            return exists;
        }

        public int EliminarPerfil(int id)
        {
            SqlParameter[] parametros = new SqlParameter[]
           {
                new SqlParameter("@Id_Perfil",id)

           };
            return cn.Escribir("EliminarPerfil", parametros);
        }


        public bool ValidarPerfil(int id)
        {
            SqlParameter[] param = new SqlParameter[]
           {
            new SqlParameter("@Id_perfil", id),
            new SqlParameter
         {
             ParameterName = "@Exists",
             SqlDbType = SqlDbType.Bit,
             Direction = ParameterDirection.Output
         }
        };
            cn.Leer("VakidarPerfil", param);

            bool exists = (bool)param[1].Value;
            return exists;
        }


        public bool ValidarFamilia(int id)
        {
            SqlParameter[] param = new SqlParameter[]
           {
            new SqlParameter("@Id_Familia", id),
            new SqlParameter
         {
             ParameterName = "@Exists",
             SqlDbType = SqlDbType.Bit,
             Direction = ParameterDirection.Output
         }
        };
            cn.Leer("ValidarFamilia", param);

            bool exists = (bool)param[1].Value;
            return exists;
        }


        public bool VerificarFamilia(string nombre)
        {
            SqlParameter[] param = new SqlParameter[]
           {
            new SqlParameter("@Nombre",nombre),
            new SqlParameter
         {
             ParameterName = "@Exists",
             SqlDbType = SqlDbType.Bit,
             Direction = ParameterDirection.Output
         }
        };
            cn.Leer("VerificarFamilia", param);

            bool exists = (bool)param[1].Value;
            return exists;
        }


        public int InsertarRelacionPerfilFamilia(int idfam, int idper)
        {
            SqlParameter[] parametros = new SqlParameter[]
         {
                new SqlParameter("@Id_Perfil",idper),
                new SqlParameter("@Id_Familia",idfam)
         };
            return cn.Escribir("IntroducirRelacionPerfilFamilia", parametros);

        }


        public bool VerificarRelacionPerfilFamilia(int idfam,int idper)
        {
            SqlParameter[] param = new SqlParameter[]
           {
            new SqlParameter("@Id_Perfil",idper),
            new SqlParameter("@Id_Familia",idfam),
            new SqlParameter
         {
             ParameterName = "@Exists",
             SqlDbType = SqlDbType.Bit,
             Direction = ParameterDirection.Output
         }
        };
            cn.Leer("VerificarRelacionFamiliaPerfil", param);

            bool exists = (bool)param[2].Value;
            return exists;
        }


        public int EliminarRelacionFamiliaPerfil(int idper) 
        {
            SqlParameter[] parametros = new SqlParameter[]
         {
                new SqlParameter("@Id_Perfil",idper)
                
         };
            return cn.Escribir("EliminarRelacionPerfilFamilia", parametros);

        }

        public int AgregarRelacionPermisoFamilia(int idfam, int idpermiso)
        {
            SqlParameter[] parametros = new SqlParameter[]
         {
                new SqlParameter("@Id_PermisoSimple",idpermiso),
                new SqlParameter("@Id_Familia",idfam)

         };
            return cn.Escribir("InsertarPermisosFamilia", parametros);

        }

        public void InsertarRelacionPermisoFamilia(DataTable dt, int idpermiso)
        {
            foreach (DataRow count in dt.Rows)
            {
                InsertarRelacionFamiliaPermiso(idpermiso, (int)count["ID"]);
            }

        }

        public void InsertarRelacionPerfil(int profileId, int idperm, int familiaId)
        {
            SqlParameter[] parametros = new SqlParameter[3]
            {
                new SqlParameter("@IdPermiso", idperm),
                new SqlParameter("@IdPerfil", profileId),
                new SqlParameter("@IdFamilia", familiaId)
            };
            cn.Escribir("InsertarPermisoPerfil", parametros);
        }

        public bool GuardarPerfil(DataTable permisos, int perfilId, int familiaId)
        {
            bool result = true;
            foreach (DataRow row in permisos.Rows)
            {
                int num = (int)row["ID"];
                if (ValidarPermisos(num, familiaId, perfilId) && num != 1)
                {
                    result = false;
                    break;
                }

                InsertarRelacionPerfil(perfilId, num, familiaId);
            }

            return result;
        }


        public bool ValidarPermisos(int idPermiso, int idFamilia, int Idperfil)
        {
            SqlParameter[] array = new SqlParameter[4]
            {
                new SqlParameter("@IdPermiso", idPermiso),
                new SqlParameter("@IdFamilia", idFamilia),
                new SqlParameter("@IdPerfil", Idperfil),
                new SqlParameter
                {
                    ParameterName = "@Exists",
                    SqlDbType = SqlDbType.Bit,
                    Direction = ParameterDirection.Output
                }
            };
            cn.Leer("ExistePermisoEnPerfilOFamilia", array);
            return (bool)array[3].Value;
        }








    }
}

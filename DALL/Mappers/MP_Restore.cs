using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL.Mappers
{
    public class MP_Restore
    {
        
        string cadenaConexion = "Server=PcAgus; Database=ProductoOSC; Integrated Security=True;";

        public void RealizarBackup(string backupPath)
        {
            try
            {
                string nombreArchivo = $"MiSistema.BCK_{DateTime.Now:ddMMyy_HHmm}.bak";
                string rutaCompleta = System.IO.Path.Combine(backupPath, nombreArchivo);
                string comandoBackup = $"BACKUP DATABASE ProductoOSC TO DISK='{rutaCompleta}'";

                

                using (SqlConnection conn = new SqlConnection())
                {
                    SqlCommand cmd = new SqlCommand(comandoBackup, conn);
                    conn.ConnectionString = cadenaConexion;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public void RealizarRestore(string backupFilePath)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    conn.Open();

                    using (SqlCommand setMaster = new SqlCommand("USE master;", conn))
                    {
                        setMaster.ExecuteNonQuery();
                    }

                    using (SqlCommand setSingleUser = new SqlCommand("ALTER DATABASE ProductoOSC SET SINGLE_USER WITH ROLLBACK IMMEDIATE;", conn))
                    {
                        setSingleUser.ExecuteNonQuery();
                    }

                    string query = $"RESTORE DATABASE ProductoOSC FROM DISK = '{backupFilePath}' WITH REPLACE;";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    using (SqlCommand setMultiUser = new SqlCommand("ALTER DATABASE ProductoOSC SET MULTI_USER;", conn))
                    {
                        setMultiUser.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al restaurar la base de datos: {ex.Message}");
            }
        }



    }
}

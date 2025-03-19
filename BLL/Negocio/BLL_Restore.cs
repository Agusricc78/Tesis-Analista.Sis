using DALL.Mappers;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Negocio
{
    public class BLL_Restore
    {
        MP_Restore obj = new MP_Restore();  
        public void RealizarBackup(string backupPath)
        {
            obj.RealizarBackup(backupPath);
        }
        public void RealizarRestore(string restorePath)
        {
            obj.RealizarRestore(restorePath);
        }


    }
}

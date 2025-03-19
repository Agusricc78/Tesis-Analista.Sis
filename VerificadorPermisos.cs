using BE.Entity;
using BLL.Negocio;
using SERVICIOS;
using SERVICIOS.Permisos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductosOSC
{
    public class VerificadorPermisos
    {
      
        public static bool TienePermiso(int idPermiso)
        {
            Usuario usuario = SessionManager.GetInstance.Usuario;

            if (usuario != null && usuario.PerfilCompleto != null)
            {
                return usuario.PerfilCompleto.permisos.Contains(idPermiso);
            }

            return false;
        }



    }



}


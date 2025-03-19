using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIOS.Permisos
{
    public class PermisoCompuesto : Component
    {
        public PermisoCompuesto() { }
        public PermisoCompuesto(int id, string cod, string descripcion, int idpadre) : base(id, cod, descripcion, idpadre)
        {
        }


        public List<Component> _listaPermiso = new List<Component>();


        public override void AgregarPermiso(Component permiso)
        {
            this._listaPermiso.Add(permiso);
        }

        public override void EliminarPermiso(Component permiso)
        {
            this._listaPermiso.Remove(permiso);
        }

        public override List<Component> ListarPermisos()
        {
            return this._listaPermiso;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIOS.Permisos
{
    public class PermisoSimple : Component
    {
        public PermisoSimple() { }
        public PermisoSimple(int id, string cod, string descripcion, int idpadre) : base(id, cod, descripcion, idpadre)
        {
        }

        public override void AgregarPermiso(Component permiso)
        {
            throw new NotImplementedException();
        }

        public override void EliminarPermiso(Component permiso)
        {
            throw new NotImplementedException();
        }

        public override List<Component> ListarPermisos()
        {
            return new List<Component>();
        }


    }
}

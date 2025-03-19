using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIOS.Permisos
{
    public abstract class Component
    {
        public Component() { }

        protected Component(int id, string cod, string descripcion, int idPadre)
        {
            _id = id;
            _cod = cod;
            _descripcion = descripcion;
            _idPadre = idPadre;
        }


        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }


        private string _cod;
        public string Codigo
        {
            get { return _cod; }
            set { _cod = value; }
        }

        private string _descripcion;


        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private int? _idPadre;
        private string cod;

        public int? ID_Padre
        {
            get { return _idPadre; }
            set { _idPadre = value; }
        }

        public abstract void AgregarPermiso(Component permiso);

        public abstract void EliminarPermiso(Component permiso);

        public abstract List<Component> ListarPermisos();

    }
}

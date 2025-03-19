using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Entity
{
    public class BE_Permisos
    {
		private int id_Permiso;

		public int Id_Permiso
		{
			get { return id_Permiso; }
			set { id_Permiso = value; }
		}

		private string descripcion;

		public string Descripcion
		{
			get { return descripcion; }
			set { descripcion = value; }
		}

		private int id_padre;

		public int Id_Padre
		{
			get { return id_padre; }
			set { id_padre = value; }
		}

		private string codigo;

		public string Codigo
		{
			get { return codigo; }
			set { codigo = value; }
		}



	}
}

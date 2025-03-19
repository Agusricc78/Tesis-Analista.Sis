using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Entity
{
    public class BE_Roles
    {
		private int Id_Rol;

		public int id_Rol
		{
			get { return Id_Rol; }
			set { Id_Rol = value; }
		}

		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}



	}
}
